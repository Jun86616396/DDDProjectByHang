using Common;
using DataAccessLayer;
using DataAccessLayer.Edmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			//组装界面
			this.listRequiredFinish.DataSource = unFinishedBoxes;

			//领料界面 
			this.OrderGridView.AutoGenerateColumns = false;
			this.OrderGridView.DataSource = dgvBindingSource;
		}

		//
		private FlowManageSystemEntities _dbcontext;

		private OrderRepository orderRepositoy;

		private OrderBoxRepository orderBoxRepository;

		private AssembleRepository assembleRepository;
		//物料
		private CollectionRepository collectionRepository;

		//初测和终测
		private ATSDATABASEEntities _opwayDbContext;
		private OpwayDataRepository opwayDataRepository;

		//未完成的盒号  --界面绑定  组装页面使用
		private BindingList<string> unFinishedBoxes = new BindingList<string>();

		//使用Bindingsource组件
		BindingSource dgvBindingSource = new BindingSource();

		//当前分页页码  
		private int CurrentPage = 1;

		private const int PageSize = 20;

		private int PageCount = 0;


		#region   下单主界面
		/// <summary>
		/// 生成订单和 对应的盒号
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOrder_Click(object sender, EventArgs e)
		{
			try
			{
				using (_dbcontext = new FlowManageSystemEntities())
				{
					orderRepositoy = new OrderRepository(_dbcontext);
					orderBoxRepository = new OrderBoxRepository(_dbcontext);

					OrderPlacing orderPlacing = new OrderPlacing()
					{
						OrderDate = Convert.ToDateTime(this.OrderDateTimePic.Text),
						Type = this.TypeTxtBox.Text,
						PlanNo = this.PlanNoTxtBox.Text,
						FinishedProductNo = this.FinishedProductNocBox.Text,
						ProductTypeNo = this.ProductTypecBox.Text,
						OnLineQuantity = Convert.ToInt32(this.OnlineQuantityTxtBox.Text),
						SnMin = SnMinTxtBox.Text,
						SnMax = SnMinTxtBox.Text,
						LabelingRequirements = this.LableRequireTxtBox.Text,
						TestReport = this.TestReportTxtBox.Text,
						CodingRequirements = this.CodingRequireTxtBox.Text,
						PackingRequirement = this.PackingRequireTxtBox.Text,
						SpecialRequirement = this.SpecialRequireTxtBox.Text,
						TestSoftConfigFile = this.TestSoftConfigFIleTxtBox.Text,
						Remark = this.RemarkTxtBox.Text,
						CustomDemandDate = Convert.ToDateTime(this.CustonRequireTimePic.Text),
						PlannedLaunchDate = Convert.ToDateTime(this.PlanOnlineTimePic.Text),
						PlanStorageDate = Convert.ToDateTime(this.PlanStorageTimePic.Text),
						DaysOfProduction = Convert.ToByte(this.ProductDaysTxtBox.Text),
						OrderCreateTime = DateTime.Now
					};



					//注意此处一对多关联数据的保存  设置关联
					IEnumerable<OrderBox> orderBoxes = SnHelper.GetListboxNumber(this.SnMinTxtBox.Text, Convert.ToInt32(this.OnlineQuantityTxtBox.Text)).Select(item => new OrderBox()
					{
						//设置导航属性
						OrderPlacing = orderPlacing,
						//设置外键Id
						OrderId = orderPlacing.OrderId,
						//盒号
						BoxNumber = item,
						//新建时间
						OrderBoxCreateTime = DateTime.Now

					});

					//添加所有 多的 一端数据				
					orderBoxRepository.AddOrderAllBoxes(orderBoxes);

					//添加 一的  一端数据  //下单				
					orderRepositoy.AddOrder(orderPlacing);

					//一对多的数据一起保存  两个仓储公用一个dbcontext  可以防止添加部分失败    会以一个事务的形式保存
					_dbcontext.SaveChanges();

					MessageBox.Show("下单成功！");

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("下单失败，请检查数据" + ex.Message);
			}




		}

		/// <summary>
		/// 主界面清空已填
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClear_Click(object sender, EventArgs e)
		{
			foreach (var control in tabPage_Order.Controls)
			{
				if (control is TextBox)
				{
					(control as TextBox).Text = "";
				}

				if (control is DateTimePicker)
				{
					(control as DateTimePicker).Text = DateTime.Now.ToShortDateString();
				}

				if (control is ComboBox)
				{
					(control as ComboBox).Text = "";
				}
			}
		}

		/// <summary>
		/// 初始管号 回车  显示当前订单 最后一个SN号
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SnMinTxtBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.SnMinTxtBox.Text.Length < 8)
			{
				MessageBox.Show("请输入正确的SN,sn长度有问题");
				return;
			}
			if (e.KeyCode == Keys.Enter)
			{
				//界面显示此次订单最大SN  以便核对
				this.lbSnMax.Text = SnHelper.SNlast(this.SnMinTxtBox.Text, Convert.ToInt32(this.OnlineQuantityTxtBox.Text));
			}

		}

		/// <summary>
		///  计划单号不能重复   在此检验
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlanNoTxtBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (orderRepositoy.PlanNoExist(this.PlanNoTxtBox.Text.Trim()))
				{
					MessageBox.Show("当前计划单号" + this.PlanNoTxtBox.Text + "数据库已存在");
					this.PlanNoTxtBox.Text = "";

				}
			}
		}

		#endregion

		#region  领取物料
		/// <summary>
		/// 从数据库获取分页的数据
		/// </summary>
		/// <param name="pageIndex"> 哪一页的数据</param>
		/// <returns></returns>
		private BindingList<OrderPlacing> FillData(int pageIndex)
		{
			using (_dbcontext = new FlowManageSystemEntities())
			{
				orderRepositoy = new OrderRepository(_dbcontext);

				//获得记录总数
				var count = orderRepositoy.GetOrderCount();

				//获取分页数量
				PageCount = count % PageSize == 0 ? count / PageSize : count / PageSize + 1;

				this.lblInfo.Text = string.Format("第{0}页/共{1}页 {2}条", CurrentPage, PageCount, count);

				return orderRepositoy.GetOrders(pageIndex, PageSize);
			}


		}

		/// <summary>
		/// 选中的是步骤二 提取数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//如果选择的是 领取物料
			if ((sender as TabControl).SelectedTab == tabControl1.TabPages[1])
			{
				Task.Factory.StartNew(() => FillData(1))
					.ContinueWith(pretask =>
				{
					dgvBindingSource.DataSource = pretask.Result;
					this.OrderGridView.ClearSelection();
				},
				TaskScheduler.FromCurrentSynchronizationContext());
			}
		}

		#region  分页
		private void btnFirstPage_Click(object sender, EventArgs e)
		{
			CurrentPage = 1;
			dgvBindingSource.DataSource = FillData(1);
			this.OrderGridView.ClearSelection();

		}

		private void btnPrevPage_Click(object sender, EventArgs e)
		{

			if (CurrentPage > 1)
				CurrentPage--;
			else
				return;

			dgvBindingSource.DataSource = FillData(CurrentPage);
			this.OrderGridView.ClearSelection();
		}

		private void btnNextPage_Click(object sender, EventArgs e)
		{
			if (CurrentPage == PageCount)
				return;
			CurrentPage++;
			dgvBindingSource.DataSource = FillData(CurrentPage);
			this.OrderGridView.ClearSelection();
		}

		private void btnLastPage_Click(object sender, EventArgs e)
		{
			CurrentPage = PageCount;
			dgvBindingSource.DataSource = FillData(PageCount);
			this.OrderGridView.ClearSelection();
		}

		#endregion

		/// <summary>
		/// 选择不同的订单时  获取已经领取的物料数
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OrderGridView_SelectionChanged(object sender, EventArgs e)
		{
			var id = (this.OrderGridView.CurrentRow.DataBoundItem as OrderPlacing).OrderId;

			//通过Id 获取已经领料的数量
			using (_dbcontext = new FlowManageSystemEntities())
			{
				collectionRepository = new CollectionRepository(_dbcontext);

				if (collectionRepository.IsOrderCollectionExist(id))
				{
					this.lbMaterialCount.Text = collectionRepository.GetCurrentOrderCollectionInfo(id).ToString();
				}
				else
				{
					this.lbMaterialCount.Text = "0";
				}
			}
		}
		/// <summary>
		/// 领取物料
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnMateriaCollection_Click(object sender, EventArgs e)
		{
			if (this.OrderGridView.SelectedRows.Count == 0)
			{
				MessageBox.Show("请选中一个订单，再进行物料领取！");
				return;
			}


			if (this.txtboxMaterialNumber.Text.Length == 0)
			{
				MessageBox.Show("请输入领取物料数量，别瞎几把乱搞！！");
				return;
			}
			if (!RegexHelper.regExpNumber.IsMatch(this.txtboxMaterialNumber.Text))
			{
				MessageBox.Show("物料数量是数字，长点心 ok？");
				return;
			}
			var number = Convert.ToInt32(this.txtboxMaterialNumber.Text.Trim());

			using (_dbcontext = new FlowManageSystemEntities())
			{
				collectionRepository = new CollectionRepository(_dbcontext);

				var order = (this.OrderGridView.CurrentRow.DataBoundItem as OrderPlacing);
				//获取Id
				var id = order.OrderId;
				var onlineCount = order.OnLineQuantity;

				//当前已经领取数量
				var hasCount = Convert.ToInt32(this.lbMaterialCount.Text);

				//现在领取后的数量大于 订单计划做的数量 不允许
				if (onlineCount < (hasCount + number))
				{
					MessageBox.Show("领取物料后的数量 怎么能大于下单数量呢？请核对");
					return;
				}

				try
				{
					collectionRepository.AddCollection(id, number);
					collectionRepository.SaveChanges();
					this.lbMaterialCount.Text = (hasCount + number).ToString();
					txtboxMaterialNumber.Text = "";
				}
				catch (Exception ex)
				{

					MessageBox.Show("异常：" + ex.Message);
				}

			}

		}

		/// <summary>
		/// 删除订单
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeleteOeder_Click(object sender, EventArgs e)
		{
			if (this.OrderGridView.SelectedRows.Count == 0)
			{
				MessageBox.Show("请选中一个订单，再进行订单删除！");
				return;
			}



			//获得订单Id
			var order = (this.OrderGridView.CurrentRow.DataBoundItem as OrderPlacing);
			var id = order.OrderId;
			var planNo = order.PlanNo;



			DialogResult dialogResult = MessageBox.Show(" 此操作非常危险  您正在删除订单：" + planNo + " 该订单关联的盒号 和其他数据全部删除？确定么", "谨慎操作", MessageBoxButtons.OKCancel);

			if (dialogResult == DialogResult.Cancel)
			{
				return;
			}

			using (_dbcontext = new FlowManageSystemEntities())
			{
				orderRepositoy = new OrderRepository(_dbcontext);

				try
				{
					orderRepositoy.DelOrder(id);

					orderRepositoy.SaveChanges();

					dgvBindingSource.RemoveCurrent();
				}
				catch (Exception ex)
				{

					MessageBox.Show("异常：" + ex.Message);
				}

			}

		}
		#endregion

		#region    组装
		/// <summary>
		/// 当前盒完成
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox_BoxNumber_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Enter)
			{
				if (!RegexHelper.regExpNumber.IsMatch(this.textBox_DoNumber.Text))
				{
					MessageBox.Show("完成的数量应该是数字");
					return;
				}

				byte doNumber = Convert.ToByte(this.textBox_DoNumber.Text);

				DialogResult dialogResult = MessageBox.Show("当前盒完成数量：" + doNumber, "询问", MessageBoxButtons.OKCancel);

				if (dialogResult == DialogResult.Cancel)
				{
					return;
				}

				using (_dbcontext = new FlowManageSystemEntities())
				{
					orderBoxRepository = new OrderBoxRepository(_dbcontext);

					var boxNumber = this.textBox_BoxNumber.Text.Trim();

					//通过盒号找到订单号
					var id = orderBoxRepository.GetOrderId(boxNumber);

					List<string> boxNumbersNeedFinished = null;

					//根据订单号 找到需要完成的所有盒号
					if (id != 0)
					{
						boxNumbersNeedFinished = orderBoxRepository.GetOrderIdBoxes(id);
					}
					else  //不存在当前盒号 直接退出
					{
						MessageBox.Show("不存在的盒号，请联系下单人员,检查是否下单错误！");
						return;
					}

					//根据id找到订单记录
					orderRepositoy = new OrderRepository(_dbcontext);

					//设置界面显示当前计划单号
					var order = orderRepositoy.getOrderByOrderId(id);
					this.lbPlanNo.Text = order.PlanNo;

					assembleRepository = new AssembleRepository(_dbcontext);
					//设置界面已组装好的数量
					this.lbDoNo.Text = assembleRepository.GetAssembleCount(id).ToString();

					//获取已完成的盒号
					var hasFinished = assembleRepository.GetAssembleFinishedBoxNo(id);

					//在组装完成前 判断是否重复扫
					if (hasFinished.Contains(this.textBox_BoxNumber.Text.Trim()))
					{
						MessageBox.Show("此盒已完成，勿重复扫!");
						this.textBox_BoxNumber.Select();
						return;
					}
					assembleRepository.assembleOneBox(id, boxNumber, doNumber);
					assembleRepository.SaveChanges();

					//获取已完成的盒号
					hasFinished = assembleRepository.GetAssembleFinishedBoxNo(id);
					//设置界面ListBox绑定
					unFinishedBoxes.Clear();
					boxNumbersNeedFinished.Except(hasFinished).ToList().ForEach(o => unFinishedBoxes.Add(o));
				}

			}
		}
		#endregion

		#region 初测	
		private void textBox_CurPlanNo_Fisrt_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				var planId = this.textBox_CurPlanNo_Fisrt.Text.Trim();

				using (_dbcontext = new FlowManageSystemEntities())
				{
					orderRepositoy = new OrderRepository(_dbcontext);

					if (!orderRepositoy.PlanNoExist(planId))
					{
						MessageBox.Show("计划单号不存在，请输入正确的单号！！！");
						return;
					}

					var order = orderRepositoy.getOrderByPlanNo(planId);
					var snMin = order.SnMin;
					var snMax = order.SnMax;
					var needDo = order.OnLineQuantity;

					//根据SN范围查询已经做了测试的
					using (_opwayDbContext = new ATSDATABASEEntities())
					{
						opwayDataRepository = new OpwayDataRepository(_opwayDbContext);


						//拿到已做的数量更新界面
						var count = 0;
						if (this.cBox_FistUndo.Checked == true)
						{
							var listFinishedSn = opwayDataRepository.GetFistTestFinishedSN(snMin, snMax);
							var AllList = SnHelper.GetSnlist(snMin, needDo);
							count = listFinishedSn.Count();
							//更新界面未做的SN
							this.ltBox_FistUndo.DataSource = AllList.Except(listFinishedSn).ToList();
						}
						else
						{
							count = opwayDataRepository.GetFirstTestCount(snMin, snMax);
						}
						this.lbFistTestFinished.Text = count.ToString();
					}
				}
			}
		}
		#endregion

		#region 终测
		private void textBox_PlanNo_Last_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				var planId = this.textBox_PlanNo_Last.Text.Trim();

				using (_dbcontext = new FlowManageSystemEntities())
				{
					orderRepositoy = new OrderRepository(_dbcontext);

					if (!orderRepositoy.PlanNoExist(planId))
					{
						MessageBox.Show("计划单号不存在，请输入正确的单号！！！");
						return;
					}

					var order = orderRepositoy.getOrderByPlanNo(planId);
					var snMin = order.SnMin;
					var snMax = order.SnMax;
					var needDo = order.OnLineQuantity;

					//根据SN范围查询已经做了测试的
					using (_opwayDbContext = new ATSDATABASEEntities())
					{
						opwayDataRepository = new OpwayDataRepository(_opwayDbContext);


						//拿到已做的数量更新界面
						var count = 0;
						if (this.cBox_LastUndo.Checked == true)
						{
							var listFinishedSn = opwayDataRepository.GetLastTestFinishedSN(snMin, snMax);
							var AllList = SnHelper.GetSnlist(snMin, needDo);
							count = listFinishedSn.Count();
							//更新界面未做的SN
							this.ltBox_LastUndo.DataSource = AllList.Except(listFinishedSn).ToList();
						}
						else
						{
							count = opwayDataRepository.GetLastTestCount(snMin, snMax);
						}
						this.lbLastTestFinished.Text = count.ToString();
					}
				}
			}
		}
		#endregion

		#region  订单入库
		/// <summary>
		/// 订单入库
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox_Storage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{

				if (!RegexHelper.regExpNumber.IsMatch(this.textBox_StorageNumber.Text.Trim()))
				{
					MessageBox.Show("入库数量应该是数字");
					return;
				}
				//从界面获取计划单号   和 入库数量
				var planId = this.textBox_Storage.Text.Trim();
				var StorageCount = Convert.ToInt32(this.textBox_StorageNumber.Text);

				using (_dbcontext = new FlowManageSystemEntities())
				{
					orderRepositoy = new OrderRepository(_dbcontext);

					//判断计划单号是否存在
					if (!orderRepositoy.PlanNoExist(planId))
					{
						MessageBox.Show("当前计划单号在数据库不存在，请检查！");
						return;
					}

					//获取当前订单生产模块个数
					var order = orderRepositoy.getOrderByPlanNo(planId);
					var count = order.OnLineQuantity;
					var dbCount = order.OrderStorageCount;

					//入库数量不能大于订单要求做的数量
					if (count < StorageCount)
					{
						MessageBox.Show("当前订单数量: " + count + " 入库数量：" + StorageCount + "请检查错误!");
						return;
					}
			

					//不允许重复入库
					if (dbCount != null)
					{
						MessageBox.Show("当前订单已入库！！！入库数量：" + dbCount);
						return;
					}

					//获取实际测试个数
					using (_opwayDbContext = new ATSDATABASEEntities())
					{
						var snMin = order.SnMin;
						var snMax = order.SnMax;

						opwayDataRepository = new OpwayDataRepository(_opwayDbContext);
						if (opwayDataRepository.GetLastTestCount(snMin, snMax) < StorageCount)
						{
							MessageBox.Show("入库数量不能大于终测通过的数量！！！");
							return;
						}
					}


					//检查通过  进行入库
					try
					{
						orderRepositoy.OrderStorage(planId, StorageCount);
						orderRepositoy.SaveChanges();

						MessageBox.Show("入库成功！");
						this.textBox_Storage.Text = "";
						this.textBox_StorageNumber.Text = "";
					}
					catch (Exception ex)
					{

						MessageBox.Show("发生异常：" + ex.Message);
					}
				}

			}
		}
		#endregion

		#region 综合查询
		private void textBox_searchPlanOrder_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Enter)
			{
				var planId = this.textBox_searchPlanOrder.Text.Trim();

				using (var dbContext = new FlowManageSystemEntities())
				{
					orderRepositoy = new OrderRepository(dbContext);

					collectionRepository = new CollectionRepository(dbContext);

					assembleRepository = new AssembleRepository(dbContext);

					if (!orderRepositoy.PlanNoExist(planId))
					{
						MessageBox.Show("计划单号不存在，请输入正确的单号！！！");
						return;
					}

					//更新界面--订单相关信息
					var order = orderRepositoy.getOrderByPlanNo(planId);
					var orderId = order.OrderId;
	
					this.lbOrderDate.Text = order.OrderDate.ToShortDateString();
					this.lbPlanOnlineDate.Text = order.PlannedLaunchDate.ToShortDateString();
					this.lbDemandDate.Text = order.CustomDemandDate.ToShortDateString();
					this.lbPlanStorageDate.Text = order.PlanStorageDate.ToShortDateString();

					//更新界面--领料相关信息
					if (collectionRepository.IsOrderCollectionExist(orderId))
					{
						var collectionInfo = collectionRepository.GetCurrentOrderCollectionInfo(orderId);

						this.lbCollectionCount.Text = collectionInfo.Item1.ToString();
						this.lbCollectionTime.Text = collectionInfo.Item2.ToString();
					}
					else
					{
						this.lbCollectionCount.Text = "未领取物料";
						this.lbCollectionTime.Text ="";
					}

					//更新界面--组装相关信息
					if (assembleRepository.IsOrderAssembleExist(orderId))
					{
						var collectionInfo = assembleRepository.GetCurrentOrderAssembleInfo(orderId);
						this.lbAssembleCount.Text = collectionInfo.Item1.ToString();
						this.lbAssembleTime.Text = collectionInfo.Item2.ToString();
					}
					else
					{
						this.lbCollectionCount.Text = "未开始组装";
						this.lbCollectionTime.Text = "";
					}

					//初调相关信息  //终测相关信息
					using (_opwayDbContext = new ATSDATABASEEntities())
					{
						opwayDataRepository = new OpwayDataRepository(_opwayDbContext);

						var snMin = order.SnMin;
						var snMax = order.SnMax;

						this.lbFirstTestCount.Text= opwayDataRepository.GetFirstTestCount(snMin, snMax).ToString();

						this.lbFInishedTestCount.Text = opwayDataRepository.GetLastTestCount(snMin, snMax).ToString();
					}


				}				
			}
		}






		#endregion



	}
}
