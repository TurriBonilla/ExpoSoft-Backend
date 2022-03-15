using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Repositories;
using Microsoft.AspNetCore.Http;

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
                return new RetrieveResponse(StatusCodes.Status200OK, "Consulta Exitosa.", entity);
            }
            return new RetrieveResponse(StatusCodes.Status400BadRequest, $"No Existe la empresa con el NIT:{request.NIT}.", null);
        }
    }

    public record RetrieveRequest(string NIT);
    public record RetrieveResponse(int StatusCode, string Message, Business Business);
}
