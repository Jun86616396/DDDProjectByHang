using DDD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DDD.Domain.Models.OPWAY;
using Infra.EF.Contexts;
using Infra.Utility;

namespace ManageSystem
{
	public partial class DBDataSearch : Form
	{
		public DBDataSearch()
		{
			InitializeComponent();
		}


	
		private GwContext _opwayDbContext;
        
		private void btnSearchStart_Click(object sender, EventArgs e)
		{
			if (this.tb_SN_Init.Text.Length <= 12)
			{
				MessageBox.Show("扫描到的序列号有问题！,小于12位,请手动输入！");
				this.tb_SN_Init.SelectAll();
				return;
			}
			var snMin = this.tb_SN_Init.Text.Trim();
			var snMax = this.tb_SN_Last.Text.Trim();

			var allSnList = SnHelper.GetSnlist(snMin, snMax);
			this.listLost.DataSource = null;
			dgvOPWAYData.DataSource = null;

			var strQuery = $"SELECT [SN] FROM [ATSDATABASE].[dbo].[OPWAYDATA] as  [A] WHERE  [A].[SN] BETWEEN  '{snMin}'  AND  '{snMax}'";


			//表格展示
			if (chb_dgv.Checked == true)
			{
				strQuery= $"SELECT * FROM [ATSDATABASE].[dbo].[OPWAYDATA] as  [A] WHERE  [A].[SN] BETWEEN  '{snMin}'  AND  '{snMax}'";
			}


			if (rdoTest.Checked)  // 测试数据查询  
			{
				strQuery += " AND [A].[EMM] !=''";
			}
			else   //调试数据
			{
				strQuery += " AND  [A].[EMM] =''";
			}

			if (chb_Result.Checked == true)
			{
				strQuery += " AND  [A].[PF] = 'PASS'";

			}

			if (cbx_TakeLastSN.Checked == true)
			{
				//SELECT [SN] FROM OPWAYDATA as  A WHERE SN BETWEEN 'OP19030502001' AND 'OP19030504000' AND EMM !='' AND PF = 'PASS'  AND A.DataId= (SELECT MAX(DataId) FROM OPWAYDATA  as B WHERE   B.SN = A.SN)	

				strQuery += " AND [A].[DataId]= (SELECT MAX([DataId]) FROM [ATSDATABASE].[dbo].[OPWAYDATA]  as [B] WHERE   [B].[SN] = [A].[SN])";
			}



			

			using (_opwayDbContext = new GwContext())
			{
				List<string> snList;

				if (chb_dgv.Checked == true)
				{

					var list = _opwayDbContext.Database.SqlQuery<OPWAYDATA>(strQuery).ToList();

				
					dgvOPWAYData.DataSource = list;

					snList = list.Select(o => o.SN).ToList();

				}
				else
				{
					 snList = _opwayDbContext.Database.SqlQuery<string>(strQuery).ToList();
				}

					
				//更新界面数字
				this.tb_Result.Text = snList.Count().ToString();
				if (chb_lost.Checked == true)
				{
					var list = allSnList.Except(snList).ToList();
					this.txtcount.Text = list.Count().ToString()+"个";
					this.listLost.DataSource = list;
				}



			}

		}

		private void tb_SN_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (this.tb_SN_Init.Text.Length <= 12)
				{
					MessageBox.Show("扫描到的序列号有问题！,小于12位,请手动输入！");
					this.tb_SN_Init.SelectAll();
					return;
				}

				this.tb_SN_Last.Text = SnHelper.SnLast(this.tb_SN_Init.Text, 50);

				btnSearchStart_Click(null, null);
			}
		}

		private void chb_Result_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
