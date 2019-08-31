using Common;
using DDD.Application.Services;
using DDD.Domain;
using DDD.Domain.Enum;
using Infrastructure;
using Infrastructure.EntityFramework;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem
{
    public partial class FrmMaterialAdd : Form
    {
        public FrmMaterialAdd()
        {
            InitializeComponent();

            dgvOrderlist.SelectionChanged -= dgvOrderlist_SelectionChanged;

            SetUserControl(Program.objCurrentUser.UserId);

            //领料界面 
            this.dgvOrderlist.AutoGenerateColumns = false;
            this.dgvOrderlist.DataSource = _dgvBindingSource;

            MultiThreadingLoadOrderData();

            //获取今日完成数量
            var unitOfWork = new UnitOfWork();
            var datFinishedService = new DayFinishedService(unitOfWork, unitOfWork.DayFinishedRepository);
            this.DayCollectionCount.Text = datFinishedService.GetTodayFinishedInfo(DateTime.Now).CollectionCount.ToString();
        }


        private void SetUserControl(int userId)
        {
            List<Right> rights = null;

            rights = RightControl.GetUserRights(userId);

            this.btnDeleteOeder.Enabled = rights.FirstOrDefault(o => o.RightName == "订单删除") == null ? false : true;

            this.btnOrderEdit.Enabled = rights.FirstOrDefault(o => o.RightName == "订单修改") == null ? false : true;
        }

        private void MultiThreadingLoadOrderData()
        {
            Task.Factory.StartNew(() => FillData(1, _orderCollectionState))
                    .ContinueWith(pretask =>
                    {
                        _dgvBindingSource.DataSource = pretask.Result;
                        dgvOrderlist.SelectionChanged += dgvOrderlist_SelectionChanged;
                        this.dgvOrderlist.ClearSelection();
                        this.lbInfo.Text = $"第{1}页/共{_pageCount}页 ";
                    },
                TaskScheduler.FromCurrentSynchronizationContext());
        }

        //使用BindingSource组件
        readonly BindingSource _dgvBindingSource = new BindingSource();


        //当前分页页码  
        private int _currentPage = 1;

        private const int PageSize = 18;

        private int _pageCount = 0;

        private OrderCollectionState _orderCollectionState = OrderCollectionState.NoneStartCollection;

        /// <summary>
        /// 从数据库获取分页的数据
        /// </summary>
        /// <param name="pageIndex"> 哪一页的数据</param>
        /// <param name="orderCollectionState">获取订单领料状况</param>
        /// <returns></returns>
        private BindingList<OrderPlacing> FillData(int pageIndex, OrderCollectionState orderCollectionState)
        {

            var unitOfWork = new UnitOfWork();
            var orderService = new OrderService(unitOfWork,unitOfWork.OrderRepository );

            var result = orderService.GetOrders(pageIndex, PageSize, orderCollectionState);

            var totalCount = result.TotalCount;
            //分页数量
            _pageCount = (int)(totalCount % PageSize == 0 ? totalCount / PageSize : (totalCount / PageSize) + 1);

            return result.CurrentPageData;
        }



        #region  分页
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            dgvOrderlist.SelectionChanged -= dgvOrderlist_SelectionChanged;
            _dgvBindingSource.DataSource = FillData(1, _orderCollectionState);
            dgvOrderlist.SelectionChanged += dgvOrderlist_SelectionChanged;

            this.dgvOrderlist.ClearSelection();
            this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {

            if (_currentPage > 1)
                _currentPage--;
            else
                return;
            dgvOrderlist.SelectionChanged -= dgvOrderlist_SelectionChanged;
            _dgvBindingSource.DataSource = FillData(_currentPage, _orderCollectionState);
            dgvOrderlist.SelectionChanged += dgvOrderlist_SelectionChanged;
            this.dgvOrderlist.ClearSelection();
            this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage == _pageCount)
                return;
            _currentPage++;
            dgvOrderlist.SelectionChanged -= dgvOrderlist_SelectionChanged;
            _dgvBindingSource.DataSource = FillData(_currentPage, _orderCollectionState);
            dgvOrderlist.SelectionChanged += dgvOrderlist_SelectionChanged;
            this.dgvOrderlist.ClearSelection();
            this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            _currentPage = _pageCount;
            dgvOrderlist.SelectionChanged -= dgvOrderlist_SelectionChanged;
            _dgvBindingSource.DataSource = FillData(_pageCount, _orderCollectionState);
            dgvOrderlist.SelectionChanged += dgvOrderlist_SelectionChanged;
            this.dgvOrderlist.ClearSelection();
            this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
        }

        #endregion

        /// <summary>
        /// 领取物料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaterialCollection_Click(object sender, EventArgs e)
        {
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



            var dgvRow = this.dgvOrderlist.CurrentRow;
            if (dgvRow == null)
            {
                return;
            }

            var order = (dgvRow.DataBoundItem as OrderPlacing);
            //获取Id
            var orderId = order.OrderId;
            var onlineCount = order.OnLineQuantity;

            //当前已经领取数量
            var hasCount = Convert.ToInt32(this.lbMaterialCount.Text);

            //现在领取后的数量大于 订单计划做的数量 不允许
            if (onlineCount < (hasCount + collectionNumber))
            {
                MessageBox.Show("领取物料后的数量 怎么能大于下单数量呢？请核对");
                return;
            }


            try
            {
                var unitOfWork = new UnitOfWork();

                var collectionService = new CollectionService(unitOfWork,unitOfWork.CollectionRepository, unitOfWork.OrderRepository, unitOfWork.DayFinishedRepository);

                collectionService.MaterialCollection(orderId, collectionNumber);


                this.lbMaterialCount.Text = (hasCount + collectionNumber).ToString();

                var datFinishedService = new DayFinishedService(unitOfWork, unitOfWork.DayFinishedRepository);
                this.DayCollectionCount.Text = datFinishedService.GetTodayFinishedInfo(DateTime.Now).CollectionCount.ToString();

                (this.dgvOrderlist.CurrentRow.DataBoundItem as OrderPlacing).OrderCollectionCount =
                    (hasCount + collectionNumber);
                _dgvBindingSource.ResetBindings(true);


               
                txtboxMaterialNumber.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }

        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (this.dgvOrderlist.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中一个订单，再进行订单删除！");
                return;
            }

            var dgvRow = this.dgvOrderlist.CurrentRow;

            if (dgvRow == null)
            {
                return;
            }

            //获得订单Id
            var order = (dgvRow.DataBoundItem as OrderPlacing);
            var OrderId = order.OrderId;
            var planNo = order.PlanNo;

            DialogResult dialogResult = MessageBox.Show(" 此操作非常危险  您正在删除订单：" + planNo + " 该订单关联的盒号 和领取物料、组装数据全部删除？确定么", "谨慎操作", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            
            try
            {
                var unitOfWork = new UnitOfWork();
                var orderService = new OrderService(unitOfWork,unitOfWork.OrderRepository );
                orderService.DelOrder(OrderId);

                _dgvBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }

        }

        /// <summary>
        /// 订单修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderEdit_Click(object sender, EventArgs e)
        {
            FrmOrderAddOrModify frmOrderAdd = new FrmOrderAddOrModify(this.dgvOrderlist.CurrentRow.DataBoundItem as OrderPlacing);
            frmOrderAdd.Show();
        }


        /// <summary>
        /// 选择不同的订单时  获取已经领取的物料数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOrderlist_SelectionChanged(object sender, EventArgs e)
        {
            var orderId = (this.dgvOrderlist.CurrentRow.DataBoundItem as OrderPlacing).OrderId;

            var unitOfWork = new UnitOfWork();
            var orderService = new OrderService(unitOfWork,unitOfWork.OrderRepository );
            var collectionService=new CollectionService(unitOfWork,unitOfWork.CollectionRepository, unitOfWork.OrderRepository,unitOfWork.DayFinishedRepository);

            var count = collectionService.GetOrderCollectionNumber(orderId);

            //通过orderId 获取已经领料的数量
            this.lbMaterialCount.Text = count.ToString();

            orderService.UpdateOrderCollectionNumber(orderId, count);
        }

        /// <summary>
        /// 单选改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnNotCollection_CheckedChanged(object sender, EventArgs e)
        {
            //本身加载列表是未入库的  已入库的不考虑

            //未开始领料
            if (radioBtnNotCollection.Checked)
            {
                _orderCollectionState = OrderCollectionState.NoneStartCollection;
                MultiThreadingLoadOrderData();
            }
            //部分领料
            else if(radioBtnPartialCollection.Checked)
            {
                _orderCollectionState = OrderCollectionState.PartialCollection;
                MultiThreadingLoadOrderData();
            }
            //领料完毕
            else
            {
                _orderCollectionState = OrderCollectionState.FinishedCollection;
                MultiThreadingLoadOrderData();
            }
        }

        /// <summary>
        /// 查看订单领料详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDetail_Click(object sender, EventArgs e)
        {

            var dgvRow = this.dgvOrderlist.CurrentRow;
            if (dgvRow == null)
            {
                MessageBox.Show("请选中一个订单");
                return;
            }

            var orderId = (this.dgvOrderlist.CurrentRow.DataBoundItem as OrderPlacing).OrderId;

            var unitOfWork = new UnitOfWork();
          
            var collectionService = new CollectionService(unitOfWork, unitOfWork.CollectionRepository, unitOfWork.OrderRepository,unitOfWork.DayFinishedRepository);

            var bindingList = collectionService.GetOrderIdCollectionInfo(orderId);
            var detailForm = new Detail($"订单:{orderId}领料详情", bindingList);
            detailForm.ShowDialog();
        }
    }
}
