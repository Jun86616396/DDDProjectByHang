using System;
using System.Linq;
using System.Linq.Expressions;

namespace DDD.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="filter">条件筛选</param>
        /// <returns></returns>
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);
        /// <summary>
        /// 显式获取数据
        /// </summary>
        /// <param name="propertySelectors">加载的导航属性</param>
        /// <returns></returns>
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[]
            propertySelectors);
        /// <summary>
        /// 显式获取数据
        /// </summary>
        /// <param name="filter">条件筛选</param>
        /// <param name="propertySelectors">加载的导航属性</param>
        /// <returns></returns>
        IQueryable<TEntity> GetAllIncluding(Expression<Func<TEntity, bool>> filter, params
            Expression<Func<TEntity, object>>[] propertySelectors);
        /// <summary>
        /// 根据Id获取
        /// </summary>
        /// <param name="id">实体Id</param>
        /// <returns></returns>
        TEntity GetById(int id);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="saveEntity">要添加的实体类</param>
        TEntity Insert(TEntity saveEntity);
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="saveEntity">编辑后的实体类</param>
        TEntity Update(TEntity saveEntity);
        /// <summary>
        /// 根据Id删除
        /// </summary>
        /// <param name="id">实体Id</param>
        void Delete(int id);
        /// <summary>
        /// 根据实体删除
        /// </summary>
        /// <param name="saveEntity">要删除的实体类</param>
        void Delete(TEntity saveEntity);
        /// <summary>
        /// 获取数据记录总条数
        /// </summary>
        /// <returns></returns>
        int Count();
        /// <summary>
        /// 获取数据记录总条数
        /// </summary>
        /// <param name="filter">条件筛选</param>
        /// <returns></returns>
        int Count(Expression<Func<TEntity, bool>> filter);


        /// <summary>
        /// 获取记录总条数
        /// </summary>
        /// <param name="filter">条件筛选</param>
        /// <param name="propertySelectors">加载的导航属性</param>
        /// <returns></returns>
        int Count(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity,
            object>>[] propertySelectors);
    }

}
