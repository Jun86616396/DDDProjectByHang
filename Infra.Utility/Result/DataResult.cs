using System;
using Infra.Utility.CustomException;

namespace Infra.Utility.Result
{
    public class DataResult<TModel>
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 错误信息提示
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 数据操作结果
        /// </summary>
        public TModel Data { get; set; }

        public DataResult()
        {
            IsSuccess = true;
        }

        public DataResult(string errorMessage)
        {
            IsSuccess = false;
            ErrorMessage = errorMessage;
        }

        public DataResult(TModel data)
        {
            IsSuccess = true;
            Data = data;
        }

        public static DataResult<TModel> ForException(Exception exception)
        {
            if (exception is AlertException)
            {
                AlertException alertException=exception as AlertException;

                return new DataResult<TModel>(alertException.Message);
            }

            return new DataResult<TModel>("系统错误，请重试");
        }

    }
}
