using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRR.DataAccessLayer.Model;
using SRR.Infrastructure.Contracts.DAL;

namespace SRR.DataAccessLayer.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class SRREntityTypeRepository : GenericRepository<SRREntityTypeSet>, ISRREntityTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public SRREntityTypeRepository(IDbContext context) : base(context)
        {

        }
    }
}
