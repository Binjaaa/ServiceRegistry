using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRR.Contracts.DAL.Repositories;
using SRR.DataAccessLayer.Model;
using SRR.Infrastructure.Contracts.DAL;

namespace SRR.DataAccessLayer.Repositories
{
    public class SRREntityTagRepository : GenericRepository<SRREntityTagKeywords>, ISRREntityTagRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public SRREntityTagRepository(IDbContext context)
            : base(context)
        {

        }
    }
}
