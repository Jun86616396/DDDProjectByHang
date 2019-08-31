using System;
using System.Linq;
using System.Windows.Forms;
using DDD.Application.DTO.User;
using DDD.Application.Interfaces;
using DDD.Domain.Enum;
using DDD.Domain.Notifications;
using Infra.IoC.AutoFac;
using Infra.Utility;
using MediatR;

namespace ManageSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            //实例化单例容器
            AutofacContainer.GetInstance();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var name = this.txtUserName.Text.Trim();
            var pwd = this.txtUserPwd.Text.Trim();
            var confirmPwd = this.txtUserPwdConfirm.Text.Trim();


            if (rBtnLogin.Checked)
            {
                if (name.Length == 0)
                {
                    MessageBox.Show("请输入登录账号！", "登录提示");
                    this.txtUserName.Focus();
                    return;
                }

                if (pwd.Length == 0)
                {
                    MessageBox.Show("请输入登录密码！", "登录提示");
                    this.txtUserPwd.Focus();
                    return;
                }

                //封装DTO对象
                UserDto objUser = new UserDto()
                {
                    UserName = name,

                    UserPwd = pwd
                };

                Login(objUser);
            }
            else
            {

                Register(new UserRegisterDto()
                {
                    UserName = name,
                    UserPwd = pwd,
                    UserConfirmPwd = confirmPwd
                });

            }

        }

        private void Login(UserDto objUser)
        {

            LogHelper.WriteLog($"btnLogin_Click{ objUser.UserName} {objUser.UserPwd}");

            try
            {

                var loginService = AutofacContainer.GetInstance().GetObject<IUserService>();

                //调用数据访问 判断账户
                LoginOutput loginResult = loginService.UserLogin(objUser);

                if (loginResult != null)
                {
                    if (loginResult.StatusId == 1) //状态正常  
                    {
                        Program.objCurrentLoginUser = loginResult; //保存当前对象

                        this.DialogResult = DialogResult.OK;  //设置窗体返回值

                        this.Close();  //窗体关掉  对象是没有清除的   窗体关掉和窗体清除是两回事。
                        //this.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("当前登录账号被禁用，请联系管理员");
                    }
                }
                else
                {
                    MessageBox.Show("登录账户或者密码错误！");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("登录出现异常" + ex.Message);
            }
        }

        private void Register(UserRegisterDto registerDto)
        {
            try
            {

                var loginService = AutofacContainer.GetInstance().GetObject<IUserService>();
                var notifications = AutofacContainer.GetInstance().GetObject<INotificationHandler<DomainNotification>>();
                // 强类型转换
                var _notifications = (DomainNotificationHandler)notifications;

                loginService.UserRegister(registerDto);

                var notifyList = _notifications.GetNotifications();

                var list = notifyList.Where(o => o.Key == "success").ToList();

                if (list.Count > 0)
                {
                    var str = string.Join("  ", list.Select(o => o.Value).ToList());
                    MessageBox.Show(str);

                    rBtnLogin.Checked = true;
                    this.lbPwdConfirm.Visible = false;
                    this.txtUserPwdConfirm.Visible = false;
                    this.btnLogin.Text = "登录";


                }
                else
                {
                    var str = string.Join("  ", notifyList.Select(o => o.Value).ToList());
                    MessageBox.Show(str);
                }

                //清空领域通知
                _notifications.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void RBtnLogin_CheckedChanged(object sender, EventArgs e)
        {

            var radioButton = (RadioButton)sender;
            if (radioButton.Checked == false) return;


            if (rBtnLogin.Checked)
            {
                this.lbPwdConfirm.Visible = false;
                this.txtUserPwdConfirm.Visible = false;
                this.btnLogin.Text = "登录";
            }
            //部分领料
            else
            {
                this.lbPwdConfirm.Visible = true;
                this.txtUserPwdConfirm.Visible = true;
                this.btnLogin.Text = "注册";
            }
        }
    }
}
