using ExpoSoft.Aplication.BusinessServices;
using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ExpoSoft.Infrastructure.WebApi.Controllers
{
    [ApiController]
    [Route("api/business")]
    [Authorize]
    public class BusinessController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IBusinessRepository _businessRepository;
        public readonly IConfiguration _configuration;

        public BusinessController(IUnitOfWork unitOfWork, IBusinessRepository businessRepository, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _businessRepository = businessRepository;
            _configuration = configuration;
        }

        [EnableCors("MyPolicy")]
        [HttpGet]
        public ActionResult<RetrieveResponse> Retrieve(RetrieveRequest request)
        {
            var service = new RetrieveService(_unitOfWork, _businessRepository);
            var response = service.Retrieve(request);
            return Ok(response);
        }
    }
}
