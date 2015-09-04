using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechConferenceCopy.Domain.Context;
using TechConferenceCopy.Domain.Repository.Interfaces;

namespace TechConferenceCopy.Domain.Repository.Classes
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected TechContext _dbContext = new TechContext();
        private readonly IDbSet<TEntity> _dbset;
        protected DbSet<TEntity> dbSet;

        public BaseRepository()
        {

            _dbset = _dbContext.Set<TEntity>();
            dbSet = _dbContext.Set<TEntity>();
        }

        #region SYNCHRONOUS CALLS

        public virtual void Add(TEntity entity)
        {
            _dbset.Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            _dbset.Remove(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = _dbset.Where<TEntity>(where).AsEnumerable();
            foreach (TEntity obj in objects)
                _dbset.Remove(obj);
            _dbContext.SaveChanges();
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return _dbset.Where(where).FirstOrDefault<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            return _dbset.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbset.AsQueryable();
        }

        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return _dbset.Where(where).ToList();
        }

        #endregion

        #region ASYNCHRONOUS CALLS

        public virtual async Task<int> AddAsync(TEntity entity)
        {
            _dbset.Add(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> UpdateAsync(TEntity entity)
        {
            _dbset.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> DeleteAsync(TEntity entity)
        {
            _dbset.Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> DeleteAsync(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = _dbset.Where<TEntity>(where).AsEnumerable();
            foreach (TEntity obj in objects)
                _dbset.Remove(obj);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where)
        {
            return await _dbset.Where(where).FirstOrDefaultAsync<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where)
        {
            return await _dbset.Where(where).ToListAsync();
        }

        #endregion
    }
}
