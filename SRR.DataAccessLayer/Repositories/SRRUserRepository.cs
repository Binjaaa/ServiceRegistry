namespace SRR.DataAccessLayer.Repositories
{
    using SRR.Contracts.DAL.Repositories;
    using SRR.DataAccessLayer.Model;
    using SRR.Infrastructure.Contracts.DAL;

    /// <summary>
    /// 
    /// </summary>
    public class SRRUserRepository : GenericRepository<SRRUsers>, IUserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public SRRUserRepository(IDbContext context)
            : base(context)
        {

        }
    }
}
