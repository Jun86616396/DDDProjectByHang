namespace ManageSystem
{
	partial class FrmMaterialAdd
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
            this.btnDeleteOeder = new System.Windows.Forms.Button();
            this.gbCollection = new System.Windows.Forms.GroupBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxMaterialNumber = new System.Windows.Forms.TextBox();
            this.lbMaterialCount = new System.Windows.Forms.Label();
            this.btnMateriaCollection = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.dgvOrderlist = new System.Windows.Forms.DataGridView();
            this.PlanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnLineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomDemandDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlannedLaunchDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysOfProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnFinishedCollection = new System.Windows.Forms.RadioButton();
            this.radioBtnPartialCollection = new System.Windows.Forms.RadioButton();
            this.radioBtnNotCollection = new System.Windows.Forms.RadioButton();
            this.DayCollectionCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbCollection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderlist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrderEdit);
            this.groupBox1.Controls.Add(this.btnDeleteOeder);
            this.groupBox1.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(0, 577);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 128);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单管理";
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrderEdit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnOrderEdit.Location = new System.Drawing.Point(199, 31);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(159, 68);
            this.btnOrderEdit.TabIndex = 7;
            this.btnOrderEdit.Text = "订单修改";
            this.btnOrderEdit.UseVisualStyleBackColor = true;
            this.btnOrderEdit.Click += new System.EventHandler(this.btnOrderEdit_Click);
            // 
            // btnDeleteOeder
            // 
            this.btnDeleteOeder.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteOeder.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteOeder.Location = new System.Drawing.Point(13, 34);
            this.btnDeleteOeder.Name = "btnDeleteOeder";
            this.btnDeleteOeder.Size = new System.Drawing.Size(159, 68);
            this.btnDeleteOeder.TabIndex = 7;
            this.btnDeleteOeder.Text = "删除选中订单";
            this.btnDeleteOeder.UseVisualStyleBackColor = true;
            this.btnDeleteOeder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // gbCollection
            // 
            this.gbCollection.Controls.Add(this.btnDetail);
            this.gbCollection.Controls.Add(this.label25);
            this.gbCollection.Controls.Add(this.label1);
            this.gbCollection.Controls.Add(this.txtboxMaterialNumber);
            this.gbCollection.Controls.Add(this.lbMaterialCount);
            this.gbCollection.Controls.Add(this.btnMateriaCollection);
            this.gbCollection.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.gbCollection.ForeColor = System.Drawing.Color.Maroon;
            this.gbCollection.Location = new System.Drawing.Point(400, 577);
            this.gbCollection.Name = "gbCollection";
            this.gbCollection.Size = new System.Drawing.Size(584, 130);
            this.gbCollection.TabIndex = 38;
            this.gbCollection.TabStop = false;
            this.gbCollection.Text = "领料管理";
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnDetail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDetail.Location = new System.Drawing.Point(421, 35);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(144, 72);
            this.btnDetail.TabIndex = 8;
            this.btnDetail.Text = "领料详情";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(12, 82);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(105, 21);
            this.label25.TabIndex = 3;
            this.label25.Text = "准备领料数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "已领数量";
            // 
            // txtboxMaterialNumber
            // 
            this.txtboxMaterialNumber.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxMaterialNumber.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtboxMaterialNumber.Location = new System.Drawing.Point(126, 73);
            this.txtboxMaterialNumber.Name = "txtboxMaterialNumber";
            this.txtboxMaterialNumber.Size = new System.Drawing.Size(126, 34);
            this.txtboxMaterialNumber.TabIndex = 4;
            this.txtboxMaterialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbMaterialCount
            // 
            this.lbMaterialCount.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMaterialCount.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbMaterialCount.Location = new System.Drawing.Point(121, 35);
            this.lbMaterialCount.Name = "lbMaterialCount";
            this.lbMaterialCount.Size = new System.Drawing.Size(131, 31);
            this.lbMaterialCount.TabIndex = 6;
            this.lbMaterialCount.Text = "lbMaterialCount";
            this.lbMaterialCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMateriaCollection
            // 
            this.btnMateriaCollection.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMateriaCollection.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnMateriaCollection.Location = new System.Drawing.Point(272, 36);
            this.btnMateriaCollection.Name = "btnMateriaCollection";
            this.btnMateriaCollection.Size = new System.Drawing.Size(135, 72);
            this.btnMateriaCollection.TabIndex = 7;
            this.btnMateriaCollection.Text = "选中订单领料";
            this.btnMateriaCollection.UseVisualStyleBackColor = true;
            this.btnMateriaCollection.Click += new System.EventHandler(this.btnMaterialCollection_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnLastPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnLastPage.Location = new System.Drawing.Point(289, 523);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(90, 40);
            this.btnLastPage.TabIndex = 34;
            this.btnLastPage.Text = "最后页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnPrevPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevPage.Location = new System.Drawing.Point(99, 525);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(90, 40);
            this.btnPrevPage.TabIndex = 35;
            this.btnPrevPage.Text = "前一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextPage.Location = new System.Drawing.Point(192, 525);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(90, 40);
            this.btnNextPage.TabIndex = 36;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnFirstPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnFirstPage.Location = new System.Drawing.Point(6, 523);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(90, 40);
            this.btnFirstPage.TabIndex = 37;
            this.btnFirstPage.Text = "第一页";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
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
            this.DaysOfProduction});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderlist.Location = new System.Drawing.Point(-1, 64);
            this.dgvOrderlist.Name = "dgvOrderlist";
            this.dgvOrderlist.ReadOnly = true;
            this.dgvOrderlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvOrderlist.RowTemplate.Height = 23;
            this.dgvOrderlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderlist.Size = new System.Drawing.Size(985, 453);
            this.dgvOrderlist.TabIndex = 33;
            this.dgvOrderlist.SelectionChanged += new System.EventHandler(this.dgvOrderlist_SelectionChanged);
            // 
            // PlanNo
            // 
            this.PlanNo.DataPropertyName = "PlanNo";
            this.PlanNo.Frozen = true;
            this.PlanNo.HeaderText = "订单号";
            this.PlanNo.Name = "PlanNo";
            this.PlanNo.ReadOnly = true;
            this.PlanNo.Width = 150;
            // 
            // SnMin
            // 
            this.SnMin.DataPropertyName = "ProductTypeNo";
            this.SnMin.HeaderText = "产品型号";
            this.SnMin.Name = "SnMin";
            this.SnMin.ReadOnly = true;
            this.SnMin.Width = 150;
            // 
            // SnMax
            // 
            this.SnMax.DataPropertyName = "SnMin";
            this.SnMax.HeaderText = "起始SN";
            this.SnMax.Name = "SnMax";
            this.SnMax.ReadOnly = true;
            this.SnMax.Width = 150;
            // 
            // OnLineQuantity
            // 
            this.OnLineQuantity.DataPropertyName = "OnLineQuantity";
            this.OnLineQuantity.FillWeight = 50F;
            this.OnLineQuantity.HeaderText = "数量";
            this.OnLineQuantity.Name = "OnLineQuantity";
            this.OnLineQuantity.ReadOnly = true;
            this.OnLineQuantity.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderCollectionCount";
            this.Column1.HeaderText = "已领";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // CustomDemandDate
            // 
            this.CustomDemandDate.DataPropertyName = "CustomDemandDate";
            this.CustomDemandDate.HeaderText = "需求日期";
            this.CustomDemandDate.Name = "CustomDemandDate";
            this.CustomDemandDate.ReadOnly = true;
            this.CustomDemandDate.Width = 120;
            // 
            // PlannedLaunchDate
            // 
            this.PlannedLaunchDate.DataPropertyName = "PlannedLaunchDate";
            this.PlannedLaunchDate.HeaderText = "上线日期";
            this.PlannedLaunchDate.Name = "PlannedLaunchDate";
            this.PlannedLaunchDate.ReadOnly = true;
            this.PlannedLaunchDate.Width = 120;
            // 
            // DaysOfProduction
            // 
            this.DaysOfProduction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DaysOfProduction.DataPropertyName = "DaysOfProduction";
            this.DaysOfProduction.HeaderText = "生产天数";
            this.DaysOfProduction.Name = "DaysOfProduction";
            this.DaysOfProduction.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnFinishedCollection);
            this.groupBox2.Controls.Add(this.radioBtnPartialCollection);
            this.groupBox2.Controls.Add(this.radioBtnNotCollection);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 57);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单列表";
            // 
            // radioBtnFinishedCollection
            // 
            this.radioBtnFinishedCollection.AutoSize = true;
            this.radioBtnFinishedCollection.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioBtnFinishedCollection.Location = new System.Drawing.Point(550, 22);
            this.radioBtnFinishedCollection.Name = "radioBtnFinishedCollection";
            this.radioBtnFinishedCollection.Size = new System.Drawing.Size(172, 26);
            this.radioBtnFinishedCollection.TabIndex = 70;
            this.radioBtnFinishedCollection.Text = "领料完毕未入库订单";
            this.radioBtnFinishedCollection.UseVisualStyleBackColor = true;
            this.radioBtnFinishedCollection.CheckedChanged += new System.EventHandler(this.RadioBtnNotCollection_CheckedChanged);
            // 
            // radioBtnPartialCollection
            // 
            this.radioBtnPartialCollection.AutoSize = true;
            this.radioBtnPartialCollection.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioBtnPartialCollection.Location = new System.Drawing.Point(344, 21);
            this.radioBtnPartialCollection.Name = "radioBtnPartialCollection";
            this.radioBtnPartialCollection.Size = new System.Drawing.Size(124, 26);
            this.radioBtnPartialCollection.TabIndex = 70;
            this.radioBtnPartialCollection.Text = "领料部分订单";
            this.radioBtnPartialCollection.UseVisualStyleBackColor = true;
            this.radioBtnPartialCollection.CheckedChanged += new System.EventHandler(this.RadioBtnNotCollection_CheckedChanged);
            // 
            // radioBtnNotCollection
            // 
            this.radioBtnNotCollection.AutoSize = true;
            this.radioBtnNotCollection.Checked = true;
            this.radioBtnNotCollection.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioBtnNotCollection.Location = new System.Drawing.Point(154, 21);
            this.radioBtnNotCollection.Name = "radioBtnNotCollection";
            this.radioBtnNotCollection.Size = new System.Drawing.Size(108, 26);
            this.radioBtnNotCollection.TabIndex = 69;
            this.radioBtnNotCollection.TabStop = true;
            this.radioBtnNotCollection.Text = "未领料订单";
            this.radioBtnNotCollection.UseVisualStyleBackColor = true;
            this.radioBtnNotCollection.CheckedChanged += new System.EventHandler(this.RadioBtnNotCollection_CheckedChanged);
            // 
            // DayCollectionCount
            // 
            this.DayCollectionCount.BackColor = System.Drawing.SystemColors.Control;
            this.DayCollectionCount.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DayCollectionCount.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.DayCollectionCount.Location = new System.Drawing.Point(845, 530);
            this.DayCollectionCount.Name = "DayCollectionCount";
            this.DayCollectionCount.Size = new System.Drawing.Size(139, 30);
            this.DayCollectionCount.TabIndex = 78;
            this.DayCollectionCount.Text = "0";
            this.DayCollectionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(697, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 77;
            this.label3.Text = "今日领料总数";
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbInfo.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.lbInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbInfo.Location = new System.Drawing.Point(405, 530);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(152, 30);
            this.lbInfo.TabIndex = 79;
            this.lbInfo.Text = "lbInfo";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMaterialAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 712);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.DayCollectionCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCollection);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.dgvOrderlist);
            this.Name = "FrmMaterialAdd";
            this.Text = "FrmMatiralCollection";
            this.groupBox1.ResumeLayout(false);
            this.gbCollection.ResumeLayout(false);
            this.gbCollection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderlist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDeleteOeder;
		private System.Windows.Forms.GroupBox gbCollection;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txtboxMaterialNumber;
		private System.Windows.Forms.Label lbMaterialCount;
		private System.Windows.Forms.Button btnMateriaCollection;
		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.DataGridView dgvOrderlist;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOrderEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnFinishedCollection;
        private System.Windows.Forms.RadioButton radioBtnPartialCollection;
        private System.Windows.Forms.RadioButton radioBtnNotCollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnLineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomDemandDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlannedLaunchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysOfProduction;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label DayCollectionCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbInfo;
    }
}