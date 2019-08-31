using Common;
using DDD.Application.Services;
using DDD.Domain;
using Infrastructure;
using Infrastructure.EntityFramework;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageSystem
{
	public partial class FrmOrderAddOrModify : Form
	{
		//正常添加
		public FrmOrderAddOrModify()
		{
			InitializeComponent();

			initData();
        }
		
		//修改时进入这个窗体  查询也进入
		public FrmOrderAddOrModify(OrderPlacing orderPlacing ,bool modify=true)
		{
			InitializeComponent();

			initData();
			this._orderPlacing = orderPlacing;
			beforModifyCount = orderPlacing.OnLineQuantity;
			beforModifySnMin = orderPlacing.SnMin;

			if (modify)
			{
				Modify = true;

				this.Text = "订单修改";

				this.btnOrder.Text = "确认修改";
			}
			else
			{
				this.Text = "订单查询";
				this.btnOrder.Enabled = false;
				this.btnClear.Enabled = false;
			}

			//设置界面绑定

			this.OrderDateTimePic.DataBindings.Add("Text", orderPlacing, "OrderDate");
			this.TypeTxtBox.DataBindings.Add("Text", orderPlacing, "Type");

			this.PlanNoTxtBox.DataBindings.Add("Text", orderPlacing, "PlanNo");
			this.FinishedProductNocBox.DataBindings.Add("Text", orderPlacing, "FinishedProductNo");

			this.ProductTypecBox.DataBindings.Add("Text", orderPlacing, "ProductTypeNo");
			this.OnlineQuantityTxtBox.DataBindings.Add("Text", orderPlacing, "OnLineQuantity");


			this.SnMinTxtBox.DataBindings.Add("Text", orderPlacing, "SnMin");
			this.SnMaxTxtBox.DataBindings.Add("Text", orderPlacing, "SnMax");

			this.LableRequireTxtBox.DataBindings.Add("Text", orderPlacing, "LabelingRequirements");
			this.TestReportTxtBox.DataBindings.Add("Text", orderPlacing, "TestReport");

			this.CodingRequireTxtBox.DataBindings.Add("Text", orderPlacing, "CodingRequirements");
			this.PackingRequireTxtBox.DataBindings.Add("Text", orderPlacing, "PackingRequirement");


			this.SpecialRequireTxtBox.DataBindings.Add("Text", orderPlacing, "SpecialRequirement");
			this.TestSoftConfigFIleTxtBox.DataBindings.Add("Text", orderPlacing, "TestSoftConfigFile");

			this.RemarkTxtBox.DataBindings.Add("Text", orderPlacing, "Remark");
			this.CustonRequireTimePic.DataBindings.Add("Text", orderPlacing, "CustomDemandDate");

			this.PlanOnlineTimePic.DataBindings.Add("Text", orderPlacing, "PlannedLaunchDate");
			this.PlanStorageTimePic.DataBindings.Add("Text", orderPlacing, "PlanStorageDate");

			this.ProductDaysTxtBox.DataBindings.Add("Text", orderPlacing, "DaysOfProduction");
			
		}

		private void initData()
		{
			//读取配置文件  初始化下拉框
			_bindingResult = FileHelper.ReadConfigFile();

			this.FinishedProductNocBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.FinishedProductNocBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.FinishedProductNocBox.AutoCompleteCustomSource.AddRange(_bindingResult.Item1.ToArray());

			this.ProductTypecBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.ProductTypecBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.ProductTypecBox.AutoCompleteCustomSource.AddRange(_bindingResult.Item2.ToArray());


            this.FinishedProductNocBox.SelectedIndexChanged -= FinishedProductNocBox_SelectedIndexChanged;
            this.ProductTypecBox.SelectedIndexChanged -= ProductTypecBox_SelectedIndexChanged;
            this.FinishedProductNocBox.DataSource = _bindingResult.Item1;
            this.ProductTypecBox.DataSource = _bindingResult.Item2;
            this.FinishedProductNocBox.SelectedIndexChanged += FinishedProductNocBox_SelectedIndexChanged;
            this.ProductTypecBox.SelectedIndexChanged += ProductTypecBox_SelectedIndexChanged;

        }

		Tuple<List<string>, List<string>> _bindingResult;

		//private FlowManageSystemEntities _dbcontext;

		//private OrderRepository orderRepositoy;

		//private OrderBoxRepository orderBoxRepository;

		private bool Modify = false;

		//保存订单数量  判断是否修改  修改要全部生成订单盒
		private int beforModifyCount = 0;

		private string beforModifySnMin = "";

		private OrderPlacing _orderPlacing;

		/// <summary>
		/// 生成订单和 对应的盒号
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOrder_Click(object sender, EventArgs e)
		{
			//此时是修改   重复的绑值太恶心了 用数据绑定
			if (Modify)
			{
                var unitOfWork = new UnitOfWork();
                var orderBoxService = new OrderBoxService(unitOfWork, unitOfWork.OrderBoxRepository);
                var orderService = new OrderService(unitOfWork, unitOfWork.OrderRepository);

                //判断是否修改了订单数量  修改了 删除盒号 重新生成
                if ((beforModifyCount != _orderPlacing.OnLineQuantity) || (beforModifySnMin != _orderPlacing.SnMin))
                {

                    //生成订单盒    注意此处一对多关联数据的保存  设置关联
                    IEnumerable<OrderBox> orderBoxes = SnHelper.GetListboxNumber(this.SnMinTxtBox.Text, Convert.ToInt32(this.OnlineQuantityTxtBox.Text)).Select(item => new OrderBox()
                    {
                        //设置导航属性
                        OrderPlacing = _orderPlacing,
                        //设置外键Id
                        OrderId = _orderPlacing.OrderId,
                        //盒号
                        BoxNumber = item,
                        //新建时间
                        OrderBoxCreateTime = DateTime.Now
                    });


                    try
                    {
                        //添加所有 多的 一端数据				
                        orderBoxService.AddOrderBoxAfterDel(_orderPlacing.OrderId, orderBoxes);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                    
                }

                try
                {
                    orderService.UpdateOrder(_orderPlacing);
                    MessageBox.Show("修改成功！");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               


               

                #region old

                //using (_dbcontext = new FlowManageSystemEntities())
                //{
                //    orderRepositoy = new OrderRepository(_dbcontext);

                //    //判断是否修改了订单数量  修改了 删除盒号 重新生成
                //    if ((beforModifyCount != _orderPlacing.OnLineQuantity) || (beforModifySnMin != _orderPlacing.SnMin))
                //    {
                //        orderBoxRepository = new OrderBoxRepository(_dbcontext);

                //        //生成订单盒
                //        //注意此处一对多关联数据的保存  设置关联
                //        IEnumerable<OrderBox> orderBoxes = SnHelper.GetListboxNumber(this.SnMinTxtBox.Text, Convert.ToInt32(this.OnlineQuantityTxtBox.Text)).Select(item => new OrderBox()
                //        {
                //            //设置导航属性
                //            OrderPlacing = _orderPlacing,
                //            //设置外键Id
                //            OrderId = _orderPlacing.OrderId,
                //            //盒号
                //            BoxNumber = item,
                //            //新建时间
                //            OrderBoxCreateTime = DateTime.Now
                //        });

                //        //添加所有 多的 一端数据				
                //        orderBoxRepository.AddOrderBoxAfterDel(_orderPlacing.OrderId, orderBoxes);

                //    }

                //    if (orderRepositoy.Edit(_orderPlacing) != 0)
                //    {
                //        MessageBox.Show("修改成功！");
                //        this.Dispose();
                //    }

                //}

                #endregion

            }
            else
			{
				try
				{

                    var unitOfWork = new UnitOfWork();
                    var orderBoxService = new OrderBoxService(unitOfWork, unitOfWork.OrderBoxRepository);
                    var orderService = new OrderService(unitOfWork, unitOfWork.OrderRepository);

                    OrderPlacing orderPlacing = new OrderPlacing()
                    {
                        OrderDate = Convert.ToDateTime(this.OrderDateTimePic.Text),
                        Type = this.TypeTxtBox.Text,
                        PlanNo = this.PlanNoTxtBox.Text,
                        FinishedProductNo = this.FinishedProductNocBox.Text,
                        ProductTypeNo = this.ProductTypecBox.Text,
                        OnLineQuantity = Convert.ToInt32(this.OnlineQuantityTxtBox.Text),
                        SnMin = SnMinTxtBox.Text,
                        SnMax = this.SnMaxTxtBox.Text,
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
                        OrderCreateTime = DateTime.Now,
                        StorageFinishedFlag = "0"
                    };

                    if (orderService.PlanNoExist(this.PlanNoTxtBox.Text.Trim()))
                    {
                        MessageBox.Show("当前计划单号" + this.PlanNoTxtBox.Text + "数据库已存在");
                        this.PlanNoTxtBox.Select();
                        return;
                    }


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
                    orderBoxService.AddOrderAllBoxes(orderBoxes);

                    //添加 一的  一端数据  //下单				
                    orderService.InsertOrder(orderPlacing);

                    ////一对多的数据一起保存  两个仓储公用一个dbcontext  可以防止添加部分失败    会以一个事务的形式保存
                    //_dbcontext.SaveChanges();

                    this.lbInfo.Text = orderPlacing.PlanNo + "下单成功！";

                    btnClear_Click(null, null);

                    #region old
                    //using (_dbcontext = new FlowManageSystemEntities())
                    //{
                    //    orderRepositoy = new OrderRepository(_dbcontext);
                    //    orderBoxRepository = new OrderBoxRepository(_dbcontext);

                    //    OrderPlacing orderPlacing = new OrderPlacing()
                    //    {
                    //        OrderDate = Convert.ToDateTime(this.OrderDateTimePic.Text),
                    //        Type = this.TypeTxtBox.Text,
                    //        PlanNo = this.PlanNoTxtBox.Text,
                    //        FinishedProductNo = this.FinishedProductNocBox.Text,
                    //        ProductTypeNo = this.ProductTypecBox.Text,
                    //        OnLineQuantity = Convert.ToInt32(this.OnlineQuantityTxtBox.Text),
                    //        SnMin = SnMinTxtBox.Text,
                    //        SnMax = this.SnMaxTxtBox.Text,
                    //        LabelingRequirements = this.LableRequireTxtBox.Text,
                    //        TestReport = this.TestReportTxtBox.Text,
                    //        CodingRequirements = this.CodingRequireTxtBox.Text,
                    //        PackingRequirement = this.PackingRequireTxtBox.Text,
                    //        SpecialRequirement = this.SpecialRequireTxtBox.Text,
                    //        TestSoftConfigFile = this.TestSoftConfigFIleTxtBox.Text,
                    //        Remark = this.RemarkTxtBox.Text,
                    //        CustomDemandDate = Convert.ToDateTime(this.CustonRequireTimePic.Text),
                    //        PlannedLaunchDate = Convert.ToDateTime(this.PlanOnlineTimePic.Text),
                    //        PlanStorageDate = Convert.ToDateTime(this.PlanStorageTimePic.Text),
                    //        DaysOfProduction = Convert.ToByte(this.ProductDaysTxtBox.Text),
                    //        OrderCreateTime = DateTime.Now,
                    //        StorageFinishedFlag = "0"
                    //    };




                    //    if (orderRepositoy.PlanNoExist(this.PlanNoTxtBox.Text.Trim()))
                    //    {
                    //        MessageBox.Show("当前计划单号" + this.PlanNoTxtBox.Text + "数据库已存在");
                    //        this.PlanNoTxtBox.Select();
                    //        return;
                    //    }


                    //    //注意此处一对多关联数据的保存  设置关联
                    //    IEnumerable<OrderBox> orderBoxes = SnHelper.GetListboxNumber(this.SnMinTxtBox.Text, Convert.ToInt32(this.OnlineQuantityTxtBox.Text)).Select(item => new OrderBox()
                    //    {
                    //        //设置导航属性
                    //        OrderPlacing = orderPlacing,
                    //        //设置外键Id
                    //        OrderId = orderPlacing.OrderId,
                    //        //盒号
                    //        BoxNumber = item,
                    //        //新建时间
                    //        OrderBoxCreateTime = DateTime.Now

                    //    });

                    //    //添加所有 多的 一端数据				
                    //    orderBoxRepository.AddOrderAllBoxes(orderBoxes);

                    //    //添加 一的  一端数据  //下单				
                    //    orderRepositoy.AddOrder(orderPlacing);

                    //    //一对多的数据一起保存  两个仓储公用一个dbcontext  可以防止添加部分失败    会以一个事务的形式保存
                    //    _dbcontext.SaveChanges();

                    //    this.lbInfo.Text = orderPlacing.PlanNo + "下单成功！";

                    //    btnClear_Click(null, null);



                    //}


                    #endregion

                }
				catch (Exception ex)
				{

					MessageBox.Show("下单失败，请检查数据是否符合规范" + ex.Message);
				}
			}		
		}

		/// <summary>
		/// 主界面清空已填
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClear_Click(object sender, EventArgs e)
		{
			foreach (var control in this.Controls)
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
			
			if (e.KeyCode == Keys.Enter)
			{
				//界面显示此次订单最大SN  以便核对
				this.SnMaxTxtBox.Text = SnHelper.SnLast(this.SnMinTxtBox.Text, Convert.ToInt32(this.OnlineQuantityTxtBox.Text));

				//修改时 程序更改序列号  数据绑定没生效  在此赋值一下
				if (_orderPlacing != null)
				{
					_orderPlacing.SnMax = this.SnMaxTxtBox.Text;
				}
			
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

                var unitOfWork = new UnitOfWork();
                var orderService = new OrderService(unitOfWork,unitOfWork.OrderRepository );

                if (orderService.PlanNoExist(this.PlanNoTxtBox.Text.Trim()))
                {
                    MessageBox.Show("当前计划单号" + this.PlanNoTxtBox.Text + "数据库已存在");
                    this.PlanNoTxtBox.Select();
                }
              

			}
		}

		private void ProductTypecBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.FinishedProductNocBox.SelectedIndex = this.ProductTypecBox.SelectedIndex;
		}

		private void FinishedProductNocBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ProductTypecBox.SelectedIndex = this.FinishedProductNocBox.SelectedIndex;
		}

		//数量变化时  自动更新最后一个SN
		private void OnlineQuantityTxtBox_TextChanged(object sender, EventArgs e)
		{
			//确保序列号是OK的
			if (RegexHelper.RegSn.IsMatch(this.SnMinTxtBox.Text))
			{
				//界面显示此次订单最大SN  以便核对
				this.SnMaxTxtBox.Text = SnHelper.SnLast(this.SnMinTxtBox.Text, Convert.ToInt32(this.OnlineQuantityTxtBox.Text));

				//修改时 程序更改序列号  数据绑定没生效  在此赋值一下
				if (_orderPlacing != null)
				{
					_orderPlacing.SnMax = this.SnMaxTxtBox.Text;
				}
			}
		}

		private void PlanOnlineTimePic_ValueChanged(object sender, EventArgs e)
		{
			var dt1 = Convert.ToDateTime(this.PlanOnlineTimePic.Text);
			var dt2 = Convert.ToDateTime(this.PlanStorageTimePic.Text);

			this.ProductDaysTxtBox.Text = Math.Floor((double)(dt2 - dt1).Days).ToString();
		}

		private void PlanStorageTimePic_ValueChanged(object sender, EventArgs e)
		{
			var dt1 = Convert.ToDateTime(this.PlanOnlineTimePic.Text);
			var dt2 = Convert.ToDateTime(this.PlanStorageTimePic.Text);
			this.ProductDaysTxtBox.Text = Math.Floor((double)(dt2 - dt1).Days).ToString();
		}

		private void CustomRequireTimePic_ValueChanged(object sender, EventArgs e)
		{
			this.PlanStorageTimePic.Text = this.CustonRequireTimePic.Text;
		}
	}
}
