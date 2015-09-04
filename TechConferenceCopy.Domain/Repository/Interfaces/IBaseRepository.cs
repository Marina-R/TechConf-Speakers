using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TechConferenceCopy.Domain.Repository.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        #region SYNCHRONOUS CALLS

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);
        TEntity Get(Expression<Func<TEntity, bool>> where);
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        #endregion

        #region ASYNCHRONOUS CALLS

        Task<int> AddAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where);
        Task<IEnumerable<TEntity>> GetAllAsync();

        #endregion
    }
}
