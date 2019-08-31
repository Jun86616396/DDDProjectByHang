namespace ManageSystem
{
	partial class FrmAssemble
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
            this.listRequiredFinish = new System.Windows.Forms.ListBox();
            this.lbPlanNo = new System.Windows.Forms.Label();
            this.lbDoNo = new System.Windows.Forms.Label();
            this.textBox_DoNumber = new System.Windows.Forms.TextBox();
            this.textBox_BoxNumber = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFinishedBoxInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNeedFinishCount = new System.Windows.Forms.Label();
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
            this.radioBtnFinishedAssemble = new System.Windows.Forms.RadioButton();
            this.DayAssembleCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnPartialAssemble = new System.Windows.Forms.RadioButton();
            this.radioBtnNotAssemble = new System.Windows.Forms.RadioButton();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderlist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listRequiredFinish
            // 
            this.listRequiredFinish.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listRequiredFinish.FormattingEnabled = true;
            this.listRequiredFinish.ItemHeight = 22;
            this.listRequiredFinish.Location = new System.Drawing.Point(760, 30);
            this.listRequiredFinish.Name = "listRequiredFinish";
            this.listRequiredFinish.Size = new System.Drawing.Size(205, 158);
            this.listRequiredFinish.TabIndex = 24;
            // 
            // lbPlanNo
            // 
            this.lbPlanNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbPlanNo.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbPlanNo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbPlanNo.Location = new System.Drawing.Point(145, 37);
            this.lbPlanNo.Name = "lbPlanNo";
            this.lbPlanNo.Size = new System.Drawing.Size(221, 31);
            this.lbPlanNo.TabIndex = 22;
            this.lbPlanNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDoNo
            // 
            this.lbDoNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbDoNo.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbDoNo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbDoNo.Location = new System.Drawing.Point(145, 139);
            this.lbDoNo.Name = "lbDoNo";
            this.lbDoNo.Size = new System.Drawing.Size(221, 31);
            this.lbDoNo.TabIndex = 23;
            this.lbDoNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_DoNumber
            // 
            this.textBox_DoNumber.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_DoNumber.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_DoNumber.Location = new System.Drawing.Point(145, 84);
            this.textBox_DoNumber.Name = "textBox_DoNumber";
            this.textBox_DoNumber.Size = new System.Drawing.Size(221, 36);
            this.textBox_DoNumber.TabIndex = 20;
            this.textBox_DoNumber.Text = "50";
            this.textBox_DoNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_BoxNumber
            // 
            this.textBox_BoxNumber.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_BoxNumber.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_BoxNumber.Location = new System.Drawing.Point(510, 84);
            this.textBox_BoxNumber.Name = "textBox_BoxNumber";
            this.textBox_BoxNumber.Size = new System.Drawing.Size(195, 36);
            this.textBox_BoxNumber.TabIndex = 21;
            this.textBox_BoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_BoxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_BoxNumber_KeyDown);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.Maroon;
            this.label27.Location = new System.Drawing.Point(10, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 22);
            this.label27.TabIndex = 15;
            this.label27.Text = "盒完成数量";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(804, 477);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 22);
            this.label16.TabIndex = 17;
            this.label16.Text = "需完成盒号";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.Maroon;
            this.label30.Location = new System.Drawing.Point(10, 41);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(98, 22);
            this.label30.TabIndex = 18;
            this.label30.Text = "计划单号";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.Maroon;
            this.label28.Location = new System.Drawing.Point(10, 143);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 22);
            this.label28.TabIndex = 16;
            this.label28.Text = "当前已做";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.Maroon;
            this.label29.Location = new System.Drawing.Point(384, 91);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 22);
            this.label29.TabIndex = 19;
            this.label29.Text = "扫描盒号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(384, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "提示信息";
            // 
            // lbFinishedBoxInfo
            // 
            this.lbFinishedBoxInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbFinishedBoxInfo.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFinishedBoxInfo.ForeColor = System.Drawing.Color.Black;
            this.lbFinishedBoxInfo.Location = new System.Drawing.Point(510, 139);
            this.lbFinishedBoxInfo.Name = "lbFinishedBoxInfo";
            this.lbFinishedBoxInfo.Size = new System.Drawing.Size(195, 31);
            this.lbFinishedBoxInfo.TabIndex = 22;
            this.lbFinishedBoxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(384, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "需完成数量";
            // 
            // lbNeedFinishCount
            // 
            this.lbNeedFinishCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbNeedFinishCount.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbNeedFinishCount.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbNeedFinishCount.Location = new System.Drawing.Point(510, 37);
            this.lbNeedFinishCount.Name = "lbNeedFinishCount";
            this.lbNeedFinishCount.Size = new System.Drawing.Size(195, 31);
            this.lbNeedFinishCount.TabIndex = 23;
            this.lbNeedFinishCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgvOrderlist.Location = new System.Drawing.Point(3, 66);
            this.dgvOrderlist.MultiSelect = false;
            this.dgvOrderlist.Name = "dgvOrderlist";
            this.dgvOrderlist.ReadOnly = true;
            this.dgvOrderlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvOrderlist.RowTemplate.Height = 23;
            this.dgvOrderlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderlist.Size = new System.Drawing.Size(985, 387);
            this.dgvOrderlist.TabIndex = 55;
            this.dgvOrderlist.SelectionChanged += new System.EventHandler(this.dgvOrderList_SelectionChanged);
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
            this.Column1.DataPropertyName = "OrderAssembleCount";
            this.Column1.HeaderText = "已组装";
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
            this.groupBox2.Controls.Add(this.radioBtnFinishedAssemble);
            this.groupBox2.Controls.Add(this.DayAssembleCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioBtnPartialAssemble);
            this.groupBox2.Controls.Add(this.radioBtnNotAssemble);
            this.groupBox2.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 57);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "组装录入系统";
            // 
            // radioBtnFinishedAssemble
            // 
            this.radioBtnFinishedAssemble.AutoSize = true;
            this.radioBtnFinishedAssemble.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtnFinishedAssemble.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioBtnFinishedAssemble.Location = new System.Drawing.Point(463, 22);
            this.radioBtnFinishedAssemble.Name = "radioBtnFinishedAssemble";
            this.radioBtnFinishedAssemble.Size = new System.Drawing.Size(201, 29);
            this.radioBtnFinishedAssemble.TabIndex = 70;
            this.radioBtnFinishedAssemble.Text = "组装完毕未入库订单";
            this.radioBtnFinishedAssemble.UseVisualStyleBackColor = true;
            this.radioBtnFinishedAssemble.CheckedChanged += new System.EventHandler(this.RadioBtnNotAssemble_CheckedChanged);
            // 
            // DayAssembleCount
            // 
            this.DayAssembleCount.BackColor = System.Drawing.SystemColors.Control;
            this.DayAssembleCount.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DayAssembleCount.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.DayAssembleCount.Location = new System.Drawing.Point(835, 20);
            this.DayAssembleCount.Name = "DayAssembleCount";
            this.DayAssembleCount.Size = new System.Drawing.Size(139, 30);
            this.DayAssembleCount.TabIndex = 76;
            this.DayAssembleCount.Text = "0";
            this.DayAssembleCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(687, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "今日组装总数";
            // 
            // radioBtnPartialAssemble
            // 
            this.radioBtnPartialAssemble.AutoSize = true;
            this.radioBtnPartialAssemble.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtnPartialAssemble.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioBtnPartialAssemble.Location = new System.Drawing.Point(303, 22);
            this.radioBtnPartialAssemble.Name = "radioBtnPartialAssemble";
            this.radioBtnPartialAssemble.Size = new System.Drawing.Size(144, 29);
            this.radioBtnPartialAssemble.TabIndex = 70;
            this.radioBtnPartialAssemble.Text = "组装部分订单";
            this.radioBtnPartialAssemble.UseVisualStyleBackColor = true;
            this.radioBtnPartialAssemble.CheckedChanged += new System.EventHandler(this.RadioBtnNotAssemble_CheckedChanged);
            // 
            // radioBtnNotAssemble
            // 
            this.radioBtnNotAssemble.AutoSize = true;
            this.radioBtnNotAssemble.Checked = true;
            this.radioBtnNotAssemble.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtnNotAssemble.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.radioBtnNotAssemble.Location = new System.Drawing.Point(153, 22);
            this.radioBtnNotAssemble.Name = "radioBtnNotAssemble";
            this.radioBtnNotAssemble.Size = new System.Drawing.Size(125, 29);
            this.radioBtnNotAssemble.TabIndex = 69;
            this.radioBtnNotAssemble.TabStop = true;
            this.radioBtnNotAssemble.Text = "未组装订单";
            this.radioBtnNotAssemble.UseVisualStyleBackColor = true;
            this.radioBtnNotAssemble.CheckedChanged += new System.EventHandler(this.RadioBtnNotAssemble_CheckedChanged);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnLastPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnLastPage.Location = new System.Drawing.Point(288, 459);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(90, 40);
            this.btnLastPage.TabIndex = 72;
            this.btnLastPage.Text = "最后页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnPrevPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevPage.Location = new System.Drawing.Point(98, 459);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(90, 40);
            this.btnPrevPage.TabIndex = 73;
            this.btnPrevPage.Text = "前一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextPage.Location = new System.Drawing.Point(191, 459);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(90, 40);
            this.btnNextPage.TabIndex = 74;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnFirstPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnFirstPage.Location = new System.Drawing.Point(5, 459);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(90, 40);
            this.btnFirstPage.TabIndex = 75;
            this.btnFirstPage.Text = "第一页";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbInfo.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.lbInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbInfo.Location = new System.Drawing.Point(390, 464);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(152, 30);
            this.lbInfo.TabIndex = 76;
            this.lbInfo.Text = "lbInfo";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNeedFinishCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.lbPlanNo);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.textBox_BoxNumber);
            this.groupBox1.Controls.Add(this.textBox_DoNumber);
            this.groupBox1.Controls.Add(this.listRequiredFinish);
            this.groupBox1.Controls.Add(this.lbDoNo);
            this.groupBox1.Controls.Add(this.lbFinishedBoxInfo);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("华文细黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 188);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前组装订单信息";
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnDetail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDetail.Location = new System.Drawing.Point(576, 459);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(172, 49);
            this.btnDetail.TabIndex = 78;
            this.btnDetail.Text = "订单组装详情";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // FrmAssemble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 705);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvOrderlist);
            this.Controls.Add(this.label16);
            this.Name = "FrmAssemble";
            this.Text = "FrmAssemble";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderlist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listRequiredFinish;
		private System.Windows.Forms.Label lbPlanNo;
		private System.Windows.Forms.Label lbDoNo;
		private System.Windows.Forms.TextBox textBox_DoNumber;
		private System.Windows.Forms.TextBox textBox_BoxNumber;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbFinishedBoxInfo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbNeedFinishCount;
        private System.Windows.Forms.DataGridView dgvOrderlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnFinishedAssemble;
        private System.Windows.Forms.RadioButton radioBtnPartialAssemble;
        private System.Windows.Forms.RadioButton radioBtnNotAssemble;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnLineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomDemandDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlannedLaunchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysOfProduction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DayAssembleCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetail;
    }
}