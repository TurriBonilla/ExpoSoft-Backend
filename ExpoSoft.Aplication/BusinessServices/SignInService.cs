using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Repositories;

namespace ExpoSoft.Aplication.BusinessServices
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

        public SignInResponse SignIn(SignInRequest request)
        {
            var entity = _businessRepository.FindFirstOrDefault(ent => ent.Email == request.email);
            if(entity != null)
            {
                if(entity.Password == request.password)
                {
                    return new SignInResponse(202, "Inicio de sesión correcto.");
                }
                return new SignInResponse(400, "Su Contraseña no es correcta.");
            }
            return new SignInResponse(400, $"No existe el usuario registrado con el correo {request.email}.");
        }
    }

    public record SignInRequest(string email, string password);
    public record SignInResponse(int code, string messaga);
}
