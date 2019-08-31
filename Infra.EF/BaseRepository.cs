using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using DDD.Domain.Interfaces;

namespace Infra.EF
{
    public class BaseRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext : DbContext
    {
        protected readonly TContext DbContext;
        //protected readonly ManageContext DbContext;

        protected readonly DbSet<TEntity> DbSet;
        
        public BaseRepository(TContext dbContext)
        {
            DbContext = dbContext;

            DbSet = DbContext.Set<TEntity>();
        }
        ////public BaseRepository(TContext dbContext)
        ////{
        ////    DbContext = dbContext;

        ////    DbSet = DbContext.Set<TEntity>();
        ////}


        //public BaseRepository(ManageContext dbContext)
        //{
        //	DbContext = dbContext;

        //	DbSet = DbContext.Set<TEntity>();
        //}
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="filter">条件筛选</param>
        /// <returns></returns>
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return GetAll().Where(filter);
        }
        /// <summary>
        /// 显式获取数据
        /// </summary>
        /// <param name="propertySelectors">加载的导航属性</param>
        /// <returns></returns>
        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>
        [] propertySelectors)
        {
            if (propertySelectors.Length == 0)
            {
                return GetAll();
            }
            var query = GetAll();
            foreach (var propertySelector in propertySelectors)
            {
                query = query.Include(propertySelector);
            }
            return query;
        }
        /// <summary>
        /// 显式获取数据
        /// </summary>
        /// <param name="filter">条件筛选</param>
        /// <param name="propertySelectors">加载的导航属性</param>
        /// <returns></returns>
        public IQueryable<TEntity> GetAllIncluding(Expression<Func<TEntity, bool>> filter,
        params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            var query = GetAll(filter);
            if (propertySelectors.Length == 0)
            {
                return query;
            }
            foreach (var propertySelector in propertySelectors)
            {
                query = query.Include(propertySelector);
            }
            return query;
        }
        /// <summary>
        /// 根据Id获取
        /// </summary>
        /// <param name="id">实体Id</param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="saveEntity">要添加的实体类</param>
        public TEntity Insert(TEntity saveEntity)
        {
            return DbSet.Add(saveEntity);
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="saveEntity">编辑后的实体类</param>
        public TEntity Update(TEntity saveEntity)
        {
            if (DbContext.Entry(saveEntity).State == EntityState.Detached)
                HandleDetached(saveEntity);

            DbContext.Entry(saveEntity).State = EntityState.Modified;
            return saveEntity;
        }

        private bool HandleDetached(TEntity entity)
        {
            var objectContext = ((IObjectContextAdapter)DbContext).ObjectContext;
            var entitySet = objectContext.CreateObjectSet<TEntity>();
            var entityKey = objectContext.CreateEntityKey(entitySet.EntitySet.Name, entity);
            object foundSet;
            bool exists = objectContext.TryGetObjectByKey(entityKey, out foundSet);
            if (exists)
            {
                objectContext.Detach(foundSet); //从上下文中移除
            }
            return exists;
        }

        /// <summary>
        /// 获取总数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return DbSet.Count();
        }
        /// <summary>
        /// 获取数据记录总条数
        /// </summary>
        /// <param name="filter">条件筛选</param>
        /// <returns></returns>
        public int Count(Expression<Func<TEntity, bool>> filter)
        {

            return GetAll(filter).Count();
        }
        /// <summary>
        /// 获取记录总条数
        /// </summary>
        /// <param name="filter">条件筛选</param>
        /// <param name="propertySelectors">加载的导航属性</param>
        /// <returns></returns>
        public int Count(Expression<Func<TEntity, bool>> filter,
        params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return GetAllIncluding(filter, propertySelectors).Count();
        }
        /// <summary>
        /// 根据Id删除
        /// </summary>
        /// <param name="id">实体Id</param>
        public void Delete(int id)
        {
            TEntity entity = DbSet.Find(id);
            Delete(entity);
        }
        /// <summary>
        /// 根据实体删除
        /// </summary>
        /// <param name="saveEntity">要删除的实体类</param>
        public void Delete(TEntity saveEntity)
        {
            DbSet.Remove(saveEntity);
        }


    }
}
