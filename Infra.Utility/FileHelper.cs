using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Infra.Utility
{
	public class FileHelper
	{

		private static string path = AppDomain.CurrentDomain.BaseDirectory;

		private static string directoryName = "订单新增配置";

		private static string txtFileName = "料号-型号配置文件.txt";

		private static string directoryPath = path + @"\" + directoryName ;

		public static string filePath = Path.Combine(directoryPath, txtFileName);


		//创建配置文件和目录
		private static void CreateDirAndFile()
		{
			//创建目录
			if (!Directory.Exists(directoryPath))
			{
				Directory.CreateDirectory(directoryPath);
			}

			//创建文件
			if (!File.Exists(filePath))
			{
				File.Create(filePath).Close();
				File.WriteAllLines(filePath, new string[] { @"请按照冒号':'填写成品料号和产品型号对应关系", "3.01.4235:OP3902D" });
			}

		}

		/// <summary>
		/// 读取配置文件
		/// </summary>
		/// <returns></returns>
		public static Tuple<List<string>,List<string>> ReadConfigFile()
		{


			CreateDirAndFile();

			List<string> finishedProductNoList = new List<string>();
			List<string> productTypeList = new List<string>();


			var list = File.ReadAllLines(filePath).ToList();
			list.RemoveAt(0);

			//文件为空
			if (list.Count == 0)
				return new Tuple<List<string>, List<string>>(finishedProductNoList, productTypeList);

			foreach (var item in list)
			{
				if (!string.IsNullOrEmpty(item))
				{
				   var zz=	item.Split(new char[] { ':' });
					finishedProductNoList.Add(zz[0]);
					productTypeList.Add(zz[1]);
				}
			}

			return new Tuple<List<string>, List<string>>(finishedProductNoList, productTypeList);

		}

	}
}
