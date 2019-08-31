namespace ManageSystem
{
	partial class DBDataSearch
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
			this.cbx_TakeLastSN = new System.Windows.Forms.CheckBox();
			this.rdoTest = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.rdodebug = new System.Windows.Forms.RadioButton();
			this.tb_SN_Last = new System.Windows.Forms.TextBox();
			this.tb_SN_Init = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.listLost = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chb_lost = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_Result = new System.Windows.Forms.ComboBox();
			this.chb_Result = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tb_Result = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btnSearchStart = new System.Windows.Forms.Button();
			this.txtcount = new System.Windows.Forms.Label();
			this.dgvOPWAYData = new System.Windows.Forms.DataGridView();
			this.chb_dgv = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOPWAYData)).BeginInit();
			this.SuspendLayout();
			// 
			// cbx_TakeLastSN
			// 
			this.cbx_TakeLastSN.AutoSize = true;
			this.cbx_TakeLastSN.Checked = true;
			this.cbx_TakeLastSN.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbx_TakeLastSN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cbx_TakeLastSN.Location = new System.Drawing.Point(12, 43);
			this.cbx_TakeLastSN.Name = "cbx_TakeLastSN";
			this.cbx_TakeLastSN.Size = new System.Drawing.Size(445, 25);
			this.cbx_TakeLastSN.TabIndex = 27;
			this.cbx_TakeLastSN.Text = "取模块测试最后一次结果为准，成功为通过，失败为未通过";
			this.cbx_TakeLastSN.UseVisualStyleBackColor = true;
			// 
			// rdoTest
			// 
			this.rdoTest.AutoSize = true;
			this.rdoTest.Checked = true;
			this.rdoTest.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.rdoTest.Location = new System.Drawing.Point(120, 136);
			this.rdoTest.Name = "rdoTest";
			this.rdoTest.Size = new System.Drawing.Size(92, 25);
			this.rdoTest.TabIndex = 25;
			this.rdoTest.TabStop = true;
			this.rdoTest.Text = "测试数据";
			this.rdoTest.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(516, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 24;
			this.label1.Text = "结束SN";
			// 
			// rdodebug
			// 
			this.rdodebug.AutoSize = true;
			this.rdodebug.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.rdodebug.Location = new System.Drawing.Point(8, 136);
			this.rdodebug.Name = "rdodebug";
			this.rdodebug.Size = new System.Drawing.Size(92, 25);
			this.rdodebug.TabIndex = 26;
			this.rdodebug.Text = "调试数据";
			this.rdodebug.UseVisualStyleBackColor = true;
			// 
			// tb_SN_Last
			// 
			this.tb_SN_Last.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tb_SN_Last.Location = new System.Drawing.Point(467, 140);
			this.tb_SN_Last.Name = "tb_SN_Last";
			this.tb_SN_Last.Size = new System.Drawing.Size(187, 29);
			this.tb_SN_Last.TabIndex = 23;
			this.tb_SN_Last.Text = "FT19071102000";
			this.tb_SN_Last.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_SN_Init
			// 
			this.tb_SN_Init.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tb_SN_Init.Location = new System.Drawing.Point(469, 65);
			this.tb_SN_Init.Name = "tb_SN_Init";
			this.tb_SN_Init.Size = new System.Drawing.Size(182, 29);
			this.tb_SN_Init.TabIndex = 22;
			this.tb_SN_Init.Text = "FT19071100001";
			this.tb_SN_Init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_SN_Init.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SN_KeyDown);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSearch.ForeColor = System.Drawing.Color.Maroon;
			this.btnSearch.Location = new System.Drawing.Point(704, 659);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(237, 40);
			this.btnSearch.TabIndex = 28;
			this.btnSearch.Text = "遗漏管号列表一键查询";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.Color.Maroon;
			this.label3.Location = new System.Drawing.Point(702, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 21);
			this.label3.TabIndex = 30;
			this.label3.Text = "遗漏管号列表";
			// 
			// listLost
			// 
			this.listLost.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listLost.FormattingEnabled = true;
			this.listLost.ItemHeight = 25;
			this.listLost.Location = new System.Drawing.Point(702, 221);
			this.listLost.Name = "listLost";
			this.listLost.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listLost.Size = new System.Drawing.Size(239, 429);
			this.listLost.TabIndex = 29;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chb_lost);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cb_Result);
			this.groupBox1.Controls.Add(this.chb_Result);
			this.groupBox1.Controls.Add(this.tb_SN_Init);
			this.groupBox1.Controls.Add(this.tb_SN_Last);
			this.groupBox1.Controls.Add(this.rdodebug);
			this.groupBox1.Controls.Add(this.cbx_TakeLastSN);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.rdoTest);
			this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
			this.groupBox1.Location = new System.Drawing.Point(7, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(662, 180);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "数据查询条件";
			// 
			// chb_lost
			// 
			this.chb_lost.AutoSize = true;
			this.chb_lost.Checked = true;
			this.chb_lost.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chb_lost.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.chb_lost.Location = new System.Drawing.Point(251, 93);
			this.chb_lost.Name = "chb_lost";
			this.chb_lost.Size = new System.Drawing.Size(157, 25);
			this.chb_lost.TabIndex = 34;
			this.chb_lost.Text = "遗漏管号查询开启";
			this.chb_lost.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(463, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(188, 21);
			this.label2.TabIndex = 33;
			this.label2.Text = "起始SN(查询范围默认50)";
			// 
			// cb_Result
			// 
			this.cb_Result.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cb_Result.FormattingEnabled = true;
			this.cb_Result.Items.AddRange(new object[] {
            "PASS",
            "FAIL",
            "手动输入"});
			this.cb_Result.Location = new System.Drawing.Point(111, 89);
			this.cb_Result.Name = "cb_Result";
			this.cb_Result.Size = new System.Drawing.Size(66, 29);
			this.cb_Result.TabIndex = 29;
			this.cb_Result.Text = "PASS";
			// 
			// chb_Result
			// 
			this.chb_Result.AutoSize = true;
			this.chb_Result.Checked = true;
			this.chb_Result.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chb_Result.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.chb_Result.Location = new System.Drawing.Point(12, 92);
			this.chb_Result.Name = "chb_Result";
			this.chb_Result.Size = new System.Drawing.Size(93, 25);
			this.chb_Result.TabIndex = 28;
			this.chb_Result.Text = "测试结果";
			this.chb_Result.UseVisualStyleBackColor = true;
			this.chb_Result.CheckedChanged += new System.EventHandler(this.chb_Result_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.tb_Result);
			this.groupBox5.Controls.Add(this.label13);
			this.groupBox5.Controls.Add(this.btnSearchStart);
			this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox5.ForeColor = System.Drawing.Color.Maroon;
			this.groupBox5.Location = new System.Drawing.Point(675, 1);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(266, 180);
			this.groupBox5.TabIndex = 32;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "查询结果";
			// 
			// tb_Result
			// 
			this.tb_Result.Location = new System.Drawing.Point(147, 50);
			this.tb_Result.Name = "tb_Result";
			this.tb_Result.Size = new System.Drawing.Size(107, 33);
			this.tb_Result.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.Color.Green;
			this.label13.Location = new System.Drawing.Point(8, 54);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(131, 25);
			this.label13.TabIndex = 0;
			this.label13.Text = "符合条件个数:";
			// 
			// btnSearchStart
			// 
			this.btnSearchStart.Location = new System.Drawing.Point(11, 110);
			this.btnSearchStart.Name = "btnSearchStart";
			this.btnSearchStart.Size = new System.Drawing.Size(243, 40);
			this.btnSearchStart.TabIndex = 6;
			this.btnSearchStart.Text = "查询";
			this.btnSearchStart.UseVisualStyleBackColor = true;
			this.btnSearchStart.Click += new System.EventHandler(this.btnSearchStart_Click);
			// 
			// txtcount
			// 
			this.txtcount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtcount.Location = new System.Drawing.Point(835, 197);
			this.txtcount.Name = "txtcount";
			this.txtcount.Size = new System.Drawing.Size(78, 20);
			this.txtcount.TabIndex = 33;
			this.txtcount.Text = "txtcount";
			// 
			// dgvOPWAYData
			// 
			this.dgvOPWAYData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOPWAYData.Location = new System.Drawing.Point(7, 221);
			this.dgvOPWAYData.Name = "dgvOPWAYData";
			this.dgvOPWAYData.RowTemplate.Height = 23;
			this.dgvOPWAYData.Size = new System.Drawing.Size(662, 479);
			this.dgvOPWAYData.TabIndex = 34;
			// 
			// chb_dgv
			// 
			this.chb_dgv.AutoSize = true;
			this.chb_dgv.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.chb_dgv.ForeColor = System.Drawing.Color.Red;
			this.chb_dgv.Location = new System.Drawing.Point(12, 189);
			this.chb_dgv.Name = "chb_dgv";
			this.chb_dgv.Size = new System.Drawing.Size(407, 25);
			this.chb_dgv.TabIndex = 28;
			this.chb_dgv.Text = "表格展示(一般不要勾选、耗费数据库性能，除非导表)";
			this.chb_dgv.UseVisualStyleBackColor = true;
			this.chb_dgv.CheckedChanged += new System.EventHandler(this.chb_Result_CheckedChanged);
			// 
			// DBDataSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(996, 712);
			this.Controls.Add(this.dgvOPWAYData);
			this.Controls.Add(this.txtcount);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.chb_dgv);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listLost);
			this.Controls.Add(this.btnSearch);
			this.Name = "DBDataSearch";
			this.Text = "数据查询核对";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOPWAYData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbx_TakeLastSN;
		private System.Windows.Forms.RadioButton rdoTest;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdodebug;
		private System.Windows.Forms.TextBox tb_SN_Last;
		private System.Windows.Forms.TextBox tb_SN_Init;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listLost;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cb_Result;
		private System.Windows.Forms.CheckBox chb_Result;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox tb_Result;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnSearchStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chb_lost;
		private System.Windows.Forms.Label txtcount;
		private System.Windows.Forms.DataGridView dgvOPWAYData;
		private System.Windows.Forms.CheckBox chb_dgv;
	}
}