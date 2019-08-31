using DDD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DDD.Application.DTO.Order;
using DDD.Application.Interfaces;
using Infra.IoC.AutoFac;
using Infra.Utility;

namespace ManageSystem
{
    public partial class FrmOrder : Form
    {
        //正常添加
        public FrmOrder()
        {
            InitializeComponent();
            InitData();
        }

        //修改时进入这个窗体  查询也进入
        public FrmOrder(int orderId, bool modify = true)
        {
            InitializeComponent();

            InitData();

            if (modify)
            {
                _modify = true;
                this.Text = "订单修改";
                this.btnOrder.Text = "确认修改";
            }
            else
            {
                this.Text = "订单查询";
                this.btnOrder.Enabled = false;
                this.btnClear.Enabled = false;
            }

            var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

            var orderEditDto = orderService.GetEditOrderById(orderId);

            this._orderEdit = orderEditDto;
            //记录看是否修改数量和初始SN
            beforeModifyCount = orderEditDto.OnLineQuantity;
            beforeModifySnMin = orderEditDto.SnMin;


            #region 数据绑定---最最最基本

            //设置界面绑定
            this.OrderDateTimePic.DataBindings.Add("Text", orderEditDto, "OrderDate");
            this.TypeTxtBox.DataBindings.Add("Text", orderEditDto, "Type");

            this.PlanNoTxtBox.DataBindings.Add("Text", orderEditDto, "PlanNo");
            this.FinishedProductNocBox.DataBindings.Add("Text", orderEditDto, "FinishedProductNo");

            this.ProductTypecBox.DataBindings.Add("Text", orderEditDto, "ProductTypeNo");
            this.OnlineQuantityTxtBox.DataBindings.Add("Text", orderEditDto, "OnLineQuantity");


            this.SnMinTxtBox.DataBindings.Add("Text", orderEditDto, "SnMin");
            this.SnMaxTxtBox.DataBindings.Add("Text", orderEditDto, "SnMax");

            this.LableRequireTxtBox.DataBindings.Add("Text", orderEditDto, "LabelingRequirements");
            this.TestReportTxtBox.DataBindings.Add("Text", orderEditDto, "TestReport");

            this.CodingRequireTxtBox.DataBindings.Add("Text", orderEditDto, "CodingRequirements");
            this.PackingRequireTxtBox.DataBindings.Add("Text", orderEditDto, "PackingRequirement");


            this.SpecialRequireTxtBox.DataBindings.Add("Text", orderEditDto, "SpecialRequirement");
            this.TestSoftConfigFIleTxtBox.DataBindings.Add("Text", orderEditDto, "TestSoftConfigFile");

            this.RemarkTxtBox.DataBindings.Add("Text", orderEditDto, "Remark");
            this.CustonRequireTimePic.DataBindings.Add("Text", orderEditDto, "CustomDemandDate");

            this.PlanOnlineTimePic.DataBindings.Add("Text", orderEditDto, "PlannedLaunchDate");
            this.PlanStorageTimePic.DataBindings.Add("Text", orderEditDto, "PlanStorageDate");

            this.ProductDaysTxtBox.DataBindings.Add("Text", orderEditDto, "DaysOfProduction");


            #endregion

        }

        private void InitData()
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

        private readonly bool _modify = false;
        //保存订单数量  判断是否修改  修改要全部生成订单盒
        private readonly int beforeModifyCount = 0;
        private readonly string beforeModifySnMin = "";
        private readonly OrderEditDto _orderEdit;

        /// <summary>
        /// 生成订单和 对应的盒号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {

            var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

            try
            {
                if (_modify)//修改订单信息
                {
                    
                    //判断是否修改了订单数量  修改了 删除盒号 重新生成
                    if ((beforeModifyCount != _orderEdit.OnLineQuantity) || (beforeModifySnMin != _orderEdit.SnMin))
                    {

                        orderService.EditOrder(_orderEdit,true);

                    }
                    else
                    {
                        orderService.EditOrder(_orderEdit, false);
                    }

                    MessageBox.Show("修改成功！");
                    this.DialogResult = DialogResult.OK;  //设置窗体返回值
                    this.Dispose();


                }
                else//新增
                {
                    if (orderService.PlanNoExist(this.PlanNoTxtBox.Text.Trim()))
                    {
                        MessageBox.Show("当前计划单号" + this.PlanNoTxtBox.Text + "数据库已存在");
                        this.PlanNoTxtBox.Select();
                        return;
                    }

                    OrderAddDto orderAddDto = new OrderAddDto()
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

                    orderService.AddOrder(orderAddDto);


                    this.lbInfo.Text = orderAddDto.PlanNo + "下单成功！";

                    btnClear_Click(null, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败，请检查数据是否符合规范" + ex.Message);
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
                if (_orderEdit != null)
                {
                    _orderEdit.SnMax = this.SnMaxTxtBox.Text;
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
                var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();


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
                if (_orderEdit != null)
                {
                    _orderEdit.SnMax = this.SnMaxTxtBox.Text;
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
