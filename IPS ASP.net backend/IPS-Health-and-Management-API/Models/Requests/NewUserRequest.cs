using System.ComponentModel.DataAnnotations;

namespace IPS_Health_and_Management_API.Models.Requests
{
    public class NewUserRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
