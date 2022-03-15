using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Repositories;

namespace ExpoSoft.Aplication.BusinessServices
{
    public class RetrieveService
    {
        private readonly IUnitOfWork _unitOfWolk;
        private readonly IBusinessRepository _businessRepository;

        public RetrieveService(IUnitOfWork unitOfWolk, IBusinessRepository businessRepository)
        {
            _unitOfWolk = unitOfWolk;
            _businessRepository = businessRepository;
        }

        public RetrieveResponse Retrieve(RetrieveRequest request)
        {
            var entity = _businessRepository.FindFirstOrDefault(ent => ent.Nit == request.NIT);
            if(entity != null)
            {
                return new RetrieveResponse(200, "Consulta Exitosa.", entity);
            }
            return new RetrieveResponse(400, $"No Existe la empresa con el NIT:{request.NIT}.", null);
        }
    }

    public record RetrieveRequest(string NIT);
    public record EntityResponse(string Nit, string Name, string Email, string TypeOfBusiness, string Department, string Town, string OwnerName, string OwnerlastName);
    public record RetrieveResponse(int Code, string Message, Business Business);
}
