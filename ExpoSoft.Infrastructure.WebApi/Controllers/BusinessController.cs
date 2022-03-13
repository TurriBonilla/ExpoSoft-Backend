using ExpoSoft.Aplication.BusinessServices;
using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpoSoft.Infrastructure.WebApi.Controllers
{
    public class BusinessController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IBusinessRepository _businessRepository;

        public BusinessController(IUnitOfWork unitOfWork, IBusinessRepository businessRepository)
        {
            _unitOfWork = unitOfWork;
            _businessRepository = businessRepository;
        }

        [HttpPost("sign-in")]
        public SignInResponse SignIn(SignInRequest request)
        {
            var service = new SignInService(_unitOfWork, _businessRepository);
            var response = service.SignIn(request);
            return response;
        }
    }
}
