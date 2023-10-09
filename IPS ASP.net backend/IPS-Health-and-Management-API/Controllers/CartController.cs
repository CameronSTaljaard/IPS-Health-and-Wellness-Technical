using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Repositories.Interfaces;
using IPS_Health_and_Management_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IPS_Health_and_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        IUnitOfWork _unitOfWork;
        ICartService _cartService;

        public CartController(IUnitOfWork unitOfWork, ICartService cartService)
        {
            _unitOfWork = unitOfWork;
            _cartService = cartService;
        }

        // GET api/<CartController>/5
        [Authorize]
        [HttpGet]
        public ActionResult Get()
        {

            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if(identity == null) { return Unauthorized(); }
            var userId = int.Parse(identity.FindFirst("userId").Value);

            return Ok(_cartService.GetCart(userId));
        }

        [Authorize]
        [HttpPost("remove/{id}")]
        public ActionResult Remove(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity == null) { return Unauthorized(); }
            var userId = int.Parse(identity.FindFirst("userId").Value);

            _cartService.RemoveFromCart(id, userId, 1);

            return Ok();
        }

        [Authorize]
        [HttpPost("add/{id}")]
        public ActionResult Add(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity == null) { return Unauthorized(); }
            var userId = int.Parse(identity.FindFirst("userId").Value);

            _cartService.AddToCart(id, userId, 1);

            return Ok();
        }
    }
}
