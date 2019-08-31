using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDD.Application.DTO.Order;
using DDD.Application.Interfaces;
using DDD.Domain.Enum;
using Infra.IoC.AutoFac;

namespace ManageSystem
{
    public partial class FrmOrderEdit : Form
    {
        public FrmOrderEdit()
        {
            InitializeComponent();

            this.dgvOrderlist.AutoGenerateColumns = false;
            this.dgvOrderlist.DataSource = _dgvBindingSource;

            MultiThreadingBindingOrderData(_currentPage, _orderState);
        }




        //使用BindingSource组件
        readonly BindingSource _dgvBindingSource = new BindingSource();

        //当前分页页码  
        private int _currentPage = 1;

        private const int PageSize = 18;

        //分多少页
        private int _pageCount = 0;


        private OrderState _orderState = OrderState.NoneStorage;

        private void MultiThreadingBindingOrderData(int pageIndex, OrderState orderState)
        {
            //绑定数据源时会触发SelectionChanged

            Task.Factory.StartNew(() => LoadData(pageIndex, orderState))
                .ContinueWith(preTask =>
                    {
                        _dgvBindingSource.DataSource = DealStorageAdvanceDays(preTask.Result) ;
                        //此句位置很重要  会触发SelectionChanged
                        this.dgvOrderlist.ClearSelection();


                        this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
                    },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        private BindingList<OrderEditDto> DealStorageAdvanceDays(BindingList<OrderEditDto> list)
        {
            if (list.First().StorageFinishedFlag != "1")
            {
                foreach (var orderEditDto in list)
                {
                    orderEditDto.StorageAdvanceDays =
                        (orderEditDto.PlanStorageDate - Convert.ToDateTime(DateTime.Now.ToShortDateString())).Days;
                }
            }
            
            return list;
        }

        /// <summary>
        /// 从数据库获取分页的数据
        /// </summary>
        /// <param name="pageIndex"> 哪一页的数据</param>
        /// <param name="orderState">获取订单领料状况</param>
        /// <returns></returns>
        private BindingList<OrderEditDto> LoadData(int pageIndex, OrderState orderState)
        {
            var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

            var result = orderService.GetOrders(pageIndex, PageSize, orderState);

            var totalCount = result.TotalCount;
            //分页数量
            _pageCount = (int)(totalCount % PageSize == 0 ? totalCount / PageSize : (totalCount / PageSize) + 1);

            _currentPage = _pageCount == 0 ? 0 : pageIndex;

            return result.CurrentPageData;

        }



        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (this.dgvOrderlist.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中一个订单，再进行订单删除！");
                return;
            }

            var dgvOrderListCurrentRow = this.dgvOrderlist.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                var order = ((OrderEditDto)dgvOrderListCurrentRow.DataBoundItem);
                var orderId = order.OrderId;
                var planNo = order.PlanNo;

                DialogResult dialogResult =
                    MessageBox.Show(" 此操作非常危险  您正在删除订单：" + planNo + " 该订单关联的盒号 和领取物料、组装数据全部删除？确定么", "谨慎操作",
                        MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    var orderService = AutofacContainer.GetInstance().GetObject<IOrderService>();

                    orderService.DelOrder(orderId);
                    //会触发selectChange事件
                    _dgvBindingSource.RemoveCurrent();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("异常：" + ex.Message);
                }
            }
        }



        private void BtnOrderEdit_Click(object sender, EventArgs e)
        {

            var dgvOrderListCurrentRow = this.dgvOrderlist.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                FrmOrder frmOrder = new FrmOrder(((OrderEditDto)dgvOrderListCurrentRow.DataBoundItem).OrderId);
                var dialogResult = frmOrder.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    MultiThreadingBindingOrderData(_currentPage, _orderState);
                }

            }


        }

        #region 分页

        private void BtnFirstPage_Click(object sender, EventArgs e)
        {
            _currentPage = 1;

            MultiThreadingBindingOrderData(_currentPage, _orderState);
        }

        private void BtnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
                _currentPage--;
            else
                return;
            MultiThreadingBindingOrderData(_currentPage, _orderState);
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage == _pageCount)
                return;
            _currentPage++;

            MultiThreadingBindingOrderData(_currentPage, _orderState);
        }

        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            _currentPage = _pageCount;
            MultiThreadingBindingOrderData(_currentPage, _orderState);
        }


        #endregion

        private void RadioBtnNotStorage_CheckedChanged(object sender, EventArgs e)
        {
            //改变会触发两次这个事件   造成偶尔访问数据库有问题 这里判断处理下
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked == false) return;


            if (radioBtnNotStorage.Checked)
            {
                _orderState = OrderState.NoneStorage;
            }
            //部分领料
            else
            {
                _orderState = OrderState.StorageFinished;
            }
            MultiThreadingBindingOrderData(1, _orderState);
        }
    }
}
