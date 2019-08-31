namespace ManageSystem
{
	partial class FrmNavigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNavigation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnCollectionMaterials = new System.Windows.Forms.Button();
            this.btnAssemble = new System.Windows.Forms.Button();
            this.btnGatherSearch = new System.Windows.Forms.Button();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.lblOperationName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEveryDay = new System.Windows.Forms.Button();
            this.btnOrderEdit = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDBSearch = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登陆信息";
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.lbUserName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbUserName.Location = new System.Drawing.Point(130, 57);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(110, 31);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "lbUserName";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddOrder.Location = new System.Drawing.Point(7, 36);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(130, 60);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "1.下单";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnCollectionMaterials
            // 
            this.btnCollectionMaterials.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCollectionMaterials.Location = new System.Drawing.Point(7, 110);
            this.btnCollectionMaterials.Name = "btnCollectionMaterials";
            this.btnCollectionMaterials.Size = new System.Drawing.Size(130, 60);
            this.btnCollectionMaterials.TabIndex = 0;
            this.btnCollectionMaterials.Text = "3.领料";
            this.btnCollectionMaterials.UseVisualStyleBackColor = true;
            this.btnCollectionMaterials.Click += new System.EventHandler(this.btnCollectionMaterials_Click);
            // 
            // btnAssemble
            // 
            this.btnAssemble.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAssemble.Location = new System.Drawing.Point(153, 110);
            this.btnAssemble.Name = "btnAssemble";
            this.btnAssemble.Size = new System.Drawing.Size(130, 60);
            this.btnAssemble.TabIndex = 0;
            this.btnAssemble.Text = "4.组装";
            this.btnAssemble.UseVisualStyleBackColor = true;
            this.btnAssemble.Click += new System.EventHandler(this.btnAssemble_Click);
            // 
            // btnGatherSearch
            // 
            this.btnGatherSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGatherSearch.Location = new System.Drawing.Point(11, 268);
            this.btnGatherSearch.Name = "btnGatherSearch";
            this.btnGatherSearch.Size = new System.Drawing.Size(270, 60);
            this.btnGatherSearch.TabIndex = 0;
            this.btnGatherSearch.Text = "订单综合查询";
            this.btnGatherSearch.UseVisualStyleBackColor = true;
            this.btnGatherSearch.Click += new System.EventHandler(this.btnGatherSearch_Click);
            // 
            // spContainer
            // 
            this.spContainer.Location = new System.Drawing.Point(-2, 2);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.lblOperationName);
            this.spContainer.Panel1.Controls.Add(this.groupBox1);
            this.spContainer.Panel1.Controls.Add(this.groupBox2);
            this.spContainer.Size = new System.Drawing.Size(1293, 725);
            this.spContainer.SplitterDistance = 300;
            this.spContainer.TabIndex = 4;
            // 
            // lblOperationName
            // 
            this.lblOperationName.Font = new System.Drawing.Font("微软雅黑 Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOperationName.ForeColor = System.Drawing.Color.Maroon;
            this.lblOperationName.Location = new System.Drawing.Point(23, 10);
            this.lblOperationName.Name = "lblOperationName";
            this.lblOperationName.Size = new System.Drawing.Size(220, 49);
            this.lblOperationName.TabIndex = 4;
            this.lblOperationName.Text = "欢迎使用";
            this.lblOperationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEveryDay);
            this.groupBox2.Controls.Add(this.btnOrderEdit);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Controls.Add(this.btnDBSearch);
            this.groupBox2.Controls.Add(this.btnGatherSearch);
            this.groupBox2.Controls.Add(this.btnAddOrder);
            this.groupBox2.Controls.Add(this.btnStorage);
            this.groupBox2.Controls.Add(this.btnCollectionMaterials);
            this.groupBox2.Controls.Add(this.btnAssemble);
            this.groupBox2.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(3, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 503);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户拥有权限";
            // 
            // btnEveryDay
            // 
            this.btnEveryDay.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEveryDay.Location = new System.Drawing.Point(152, 193);
            this.btnEveryDay.Name = "btnEveryDay";
            this.btnEveryDay.Size = new System.Drawing.Size(130, 60);
            this.btnEveryDay.TabIndex = 2;
            this.btnEveryDay.Text = "6.每日完成";
            this.btnEveryDay.UseVisualStyleBackColor = true;
            this.btnEveryDay.Click += new System.EventHandler(this.BtnEveryDay_Click);
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnOrderEdit.Location = new System.Drawing.Point(153, 36);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(130, 60);
            this.btnOrderEdit.TabIndex = 1;
            this.btnOrderEdit.Text = "2.所有订单";
            this.btnOrderEdit.UseVisualStyleBackColor = true;
            this.btnOrderEdit.Click += new System.EventHandler(this.BtnOrderEdit_Click);
            // 
            // btnRight
            // 
            this.btnRight.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnRight.Location = new System.Drawing.Point(11, 416);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(270, 60);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "用户角色权限管理系统";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDBSearch
            // 
            this.btnDBSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDBSearch.Location = new System.Drawing.Point(11, 342);
            this.btnDBSearch.Name = "btnDBSearch";
            this.btnDBSearch.Size = new System.Drawing.Size(270, 60);
            this.btnDBSearch.TabIndex = 0;
            this.btnDBSearch.Text = "数据库查询";
            this.btnDBSearch.UseVisualStyleBackColor = true;
            this.btnDBSearch.Click += new System.EventHandler(this.btnDBSearch_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnStorage.Location = new System.Drawing.Point(7, 193);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(130, 60);
            this.btnStorage.TabIndex = 0;
            this.btnStorage.Text = "5.入库";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // FrmNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 729);
            this.Controls.Add(this.spContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "流程管理系统";
            this.groupBox1.ResumeLayout(false);
            this.spContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbUserName;
		private System.Windows.Forms.Button btnGatherSearch;
		private System.Windows.Forms.Button btnAssemble;
		private System.Windows.Forms.Button btnCollectionMaterials;
		private System.Windows.Forms.Button btnAddOrder;
		private System.Windows.Forms.Label lblOperationName;
		private System.Windows.Forms.SplitContainer spContainer;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnStorage;
		private System.Windows.Forms.Button btnDBSearch;
        private System.Windows.Forms.Button btnOrderEdit;
        private System.Windows.Forms.Button btnEveryDay;
    }
}