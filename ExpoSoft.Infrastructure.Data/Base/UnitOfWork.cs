using ExpoSoft.Domain.Contracts;

namespace ExpoSoft.Infrastructure.Data.Base
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private IDbContext _dbContext;

        public UnitOfWork(IDbContext context)
        {
            _dbContext = context;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
