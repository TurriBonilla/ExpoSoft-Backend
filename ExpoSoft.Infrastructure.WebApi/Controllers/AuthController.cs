using ExpoSoft.Aplication.AuthServices;
using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Repositories;
using ExpoSoft.Infrastructure.WebApi.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ExpoSoft.Infrastructure.WebApi.Controllers
{
    [ApiController]
    [Route("api/auth")]
    [Authorize]
    public class AuthController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IBusinessRepository _businessRepository;
        public readonly IConfiguration _configuration;

        public AuthController(IUnitOfWork unitOfWork, IBusinessRepository businessRepository, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _businessRepository = businessRepository;
            _configuration = configuration;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult<SignInResponse> SignIn([FromQuery]SignInRequest request)
        {
            string secret = _configuration.GetValue<string>("Secret");

            var service = new SignInService(_unitOfWork, _businessRepository);
            var response = service.SignIn(request, new Token(secret).Create(request.Email));

            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<SignUpResponse> SignUp(SignUpRequest request)
        {
            string secret = _configuration.GetValue<string>("Secret");

            var service = new SignUpService(_unitOfWork, _businessRepository);
            var response = service.SignIn(request, new Token(secret).Create(request.Email));
            return StatusCode(response.StatusCode, response);
        }
    }
}
