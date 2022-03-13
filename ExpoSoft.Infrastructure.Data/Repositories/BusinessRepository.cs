using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Repositories;
using ExpoSoft.Infrastructure.Data.Base;

namespace ExpoSoft.Infrastructure.Data.Repositories
{
    public class BusinessRepository : GenericRepository<Business>, IBusinessRepository
    {
        public BusinessRepository(IDbContext context) : base(context) { }
    }
}
