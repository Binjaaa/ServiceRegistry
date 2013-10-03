namespace SRR.DataAccessLayer.Repositories
{
    using SRR.Contracts.DAL.Repositories;
    using SRR.DataAccessLayer.Model;
    using SRR.Infrastructure.Contracts.DAL;

    /// <summary>
    /// 
    /// </summary>
    public class SRRApplicationRepository : GenericRepository<SRRApplications>, IApplicationRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public SRRApplicationRepository(IDbContext context)
            : base(context)
        {

        }
    }
}
