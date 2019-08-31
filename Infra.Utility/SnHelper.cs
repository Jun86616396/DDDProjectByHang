using System;
using System.Collections.Generic;

namespace Infra.Utility
{
    public class SnHelper
    {
		/// <summary>
		/// 得到最后一个SN
		/// </summary>
		/// <param name="sn"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public static string SnLast(  string sn, int count)
		{
			string str1 = sn.Substring(sn.Length - 5);
			Int32 snLastfive = Int32.Parse(str1);        //转化为数字
			snLastfive = count + snLastfive - 1;
			return sn.Substring(0, sn.Length - 5) + snLastfive.ToString().PadLeft(5, '0');
		}

		/// <summary>
		/// 默认增加1
		/// </summary>
		/// <param name="sn"></param>
		/// <returns></returns>
		public static string SnIncrease(string sn)
		{
			//获取后五位
			string str1 = sn.Substring(sn.Length - 5);
			Int32 snLastFive = Int32.Parse(str1);        //转化为数字
			snLastFive++;
			sn = sn.Substring(0, sn.Length - 5) + snLastFive.ToString().PadLeft(5, '0');
			return sn;
		}
		/// <summary>
		/// 增加指定数量
		/// </summary>
		/// <param name="sn"></param>
		/// <param name="number"></param>
		/// <returns></returns>
		public static string SnIncrease(string sn,int number)
		{
			string str1 = sn.Substring(sn.Length - 5);
			Int32 snLastFive = Int32.Parse(str1);        //转化为数字
			snLastFive+= number;
			sn = sn.Substring(0, sn.Length - 5) + snLastFive.ToString().PadLeft(5, '0');
			return sn;
		}
		/// <summary>
		/// 得到起始号开始的所有SN
		/// </summary>
		/// <param name="snMin"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public static List<string> GetSnlist(string snMin,int count)
		{
			List<string> orderSnList = new List<string>();
			int first = Int32.Parse(snMin.Substring(snMin.Length - 5));

			int last = Int32.Parse(SnLast(snMin, count).Substring(snMin.Length - 5));

			string firstSn = snMin;
			for (int i = 0; i <= (last - first); i++)
			{
				orderSnList.Add(firstSn);

				firstSn = SnIncrease(firstSn);
			}

			return orderSnList;
		}


		public static List<string> GetSnlist(string snMin,string snMax)
		{
			List<string> orderSnList = new List<string>();
			int first = Int32.Parse(snMin.Substring(snMin.Length - 5));
			int last = Int32.Parse(snMax.Substring(snMax.Length - 5));

			string firstSn = snMin;
			for (int i = 0; i <= (last - first); i++)
			{
				orderSnList.Add(firstSn);

				firstSn = SnIncrease(firstSn);
			}

			return orderSnList;

		}

		/// <summary>
		/// 得到起始SN所有的盒号
		/// </summary>
		/// <param name="sn"></param>
		/// <param name="count"></param>
		/// <param name="boxNumber"></param>
		/// <returns></returns>
		public static List<string> GetListboxNumber(string sn ,int count  , int boxNumber=50 )
		{
			List<string> orderboxs = new List<string>();

			int times = (count / boxNumber)+(count % boxNumber==0?0:1);

			for(int i = 0; i < times; i++)
			{
				orderboxs.Add(sn);
				sn = SnIncrease(sn, 50);
			}
			return orderboxs;
		}

	}
}
