using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Repositories;
using ExpoSoft.Infrastructure.Data.Base;

namespace ExpoSoft.Infrastructure.Data.Repositories
{
    public class HistoricalScoreRepository : GenericRepository<HistoricalScore>, IHistoricalScoreRepository
    {
        public HistoricalScoreRepository(IDbContext context) : base(context) { }
    }
}
