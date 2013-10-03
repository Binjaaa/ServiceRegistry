namespace SRR.DataAccessLayer.Repositories
{
    using SRR.Contracts.DAL.Repositories;
    using SRR.DataAccessLayer.Model;
    using SRR.Infrastructure.Contracts.DAL;

    /// <summary>
    /// 
    /// </summary>
    public class SRREntityTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public SRREntityTypeRepository(IDbContext context) 
        {

        }
        //: base(context)
         //: GenericRepository<SRREntityTypeSet>, IEntityTypeRepository
    }
}
