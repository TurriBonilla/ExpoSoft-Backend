using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Repositories;
using ExpoSoft.Infrastructure.Data.Base;

namespace ExpoSoft.Infrastructure.Data.Repositories
{
    public class ScoreRepository : GenericRepository<Score>, IScoreRepository
    {
        public ScoreRepository(IDbContext context) : base(context) { }
    }
}
