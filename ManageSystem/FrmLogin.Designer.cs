namespace ManageSystem
{
	partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtnLogin = new System.Windows.Forms.RadioButton();
            this.rBtnRegist = new System.Windows.Forms.RadioButton();
            this.lbPwdConfirm = new System.Windows.Forms.Label();
            this.txtUserPwdConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(575, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 55);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "退  出";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(433, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 52);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "登  录";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPwd.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.txtUserPwd.Location = new System.Drawing.Point(575, 126);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(184, 34);
            this.txtUserPwd.TabIndex = 15;
            this.txtUserPwd.Text = "zhouhang";
            this.txtUserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserPwd_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.txtUserName.Location = new System.Drawing.Point(575, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 34);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.Text = "周沆";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(439, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "登录密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(439, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "登录账号：";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(27, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 323);
            this.panel1.TabIndex = 18;
            // 
            // rBtnLogin
            // 
            this.rBtnLogin.AutoSize = true;
            this.rBtnLogin.Checked = true;
            this.rBtnLogin.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.rBtnLogin.Location = new System.Drawing.Point(442, 245);
            this.rBtnLogin.Name = "rBtnLogin";
            this.rBtnLogin.Size = new System.Drawing.Size(66, 25);
            this.rBtnLogin.TabIndex = 19;
            this.rBtnLogin.TabStop = true;
            this.rBtnLogin.Text = "登录";
            this.rBtnLogin.UseVisualStyleBackColor = true;
            this.rBtnLogin.CheckedChanged += new System.EventHandler(this.RBtnLogin_CheckedChanged);
            // 
            // rBtnRegist
            // 
            this.rBtnRegist.AutoSize = true;
            this.rBtnRegist.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.rBtnRegist.Location = new System.Drawing.Point(575, 245);
            this.rBtnRegist.Name = "rBtnRegist";
            this.rBtnRegist.Size = new System.Drawing.Size(66, 25);
            this.rBtnRegist.TabIndex = 20;
            this.rBtnRegist.Text = "注册";
            this.rBtnRegist.UseVisualStyleBackColor = true;
            this.rBtnRegist.CheckedChanged += new System.EventHandler(this.RBtnLogin_CheckedChanged);
            // 
            // lbPwdConfirm
            // 
            this.lbPwdConfirm.AutoSize = true;
            this.lbPwdConfirm.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.lbPwdConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.lbPwdConfirm.Location = new System.Drawing.Point(439, 189);
            this.lbPwdConfirm.Name = "lbPwdConfirm";
            this.lbPwdConfirm.Size = new System.Drawing.Size(105, 21);
            this.lbPwdConfirm.TabIndex = 13;
            this.lbPwdConfirm.Text = "确认密码：";
            this.lbPwdConfirm.Visible = false;
            // 
            // txtUserPwdConfirm
            // 
            this.txtUserPwdConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPwdConfirm.Font = new System.Drawing.Font("华文细黑", 14.25F);
            this.txtUserPwdConfirm.Location = new System.Drawing.Point(575, 182);
            this.txtUserPwdConfirm.Name = "txtUserPwdConfirm";
            this.txtUserPwdConfirm.PasswordChar = '*';
            this.txtUserPwdConfirm.Size = new System.Drawing.Size(184, 34);
            this.txtUserPwdConfirm.TabIndex = 15;
            this.txtUserPwdConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserPwdConfirm.Visible = false;
            this.txtUserPwdConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserPwd_KeyDown);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBtnRegist);
            this.Controls.Add(this.rBtnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserPwdConfirm);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbPwdConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtUserPwd;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtnLogin;
        private System.Windows.Forms.RadioButton rBtnRegist;
        private System.Windows.Forms.Label lbPwdConfirm;
        private System.Windows.Forms.TextBox txtUserPwdConfirm;
    }
}