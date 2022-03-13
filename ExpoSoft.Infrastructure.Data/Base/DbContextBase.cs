using Microsoft.EntityFrameworkCore;

namespace ExpoSoft.Infrastructure.Data.Base
{
    public class DbContextBase : DbContext, IDbContext
    {
        public DbContextBase() { }
        public DbContextBase(DbContextOptions options) : base(options) { }
        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
