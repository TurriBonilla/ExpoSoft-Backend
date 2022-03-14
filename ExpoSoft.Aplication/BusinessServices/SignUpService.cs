using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Repositories;

namespace ExpoSoft.Aplication.BusinessServices
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

        public SignUpResponse SignIn(SignUpRequest request)
        {
            var entityNIT = _businessRepository.FindFirstOrDefault(ent => ent.Nit == request.NIT);
            var entityEmail = _businessRepository.FindFirstOrDefault(ent => ent.Nit == request.NIT);
            if (entityEmail == null)
            {
                if (entityEmail == null)
                {
                    var newEntity = new Business();
                    var resEntity = newEntity.SignUp(request.Name, request.NIT, request.Email, request.Password);
                    if (resEntity.Equals("Registro Exitoso."))
                    {
                        _businessRepository.Add(newEntity);
                        _unitOfWork.Commit();
                        return new SignUpResponse(201, resEntity, newEntity.Id);
                    }
                    return new SignUpResponse(400, resEntity, -1);
                }
                return new SignUpResponse(400, $"Ya existe una empresa con el correo {request.Email}.", -1);
            }
            return new SignUpResponse(400, $"Ya existe una empresa con el NIT:{request.NIT}.", -1);
        }
    }

    public record SignUpRequest(string NIT, string Name,string Email, string Password);
    public record SignUpResponse(int Code, string Message, int Token);
}
