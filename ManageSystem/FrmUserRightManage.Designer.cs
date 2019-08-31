namespace ManageSystem
{
	partial class FrmUserRightManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserRightManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelRole = new System.Windows.Forms.Button();
            this.txtRoleDesc = new System.Windows.Forms.TextBox();
            this.btnEidtRoleName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnUserHasRole = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBoxRoles = new System.Windows.Forms.ListBox();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClearSelect = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnRoleExpand = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.BtnGiveRoleRights = new System.Windows.Forms.Button();
            this.tvRoleRightList = new System.Windows.Forms.TreeView();
            this.cboRoleList = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tvAllRightList = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UserRightsTView = new System.Windows.Forms.TreeView();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUserToSeachRight = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserToSeachRight)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 688);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabPage2.Controls.Add(this.lbInfo);
            this.tabPage2.Controls.Add(this.btnLastPage);
            this.tabPage2.Controls.Add(this.btnPrevPage);
            this.tabPage2.Controls.Add(this.btnNextPage);
            this.tabPage2.Controls.Add(this.btnFirstPage);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ListBoxRoles);
            this.tabPage2.Controls.Add(this.dgvUserList);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "[用户--角色设置]";
            // 
            // lbInfo
            // 
            this.lbInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbInfo.Location = new System.Drawing.Point(401, 442);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(152, 30);
            this.lbInfo.TabIndex = 47;
            this.lbInfo.Text = "分页信息";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnLastPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnLastPage.Location = new System.Drawing.Point(295, 437);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(90, 40);
            this.btnLastPage.TabIndex = 43;
            this.btnLastPage.Text = "最后页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnPrevPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrevPage.Location = new System.Drawing.Point(104, 437);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(90, 40);
            this.btnPrevPage.TabIndex = 44;
            this.btnPrevPage.Text = "前一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextPage.Location = new System.Drawing.Point(197, 437);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(90, 40);
            this.btnNextPage.TabIndex = 45;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnFirstPage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnFirstPage.Location = new System.Drawing.Point(11, 437);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(90, 40);
            this.btnFirstPage.TabIndex = 46;
            this.btnFirstPage.Text = "第一页";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtRoleName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnDelRole);
            this.groupBox3.Controls.Add(this.txtRoleDesc);
            this.groupBox3.Controls.Add(this.btnEidtRoleName);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnAddRole);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(736, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 395);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "角色管理";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "[新角色/修改]名称：";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(10, 56);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(197, 26);
            this.txtRoleName.TabIndex = 32;
            this.txtRoleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "角色描述：";
            // 
            // btnDelRole
            // 
            this.btnDelRole.BackColor = System.Drawing.Color.Gray;
            this.btnDelRole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelRole.ForeColor = System.Drawing.Color.White;
            this.btnDelRole.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRole.Image")));
            this.btnDelRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelRole.Location = new System.Drawing.Point(10, 231);
            this.btnDelRole.Name = "btnDelRole";
            this.btnDelRole.Size = new System.Drawing.Size(91, 45);
            this.btnDelRole.TabIndex = 37;
            this.btnDelRole.Text = "删除角色";
            this.btnDelRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelRole.UseVisualStyleBackColor = false;
            this.btnDelRole.Click += new System.EventHandler(this.btnDelRole_Click);
            // 
            // txtRoleDesc
            // 
            this.txtRoleDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoleDesc.Location = new System.Drawing.Point(10, 118);
            this.txtRoleDesc.Multiline = true;
            this.txtRoleDesc.Name = "txtRoleDesc";
            this.txtRoleDesc.Size = new System.Drawing.Size(197, 95);
            this.txtRoleDesc.TabIndex = 33;
            this.txtRoleDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEidtRoleName
            // 
            this.btnEidtRoleName.BackColor = System.Drawing.Color.Gray;
            this.btnEidtRoleName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEidtRoleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEidtRoleName.ForeColor = System.Drawing.Color.White;
            this.btnEidtRoleName.Image = ((System.Drawing.Image)(resources.GetObject("btnEidtRoleName.Image")));
            this.btnEidtRoleName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEidtRoleName.Location = new System.Drawing.Point(105, 231);
            this.btnEidtRoleName.Name = "btnEidtRoleName";
            this.btnEidtRoleName.Size = new System.Drawing.Size(104, 45);
            this.btnEidtRoleName.TabIndex = 36;
            this.btnEidtRoleName.Text = "修改角色";
            this.btnEidtRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEidtRoleName.UseVisualStyleBackColor = false;
            this.btnEidtRoleName.Click += new System.EventHandler(this.btnEidtRoleName_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(7, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 45);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "清空界面";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.Gray;
            this.btnAddRole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRole.Image")));
            this.btnAddRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.Location = new System.Drawing.Point(105, 310);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(104, 45);
            this.btnAddRole.TabIndex = 35;
            this.btnAddRole.Text = "新增角色";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtUserId);
            this.groupBox2.Controls.Add(this.btnUserHasRole);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(736, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 226);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户角色管理";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(18, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "角色分配会删除以前拥有的";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(22, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "角色列表CTRL多选后确认";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(17, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "用户系统编号：       姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 65);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(102, 26);
            this.txtName.TabIndex = 34;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(21, 65);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(54, 26);
            this.txtUserId.TabIndex = 34;
            this.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUserHasRole
            // 
            this.btnUserHasRole.BackColor = System.Drawing.Color.Gray;
            this.btnUserHasRole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUserHasRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserHasRole.ForeColor = System.Drawing.Color.White;
            this.btnUserHasRole.Image = ((System.Drawing.Image)(resources.GetObject("btnUserHasRole.Image")));
            this.btnUserHasRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserHasRole.Location = new System.Drawing.Point(21, 165);
            this.btnUserHasRole.Name = "btnUserHasRole";
            this.btnUserHasRole.Size = new System.Drawing.Size(161, 45);
            this.btnUserHasRole.TabIndex = 35;
            this.btnUserHasRole.Text = "为用户分配角色";
            this.btnUserHasRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserHasRole.UseVisualStyleBackColor = false;
            this.btnUserHasRole.Click += new System.EventHandler(this.btnUserHasRole_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUserPwd);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnUpdateUser);
            this.groupBox1.Controls.Add(this.btnDelUser);
            this.groupBox1.Controls.Add(this.btnEnable);
            this.groupBox1.Controls.Add(this.btnDisable);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(9, 497);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 149);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户管理";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(10, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "用户姓名：";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(94, 91);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(161, 26);
            this.txtUserPwd.TabIndex = 34;
            this.txtUserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(95, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(161, 26);
            this.txtUserName.TabIndex = 34;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Gray;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(276, 24);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(120, 45);
            this.btnAddUser.TabIndex = 38;
            this.btnAddUser.Text = "新增管理员";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(11, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "用户密码";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Gray;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.Image")));
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(551, 29);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(152, 45);
            this.btnUpdateUser.TabIndex = 36;
            this.btnUpdateUser.Text = "修改用户名和密码";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.BackColor = System.Drawing.Color.Gray;
            this.btnDelUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelUser.ForeColor = System.Drawing.Color.White;
            this.btnDelUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDelUser.Image")));
            this.btnDelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelUser.Location = new System.Drawing.Point(276, 82);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(120, 45);
            this.btnDelUser.TabIndex = 4;
            this.btnDelUser.Text = "删除账号";
            this.btnDelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelUser.UseVisualStyleBackColor = false;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.Gray;
            this.btnEnable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Image = ((System.Drawing.Image)(resources.GetObject("btnEnable.Image")));
            this.btnEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnable.Location = new System.Drawing.Point(415, 28);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(120, 45);
            this.btnEnable.TabIndex = 4;
            this.btnEnable.Text = "启用当前账号";
            this.btnEnable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.Gray;
            this.btnDisable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Image = ((System.Drawing.Image)(resources.GetObject("btnDisable.Image")));
            this.btnDisable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisable.Location = new System.Drawing.Point(415, 82);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(120, 45);
            this.btnDisable.TabIndex = 4;
            this.btnDisable.Text = "禁用当前账号";
            this.btnDisable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(560, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "--系统角色列表--";
            // 
            // ListBoxRoles
            // 
            this.ListBoxRoles.BackColor = System.Drawing.SystemColors.Control;
            this.ListBoxRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxRoles.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListBoxRoles.FormattingEnabled = true;
            this.ListBoxRoles.ItemHeight = 20;
            this.ListBoxRoles.Location = new System.Drawing.Point(564, 37);
            this.ListBoxRoles.Name = "ListBoxRoles";
            this.ListBoxRoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxRoles.Size = new System.Drawing.Size(158, 460);
            this.ListBoxRoles.TabIndex = 24;
            this.ListBoxRoles.SelectedIndexChanged += new System.EventHandler(this.ListBoxRoles_SelectedIndexChanged);
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AllowUserToResizeColumns = false;
            this.dgvUserList.AllowUserToResizeRows = false;
            this.dgvUserList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.ColumnHeadersHeight = 28;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.AdminName,
            this.RoleName,
            this.StatusId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserList.EnableHeadersVisualStyles = false;
            this.dgvUserList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.dgvUserList.Location = new System.Drawing.Point(9, 36);
            this.dgvUserList.MultiSelect = false;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserList.RowHeadersVisible = false;
            this.dgvUserList.RowTemplate.Height = 23;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(547, 388);
            this.dgvUserList.TabIndex = 5;
            this.dgvUserList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUserList_CellFormatting);
            this.dgvUserList.SelectionChanged += new System.EventHandler(this.dgvUserList_SelectionChanged);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "系统编号";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // AdminName
            // 
            this.AdminName.DataPropertyName = "UserName";
            this.AdminName.HeaderText = "姓名";
            this.AdminName.Name = "AdminName";
            this.AdminName.ReadOnly = true;
            this.AdminName.Width = 120;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "UserPwd";
            this.RoleName.HeaderText = "密码";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 150;
            // 
            // StatusId
            // 
            this.StatusId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusId.DataPropertyName = "StatusId";
            this.StatusId.HeaderText = "状态";
            this.StatusId.Name = "StatusId";
            this.StatusId.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "用户列表：";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabPage1.Controls.Add(this.btnClearSelect);
            this.tabPage1.Controls.Add(this.btnCollapse);
            this.tabPage1.Controls.Add(this.btnRoleExpand);
            this.tabPage1.Controls.Add(this.btnExpand);
            this.tabPage1.Controls.Add(this.BtnGiveRoleRights);
            this.tabPage1.Controls.Add(this.tvRoleRightList);
            this.tabPage1.Controls.Add(this.cboRoleList);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tvAllRightList);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "[角色--权限设置]";
            // 
            // btnClearSelect
            // 
            this.btnClearSelect.BackColor = System.Drawing.Color.Gray;
            this.btnClearSelect.ForeColor = System.Drawing.Color.White;
            this.btnClearSelect.Location = new System.Drawing.Point(271, 115);
            this.btnClearSelect.Name = "btnClearSelect";
            this.btnClearSelect.Size = new System.Drawing.Size(140, 42);
            this.btnClearSelect.TabIndex = 28;
            this.btnClearSelect.Text = "清除所有选中";
            this.btnClearSelect.UseVisualStyleBackColor = false;
            this.btnClearSelect.Click += new System.EventHandler(this.btnClearSelect_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.Gray;
            this.btnCollapse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Image = ((System.Drawing.Image)(resources.GetObject("btnCollapse.Image")));
            this.btnCollapse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollapse.Location = new System.Drawing.Point(275, 301);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(136, 36);
            this.btnCollapse.TabIndex = 27;
            this.btnCollapse.Text = "折叠全部权限";
            this.btnCollapse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnRoleExpand
            // 
            this.btnRoleExpand.BackColor = System.Drawing.Color.Gray;
            this.btnRoleExpand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRoleExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleExpand.ForeColor = System.Drawing.Color.White;
            this.btnRoleExpand.Image = ((System.Drawing.Image)(resources.GetObject("btnRoleExpand.Image")));
            this.btnRoleExpand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoleExpand.Location = new System.Drawing.Point(712, 134);
            this.btnRoleExpand.Name = "btnRoleExpand";
            this.btnRoleExpand.Size = new System.Drawing.Size(136, 36);
            this.btnRoleExpand.TabIndex = 27;
            this.btnRoleExpand.Text = "展开全部权限";
            this.btnRoleExpand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoleExpand.UseVisualStyleBackColor = false;
            this.btnRoleExpand.Click += new System.EventHandler(this.btnRoleExpand_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.Gray;
            this.btnExpand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Image = ((System.Drawing.Image)(resources.GetObject("btnExpand.Image")));
            this.btnExpand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpand.Location = new System.Drawing.Point(275, 209);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(136, 36);
            this.btnExpand.TabIndex = 27;
            this.btnExpand.Text = "展开全部权限";
            this.btnExpand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // BtnGiveRoleRights
            // 
            this.BtnGiveRoleRights.BackColor = System.Drawing.Color.Gray;
            this.BtnGiveRoleRights.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGiveRoleRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiveRoleRights.ForeColor = System.Drawing.Color.White;
            this.BtnGiveRoleRights.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiveRoleRights.Image")));
            this.BtnGiveRoleRights.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGiveRoleRights.Location = new System.Drawing.Point(705, 284);
            this.BtnGiveRoleRights.Name = "BtnGiveRoleRights";
            this.BtnGiveRoleRights.Size = new System.Drawing.Size(221, 36);
            this.BtnGiveRoleRights.TabIndex = 27;
            this.BtnGiveRoleRights.Text = "<-为当前角色重新分配权限";
            this.BtnGiveRoleRights.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGiveRoleRights.UseVisualStyleBackColor = false;
            this.BtnGiveRoleRights.Click += new System.EventHandler(this.BtnGiveRoleRights_Click);
            // 
            // tvRoleRightList
            // 
            this.tvRoleRightList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvRoleRightList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvRoleRightList.Location = new System.Drawing.Point(450, 76);
            this.tvRoleRightList.Name = "tvRoleRightList";
            this.tvRoleRightList.Size = new System.Drawing.Size(223, 569);
            this.tvRoleRightList.TabIndex = 23;
            this.tvRoleRightList.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvRoleRightList_AfterCheck);
            // 
            // cboRoleList
            // 
            this.cboRoleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoleList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRoleList.FormattingEnabled = true;
            this.cboRoleList.Location = new System.Drawing.Point(450, 37);
            this.cboRoleList.Name = "cboRoleList";
            this.cboRoleList.Size = new System.Drawing.Size(221, 28);
            this.cboRoleList.TabIndex = 0;
            this.cboRoleList.SelectedIndexChanged += new System.EventHandler(this.cboRoleList_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(708, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "请勾选左侧权限树然后确认：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择角色查询权限：";
            // 
            // tvAllRightList
            // 
            this.tvAllRightList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvAllRightList.CheckBoxes = true;
            this.tvAllRightList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvAllRightList.FullRowSelect = true;
            this.tvAllRightList.Location = new System.Drawing.Point(15, 43);
            this.tvAllRightList.Name = "tvAllRightList";
            this.tvAllRightList.Size = new System.Drawing.Size(230, 603);
            this.tvAllRightList.TabIndex = 23;
            this.tvAllRightList.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvAllRightList_AfterCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(47, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "----系统全部权限列表-----\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabPage3.Controls.Add(this.UserRightsTView);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dgvUserToSeachRight);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(960, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "用户-权限查询";
            // 
            // UserRightsTView
            // 
            this.UserRightsTView.Location = new System.Drawing.Point(597, 33);
            this.UserRightsTView.Name = "UserRightsTView";
            this.UserRightsTView.Size = new System.Drawing.Size(203, 591);
            this.UserRightsTView.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(593, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "----用户对应的权限列表-----\r\n";
            // 
            // dgvUserToSeachRight
            // 
            this.dgvUserToSeachRight.AllowUserToAddRows = false;
            this.dgvUserToSeachRight.AllowUserToDeleteRows = false;
            this.dgvUserToSeachRight.AllowUserToResizeColumns = false;
            this.dgvUserToSeachRight.AllowUserToResizeRows = false;
            this.dgvUserToSeachRight.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUserToSeachRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserToSeachRight.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserToSeachRight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserToSeachRight.ColumnHeadersHeight = 28;
            this.dgvUserToSeachRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.UserState});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserToSeachRight.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserToSeachRight.EnableHeadersVisualStyles = false;
            this.dgvUserToSeachRight.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.dgvUserToSeachRight.Location = new System.Drawing.Point(30, 33);
            this.dgvUserToSeachRight.MultiSelect = false;
            this.dgvUserToSeachRight.Name = "dgvUserToSeachRight";
            this.dgvUserToSeachRight.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserToSeachRight.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserToSeachRight.RowHeadersVisible = false;
            this.dgvUserToSeachRight.RowTemplate.Height = 23;
            this.dgvUserToSeachRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserToSeachRight.Size = new System.Drawing.Size(547, 591);
            this.dgvUserToSeachRight.TabIndex = 7;
            this.dgvUserToSeachRight.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvUserToSeachRight_CellFormatting);
            this.dgvUserToSeachRight.SelectionChanged += new System.EventHandler(this.dgvUserToSeachRight_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn1.HeaderText = "系统编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserPwd";
            this.dataGridViewTextBoxColumn3.HeaderText = "密码";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // UserState
            // 
            this.UserState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserState.DataPropertyName = "StatusId";
            this.UserState.HeaderText = "状态";
            this.UserState.Name = "UserState";
            this.UserState.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(26, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "用户列表：";
            // 
            // FrmUserRightManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 712);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmUserRightManage";
            this.Text = "高级权限管理系统";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserToSeachRight)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dgvUserList;
		private System.Windows.Forms.Button btnEnable;
		private System.Windows.Forms.Button btnDelUser;
		private System.Windows.Forms.Button btnDisable;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnCollapse;
		private System.Windows.Forms.Button btnExpand;
		private System.Windows.Forms.Button BtnGiveRoleRights;
		private System.Windows.Forms.TreeView tvRoleRightList;
		private System.Windows.Forms.ComboBox cboRoleList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView tvAllRightList;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnDelRole;
		private System.Windows.Forms.Button btnAddRole;
		private System.Windows.Forms.TextBox txtRoleDesc;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtRoleName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox ListBoxRoles;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtUserPwd;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnEidtRoleName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.Button btnUserHasRole;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dgvUserToSeachRight;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnUpdateUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
		private System.Windows.Forms.DataGridViewTextBoxColumn AdminName;
		private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn StatusId;
		private System.Windows.Forms.Label lbInfo;
		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnRoleExpand;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnClearSelect;
		private System.Windows.Forms.TreeView UserRightsTView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserState;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label14;
	}
}