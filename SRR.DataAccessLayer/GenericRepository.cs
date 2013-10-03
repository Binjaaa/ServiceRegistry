namespace SRR.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using SRR.Infrastructure.Contracts.DAL;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region [--MEMBERS--]
        internal readonly IDbContext _context;
        internal readonly IDbSet<TEntity> _dbset;
        bool _disposed = false;
        #endregion // END OF MEMBERS


        #region [--CONSTRUCTOR--]
        public GenericRepository(IDbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        #endregion // END OF CONSTRUCTOR


        #region [--METHODS--]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(TEntity entity)
        {
            _dbset.Add(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(long id)
        {
            TEntity entityToDelete = _dbset.Find(id);
            Delete(entityToDelete);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(TEntity entity)
        {
            if (entity != null)
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    _dbset.Attach(entity);
                }
                _dbset.Remove(entity);    
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(TEntity entity)
        {
            //var fuck = 

            _dbset.Attach(entity);
            var entry = _context.Entry<TEntity>(entity);
            entry.State = EntityState.Modified;
        }

        public virtual void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

        public virtual TEntity GetById(long ID)
        {
            return _dbset.Find(ID);
        }

        public virtual IQueryable<TEntity> All()
        {
            return _dbset.AsQueryable<TEntity>();
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbset.Where(predicate);
        }


        //public async Task AddAsync(T entity, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    throw new NotImplementedException();
        //    //return await _dbset.ToList().as;
        //}

        //public async Task DeleteAsync(long id, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    throw new NotImplementedException();
        //}
        #endregion // END OF METHODS

       

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
