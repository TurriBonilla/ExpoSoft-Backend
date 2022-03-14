﻿using ExpoSoft.Aplication.BusinessServices;
using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<SignInResponse> SignIn(SignInRequest request)
        {
            var service = new SignInService(_unitOfWork, _businessRepository);
            var response = service.SignIn(request);
            return Ok(response);
        }

        [HttpPost("sign-up")]
        public ActionResult<SignUpResponse> SignUp(SignUpRequest request)
        {
            var service = new SignUpService(_unitOfWork, _businessRepository);
            var response = service.SignIn(request);
            return Ok(response);
        }

        [HttpPost("retrieve")]
        public ActionResult<RetrieveResponse> Retrieve(RetrieveRequest request)
        {
            var service = new RetrieveService(_unitOfWork, _businessRepository);
            var response = service.Retrieve(request);
            return Ok(response);
        }
    }
}
