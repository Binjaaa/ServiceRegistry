using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SRR.Infrastructure.Contracts.DAL
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> : IDisposable where T : class
    {
        //Sync members
        void Add(T entity);

        void Delete(long ID);
        void Delete(T entity);

        void Update(T entity);
        T GetById(long Id);
        IQueryable<T> All();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        void Save();
        //Async members
        //Task AddAsync(T entity, CancellationToken cancellationToken = default(CancellationToken));
        //Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));
        //Task DeleteAsync(long id, CancellationToken cancellationToken = default(CancellationToken));
    }
}
