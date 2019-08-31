using DDD.Domain.Enum;
using Infra.IoC.AutoFac;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDD.Application.DTO.DayFinished;
using DDD.Application.DTO.Order;
using DDD.Application.Interfaces;
using DDD.Domain;
using Infra.Utility;

// ReSharper disable LocalizableElement

namespace ManageSystem
{
    public partial class FrmCollection : Form
    {
        public FrmCollection()
        {
            InitializeComponent();

            SetUserControl(Program.objCurrentLoginUser.UserId);

            //领料界面 
            this.dgvOrderlist.AutoGenerateColumns = false;
            this.dgvOrderlist.DataSource = _dgvBindingSource;

            MultiThreadingBindingOrderData(_currentPage, _orderCollectionState);

            //获取今日完成数量

            var datFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();

            this.DayCollectionCount.Text = datFinishedService.GetTodayFinishedInfo(DateTime.Now).CollectionCount.ToString();

        }


        private void SetUserControl(int userId)
        {
            //List<Right> rights = null;

            //rights = RightControl.GetUserRights(userId);

            //this.btnDeleteOeder.Enabled = rights.FirstOrDefault(o => o.RightName == "订单删除") != null;

            //this.btnOrderEdit.Enabled = rights.FirstOrDefault(o => o.RightName == "订单修改") != null;
        }

        /// <summary>
        /// 从数据库获取分页的数据
        /// </summary>
        /// <param name="pageIndex"> 哪一页的数据</param>
        /// <param name="orderCollectionState">获取订单领料状况</param>
        /// <returns></returns>
        private BindingList<OrderCollectionDto> LoadData(int pageIndex, OrderCollectionState orderCollectionState)
        {
            var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

            var result = orderService.GetOrders(pageIndex, PageSize, orderCollectionState);

            var totalCount = result.TotalCount;
            //分页数量
            _pageCount = (int)(totalCount % PageSize == 0 ? totalCount / PageSize : (totalCount / PageSize) + 1);

            _currentPage = _pageCount == 0 ? 0 : pageIndex;

            return result.CurrentPageData;
        }

        private void MultiThreadingBindingOrderData(int pageIndex, OrderCollectionState orderCollectionState)
        {
            //绑定数据源时会触发SelectionChanged
            dgvOrderlist.SelectionChanged -= dgvOrderList_SelectionChanged;

            Task.Factory.StartNew(() => LoadData(pageIndex, orderCollectionState))
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

        //使用BindingSource组件
        readonly BindingSource _dgvBindingSource = new BindingSource();


        //当前分页页码  
        private int _currentPage = 1;

        private const int PageSize = 18;

        //分多少页
        private int _pageCount = 0;

        private OrderCollectionState _orderCollectionState = OrderCollectionState.NoneStartCollection;

        #region  分页
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            _currentPage = 1;

            MultiThreadingBindingOrderData(_currentPage, _orderCollectionState);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {

            if (_currentPage > 1)
                _currentPage--;
            else
                return;
            MultiThreadingBindingOrderData(_currentPage, _orderCollectionState);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage == _pageCount)
                return;
            _currentPage++;

            MultiThreadingBindingOrderData(_currentPage, _orderCollectionState);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            _currentPage = _pageCount;
            MultiThreadingBindingOrderData(_currentPage, _orderCollectionState);
        }

        #endregion

        /// <summary>
        /// 领取物料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnMaterialCollection_Click(object sender, EventArgs e)
        {

            //防止未选中领料
            var dgvOrderListCurrentRow = this.dgvOrderlist.CurrentRow;
            if (dgvOrderListCurrentRow == null) return;

            if (this.dgvOrderlist.SelectedRows.Count == 0)
            {
                MessageBox.Show($"请选中一个订单，再进行物料领取！");
                return;
            }

            if (this.txtboxMaterialNumber.Text.Length == 0)
            {
                MessageBox.Show($"请输入领取物料数量，再进行领料！");
                return;
            }
            if (!RegexHelper.RegExpNumber.IsMatch(this.txtboxMaterialNumber.Text))
            {
                MessageBox.Show($"物料数量是数字 ok？");
                return;
            }

            //领取物料数量
            var collectionNumber = Convert.ToInt32(this.txtboxMaterialNumber.Text.Trim());

            var order = (dgvOrderListCurrentRow.DataBoundItem as OrderCollectionDto);

            try
            {
                //组装服务
                var collectionService = AutofacContainer.GetInstance().GetObject<ICollectionService>();
                var result = await collectionService.MaterialCollection(order, collectionNumber);

                if (result.IsSucceed)
                {

                    int totalFinishedCount = order.OrderCollectionCount + collectionNumber;

                    #region 刷新dgv
                    ((OrderCollectionDto)dgvOrderListCurrentRow.DataBoundItem).OrderCollectionCount = totalFinishedCount;

                    //临时过渡使用 因为要用到SelectionChanged同步以前的数据
                    dgvOrderlist.SelectionChanged -= dgvOrderList_SelectionChanged;
                    _dgvBindingSource.ResetBindings(true);
                    dgvOrderlist.SelectionChanged += dgvOrderList_SelectionChanged;
                    #endregion

                    var datFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();
                    this.DayCollectionCount.Text = datFinishedService.GetTodayFinishedInfo(DateTime.Now).CollectionCount.ToString();

                    this.lbMaterialCount.Text = totalFinishedCount.ToString();
                    this.txtboxMaterialNumber.Text = "";
                }
                else
                {
                    MessageBox.Show(result.Message);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }

        }



        /// <summary>
        /// 选择不同的订单时  获取已经领取的物料数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOrderList_SelectionChanged(object sender, EventArgs e)
        {
            var dgvOrderListCurrentRow = this.dgvOrderlist.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                var orderId = ((OrderCollectionDto)dgvOrderListCurrentRow.DataBoundItem).OrderId;

                var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();
                var collectionService = AutofacContainer.GetInstance().GetObject<ICollectionService>();

                var count = collectionService.GetOrderCollectionNumber(orderId);

                //通过orderId 获取已经领料的数量
                this.lbMaterialCount.Text = count.ToString();

                orderService.UpdateOrderCollectionNumber(orderId, count);
            }
        }

