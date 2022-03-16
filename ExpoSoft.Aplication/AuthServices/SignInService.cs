using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Repositories;
using Microsoft.AspNetCore.Http;

namespace ExpoSoft.Aplication.AuthServices
{
    public class SignInService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBusinessRepository _businessRepository;

        public SignInService(IUnitOfWork unitOfWork, IBusinessRepository businessRepository)
        {
            _unitOfWork = unitOfWork;
            _businessRepository = businessRepository;
        }

        public SignInResponse SignIn(SignInRequest request, string token)
        {
            var entity = _businessRepository.FindFirstOrDefault(ent => ent.Email == request.Email);
            if(entity != null)
            {
                
                if(BCrypt.Net.BCrypt.Verify(request.Password, entity.Password))
                {
                    return new SignInResponse(StatusCodes.Status202Accepted, "Inicio de sesión correcto.", token, entity.Nit);
                }
                return new SignInResponse(StatusCodes.Status400BadRequest, "Su Contraseña no es correcta.", null, null);
            }
            return new SignInResponse(StatusCodes.Status400BadRequest, $"No existe el usuario registrado con el correo {request.Email}.", null, null);
        }
    }

    public record SignInRequest(string Email, string Password);
    public record SignInResponse(int StatusCode, string Message, string Token, string NIT);
}
