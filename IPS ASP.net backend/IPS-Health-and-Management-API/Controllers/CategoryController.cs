using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Models.Requests;
using IPS_Health_and_Management_API.Models.Responses;
using IPS_Health_and_Management_API.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IPS_Health_and_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        [Authorize]
        public IEnumerable<CategoryResponse> Get()
        {
            return _unitOfWork.GetRepository<Category>().Get(includeProperties: "Products").Select(cat =>
                new CategoryResponse() { Id= cat.Id, Name = cat.Name, Description = cat.Description, Count = cat.Products.Count(), ImageData = cat.Products.First().ImageData});
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        [Authorize]
        public IEnumerable<Product> Get(int id)
        {
            return _unitOfWork.GetRepository<Category>().Get(x => x.Id == id, includeProperties: "Products").FirstOrDefault().Products;
        }


    }
}
