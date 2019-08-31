using DDD.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDD.Application.DTO.Order;
using DDD.Application.DTO.Storage;
using DDD.Application.Interfaces;
using DDD.Domain.Enum;
   
using Infra.EF.Repository;
using Infra.IoC.AutoFac;
using Infra.Utility;

namespace ManageSystem
{
    public partial class FrmStorage : Form
    {
        public FrmStorage()
        {
            InitializeComponent();


            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.DataSource = _dgvBindingSource;

            MultiThreadingBindingOrderData(_currentPage, _orderStorageState);

            //获取今日完成数量
            var datFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();
            this.DayStorageCount.Text = datFinishedService.GetTodayFinishedInfo(DateTime.Now).StorageCount.ToString();
        }

        //使用BindingSource组件
        readonly BindingSource _dgvBindingSource = new BindingSource();

        //当前分页页码  
        private int _currentPage = 1;

        private const int PageSize = 18;

        //分多少页
        private int _pageCount = 0;


        private OrderStorageState _orderStorageState = OrderStorageState.NoneStorage;

        private void MultiThreadingBindingOrderData(int pageIndex, OrderStorageState orderStorageState)
        {
            //绑定数据源时会触发SelectionChanged
            dgvOrderList.SelectionChanged -= dgvOrderList_SelectionChanged;

            Task.Factory.StartNew(() => LoadData(pageIndex, orderStorageState))
                .ContinueWith(preTask =>
                    {
                        _dgvBindingSource.DataSource = DealStorageAdvanceDays(preTask.Result);
                        //此句位置很重要  会触发SelectionChanged
                        this.dgvOrderList.ClearSelection();
                        dgvOrderList.SelectionChanged += dgvOrderList_SelectionChanged;

                        this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
                    },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }


        private BindingList<OrderStorageDto> DealStorageAdvanceDays(BindingList<OrderStorageDto> list)
        {
            if (_orderStorageState == OrderStorageState.NoneStorage)
            {
                foreach (var orderStorageDto in list)
                {
                    orderStorageDto.StorageAdvanceDays =
                        (orderStorageDto.PlanStorageDate - Convert.ToDateTime(DateTime.Now.ToShortDateString())).Days;
                }
            }

            return list;
        }

        /// <summary>
        /// 从数据库获取分页的数据
        /// </summary>
        /// <param name="pageIndex"> 哪一页的数据</param>
        /// <param name="orderStorageState">获取订单状况</param>
        /// <returns></returns>
        private BindingList<OrderStorageDto> LoadData(int pageIndex, OrderStorageState orderStorageState)
        {
            var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

            var result = orderService.GetOrders(pageIndex, PageSize, orderStorageState);

            var totalCount = result.TotalCount;
            //分页数量
            _pageCount = (int)(totalCount % PageSize == 0 ? totalCount / PageSize : (totalCount / PageSize) + 1);

            _currentPage = _pageCount == 0 ? 0 : pageIndex;

            return result.CurrentPageData;

        }


        #region 分页

        private void BtnFirstPage_Click(object sender, EventArgs e)
        {
            _currentPage = 1;

            MultiThreadingBindingOrderData(_currentPage, _orderStorageState);
        }

        private void BtnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
                _currentPage--;
            else
                return;
            MultiThreadingBindingOrderData(_currentPage, _orderStorageState);
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage == _pageCount)
                return;
            _currentPage++;

