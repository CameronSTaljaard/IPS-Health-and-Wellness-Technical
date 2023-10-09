using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IPS_Health_and_Management_API.Models.Requests
{
    public class LoginRequest 
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
