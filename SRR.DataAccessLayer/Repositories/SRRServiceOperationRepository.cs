namespace SRR.DataAccessLayer.Repositories
{
    using SRR.Contracts.DAL.Repositories;
    using SRR.DataAccessLayer.Model;
    using SRR.Infrastructure.Contracts.DAL;

    /// <summary>
    /// 
    /// </summary>
    public class SRRServiceOperationRepository : GenericRepository<SRRServiceOperations>, IServiceOperationRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public SRRServiceOperationRepository(IDbContext context)
            : base(context)
        {

        }
    }
}