            MultiThreadingBindingOrderData(_currentPage, _orderStorageState);
        }

        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            _currentPage = _pageCount;
            MultiThreadingBindingOrderData(_currentPage, _orderStorageState);
        }


        #endregion

        private void RadioBtnNotStorage_CheckedChanged(object sender, EventArgs e)
        {
            //改变会触发两次这个事件   造成偶尔访问数据库有问题 这里判断处理下
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked == false) return;


            if (radioBtnNotStorage.Checked)
            {
                _orderStorageState = OrderStorageState.NoneStorage;
            }
            //部分领料
            else
            {
                _orderStorageState = OrderStorageState.StorageFinished;
            }
            MultiThreadingBindingOrderData(1, _orderStorageState);
        }


        //更新界面订单号
        private void dgvOrderList_SelectionChanged(object sender, EventArgs e)
        {
            var dgvOrderListCurrentRow = this.dgvOrderList.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                var order = dgvOrderListCurrentRow.DataBoundItem as OrderStorageDto;

                this.textBox_Storage.Text = order.PlanNo;
            }
        }



        /// <summary>
        /// 订单入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 		
        private async void textBox_StorageNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!RegexHelper.RegExpNumber.IsMatch(this.textBox_StorageNumber.Text.Trim()))
                {
                    MessageBox.Show("入库数量应该是数字");
                    return;
                }

                var dgvOrderListCurrentRow = this.dgvOrderList.CurrentRow;
                if (dgvOrderListCurrentRow == null) return;

                //从界面获取计划单号   和 入库数量
                var planId = this.textBox_Storage.Text.Trim();
                var currentStorageCount = Convert.ToInt32(this.textBox_StorageNumber.Text);

                var orderStorageDto = (dgvOrderListCurrentRow.DataBoundItem as OrderStorageDto);


                try
                {
                    var storageService = AutofacContainer.GetInstance().GetObject<IStorageService>();

                    var result = await storageService.OrderStorage(orderStorageDto, currentStorageCount);

                    if (!result.IsSucceed)
                    {
                        MessageBox.Show(result.Message);

                    }
                    else
                    {
                        //获取今日完成数量
                        var datFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();
                        this.DayStorageCount.Text = datFinishedService.GetTodayFinishedInfo(DateTime.Now).StorageCount.ToString();

                        this.textBox_Storage.Text = "";
                        this.textBox_StorageNumber.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BtnStorageTagFinish_Click(object sender, EventArgs e)
        {

            var orderStorageDto = CheckSelect();
            if (orderStorageDto != null)
            {

                try
                {
                    var storageService = AutofacContainer.GetInstance().GetObject<IStorageService>();

                    var result = storageService.ChangeOrderStorageState(orderStorageDto, true);
                    if (result)
                    {
                        var orderId = orderStorageDto.OrderId;
                        #region 刷新dgv

                        var dataList = (IList<OrderStorageDto>)_dgvBindingSource.List;
                        var first = dataList.FirstOrDefault(o => o.OrderId == orderId);

                        if (first != null)
                        {
                            dataList.Remove(first);
                        }

                        //临时过渡使用 因为要用到SelectionChanged同步以前的数据
                        dgvOrderList.SelectionChanged -= dgvOrderList_SelectionChanged;
                        _dgvBindingSource.ResetBindings(true);
                        this.dgvOrderList.ClearSelection();
                        dgvOrderList.SelectionChanged += dgvOrderList_SelectionChanged;
                        #endregion

                        MessageBox.Show(
                           $"订单:{orderStorageDto.PlanNo} 入库数量：{orderStorageDto.OrderStorageCount ?? 0}标记完成成功！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void BtnStorageTagUndo_Click(object sender, EventArgs e)
        {
            var orderStorageDto = CheckSelect();
            if (orderStorageDto != null)
            {

                try
                {
                    var storageService = AutofacContainer.GetInstance().GetObject<IStorageService>();

                    var result = storageService.ChangeOrderStorageState(orderStorageDto, false);

                    if (result)
                    {
                        var orderId = orderStorageDto.OrderId;
                        #region 刷新dgv

                        var dataList = (IList<OrderStorageDto>)_dgvBindingSource.List;
                        var first = dataList.FirstOrDefault(o => o.OrderId == orderId);

                        if (first != null)
                        {
                            dataList.Remove(first);
                        }

                        //临时过渡使用 因为要用到SelectionChanged同步以前的数据
                        dgvOrderList.SelectionChanged -= dgvOrderList_SelectionChanged;
                        _dgvBindingSource.ResetBindings(true);
                        this.dgvOrderList.ClearSelection();
                        dgvOrderList.SelectionChanged += dgvOrderList_SelectionChanged;
                        #endregion

                        MessageBox.Show(
                            $"订单:{orderStorageDto.PlanNo} 入库数量：{orderStorageDto.OrderStorageCount ?? 0}取消标记成功！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }


        private OrderStorageDto CheckSelect()
        {
            if (this.dgvOrderList.SelectedRows.Count == 0)
            {
                MessageBox.Show($"请选中一个订单，再进行操作！");
                return null;
            }
            var dgvOrderListCurrentRow = this.dgvOrderList.CurrentRow;
            if (dgvOrderListCurrentRow == null)
            {
                MessageBox.Show("请选择一个订单再打标记");
                return null;
            }

            return (dgvOrderListCurrentRow.DataBoundItem as OrderStorageDto);
        }

        private async void BtnStorageDetail_Click(object sender, EventArgs e)
        {
            var orderId = CheckAndGetOrderId();
            if (orderId != 0)
            {
                var storageService = AutofacContainer.GetInstance().GetObject<IStorageService>();

                var storageList = await storageService.GetOrderStorageList(orderId);

                var detailForm = new FrmDetail($"订单:{orderId}入库详情", storageList);

                detailForm.ShowDialog();
            }
        }


        private int CheckAndGetOrderId()
        {
            var count = this.dgvOrderList.SelectedRows.Count;

            var orderId = 0;
            if (count == 0)
            {
                MessageBox.Show("请选中一个订单");
            }

            var dgvOrderListCurrentRow = this.dgvOrderList.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                orderId = ((OrderStorageDto)dgvOrderListCurrentRow.DataBoundItem).OrderId;
            }
            return orderId;
        }
    }
}
