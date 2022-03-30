using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Repositories;
using Microsoft.AspNetCore.Http;

namespace ExpoSoft.Aplication.AuthServices
{
    public class SignUpService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBusinessRepository _businessRepository;

        public SignUpService(IUnitOfWork unitOfWork, IBusinessRepository businessRepository)
        {
            _unitOfWork = unitOfWork;
            _businessRepository = businessRepository;
        }

        public SignUpResponse SignIn(SignUpRequest request, string token)
        {
            var entityNIT = _businessRepository.FindFirstOrDefault(ent => ent.Nit == request.NIT);
            if (entityNIT == null)
            {
                var entityEmail = _businessRepository.FindFirstOrDefault(ent => ent.Email == request.Email);
                if (entityEmail == null)
                {
                    var newEntity = new Business();
                    var resEntity = newEntity.SignUp(request.Name, request.NIT, request.Email, request.Password);
                    if (resEntity.Equals("Registro Exitoso."))
                    {
                        _businessRepository.Add(newEntity);
                        _unitOfWork.Commit();
                        return new SignUpResponse(StatusCodes.Status201Created, resEntity, token, newEntity.Nit);
                    }
                    return new SignUpResponse(StatusCodes.Status406NotAcceptable, resEntity, null, null);
                }
                return new SignUpResponse(StatusCodes.Status226IMUsed, $"Ya existe una empresa con el correo {request.Email}.", null, null);
            }
            return new SignUpResponse(StatusCodes.Status226IMUsed, $"Ya existe una empresa con el NIT:{request.NIT}.", null, null);
        }
    }

    public record SignUpRequest(string NIT, string Name,string Email, string Password);
    public record SignUpResponse(int StatusCode, string Message, string Token, string NIT);
}
