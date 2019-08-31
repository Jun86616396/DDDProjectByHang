
using DDD.Domain;
using System;
using System.Windows.Forms;
using DDD.Application.DTO.User;

namespace ManageSystem
{
    static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            //显示登录窗体
			FrmLogin frmLogin = new FrmLogin();
			DialogResult result = frmLogin.ShowDialog();

			//判断登录是否成功
			if (result == DialogResult.OK)
			{
				Application.Run(new FrmNavigation());
			}
			else
			{
				Application.Exit();//退出整个应用程序
			}

		
	    }
		//定义一个全局变量  用于保存当前登录用户
		public static LoginOutput objCurrentLoginUser = null;

	}
}
