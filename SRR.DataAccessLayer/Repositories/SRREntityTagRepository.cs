namespace SRR.DataAccessLayer.Repositories
{
    using SRR.Contracts.DAL.Repositories;
    using SRR.DataAccessLayer.Model;
    using SRR.Infrastructure.Contracts.DAL;

    /// <summary>
    /// 
    /// </summary>
    public class SRREntityTagRepository : GenericRepository<SRREntityTagKeywords>, IEntityTagRepository
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
