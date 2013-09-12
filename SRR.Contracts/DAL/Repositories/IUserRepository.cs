using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRR.DataAccessLayer.Model;
using SRR.Infrastructure.Contracts.DAL;

namespace SRR.Contracts.DAL.Repositories
{
    public interface IUserRepository : IRepository<SRRUsers>
    {
    }
}
