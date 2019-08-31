namespace ManageSystem
{
	partial class FrmGatherSearch
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
            this.textBox_searchPlanOrder = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btnOrderInfo = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStorageDetail = new System.Windows.Forms.Button();
            this.btnAssembleDetail = new System.Windows.Forms.Button();
            this.btnCollectionDetail = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDateAssembly = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDateStorage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDateLastTest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDateFistTest = new System.Windows.Forms.Label();
            this.lbDateCollection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDateleft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomDemandDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnLineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlannedStorageDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysOfProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_searchPlanOrder
            // 
            this.textBox_searchPlanOrder.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_searchPlanOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_searchPlanOrder.Location = new System.Drawing.Point(346, 35);
            this.textBox_searchPlanOrder.Name = "textBox_searchPlanOrder";
            this.textBox_searchPlanOrder.Size = new System.Drawing.Size(194, 36);
            this.textBox_searchPlanOrder.TabIndex = 33;
            this.textBox_searchPlanOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label37.ForeColor = System.Drawing.Color.Maroon;
            this.label37.Location = new System.Drawing.Point(64, 37);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(180, 34);
            this.label37.TabIndex = 27;
            this.label37.Text = "当前订单号";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrderInfo
            // 
            this.btnOrderInfo.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnOrderInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnOrderInfo.Location = new System.Drawing.Point(56, 96);
            this.btnOrderInfo.Name = "btnOrderInfo";
            this.btnOrderInfo.Size = new System.Drawing.Size(197, 51);
            this.btnOrderInfo.TabIndex = 48;
            this.btnOrderInfo.Text = "订单详细";
            this.btnOrderInfo.UseVisualStyleBackColor = true;
            this.btnOrderInfo.Click += new System.EventHandler(this.btnOrderInfo_Click);
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
            this.CustomDemandDate,
            this.SnMin,
            this.OnLineQuantity,
            this.PlannedStorageDate,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.DaysOfProduction});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderList.Location = new System.Drawing.Point(3, 1);
            this.dgvOrderList.MultiSelect = false;
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvOrderList.RowTemplate.Height = 23;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(985, 393);
            this.dgvOrderList.TabIndex = 49;
            this.dgvOrderList.SelectionChanged += new System.EventHandler(this.DgvOrderList_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_searchPlanOrder);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.btnStorageDetail);
            this.groupBox1.Controls.Add(this.btnAssembleDetail);
            this.groupBox1.Controls.Add(this.btnCollectionDetail);
            this.groupBox1.Controls.Add(this.btnOrderInfo);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(5, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 246);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单相关简要";
            // 
            // btnStorageDetail
            // 
            this.btnStorageDetail.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStorageDetail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnStorageDetail.Location = new System.Drawing.Point(340, 175);
            this.btnStorageDetail.Name = "btnStorageDetail";
            this.btnStorageDetail.Size = new System.Drawing.Size(197, 51);
            this.btnStorageDetail.TabIndex = 48;
            this.btnStorageDetail.Text = "入库详细";
            this.btnStorageDetail.UseVisualStyleBackColor = true;
            this.btnStorageDetail.Click += new System.EventHandler(this.BtnStorageDetail_Click);
            // 
            // btnAssembleDetail
            // 
            this.btnAssembleDetail.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAssembleDetail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAssembleDetail.Location = new System.Drawing.Point(56, 175);
            this.btnAssembleDetail.Name = "btnAssembleDetail";
            this.btnAssembleDetail.Size = new System.Drawing.Size(197, 51);
            this.btnAssembleDetail.TabIndex = 48;
            this.btnAssembleDetail.Text = "组装详细";
            this.btnAssembleDetail.UseVisualStyleBackColor = true;
            this.btnAssembleDetail.Click += new System.EventHandler(this.BtnAssembleDetail_Click);
            // 
            // btnCollectionDetail
            // 
            this.btnCollectionDetail.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCollectionDetail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCollectionDetail.Location = new System.Drawing.Point(342, 96);
            this.btnCollectionDetail.Name = "btnCollectionDetail";
            this.btnCollectionDetail.Size = new System.Drawing.Size(197, 51);
            this.btnCollectionDetail.TabIndex = 48;
            this.btnCollectionDetail.Text = "领料详细";
            this.btnCollectionDetail.UseVisualStyleBackColor = true;
            this.btnCollectionDetail.Click += new System.EventHandler(this.BtnCollectionDetail_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbInfo.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.lbInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbInfo.Location = new System.Drawing.Point(395, 416);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(152, 30);
            this.lbInfo.TabIndex = 75;
            this.lbInfo.Text = "lbInfo";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnLastPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnLastPage.Location = new System.Drawing.Point(289, 411);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(90, 40);
            this.btnLastPage.TabIndex = 71;
            this.btnLastPage.Text = "最后页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnPrevPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevPage.Location = new System.Drawing.Point(98, 411);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(90, 40);
            this.btnPrevPage.TabIndex = 72;
            this.btnPrevPage.Text = "前一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.BtnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextPage.Location = new System.Drawing.Point(191, 411);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(90, 40);
            this.btnNextPage.TabIndex = 73;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnFirstPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnFirstPage.Location = new System.Drawing.Point(5, 411);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(90, 40);
            this.btnFirstPage.TabIndex = 74;
            this.btnFirstPage.Text = "第一页";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDateAssembly);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbDateStorage);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbDateLastTest);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbDateFistTest);
            this.groupBox2.Controls.Add(this.lbDateCollection);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbDateleft);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(683, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 311);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单延期预估";
            // 
            // lbDateAssembly
            // 
            this.lbDateAssembly.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateAssembly.ForeColor = System.Drawing.Color.Maroon;
            this.lbDateAssembly.Location = new System.Drawing.Point(120, 126);
            this.lbDateAssembly.Name = "lbDateAssembly";
            this.lbDateAssembly.Size = new System.Drawing.Size(172, 34);
            this.lbDateAssembly.TabIndex = 27;
            this.lbDateAssembly.Text = "lbDateAssembly";
            this.lbDateAssembly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 34);
            this.label5.TabIndex = 27;
            this.label5.Text = "组装限期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateStorage
            // 
            this.lbDateStorage.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateStorage.ForeColor = System.Drawing.Color.Maroon;
            this.lbDateStorage.Location = new System.Drawing.Point(120, 261);
            this.lbDateStorage.Name = "lbDateStorage";
            this.lbDateStorage.Size = new System.Drawing.Size(172, 34);
            this.lbDateStorage.TabIndex = 27;
            this.lbDateStorage.Text = "lbDateStorage";
            this.lbDateStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(5, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 34);
            this.label6.TabIndex = 27;
            this.label6.Text = "入库限期";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateLastTest
            // 
            this.lbDateLastTest.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateLastTest.ForeColor = System.Drawing.Color.Maroon;
            this.lbDateLastTest.Location = new System.Drawing.Point(120, 216);
            this.lbDateLastTest.Name = "lbDateLastTest";
            this.lbDateLastTest.Size = new System.Drawing.Size(172, 34);
            this.lbDateLastTest.TabIndex = 27;
            this.lbDateLastTest.Text = "lbDateLastTest";
            this.lbDateLastTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(5, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 34);
            this.label4.TabIndex = 27;
            this.label4.Text = "终测限期";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateFistTest
            // 
            this.lbDateFistTest.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateFistTest.ForeColor = System.Drawing.Color.Maroon;
            this.lbDateFistTest.Location = new System.Drawing.Point(120, 171);
            this.lbDateFistTest.Name = "lbDateFistTest";
            this.lbDateFistTest.Size = new System.Drawing.Size(172, 34);
            this.lbDateFistTest.TabIndex = 27;
            this.lbDateFistTest.Text = "lbDateFistTest";
            this.lbDateFistTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateCollection
            // 
            this.lbDateCollection.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateCollection.ForeColor = System.Drawing.Color.Maroon;
            this.lbDateCollection.Location = new System.Drawing.Point(120, 81);
            this.lbDateCollection.Name = "lbDateCollection";
            this.lbDateCollection.Size = new System.Drawing.Size(172, 34);
            this.lbDateCollection.TabIndex = 27;
            this.lbDateCollection.Text = "lbDateCollection";
            this.lbDateCollection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(5, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "初测限期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateleft
            // 
            this.lbDateleft.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDateleft.ForeColor = System.Drawing.Color.Maroon;
            this.lbDateleft.Location = new System.Drawing.Point(120, 36);
            this.lbDateleft.Name = "lbDateleft";
            this.lbDateleft.Size = new System.Drawing.Size(172, 34);
            this.lbDateleft.TabIndex = 27;
            this.lbDateleft.Text = "lbDateleft";
            this.lbDateleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 34);
            this.label2.TabIndex = 27;
            this.label2.Text = "领料限期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "剩余天数";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlanNo
            // 
            this.PlanNo.DataPropertyName = "PlanNo";
            this.PlanNo.Frozen = true;
            this.PlanNo.HeaderText = "订单号";
            this.PlanNo.Name = "PlanNo";
            this.PlanNo.ReadOnly = true;
            this.PlanNo.Width = 110;
            // 
            // CustomDemandDate
            // 
            this.CustomDemandDate.DataPropertyName = "ProductTypeNo";
            this.CustomDemandDate.HeaderText = "产品型号";
            this.CustomDemandDate.Name = "CustomDemandDate";
            this.CustomDemandDate.ReadOnly = true;
            this.CustomDemandDate.Width = 120;
            // 
            // SnMin
            // 
            this.SnMin.DataPropertyName = "SnMin";
            this.SnMin.HeaderText = "初始SN";
            this.SnMin.Name = "SnMin";
            this.SnMin.ReadOnly = true;
            this.SnMin.Width = 125;
            // 
            // OnLineQuantity
            // 
            this.OnLineQuantity.DataPropertyName = "OnLineQuantity";
            this.OnLineQuantity.FillWeight = 50F;
            this.OnLineQuantity.HeaderText = "数量";
            this.OnLineQuantity.Name = "OnLineQuantity";
            this.OnLineQuantity.ReadOnly = true;
            this.OnLineQuantity.Width = 60;
            // 
            // PlannedStorageDate
            // 
            this.PlannedStorageDate.DataPropertyName = "PlanStorageDate";
            this.PlannedStorageDate.HeaderText = "入库日期";
            this.PlannedStorageDate.Name = "PlannedStorageDate";
            this.PlannedStorageDate.ReadOnly = true;
            this.PlannedStorageDate.Width = 110;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderStorageCount";
            this.Column1.HeaderText = "入库";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "OrderCollectionCount";
            this.Column2.HeaderText = "领料";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "OrderAssembleCount";
            this.Column3.HeaderText = "组装";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FisrtTestCount";
            this.Column4.HeaderText = "初测";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LastTestCount";
            this.Column5.HeaderText = "终测";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "StorageAdvanceDays";
            this.Column6.HeaderText = "提前";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // DaysOfProduction
            // 
            this.DaysOfProduction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DaysOfProduction.DataPropertyName = "DaysOfProduction";
            this.DaysOfProduction.HeaderText = "生产";
            this.DaysOfProduction.Name = "DaysOfProduction";
            this.DaysOfProduction.ReadOnly = true;
            // 
            // FrmGatherSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 712);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOrderList);
            this.Name = "FrmGatherSearch";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_searchPlanOrder;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Button btnOrderInfo;
		private System.Windows.Forms.DataGridView dgvOrderList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbInfo;
		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbDateAssembly;
		private System.Windows.Forms.Label lbDateStorage;
		private System.Windows.Forms.Label lbDateLastTest;
		private System.Windows.Forms.Label lbDateFistTest;
		private System.Windows.Forms.Label lbDateCollection;
		private System.Windows.Forms.Label lbDateleft;
        private System.Windows.Forms.Button btnCollectionDetail;
        private System.Windows.Forms.Button btnStorageDetail;
        private System.Windows.Forms.Button btnAssembleDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomDemandDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnLineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlannedStorageDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysOfProduction;
    }
}