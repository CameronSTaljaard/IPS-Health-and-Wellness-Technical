using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Models.Requests;
using IPS_Health_and_Management_API.Models.Responses;
using IPS_Health_and_Management_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IPS_Health_and_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        IAuthenticateUserService _authenticateUserService;

        public LoginController(IAuthenticateUserService authenticateUserService)
        {
            _authenticateUserService = authenticateUserService;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Post([FromBody] LoginRequest request)
        {
            if (request == null) return new JsonResult(new { error = "No Token" }); ;

            User user = _authenticateUserService.Authenticate(request);

            if (user == null) return new JsonResult(new { error = "Invalid User" }); ;

            return Ok(new TokenResponse()
            {
                Token = _authenticateUserService.GetToken(user)
            });
        }

    }
}
