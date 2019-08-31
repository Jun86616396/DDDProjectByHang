using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDD.Application.DTO.DayFinished;
using DDD.Application.Interfaces;
using Infra.IoC.AutoFac;

namespace ManageSystem
{
    public partial class FrmDayProduct : Form
    {
        public FrmDayProduct()
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

        private const int PageSize = 18;

        //分多少页
        private int _pageCount = 0;




        private void MultiThreadingBindingOrderData(int pageIndex)
        {
            //绑定数据源时会触发SelectionChanged
            dgvOrderList.SelectionChanged -= DgvOrderList_SelectionChanged;

            Task.Factory.StartNew(() => LoadData(pageIndex))
                .ContinueWith(preTask =>
                {
                    _dgvBindingSource.DataSource = preTask.Result;
                    //此句位置很重要  会触发SelectionChanged
                    this.dgvOrderList.ClearSelection();
                    dgvOrderList.SelectionChanged += DgvOrderList_SelectionChanged;

                    this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
                },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }


        /// <summary>
        /// 从数据库获取分页的数据
        /// </summary>
        /// <param name="pageIndex"> 哪一页的数据</param>
        /// <returns></returns>
        private BindingList<DayFinishedDto> LoadData(int pageIndex)
        {
            var dayFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();

            var result = dayFinishedService.GetDayFinishedList(pageIndex, PageSize);

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

        private void DgvOrderList_SelectionChanged(object sender, EventArgs e)
        {

            var dayFinishedDto = CheckAndGetBindingDto();
            
            if (dayFinishedDto.SynchronizationFlag == 0)
            {
                var dayFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();

                var result = dayFinishedService.SynchronizeTestDataToLocal(dayFinishedDto);
                if (result)
                {
                    MultiThreadingBindingOrderData(_currentPage);
                    MessageBox.Show("从数据库同步测试数据成功");
                }
            }

        }

        private DayFinishedDto CheckAndGetBindingDto()
        {
            var count = this.dgvOrderList.SelectedRows.Count;

            var dayFinishedDto = new DayFinishedDto();

            if (count == 0)
            {
                MessageBox.Show("请选中列表中一项");
            }

            var dgvOrderListCurrentRow = this.dgvOrderList.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                dayFinishedDto = ((DayFinishedDto)dgvOrderListCurrentRow.DataBoundItem);
            }
            return dayFinishedDto;
        }

        private void DTimePic_ValueChanged(object sender, EventArgs e)
        {

            var dt = Convert.ToDateTime(dTimePic.Text);
            if (rbtnMonth.Checked)
            {
                GetInfo(dt, true);
            }
            else
            {
                GetInfo(dt, false);
            }

        }

        private void RbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked == false) return;

            var dt = Convert.ToDateTime(dTimePic.Text);
            if (rbtnMonth.Checked)
            {
                GetInfo(dt, true);
            }
            else
            {
                GetInfo(dt, false);
            }
        }


        private void GetInfo(DateTime datetime, bool month)
        {
            var dayFinishedService = AutofacContainer.GetInstance().GetObject<IDayFinishedService>();

            var dto = dayFinishedService.GetFinishedInfo(datetime, month);
            this.lbCollection.Text = dto.CollectionCount.ToString();
            this.lbAssemble.Text = dto.AssembleCount.ToString();
            this.lbFirst.Text = dto.FistTestCount.ToString();
            this.lbLast.Text = dto.LastTestCount.ToString();
            this.lbStorage.Text = dto.StorageCount.ToString();
        }
    }
}
