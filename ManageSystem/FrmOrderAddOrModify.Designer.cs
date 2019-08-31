namespace ManageSystem
{
	partial class FrmOrderAddOrModify
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
			this.label20 = new System.Windows.Forms.Label();
			this.ProductTypecBox = new System.Windows.Forms.ComboBox();
			this.FinishedProductNocBox = new System.Windows.Forms.ComboBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.SpecialRequireTxtBox = new System.Windows.Forms.TextBox();
			this.PackingRequireTxtBox = new System.Windows.Forms.TextBox();
			this.CodingRequireTxtBox = new System.Windows.Forms.TextBox();
			this.TestReportTxtBox = new System.Windows.Forms.TextBox();
			this.LableRequireTxtBox = new System.Windows.Forms.TextBox();
			this.SnMinTxtBox = new System.Windows.Forms.TextBox();
			this.OnlineQuantityTxtBox = new System.Windows.Forms.TextBox();
			this.ProductDaysTxtBox = new System.Windows.Forms.TextBox();
			this.RemarkTxtBox = new System.Windows.Forms.TextBox();
			this.TestSoftConfigFIleTxtBox = new System.Windows.Forms.TextBox();
			this.TypeTxtBox = new System.Windows.Forms.TextBox();
			this.PlanNoTxtBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PlanStorageTimePic = new System.Windows.Forms.DateTimePicker();
			this.PlanOnlineTimePic = new System.Windows.Forms.DateTimePicker();
			this.CustonRequireTimePic = new System.Windows.Forms.DateTimePicker();
			this.OrderDateTimePic = new System.Windows.Forms.DateTimePicker();
			this.lbInfo = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.SnMaxTxtBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label20.ForeColor = System.Drawing.Color.Maroon;
			this.label20.Location = new System.Drawing.Point(16, 386);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(88, 25);
			this.label20.TabIndex = 46;
			this.label20.Text = "管号结束";
			// 
			// ProductTypecBox
			// 
			this.ProductTypecBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ProductTypecBox.FormattingEnabled = true;
			this.ProductTypecBox.Location = new System.Drawing.Point(124, 223);
			this.ProductTypecBox.Name = "ProductTypecBox";
			this.ProductTypecBox.Size = new System.Drawing.Size(312, 33);
			this.ProductTypecBox.TabIndex = 45;
			this.ProductTypecBox.Text = "OP3902D";
			this.ProductTypecBox.SelectedIndexChanged += new System.EventHandler(this.ProductTypecBox_SelectedIndexChanged);
			// 
			// FinishedProductNocBox
			// 
			this.FinishedProductNocBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FinishedProductNocBox.FormattingEnabled = true;
			this.FinishedProductNocBox.Location = new System.Drawing.Point(124, 170);
			this.FinishedProductNocBox.Name = "FinishedProductNocBox";
			this.FinishedProductNocBox.Size = new System.Drawing.Size(312, 33);
			this.FinishedProductNocBox.TabIndex = 44;
			this.FinishedProductNocBox.Text = "3.01.4235";
			this.FinishedProductNocBox.SelectedIndexChanged += new System.EventHandler(this.FinishedProductNocBox_SelectedIndexChanged);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnClear.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.btnClear.Location = new System.Drawing.Point(703, 531);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(206, 89);
			this.btnClear.TabIndex = 43;
			this.btnClear.Text = "界面清除";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnOrder.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.btnOrder.Location = new System.Drawing.Point(472, 531);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(206, 89);
			this.btnOrder.TabIndex = 42;
			this.btnOrder.Text = "下单";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// SpecialRequireTxtBox
			// 
			this.SpecialRequireTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SpecialRequireTxtBox.Location = new System.Drawing.Point(124, 639);
			this.SpecialRequireTxtBox.Name = "SpecialRequireTxtBox";
			this.SpecialRequireTxtBox.Size = new System.Drawing.Size(801, 33);
			this.SpecialRequireTxtBox.TabIndex = 30;
			this.SpecialRequireTxtBox.Text = "特殊要求";
			this.SpecialRequireTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PackingRequireTxtBox
			// 
			this.PackingRequireTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PackingRequireTxtBox.Location = new System.Drawing.Point(124, 586);
			this.PackingRequireTxtBox.Name = "PackingRequireTxtBox";
			this.PackingRequireTxtBox.Size = new System.Drawing.Size(312, 33);
			this.PackingRequireTxtBox.TabIndex = 31;
			this.PackingRequireTxtBox.Text = "包装要求";
			this.PackingRequireTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CodingRequireTxtBox
			// 
			this.CodingRequireTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CodingRequireTxtBox.Location = new System.Drawing.Point(124, 533);
			this.CodingRequireTxtBox.Name = "CodingRequireTxtBox";
			this.CodingRequireTxtBox.Size = new System.Drawing.Size(312, 33);
			this.CodingRequireTxtBox.TabIndex = 32;
			this.CodingRequireTxtBox.Text = "写码要求";
			this.CodingRequireTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TestReportTxtBox
			// 
			this.TestReportTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TestReportTxtBox.Location = new System.Drawing.Point(124, 480);
			this.TestReportTxtBox.Name = "TestReportTxtBox";
			this.TestReportTxtBox.Size = new System.Drawing.Size(312, 33);
			this.TestReportTxtBox.TabIndex = 35;
			this.TestReportTxtBox.Text = "测试报告";
			this.TestReportTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LableRequireTxtBox
			// 
			this.LableRequireTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LableRequireTxtBox.Location = new System.Drawing.Point(124, 427);
			this.LableRequireTxtBox.Name = "LableRequireTxtBox";
			this.LableRequireTxtBox.Size = new System.Drawing.Size(312, 33);
			this.LableRequireTxtBox.TabIndex = 33;
			this.LableRequireTxtBox.Text = "标签要求";
			this.LableRequireTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// SnMinTxtBox
			// 
			this.SnMinTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SnMinTxtBox.Location = new System.Drawing.Point(124, 329);
			this.SnMinTxtBox.Name = "SnMinTxtBox";
			this.SnMinTxtBox.Size = new System.Drawing.Size(312, 33);
			this.SnMinTxtBox.TabIndex = 34;
			this.SnMinTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SnMinTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnMinTxtBox_KeyDown);
			// 
			// OnlineQuantityTxtBox
			// 
			this.OnlineQuantityTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OnlineQuantityTxtBox.Location = new System.Drawing.Point(124, 276);
			this.OnlineQuantityTxtBox.Name = "OnlineQuantityTxtBox";
			this.OnlineQuantityTxtBox.Size = new System.Drawing.Size(312, 33);
			this.OnlineQuantityTxtBox.TabIndex = 41;
			this.OnlineQuantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.OnlineQuantityTxtBox.TextChanged += new System.EventHandler(this.OnlineQuantityTxtBox_TextChanged);
			// 
			// ProductDaysTxtBox
			// 
			this.ProductDaysTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ProductDaysTxtBox.Location = new System.Drawing.Point(636, 264);
			this.ProductDaysTxtBox.Name = "ProductDaysTxtBox";
			this.ProductDaysTxtBox.Size = new System.Drawing.Size(289, 33);
			this.ProductDaysTxtBox.TabIndex = 36;
			this.ProductDaysTxtBox.Text = "4";
			this.ProductDaysTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// RemarkTxtBox
			// 
			this.RemarkTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RemarkTxtBox.Location = new System.Drawing.Point(634, 62);
			this.RemarkTxtBox.Name = "RemarkTxtBox";
			this.RemarkTxtBox.Size = new System.Drawing.Size(291, 33);
			this.RemarkTxtBox.TabIndex = 37;
			this.RemarkTxtBox.Text = "备注";
			this.RemarkTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TestSoftConfigFIleTxtBox
			// 
			this.TestSoftConfigFIleTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TestSoftConfigFIleTxtBox.Location = new System.Drawing.Point(634, 11);
			this.TestSoftConfigFIleTxtBox.Name = "TestSoftConfigFIleTxtBox";
			this.TestSoftConfigFIleTxtBox.Size = new System.Drawing.Size(291, 33);
			this.TestSoftConfigFIleTxtBox.TabIndex = 38;
			this.TestSoftConfigFIleTxtBox.Text = "测试配置文件";
			this.TestSoftConfigFIleTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TypeTxtBox
			// 
			this.TypeTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TypeTxtBox.Location = new System.Drawing.Point(124, 64);
			this.TypeTxtBox.Name = "TypeTxtBox";
			this.TypeTxtBox.Size = new System.Drawing.Size(312, 33);
			this.TypeTxtBox.TabIndex = 39;
			this.TypeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PlanNoTxtBox
			// 
			this.PlanNoTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PlanNoTxtBox.Location = new System.Drawing.Point(124, 117);
			this.PlanNoTxtBox.Name = "PlanNoTxtBox";
			this.PlanNoTxtBox.Size = new System.Drawing.Size(312, 33);
			this.PlanNoTxtBox.TabIndex = 40;
			this.PlanNoTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.PlanNoTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlanNoTxtBox_KeyDown);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label11.ForeColor = System.Drawing.Color.Maroon;
			this.label11.Location = new System.Drawing.Point(13, 651);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 25);
			this.label11.TabIndex = 27;
			this.label11.Text = "特殊要求";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label21.ForeColor = System.Drawing.Color.Maroon;
			this.label21.Location = new System.Drawing.Point(467, 62);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(50, 25);
			this.label21.TabIndex = 25;
			this.label21.Text = "备注";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label18.ForeColor = System.Drawing.Color.Maroon;
			this.label18.Location = new System.Drawing.Point(458, 15);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(164, 25);
			this.label18.TabIndex = 11;
			this.label18.Text = "测试软件配置文件";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label15.ForeColor = System.Drawing.Color.Maroon;
			this.label15.Location = new System.Drawing.Point(458, 117);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(126, 25);
			this.label15.TabIndex = 12;
			this.label15.Text = "客户需求日期";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label14.ForeColor = System.Drawing.Color.Maroon;
			this.label14.Location = new System.Drawing.Point(458, 267);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(88, 25);
			this.label14.TabIndex = 13;
			this.label14.Text = "生产天数";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.ForeColor = System.Drawing.Color.Maroon;
			this.label7.Location = new System.Drawing.Point(13, 439);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 25);
			this.label7.TabIndex = 14;
			this.label7.Text = "标签要求";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label10.ForeColor = System.Drawing.Color.Maroon;
			this.label10.Location = new System.Drawing.Point(13, 598);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 25);
			this.label10.TabIndex = 15;
			this.label10.Text = "包装要求";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label13.ForeColor = System.Drawing.Color.Maroon;
			this.label13.Location = new System.Drawing.Point(458, 217);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(126, 25);
			this.label13.TabIndex = 16;
			this.label13.Text = "计划入库日期";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.ForeColor = System.Drawing.Color.Maroon;
			this.label6.Location = new System.Drawing.Point(13, 333);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 25);
			this.label6.TabIndex = 17;
			this.label6.Text = "管号初始";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.ForeColor = System.Drawing.Color.Maroon;
			this.label9.Location = new System.Drawing.Point(13, 545);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 25);
			this.label9.TabIndex = 18;
			this.label9.Text = "写码要求";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label12.ForeColor = System.Drawing.Color.Maroon;
			this.label12.Location = new System.Drawing.Point(458, 167);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(126, 25);
			this.label12.TabIndex = 26;
			this.label12.Text = "计划上线日期";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Maroon;
			this.label5.Location = new System.Drawing.Point(13, 280);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 25);
			this.label5.TabIndex = 19;
			this.label5.Text = "上线数量";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.ForeColor = System.Drawing.Color.Maroon;
			this.label8.Location = new System.Drawing.Point(13, 492);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 25);
			this.label8.TabIndex = 20;
			this.label8.Text = "测试报告";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.ForeColor = System.Drawing.Color.Maroon;
			this.label4.Location = new System.Drawing.Point(13, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 25);
			this.label4.TabIndex = 21;
			this.label4.Text = "产品型号";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label17.ForeColor = System.Drawing.Color.Maroon;
			this.label17.Location = new System.Drawing.Point(37, 68);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(50, 25);
			this.label17.TabIndex = 22;
			this.label17.Text = "类型";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.Color.Maroon;
			this.label3.Location = new System.Drawing.Point(13, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 25);
			this.label3.TabIndex = 23;
			this.label3.Text = "成品料号";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Maroon;
			this.label2.Location = new System.Drawing.Point(13, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 25);
			this.label2.TabIndex = 24;
			this.label2.Text = "计划单号";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "下单日期";
			// 
			// PlanStorageTimePic
			// 
			this.PlanStorageTimePic.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PlanStorageTimePic.Location = new System.Drawing.Point(636, 215);
			this.PlanStorageTimePic.Name = "PlanStorageTimePic";
			this.PlanStorageTimePic.Size = new System.Drawing.Size(289, 33);
			this.PlanStorageTimePic.TabIndex = 7;
			this.PlanStorageTimePic.ValueChanged += new System.EventHandler(this.PlanStorageTimePic_ValueChanged);
			// 
			// PlanOnlineTimePic
			// 
			this.PlanOnlineTimePic.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PlanOnlineTimePic.Location = new System.Drawing.Point(636, 166);
			this.PlanOnlineTimePic.Name = "PlanOnlineTimePic";
			this.PlanOnlineTimePic.Size = new System.Drawing.Size(289, 33);
			this.PlanOnlineTimePic.TabIndex = 9;
			this.PlanOnlineTimePic.ValueChanged += new System.EventHandler(this.PlanOnlineTimePic_ValueChanged);
			// 
			// CustonRequireTimePic
			// 
			this.CustonRequireTimePic.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CustonRequireTimePic.Location = new System.Drawing.Point(636, 117);
			this.CustonRequireTimePic.Name = "CustonRequireTimePic";
			this.CustonRequireTimePic.Size = new System.Drawing.Size(289, 33);
			this.CustonRequireTimePic.TabIndex = 8;
			this.CustonRequireTimePic.ValueChanged += new System.EventHandler(this.CustomRequireTimePic_ValueChanged);
			// 
			// OrderDateTimePic
			// 
			this.OrderDateTimePic.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OrderDateTimePic.Location = new System.Drawing.Point(124, 11);
			this.OrderDateTimePic.Name = "OrderDateTimePic";
			this.OrderDateTimePic.Size = new System.Drawing.Size(312, 33);
			this.OrderDateTimePic.TabIndex = 6;
			// 
			// lbInfo
			// 
			this.lbInfo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lbInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.lbInfo.Location = new System.Drawing.Point(643, 435);
			this.lbInfo.Name = "lbInfo";
			this.lbInfo.Size = new System.Drawing.Size(291, 38);
			this.lbInfo.TabIndex = 14;
			this.lbInfo.Text = "lbInfo";
			this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label16.ForeColor = System.Drawing.Color.Maroon;
			this.label16.Location = new System.Drawing.Point(476, 442);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 25);
			this.label16.TabIndex = 13;
			this.label16.Text = "订单状态";
			// 
			// SnMaxTxtBox
			// 
			this.SnMaxTxtBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SnMaxTxtBox.Location = new System.Drawing.Point(124, 382);
			this.SnMaxTxtBox.Name = "SnMaxTxtBox";
			this.SnMaxTxtBox.Size = new System.Drawing.Size(312, 33);
			this.SnMaxTxtBox.TabIndex = 41;
			this.SnMaxTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FrmOrderAddOrModify
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(996, 696);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.ProductTypecBox);
			this.Controls.Add(this.FinishedProductNocBox);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.SpecialRequireTxtBox);
			this.Controls.Add(this.PackingRequireTxtBox);
			this.Controls.Add(this.CodingRequireTxtBox);
			this.Controls.Add(this.TestReportTxtBox);
			this.Controls.Add(this.LableRequireTxtBox);
			this.Controls.Add(this.SnMinTxtBox);
			this.Controls.Add(this.SnMaxTxtBox);
			this.Controls.Add(this.OnlineQuantityTxtBox);
			this.Controls.Add(this.ProductDaysTxtBox);
			this.Controls.Add(this.RemarkTxtBox);
			this.Controls.Add(this.TestSoftConfigFIleTxtBox);
			this.Controls.Add(this.TypeTxtBox);
			this.Controls.Add(this.PlanNoTxtBox);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.lbInfo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PlanStorageTimePic);
			this.Controls.Add(this.PlanOnlineTimePic);
			this.Controls.Add(this.CustonRequireTimePic);
			this.Controls.Add(this.OrderDateTimePic);
			this.Name = "FrmOrderAddOrModify";
			this.Text = "订单新增";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox ProductTypecBox;
		private System.Windows.Forms.ComboBox FinishedProductNocBox;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.TextBox SpecialRequireTxtBox;
		private System.Windows.Forms.TextBox PackingRequireTxtBox;
		private System.Windows.Forms.TextBox CodingRequireTxtBox;
		private System.Windows.Forms.TextBox TestReportTxtBox;
		private System.Windows.Forms.TextBox LableRequireTxtBox;
		private System.Windows.Forms.TextBox SnMinTxtBox;
		private System.Windows.Forms.TextBox OnlineQuantityTxtBox;
		private System.Windows.Forms.TextBox ProductDaysTxtBox;
		private System.Windows.Forms.TextBox RemarkTxtBox;
		private System.Windows.Forms.TextBox TestSoftConfigFIleTxtBox;
		private System.Windows.Forms.TextBox TypeTxtBox;
		private System.Windows.Forms.TextBox PlanNoTxtBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker PlanStorageTimePic;
		private System.Windows.Forms.DateTimePicker PlanOnlineTimePic;
		private System.Windows.Forms.DateTimePicker CustonRequireTimePic;
		private System.Windows.Forms.DateTimePicker OrderDateTimePic;
		private System.Windows.Forms.Label lbInfo;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox SnMaxTxtBox;
	}
}