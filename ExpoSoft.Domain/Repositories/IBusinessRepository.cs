using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpoSoft.Domain.Contracts;
using ExpoSoft.Domain.Entities;

namespace ExpoSoft.Domain.Repositories
{
    public interface IBusinessRepository : IGenericRepository<Business>
    {
    }
}
