using IPS_Health_and_Management_API.Models.Database;
using IPS_Health_and_Management_API.Models.Requests;
using IPS_Health_and_Management_API.Models.Responses;
using IPS_Health_and_Management_API.Repositories.Interfaces;
using IPS_Health_and_Management_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IPS_Health_and_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        IAuthenticateUserService _authenticateUserService;
        IUnitOfWork _unitOfWork;

        public RegisterController(IAuthenticateUserService authenticateUserService, IUnitOfWork unitOfWork)
        {
            _authenticateUserService = authenticateUserService;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Post([FromBody] NewUserRequest request)
        {
            User user = new User()
            {
                Username = request.Username,
                Password = _authenticateUserService.HashPassword(request.Password)
            };

            if (_unitOfWork.GetRepository<User>().Get(user => user.Username == request.Username).FirstOrDefault() != null) return Unauthorized("Username Taken"); 

            _unitOfWork.GetRepository<User>().Insert(user);
            _unitOfWork.Save();

            return Ok(new TokenResponse()
            {
                Token = _authenticateUserService.GetToken(user)
            });
        }
    }
}
