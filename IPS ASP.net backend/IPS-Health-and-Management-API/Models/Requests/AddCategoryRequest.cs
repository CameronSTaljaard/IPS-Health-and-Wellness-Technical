using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IPS_Health_and_Management_API.Models.Requests
{
    public class AddCategoryRequest 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageString { get; set; }
    }
}
