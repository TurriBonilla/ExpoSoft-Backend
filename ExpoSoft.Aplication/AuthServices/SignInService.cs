using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Repositories;

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
                if(entity.Password == request.Password)
                {
                    return new SignInResponse(202, "Inicio de sesión correcto.", entity.Nit, token);
                }
                return new SignInResponse(400, "Su Contraseña no es correcta.", null, null);
            }
            return new SignInResponse(400, $"No existe el usuario registrado con el correo {request.Email}.", null, null);
        }
    }

    public record SignInRequest(string Email, string Password);
    public record SignInResponse(int Code, string Message, string NIT, string Token);
}
