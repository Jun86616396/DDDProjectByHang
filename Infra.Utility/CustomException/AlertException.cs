using System;

namespace Infra.Utility.CustomException
{

    /// <summary>
    /// 自定义提示异常
    /// </summary>
    public class AlertException : Exception
    {
        public AlertException(string message) : base(message)
        {

        }
    }
}
