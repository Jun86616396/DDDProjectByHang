using DDD.Domain;
using DDD.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDD.Application.DTO.DayFinished;
using DDD.Application.DTO.Order;
using DDD.Application.Interfaces;
using Infra.IoC.AutoFac;
using Infra.Utility;

namespace ManageSystem
{
    public partial class FrmAssemble : Form
    {
        public FrmAssemble()
        {
            InitializeComponent();

            this.dgvOrderlist.AutoGenerateColumns = false;
            this.dgvOrderlist.DataSource = _dgvBindingSource;

            MultiThreadingBindingOrderData(_currentPage, _orderAssembleState);

            //组装界面
            this.listRequiredFinish.DataSource = unFinishedBoxes;

            //获取今日完成数量
            var datFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();
            this.DayAssembleCount.Text = datFinishedService.GetTodayFinishedInfo(DateTime.Now).AssembleCount.ToString();


        }

        //未完成的盒号  --界面绑定  组装页面使用
        private readonly BindingList<string> unFinishedBoxes = new BindingList<string>();

        //当前分页页码  
        private int _currentPage = 1;

        private const int PageSize = 15;

        private int _pageCount = 0;

        private OrderAssembleState _orderAssembleState = OrderAssembleState.NoneStartAssemble;

        //使用BindingSource组件
        readonly BindingSource _dgvBindingSource = new BindingSource();

        private void MultiThreadingBindingOrderData(int pageIndex, OrderAssembleState orderAssembleState)
        {
            //绑定数据源时会触发SelectionChanged
            dgvOrderlist.SelectionChanged -= dgvOrderList_SelectionChanged;

            Task.Factory.StartNew(() => LoadData(pageIndex, orderAssembleState))
                .ContinueWith(preTask =>
                    {
                        _dgvBindingSource.DataSource = preTask.Result;
                        //此句位置很重要  会触发SelectionChanged
                        this.dgvOrderlist.ClearSelection();
                        dgvOrderlist.SelectionChanged += dgvOrderList_SelectionChanged;

                        this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
                    },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>
        /// 从数据库获取分页的数据
        /// </summary>
        /// <param name="pageIndex"> 哪一页的数据</param>
        /// <param name="orderAssembleState">获取订单组装状况</param>
        /// <returns></returns>
        private BindingList<OrderAssembleDto> LoadData(int pageIndex, OrderAssembleState orderAssembleState)
        {

            var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

            var result = orderService.GetOrders(pageIndex, PageSize, orderAssembleState);

            var totalCount = result.TotalCount;
            //分页数量
            _pageCount = (int)(totalCount % PageSize == 0 ? totalCount / PageSize : (totalCount / PageSize) + 1);

            _currentPage = _pageCount == 0 ? 0 : pageIndex;

            return result.CurrentPageData;
        }

        #region  分页
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            _currentPage = 1;

            MultiThreadingBindingOrderData(_currentPage, _orderAssembleState);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {

            if (_currentPage > 1)
                _currentPage--;
            else
                return;
            MultiThreadingBindingOrderData(_currentPage, _orderAssembleState);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage == _pageCount)
                return;
            _currentPage++;

            MultiThreadingBindingOrderData(_currentPage, _orderAssembleState);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            _currentPage = _pageCount;
            MultiThreadingBindingOrderData(_currentPage, _orderAssembleState);
        }

        #endregion

        /// <summary>
        /// 选择不同的状态的组装订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnNotAssemble_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked == false) return;
            //本身加载列表是未入库的  已入库的不考虑

            //未开始领料
            if (radioBtnNotAssemble.Checked)
            {
                _orderAssembleState = OrderAssembleState.NoneStartAssemble;
                MultiThreadingBindingOrderData(1, _orderAssembleState);
            }
            //部分领料
            else if (radioBtnPartialAssemble.Checked)
            {
                _orderAssembleState = OrderAssembleState.PartialAssemble;
                MultiThreadingBindingOrderData(1, _orderAssembleState);
            }
            //领料完毕
            else
            {
                _orderAssembleState = OrderAssembleState.FinishedAssemble;
                MultiThreadingBindingOrderData(1, _orderAssembleState);
            }
        }


