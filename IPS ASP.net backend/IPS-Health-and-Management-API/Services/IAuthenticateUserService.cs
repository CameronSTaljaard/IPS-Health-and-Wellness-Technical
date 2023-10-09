using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Models.Requests;

namespace IPS_Health_and_Management_API.Services
{
    public interface IAuthenticateUserService
    {
        public User Authenticate(LoginRequest request);
        public string HashPassword(string password);
        public string GetToken(User user);
    }
}
