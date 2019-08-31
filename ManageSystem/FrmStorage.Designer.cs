namespace ManageSystem
{
	partial class FrmStorage
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
            this.textBox_StorageNumber = new System.Windows.Forms.TextBox();
            this.textBox_Storage = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblOperationName = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnFinished = new System.Windows.Forms.RadioButton();
            this.radioBtnNotStorage = new System.Windows.Forms.RadioButton();
            this.btnStorageTagFinish = new System.Windows.Forms.Button();
            this.btnStorageTagUndo = new System.Windows.Forms.Button();
            this.DayStorageCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStorageDetail = new System.Windows.Forms.Button();
            this.PlanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnLineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.下单日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_StorageNumber
            // 
            this.textBox_StorageNumber.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_StorageNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_StorageNumber.Location = new System.Drawing.Point(750, 220);
            this.textBox_StorageNumber.Name = "textBox_StorageNumber";
            this.textBox_StorageNumber.Size = new System.Drawing.Size(222, 36);
            this.textBox_StorageNumber.TabIndex = 31;
            this.textBox_StorageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_StorageNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_StorageNumber_KeyDown);
            // 
            // textBox_Storage
            // 
            this.textBox_Storage.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_Storage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Storage.Location = new System.Drawing.Point(750, 143);
            this.textBox_Storage.Name = "textBox_Storage";
            this.textBox_Storage.Size = new System.Drawing.Size(222, 36);
            this.textBox_Storage.TabIndex = 32;
            this.textBox_Storage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label38.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label38.Location = new System.Drawing.Point(646, 149);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(98, 22);
            this.label38.TabIndex = 30;
            this.label38.Text = "入库单号";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label39.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label39.Location = new System.Drawing.Point(646, 224);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(98, 22);
            this.label39.TabIndex = 29;
            this.label39.Text = "入库数量";
            // 
            // lblOperationName
            // 
            this.lblOperationName.Font = new System.Drawing.Font("微软雅黑 Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOperationName.ForeColor = System.Drawing.Color.Maroon;
            this.lblOperationName.Location = new System.Drawing.Point(320, 9);
            this.lblOperationName.Name = "lblOperationName";
            this.lblOperationName.Size = new System.Drawing.Size(289, 49);
            this.lblOperationName.TabIndex = 60;
            this.lblOperationName.Text = "订单入库管理系统";
            this.lblOperationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanNo,
            this.Column1,
            this.OnLineQuantity,
            this.下单日期,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 140);
            this.dgvOrderList.MultiSelect = false;
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvOrderList.RowTemplate.Height = 23;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(619, 491);
            this.dgvOrderList.TabIndex = 61;
            this.dgvOrderList.SelectionChanged += new System.EventHandler(this.dgvOrderList_SelectionChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbInfo.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.lbInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbInfo.Location = new System.Drawing.Point(403, 654);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(152, 30);
            this.lbInfo.TabIndex = 67;
            this.lbInfo.Text = "lbInfo";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnLastPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnLastPage.Location = new System.Drawing.Point(297, 649);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(90, 40);
            this.btnLastPage.TabIndex = 63;
            this.btnLastPage.Text = "最后页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnPrevPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevPage.Location = new System.Drawing.Point(106, 649);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(90, 40);
            this.btnPrevPage.TabIndex = 64;
            this.btnPrevPage.Text = "前一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.BtnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextPage.Location = new System.Drawing.Point(199, 649);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(90, 40);
            this.btnNextPage.TabIndex = 65;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnFirstPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnFirstPage.Location = new System.Drawing.Point(13, 649);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(90, 40);
            this.btnFirstPage.TabIndex = 66;
            this.btnFirstPage.Text = "第一页";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnFinished);
            this.groupBox1.Controls.Add(this.radioBtnNotStorage);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 57);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单列表";
            // 
            // radioBtnFinished
            // 
            this.radioBtnFinished.AutoSize = true;
            this.radioBtnFinished.Location = new System.Drawing.Point(396, 22);
            this.radioBtnFinished.Name = "radioBtnFinished";
            this.radioBtnFinished.Size = new System.Drawing.Size(108, 26);
            this.radioBtnFinished.TabIndex = 70;
            this.radioBtnFinished.Text = "已入库订单";
            this.radioBtnFinished.UseVisualStyleBackColor = true;
            this.radioBtnFinished.CheckedChanged += new System.EventHandler(this.RadioBtnNotStorage_CheckedChanged);
            // 
            // radioBtnNotStorage
            // 
            this.radioBtnNotStorage.AutoSize = true;
            this.radioBtnNotStorage.Checked = true;
            this.radioBtnNotStorage.Location = new System.Drawing.Point(145, 23);
            this.radioBtnNotStorage.Name = "radioBtnNotStorage";
            this.radioBtnNotStorage.Size = new System.Drawing.Size(108, 26);
            this.radioBtnNotStorage.TabIndex = 69;
            this.radioBtnNotStorage.TabStop = true;
            this.radioBtnNotStorage.Text = "未入库订单";
            this.radioBtnNotStorage.UseVisualStyleBackColor = true;
            this.radioBtnNotStorage.CheckedChanged += new System.EventHandler(this.RadioBtnNotStorage_CheckedChanged);
            // 
            // btnStorageTagFinish
            // 
            this.btnStorageTagFinish.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnStorageTagFinish.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnStorageTagFinish.Location = new System.Drawing.Point(644, 490);
            this.btnStorageTagFinish.Name = "btnStorageTagFinish";
            this.btnStorageTagFinish.Size = new System.Drawing.Size(200, 51);
            this.btnStorageTagFinish.TabIndex = 70;
            this.btnStorageTagFinish.Text = "订单标记--完成";
            this.btnStorageTagFinish.UseVisualStyleBackColor = true;
            this.btnStorageTagFinish.Click += new System.EventHandler(this.BtnStorageTagFinish_Click);
            // 
            // btnStorageTagUndo
            // 
            this.btnStorageTagUndo.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnStorageTagUndo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnStorageTagUndo.Location = new System.Drawing.Point(644, 580);
            this.btnStorageTagUndo.Name = "btnStorageTagUndo";
            this.btnStorageTagUndo.Size = new System.Drawing.Size(200, 51);
            this.btnStorageTagUndo.TabIndex = 70;
            this.btnStorageTagUndo.Text = "订单标记--取消完成";
            this.btnStorageTagUndo.UseVisualStyleBackColor = true;
            this.btnStorageTagUndo.Click += new System.EventHandler(this.BtnStorageTagUndo_Click);
            // 
            // DayStorageCount
            // 
            this.DayStorageCount.BackColor = System.Drawing.SystemColors.Control;
            this.DayStorageCount.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DayStorageCount.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.DayStorageCount.Location = new System.Drawing.Point(785, 95);
            this.DayStorageCount.Name = "DayStorageCount";
            this.DayStorageCount.Size = new System.Drawing.Size(139, 30);
            this.DayStorageCount.TabIndex = 80;
            this.DayStorageCount.Text = "0";
            this.DayStorageCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(637, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 79;
            this.label3.Text = "今日入库总数";
            // 
            // btnStorageDetail
            // 
            this.btnStorageDetail.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStorageDetail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnStorageDetail.Location = new System.Drawing.Point(647, 406);
            this.btnStorageDetail.Name = "btnStorageDetail";
            this.btnStorageDetail.Size = new System.Drawing.Size(197, 51);
            this.btnStorageDetail.TabIndex = 81;
            this.btnStorageDetail.Text = "入库详细";
            this.btnStorageDetail.UseVisualStyleBackColor = true;
            this.btnStorageDetail.Click += new System.EventHandler(this.BtnStorageDetail_Click);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "OnLineQuantity";
            this.Column1.HeaderText = "计划数量";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // OnLineQuantity
            // 
            this.OnLineQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OnLineQuantity.DataPropertyName = "OrderStorageCount";
            this.OnLineQuantity.FillWeight = 50F;
            this.OnLineQuantity.HeaderText = "已入库";
            this.OnLineQuantity.Name = "OnLineQuantity";
            this.OnLineQuantity.ReadOnly = true;
            // 
            // 下单日期
            // 
            this.下单日期.DataPropertyName = "PlanStorageDate";
            this.下单日期.HeaderText = "应入库日期";
            this.下单日期.Name = "下单日期";
            this.下单日期.ReadOnly = true;
            this.下单日期.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StorageAdvanceDays";
            this.Column2.HeaderText = "入库提前";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FrmStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.btnStorageDetail);
            this.Controls.Add(this.DayStorageCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStorageTagUndo);
            this.Controls.Add(this.btnStorageTagFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.lblOperationName);
            this.Controls.Add(this.textBox_StorageNumber);
            this.Controls.Add(this.textBox_Storage);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Name = "FrmStorage";
            this.Text = "FrmStorage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_StorageNumber;
		private System.Windows.Forms.TextBox textBox_Storage;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label lblOperationName;
		private System.Windows.Forms.DataGridView dgvOrderList;
		private System.Windows.Forms.Label lbInfo;
		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioBtnFinished;
		private System.Windows.Forms.RadioButton radioBtnNotStorage;
        private System.Windows.Forms.Button btnStorageTagFinish;
        private System.Windows.Forms.Button btnStorageTagUndo;
        private System.Windows.Forms.Label DayStorageCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStorageDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnLineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn 下单日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}