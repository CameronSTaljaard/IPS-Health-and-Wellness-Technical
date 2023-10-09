using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Models.Requests;
using IPS_Health_and_Management_API.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IPS_Health_and_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<ValuesController>
        [Authorize]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _unitOfWork.GetRepository<Product>().Get();
        }

        // GET api/<ValuesController>/5
        [Authorize]
        [HttpGet("{id}")]
        public ProductResponse Get(int id)
        {
            return _unitOfWork.GetRepository<Product>().Get(x=>x.Id==id, includeProperties: "ProductStocks").Select(x=>new ProductResponse { 
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Price = x.ProductStocks.OrderByDescending(x=>x.DateTaken).FirstOrDefault().Price,
                ImageData = x.ImageData
            }).FirstOrDefault();
        }

        // POST api/<ValuesController>
        [Authorize]
        [HttpPost]
        public void Post([FromBody] ProductRequest request)
        {
            Product product = new()
            {
                ImageData = request.ImageData,
                Name = request.Name,
                ShortDescription = request.ShortDescription,
                Description = request.Description,
            };

            ProductStock stock = new()
            {
                StockLevel = request.StockLevel,
                DateTaken = DateTime.UtcNow,
                Product = product
            };

            _unitOfWork.GetRepository<Product>().Insert(product);
            _unitOfWork.GetRepository<ProductStock>().Insert(stock);
            _unitOfWork.Save();
        }
    }
}