        //临时存放
        private void dgvOrderList_SelectionChanged(object sender, EventArgs e)
        {
            var dgvOrderlistCurrentRow = this.dgvOrderlist.CurrentRow;
            if (dgvOrderlistCurrentRow != null)
            {
                var orderId = ((OrderAssembleDto) dgvOrderlistCurrentRow.DataBoundItem).OrderId;

                var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();
                var assembleService = AutofacContainer.GetInstance().GetObject<IAssembleService>();

                var finishedCount = assembleService.GetOrderAssembleFinishedCount(orderId);


                var order = orderService.GetEditOrderById(orderId);

                order.OrderAssembleCount = finishedCount;

                orderService.EditOrder(order);
            }
        }

        /// <summary>
        /// 当前盒完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void textBox_BoxNumber_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!RegexHelper.RegExpNumber.IsMatch(this.textBox_DoNumber.Text))
                {
                    MessageBox.Show("完成的数量应该是数字");
                    return;
                }

                byte doNumber = Convert.ToByte(this.textBox_DoNumber.Text);

                var boxNumber = this.textBox_BoxNumber.Text.Trim();

                try
                {
                    var assembleService = AutofacContainer.GetInstance().GetObject<IAssembleService>();

                    var submitResult = await assembleService.OrderAssemble(boxNumber, doNumber);

                    if (!submitResult.IsSucceed)
                    {
                        MessageBox.Show(submitResult.Message);
                    }
                    else
                    {

                        var orderId = assembleService.GetOrderId(boxNumber);

                        var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

                        var orderAssembleDto = orderService.GetOrderById(orderId);

                        #region 刷新dgv

                        var first = ((IList<OrderAssembleDto>)_dgvBindingSource.List).FirstOrDefault(o => o.OrderId == orderId);
                        
                        if (first != null) first.OrderAssembleCount = first.OrderAssembleCount + doNumber;

                        //临时过渡使用 因为要用到SelectionChanged同步以前的数据
                        dgvOrderlist.SelectionChanged -= dgvOrderList_SelectionChanged;
                        _dgvBindingSource.ResetBindings(true);
                        dgvOrderlist.SelectionChanged += dgvOrderList_SelectionChanged;
                        #endregion

                        //更新界面需要字段
                        this.lbPlanNo.Text = orderAssembleDto.PlanNo.ToString();
                        this.lbNeedFinishCount.Text = orderAssembleDto.OnLineQuantity.ToString();
                        this.lbDoNo.Text = orderAssembleDto.OrderAssembleCount.ToString();


                        //更新界面需要完成的盒号
                        var orderBoxes = assembleService.GetOrderAllAssembleBoxes(orderId);
                        var hasFinishedBoxes = assembleService.GetAssembleFinishedBoxes(orderId);
                        unFinishedBoxes.Clear();
                        orderBoxes.Except(hasFinishedBoxes).ToList().ForEach(o => unFinishedBoxes.Add(o));


                        //更新今日组装完成总数
                        var datFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();
                        this.DayAssembleCount.Text = datFinishedService.GetTodayFinishedInfo(DateTime.Now).AssembleCount.ToString();


                        //清理界面
                        this.textBox_BoxNumber.Clear();
                        this.lbFinishedBoxInfo.Text = $"{boxNumber}OK!";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("异常：" + ex.Message);
                }
               

            }
        }

        private async void BtnDetail_Click(object sender, EventArgs e)
        {
            var dgvRow = this.dgvOrderlist.CurrentRow;
            if (dgvRow == null)
            {
                MessageBox.Show("请选中一个订单");
                return;
            }

            var orderId = ((OrderAssembleDto) dgvRow.DataBoundItem).OrderId;

            var assembleService = AutofacContainer.GetInstance().GetObject<IAssembleService>();

            var assembleList = await assembleService.GetOrderAssembleList(orderId);

            var detailForm = new FrmDetail($"订单:{orderId}组装详情", assembleList);

            detailForm.ShowDialog();
        }
    }
}
