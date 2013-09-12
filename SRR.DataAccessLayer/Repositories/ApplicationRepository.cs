namespace SRR.DataAccessLayer.Repositories
{
    using SRR.Contracts.DAL.Repositories;
    using SRR.DataAccessLayer.Model;
    using SRR.Infrastructure.Contracts.DAL;

    /// <summary>
    /// 
    /// </summary>
    public class ApplicationRepository : GenericRepository<SRRApplications>, IApplicationRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ApplicationRepository(IDbContext context)
            : base(context)
        {

        }
    }
}
