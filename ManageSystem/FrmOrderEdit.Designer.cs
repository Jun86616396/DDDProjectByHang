namespace ManageSystem
{
    partial class FrmOrderEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrderEdit = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.dgvOrderlist = new System.Windows.Forms.DataGridView();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnStorageFinished = new System.Windows.Forms.RadioButton();
            this.radioBtnNotStorage = new System.Windows.Forms.RadioButton();
            this.PlanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnLineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomDemandDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlannedLaunchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysOfProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderlist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrderEdit);
            this.groupBox1.Controls.Add(this.btnDeleteOrder);
            this.groupBox1.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(6, 566);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 128);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单管理";
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrderEdit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnOrderEdit.Location = new System.Drawing.Point(306, 34);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(159, 68);
            this.btnOrderEdit.TabIndex = 7;
            this.btnOrderEdit.Text = "订单修改";
            this.btnOrderEdit.UseVisualStyleBackColor = true;
            this.btnOrderEdit.Click += new System.EventHandler(this.BtnOrderEdit_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteOrder.Location = new System.Drawing.Point(55, 34);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(159, 68);
            this.btnDeleteOrder.TabIndex = 7;
            this.btnDeleteOrder.Text = "删除选中订单";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // dgvOrderlist
            // 
            this.dgvOrderlist.AllowUserToAddRows = false;
            this.dgvOrderlist.AllowUserToDeleteRows = false;
            this.dgvOrderlist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvOrderlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanNo,
            this.SnMin,
            this.SnMax,
            this.OnLineQuantity,
            this.Column1,
            this.CustomDemandDate,
            this.PlannedLaunchDate,
            this.DaysOfProduction,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderlist.Location = new System.Drawing.Point(-1, 59);
            this.dgvOrderlist.MultiSelect = false;
            this.dgvOrderlist.Name = "dgvOrderlist";
            this.dgvOrderlist.ReadOnly = true;
            this.dgvOrderlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvOrderlist.RowTemplate.Height = 23;
            this.dgvOrderlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderlist.Size = new System.Drawing.Size(985, 453);
            this.dgvOrderlist.TabIndex = 41;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbInfo.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.lbInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbInfo.Location = new System.Drawing.Point(401, 525);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(152, 30);
            this.lbInfo.TabIndex = 84;
            this.lbInfo.Text = "lbInfo";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnLastPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnLastPage.Location = new System.Drawing.Point(285, 518);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(90, 40);
            this.btnLastPage.TabIndex = 80;
            this.btnLastPage.Text = "最后页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnPrevPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevPage.Location = new System.Drawing.Point(95, 520);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(90, 40);
            this.btnPrevPage.TabIndex = 81;
            this.btnPrevPage.Text = "前一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.BtnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextPage.Location = new System.Drawing.Point(188, 520);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(90, 40);
            this.btnNextPage.TabIndex = 82;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnFirstPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnFirstPage.Location = new System.Drawing.Point(2, 518);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(90, 40);
            this.btnFirstPage.TabIndex = 83;
            this.btnFirstPage.Text = "第一页";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnStorageFinished);
            this.groupBox2.Controls.Add(this.radioBtnNotStorage);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 57);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单列表";
            // 
            // radioBtnStorageFinished
            // 
            this.radioBtnStorageFinished.AutoSize = true;
            this.radioBtnStorageFinished.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioBtnStorageFinished.Location = new System.Drawing.Point(454, 21);
            this.radioBtnStorageFinished.Name = "radioBtnStorageFinished";
            this.radioBtnStorageFinished.Size = new System.Drawing.Size(108, 26);
            this.radioBtnStorageFinished.TabIndex = 70;
            this.radioBtnStorageFinished.Text = "已入库订单";
            this.radioBtnStorageFinished.UseVisualStyleBackColor = true;
            this.radioBtnStorageFinished.CheckedChanged += new System.EventHandler(this.RadioBtnNotStorage_CheckedChanged);
            // 
            // radioBtnNotStorage
            // 
            this.radioBtnNotStorage.AutoSize = true;
            this.radioBtnNotStorage.Checked = true;
            this.radioBtnNotStorage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioBtnNotStorage.Location = new System.Drawing.Point(230, 21);
            this.radioBtnNotStorage.Name = "radioBtnNotStorage";
            this.radioBtnNotStorage.Size = new System.Drawing.Size(108, 26);
            this.radioBtnNotStorage.TabIndex = 69;
            this.radioBtnNotStorage.TabStop = true;
            this.radioBtnNotStorage.Text = "未入库订单";
            this.radioBtnNotStorage.UseVisualStyleBackColor = true;
            this.radioBtnNotStorage.CheckedChanged += new System.EventHandler(this.RadioBtnNotStorage_CheckedChanged);
            // 
            // PlanNo
            // 
            this.PlanNo.DataPropertyName = "PlanNo";
            this.PlanNo.Frozen = true;
            this.PlanNo.HeaderText = "订单号";
            this.PlanNo.MinimumWidth = 8;
            this.PlanNo.Name = "PlanNo";
            this.PlanNo.ReadOnly = true;
            this.PlanNo.Width = 120;
            // 
            // SnMin
            // 
            this.SnMin.DataPropertyName = "ProductTypeNo";
            this.SnMin.HeaderText = "产品型号";
            this.SnMin.MinimumWidth = 8;
            this.SnMin.Name = "SnMin";
            this.SnMin.ReadOnly = true;
            this.SnMin.Width = 130;
            // 
            // SnMax
            // 
            this.SnMax.DataPropertyName = "SnMin";
            this.SnMax.HeaderText = "起始SN";
            this.SnMax.MinimumWidth = 8;
            this.SnMax.Name = "SnMax";
            this.SnMax.ReadOnly = true;
            this.SnMax.Width = 140;
            // 
            // OnLineQuantity
            // 
            this.OnLineQuantity.DataPropertyName = "OnLineQuantity";
            this.OnLineQuantity.FillWeight = 50F;
            this.OnLineQuantity.HeaderText = "数量";
            this.OnLineQuantity.MinimumWidth = 8;
            this.OnLineQuantity.Name = "OnLineQuantity";
            this.OnLineQuantity.ReadOnly = true;
            this.OnLineQuantity.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderStorageCount";
            this.Column1.HeaderText = "入库数";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // CustomDemandDate
            // 
            this.CustomDemandDate.DataPropertyName = "CustomDemandDate";
            this.CustomDemandDate.HeaderText = "需求日期";
            this.CustomDemandDate.MinimumWidth = 8;
            this.CustomDemandDate.Name = "CustomDemandDate";
            this.CustomDemandDate.ReadOnly = true;
            this.CustomDemandDate.Width = 110;
            // 
            // PlannedLaunchDate
            // 
            this.PlannedLaunchDate.DataPropertyName = "PlannedLaunchDate";
            this.PlannedLaunchDate.HeaderText = "计划入库日期";
            this.PlannedLaunchDate.MinimumWidth = 8;
            this.PlannedLaunchDate.Name = "PlannedLaunchDate";
            this.PlannedLaunchDate.ReadOnly = true;
            this.PlannedLaunchDate.Width = 110;
            // 
            // DaysOfProduction
            // 
            this.DaysOfProduction.DataPropertyName = "DaysOfProduction";
            this.DaysOfProduction.HeaderText = "生产天数";
            this.DaysOfProduction.MinimumWidth = 8;
            this.DaysOfProduction.Name = "DaysOfProduction";
            this.DaysOfProduction.ReadOnly = true;
            this.DaysOfProduction.Width = 80;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "StorageAdvanceDays";
            this.Column2.HeaderText = "提前天数";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FrmOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.dgvOrderlist);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrderEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderEdit";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderlist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrderEdit;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.DataGridView dgvOrderlist;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnStorageFinished;
        private System.Windows.Forms.RadioButton radioBtnNotStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnLineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomDemandDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlannedLaunchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysOfProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}