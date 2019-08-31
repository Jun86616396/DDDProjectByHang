using DDD.Domain;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDD.Application.DTO.Order;
using DDD.Application.Interfaces;
   
using Infra.EF.Repository;
using Infra.IoC.AutoFac;

namespace ManageSystem
{
    public partial class FrmGatherSearch : Form
    {
        public FrmGatherSearch()
        {
            InitializeComponent();

            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.DataSource = _dgvBindingSource;

            MultiThreadingBindingOrderData(1);
        }

        //使用BindingSource组件
        readonly BindingSource _dgvBindingSource = new BindingSource();

        //当前分页页码  
        private int _currentPage = 1;

        private const int PageSize = 15;

        //分多少页
        private int _pageCount = 0;

        private void MultiThreadingBindingOrderData(int pageIndex)
        {
            //绑定数据源时会触发SelectionChanged
            dgvOrderList.SelectionChanged -= DgvOrderList_SelectionChanged;

            Task.Factory.StartNew(() => LoadData(pageIndex))
                .ContinueWith(preTask =>
                {
                    _dgvBindingSource.DataSource = DealStorageAdvanceDays(preTask.Result) ;
                    //此句位置很重要  会触发SelectionChanged
                    this.dgvOrderList.ClearSelection();
                    dgvOrderList.SelectionChanged += DgvOrderList_SelectionChanged;

                    this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
                },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        private BindingList<OrderGatherSearchDto> DealStorageAdvanceDays(BindingList<OrderGatherSearchDto> list)
        {
            foreach (var orderGatherSearchDto in list)
            {
                orderGatherSearchDto.StorageAdvanceDays =
                    (orderGatherSearchDto.PlanStorageDate - Convert.ToDateTime(DateTime.Now.ToShortDateString())).Days;
            }

            return list;
        }


        /// <summary>
        /// 从数据库获取分页的数据
        /// </summary>
        /// <param name="pageIndex"> 哪一页的数据</param>
        /// <returns></returns>
        private BindingList<OrderGatherSearchDto> LoadData(int pageIndex)
        {
            var gatherSearchService = AutofacContainer.GetInstance().GetObject<IGatherSearchService>();

            var result = gatherSearchService.GetOrderList(pageIndex, PageSize);

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

            MultiThreadingBindingOrderData(_currentPage);
        }

        private void BtnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
                _currentPage--;
            else
                return;
            MultiThreadingBindingOrderData(_currentPage);
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage == _pageCount)
                return;
            _currentPage++;

            MultiThreadingBindingOrderData(_currentPage);
        }

        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            _currentPage = _pageCount;
            MultiThreadingBindingOrderData(_currentPage);
        }

        #endregion



        private void textBox_searchPlanOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var planId = this.textBox_searchPlanOrder.Text.Trim();
            }
        }



        private void DgvOrderList_SelectionChanged(object sender, EventArgs e)
        {

            var orderGatherSearchDto = CheckAndGetOrder();
            var orderId = orderGatherSearchDto.OrderId;
            if (orderId != 0)
            {
                this.textBox_searchPlanOrder.Text = orderGatherSearchDto.PlanNo;

                if (FilterUpdateTestCountSearch(orderGatherSearchDto))
                {
                    var gatherSearchService = AutofacContainer.GetInstance().GetObject<IGatherSearchService>();

                    bool result = gatherSearchService.UpdateTestCount(orderGatherSearchDto);

                    if (result)
                    {
                        MultiThreadingBindingOrderData(_currentPage);
                    }
                }

                TipOrderInfo(orderGatherSearchDto);
            }
        }



        private bool FilterUpdateTestCountSearch( OrderGatherSearchDto searchDto)
        {
            if(searchDto.OnLineQuantity != searchDto.FisrtTestCount || searchDto.LastTestCount!= searchDto.OnLineQuantity)
            {
                return true;
            }

            return false;
        }



        //根据订单对象推算延期信息 并更新界面lable
        private void TipOrderInfo(OrderGatherSearchDto order)
        {
            //给的生产天数
            var days = Convert.ToInt32(order.DaysOfProduction);

            //今天日期
            var now = Convert.ToDateTime(DateTime.Now.ToString("d"));

            //入库到期日期
            var dayStorage = Convert.ToDateTime(order.PlanStorageDate.ToString("d"));

            //入库限期--界面
            this.lbDateStorage.Text = dayStorage.ToString("d");


            //终测限期--界面
            this.lbDateLastTest.Text = dayStorage.AddDays(-1).ToString("d");

            //初测限期--界面
            this.lbDateFistTest.Text = dayStorage.AddDays(-2).ToString("d");

            //组装限期--界面
            this.lbDateAssembly.Text = dayStorage.AddDays(-4).ToString("d");

            //领料限期--界面
            this.lbDateCollection.Text = dayStorage.AddDays(-5).ToString("d");

            //订单剩余日期--界面
            this.lbDateleft.Text = (dayStorage - now).Days.ToString();

        }

        private void btnOrderInfo_Click(object sender, EventArgs e)
        {
            var orderId = CheckAndGetOrder().OrderId;
            if (orderId != 0)
            {
                FrmOrder objFrm = new FrmOrder(orderId, false);
                objFrm.ShowDialog();
            }
        }

        private async void BtnCollectionDetail_Click(object sender, EventArgs e)
        {
            var orderId = CheckAndGetOrder().OrderId;
            if (orderId != 0)
            {
                var collectionService = AutofacContainer.GetInstance().GetObject<ICollectionService>();

                var collectionList = await collectionService.GetOrderIdCollectionList(orderId);

                var detailForm = new FrmDetail($"订单:{orderId}领料详情", collectionList);

                detailForm.ShowDialog();
            }
        }

        private async void BtnAssembleDetail_Click(object sender, EventArgs e)
        {
            var orderId = CheckAndGetOrder().OrderId;
            if (orderId != 0)
            {
                var assembleService = AutofacContainer.GetInstance().GetObject<IAssembleService>();

                var assembleList = await assembleService.GetOrderAssembleList(orderId);

                var detailForm = new FrmDetail($"订单:{orderId}组装详情", assembleList);


                detailForm.ShowDialog();
            }
        }

        private async void BtnStorageDetail_Click(object sender, EventArgs e)
        {
            var orderId = CheckAndGetOrder().OrderId;
            if (orderId != 0)
            {
                var storageService = AutofacContainer.GetInstance().GetObject<IStorageService>();

                var storageList = await storageService.GetOrderStorageList(orderId);

                var detailForm = new FrmDetail($"订单:{orderId}入库详情", storageList);

                detailForm.ShowDialog();
            }
        }


        private OrderGatherSearchDto CheckAndGetOrder()
        {
            var count = this.dgvOrderList.SelectedRows.Count;

            var orderGatherSearchDto = new OrderGatherSearchDto();

            if (count == 0)
            {
                MessageBox.Show("请选中一个订单");
            }

            var dgvOrderListCurrentRow = this.dgvOrderList.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                orderGatherSearchDto = ((OrderGatherSearchDto)dgvOrderListCurrentRow.DataBoundItem);
            }
            return orderGatherSearchDto;
        }

    }
}
