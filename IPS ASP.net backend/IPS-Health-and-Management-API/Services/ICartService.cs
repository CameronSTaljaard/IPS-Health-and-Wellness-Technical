using IPS_Health_and_Management_API.Models.Responses;

namespace IPS_Health_and_Management_API.Services
{
    public interface ICartService
    {
        void AddToCart(int productId, int userId, int count);
        void RemoveFromCart(int productId, int userId, int count);
        List<CartProductResponse> GetCart(int userId);
    }
}