        /// <summary>
        /// 单选改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnNotCollection_CheckedChanged(object sender, EventArgs e)
        {
            //改变会触发两次这个事件   造成偶尔访问数据库有问题 这里判断处理下
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked == false) return;
            //本身加载列表是未入库的  已入库的不考虑

            //未开始领料
            if (radioBtnNotCollection.Checked)
            {
                _orderCollectionState = OrderCollectionState.NoneStartCollection;
            }
            //部分领料
            else if (radioBtnPartialCollection.Checked)
            {
                _orderCollectionState = OrderCollectionState.PartialCollection;
            }
            //领料完毕
            else
            {
                _orderCollectionState = OrderCollectionState.FinishedCollection;
            }
            MultiThreadingBindingOrderData(1, _orderCollectionState);
        }

        /// <summary>
        /// 查看订单领料详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnDetail_Click(object sender, EventArgs e)
        {
            var dgvRow = this.dgvOrderlist.CurrentRow;
            if (dgvRow == null)
            {
                MessageBox.Show("请选中一个订单");
                return;
            }

            var dgvOrderListCurrentRow = this.dgvOrderlist.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                var orderId = ((OrderCollectionDto)dgvOrderListCurrentRow.DataBoundItem).OrderId;

                var collectionService = AutofacContainer.GetInstance().GetObject<ICollectionService>();

                var collectionList =await collectionService.GetOrderIdCollectionList(orderId);

                var detailForm = new FrmDetail($"订单:{orderId}领料详情", collectionList);

                detailForm.ShowDialog();
            }
        }

        private void TxtboxMaterialNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMaterialCollection_Click(null, null);
            }
        }


        #region old

        ///// <summary>
        ///// 删除订单
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnDeleteOrder_Click(object sender, EventArgs e)
        //{
        //    if (this.dgvOrderlist.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("请选中一个订单，再进行订单删除！");
        //        return;
        //    }

        //    var dgvOrderListCurrentRow = this.dgvOrderlist.CurrentRow;
        //    if (dgvOrderListCurrentRow != null)
        //    {
        //        var order = ((OrderCollectionDto)dgvOrderListCurrentRow.DataBoundItem);
        //        var orderId = order.OrderId;
        //        var planNo = order.PlanNo;

        //        DialogResult dialogResult = MessageBox.Show(" 此操作非常危险  您正在删除订单：" + planNo + " 该订单关联的盒号 和领取物料、组装数据全部删除？确定么", "谨慎操作", MessageBoxButtons.OKCancel);

        //        if (dialogResult == DialogResult.Cancel)
        //        {
        //            return;
        //        }

        //        try
        //        {
        //            var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

        //            orderService.DelOrder(orderId);
        //            //会触发selectChange事件
        //            _dgvBindingSource.RemoveCurrent();
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show("异常：" + ex.Message);
        //        }
        //    }

        //}

        ///// <summary>
        ///// 订单修改
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnOrderEdit_Click(object sender, EventArgs e)
        //{
        //    var dgvOrderListCurrentRow = this.dgvOrderlist.CurrentRow;
        //    if (dgvOrderListCurrentRow != null)
        //    {
        //        FrmOrder frmOrderAdd = new FrmOrder(((OrderCollectionDto)dgvOrderListCurrentRow.DataBoundItem).OrderId);
        //        frmOrderAdd.Show();
        //    }

        //}


        #endregion
    }
}
