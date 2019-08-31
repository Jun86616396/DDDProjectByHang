using System;

namespace Infra.Utility
{
	public class LogHelper
	{
		public static readonly log4net.ILog LogInfo = log4net.LogManager.GetLogger("loginfo");
		public static readonly log4net.ILog LogError = log4net.LogManager.GetLogger("logerror");
		public static void WriteLog(string info)
		{
			if (LogInfo.IsInfoEnabled)
			{
				LogInfo.Info(info);
			}
		}

		public static void WriteLog(string info, Exception ex)
		{
			if (LogError.IsErrorEnabled)
			{
				LogError.Error(info, ex);
			}
		}
	}
}
