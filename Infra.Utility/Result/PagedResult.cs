using System.ComponentModel;

namespace Infra.Utility.Result
{
    /// <summary>
    /// 分页数据结果
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class PagedResult<TModel>:DataResult<TModel>
    {
        /// <summary>
        /// 当前页索引
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页的记录条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 数据的总记录条数
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// 当前页数据
        /// </summary>
        public BindingList<TModel> CurrentPageData { get; set; }

        public PagedResult(long totalCount, BindingList<TModel> data)
        {
            TotalCount = totalCount;
            CurrentPageData = data;
        }

        public PagedResult(int pageIndex, int pageSize, long totalCount, BindingList<TModel> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            CurrentPageData = data;
        }

    }
}
