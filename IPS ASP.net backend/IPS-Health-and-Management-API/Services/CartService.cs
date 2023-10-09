using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Models.Responses;
using IPS_Health_and_Management_API.Repositories.Concrete;
using IPS_Health_and_Management_API.Repositories.Interfaces;

namespace IPS_Health_and_Management_API.Services
{
    public class CartService : ICartService
    {
        IUnitOfWork _unitOfWork;
        GenericRepository<Cart> cartRepo;
        GenericRepository<User> userRepo;
        GenericRepository<Product> productRepo;
        GenericRepository<CartProduct> cartProductRepo;

        public CartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            cartRepo = _unitOfWork.GetRepository<Cart>();
            userRepo = _unitOfWork.GetRepository<User>();
            productRepo = _unitOfWork.GetRepository<Product>();
            cartProductRepo = _unitOfWork.GetRepository<CartProduct>();
        }

        public void AddToCart(int productId, int userId, int count)
        {
            var user = userRepo.Get(x => x.Id == userId).FirstOrDefault();
            if (user == null) { throw new ArgumentException("User Invalid"); }

            var product = productRepo.Get(x => x.Id == productId).FirstOrDefault();
            if (product == null) { throw new ArgumentException("Product Invalid"); }

            // check if cart already exists for user
            var cart = cartRepo.Get(x => x.IsActive == true, includeProperties: "CartProducts,CartProducts.Product").FirstOrDefault();
            if (cart == null) { cart = CreateCart(user.Id); }

            // check if cart has that product already
            if(cart.CartProducts == null) cart.CartProducts = new List<CartProduct>();
            var temp = cart.CartProducts.Where(x => x.ProductId == product.Id).FirstOrDefault();

            if (temp == null)
            {
                var cartProduct = new CartProduct
                {
                    CartId = cart.Id,
                    ProductId = product.Id,
                    Count = count
                };
                cartProductRepo.Insert(cartProduct);
                cart.CartProducts.Add(cartProduct);
            }
            else
            {
                temp.Count += count;
            }

            cartRepo.Update(cart);
            _unitOfWork.Save();
        }

        private Cart CreateCart(int userId)
        {
            var cart = new Cart { IsActive = true, UserId = userId };
            _unitOfWork.GetRepository<Cart>().Insert(cart);
            _unitOfWork.Save();
            return cart;
        }

        public List<CartProductResponse> GetCart(int userId)
        {
            var cart = cartRepo.Get(x => x.UserId == userId && x.IsActive == true, includeProperties: "CartProducts,CartProducts.Product,CartProducts.Product.ProductStocks").FirstOrDefault();
            if(cart == null) { throw new ArgumentException("User Invalid"); }

            return cart.CartProducts.Select(prod =>
                new CartProductResponse
                {
                    Id = prod.Product.Id,
                    productBrief = prod.Product.ShortDescription,
                    productName = prod.Product.Name,
                    productImage = prod.Product.ImageData,
                    productPrice = prod.Product.ProductStocks.OrderByDescending(x => x.DateTaken).First().Price,
                    productQuantity = prod.Count
                }).ToList();
        }

        public void RemoveEntireCart(int userId)
        {
            var cart = cartRepo.Get(x=>x.UserId == userId && x.IsActive).FirstOrDefault();
            if (cart == null) { throw new ArgumentException("User Invalid"); }
            cart.IsActive = false;
            cartRepo.Update(cart);
            _unitOfWork.Save();
        }

        public void RemoveFromCart(int productId, int userId, int count)
        {
            var cart = cartRepo.Get(x => x.UserId == userId && x.IsActive == true, includeProperties: "CartProducts,CartProducts.Product,CartProducts.Product.ProductStocks").FirstOrDefault();
            if (cart == null) { throw new ArgumentException("User Invalid"); }

            var product = productRepo.Get(x => x.Id == productId).FirstOrDefault();
            if (product == null) { throw new ArgumentException("Product Invalid"); }

            var temp = cart.CartProducts.Where(x => x.ProductId == product.Id).ToList().FirstOrDefault();

            if (temp == null) { throw new ArgumentException("CartProduct Invalid"); }

            
            cart.CartProducts.Remove(temp);
            cartRepo.Update(cart);
            _unitOfWork.Save();
            
        }
    }
}
