using DDD.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDD.Application.DTO.Right;
using DDD.Application.DTO.Role;
using DDD.Application.DTO.User;
using DDD.Application.Interfaces;
   
using Infra.EF.Repository;
using Infra.IoC.AutoFac;
using Infra.Utility;

namespace ManageSystem
{
    public partial class FrmUserRightManage : Form
    {
        public FrmUserRightManage()
        {
            InitializeComponent();

            //设置控制使能
            SetUserControl(Program.objCurrentLoginUser);

            //用户列表 
            this.dgvUserList.AutoGenerateColumns = false;
            this.dgvUserList.DataSource = _dgvBindingSource;

            this.dgvUserToSeachRight.AutoGenerateColumns = false;

            //角色列表
            this.ListBoxRoles.DisplayMember = "RoleName";
            this.ListBoxRoles.ValueMember = "RoleId";

            //角色权限里面的角色列表
            this.cboRoleList.DisplayMember = "RoleName";
            this.cboRoleList.ValueMember = "RoleId";


            //异步加载  角色列表
            AsyncLoadData_RoleList();

            //多线程加载  用户列表
            MultiThreadingBindingUserData(1);

            //异步加载   权限列表
            AsyncLoadData_RightList();
        }

        //所有的权限项  用于形成树形菜单
        List<RightDto> rightList;

        //角色对应权限的一级目录表
        List<RightDto> firstMenuRightList;

        /// <summary>
        /// 设置是否能使用相关功能
        /// </summary>
        /// <param name="loginUser"></param>
        private void SetUserControl(LoginOutput loginUser)
        {
            var userRights = loginUser.UserRightList;


            this.btnAddUser.Enabled = userRights.FirstOrDefault(o => o.RightName == "用户新增") != null;

            this.btnUpdateUser.Enabled = userRights.FirstOrDefault(o => o.RightName == "用户修改") != null;

            this.btnDelUser.Enabled = userRights.FirstOrDefault(o => o.RightName == "用户删除") != null;

            this.btnAddRole.Enabled = userRights.FirstOrDefault(o => o.RightName == "角色新增") != null;

            this.btnEidtRoleName.Enabled = userRights.FirstOrDefault(o => o.RightName == "角色修改") != null;

            this.btnDelRole.Enabled = userRights.FirstOrDefault(o => o.RightName == "角色删除") != null;

            this.btnUserHasRole.Enabled = userRights.FirstOrDefault(o => o.RightName == "为用户分配角色") != null;

            this.BtnGiveRoleRights.Enabled = userRights.FirstOrDefault(o => o.RightName == "为角色分配权限") != null;

        }


        //使用BindingSource组件
        readonly BindingSource _dgvBindingSource = new BindingSource();

        //当前分页页码  
        private int _currentPage = 1;

        private const int PageSize = 18;

        //分多少页
        private int _pageCount = 0;

        #region 分页

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            _currentPage = 1;

            MultiThreadingBindingUserData(_currentPage);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
                _currentPage--;
            else
                return;
            MultiThreadingBindingUserData(_currentPage);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage == _pageCount)
                return;
            _currentPage++;

            MultiThreadingBindingUserData(_currentPage);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            _currentPage = _pageCount;
            MultiThreadingBindingUserData(_currentPage);
        }

        #endregion
        private void MultiThreadingBindingUserData(int pageIndex)
        {
            //绑定数据源时会触发SelectionChanged
            dgvUserList.SelectionChanged -= dgvUserList_SelectionChanged;

            Task.Factory.StartNew(() => LoadData(pageIndex))
                .ContinueWith(preTask =>
                {
                    _dgvBindingSource.DataSource = preTask.Result;
                    //此句位置很重要  会触发SelectionChanged
                    this.dgvUserList.ClearSelection();
                    dgvUserList.SelectionChanged += dgvUserList_SelectionChanged;

                    this.lbInfo.Text = $"第{_currentPage}页/共{_pageCount}页 ";
                },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>
        /// 从数据库获取分页的数据
        /// </summary>
        /// <param name="pageIndex"> 哪一页的数据</param>
        /// <returns></returns>
        private BindingList<UserDto> LoadData(int pageIndex)
        {
            var userService = AutofacContainer.GetInstance().GetObject<IUserService>();

            var result = userService.GetUserList(pageIndex, PageSize);

            var totalCount = result.TotalCount;
            //分页数量
            _pageCount = (int)(totalCount % PageSize == 0 ? totalCount / PageSize : (totalCount / PageSize) + 1);

            _currentPage = _pageCount == 0 ? 0 : pageIndex;

            return result.CurrentPageData;

        }


        /// <summary>
        /// 异步加载所有角色
        /// </summary>
        /// <returns></returns>
        private async Task<BindingList<RoleDto>> LoadRoles()
        {
            var roleService = AutofacContainer.GetInstance().GetObject<IRoleService>();
            return await roleService.GetRoleList();
        }


        /// <summary>
        ///装载所有权限
        /// </summary>
        /// <returns></returns>
        private async Task<List<RightDto>> LoadRights()
        {
            var rightService = AutofacContainer.GetInstance().GetObject<IRightService>();
            return await rightService.GetRightList();
        }

        /// <summary>
        /// 装载角色列表
        /// </summary>
        private async void AsyncLoadData_RoleList()
        {
            BindingList<RoleDto> roleList = await LoadRoles();

            this.cboRoleList.DataSource = roleList;

            this.ListBoxRoles.DataSource = roleList;

            //消除默认选中事件
            btnClear_Click(null, null);

        }

        /// <summary>
        /// 装载权限列表  渲染TreeView控件
        /// </summary>
        private async void AsyncLoadData_RightList()
        {
            //所有的权限项
            rightList = await LoadRights();

            firstMenuRightList = rightList.Where(o => o.PID == 0).ToList();

            //创建根节点
            this.tvAllRightList.Nodes.Clear();//清空节点
            TreeNode rootNode = new TreeNode() { Text = "权限设置系统", ForeColor = Color.Gold, Tag = 1 };
            this.tvAllRightList.Nodes.Add(rootNode);

            //查找一级节点  在数据中PID==0
            CreateChildNode(rootNode, 0, this.rightList);

            this.tvAllRightList.Nodes[0].Expand();//展开一级菜单    //this.tvAllRightList.ExpandAll();//展开所有菜单


        }


        #region  递归创建节点树
        //递归创建节点
        private void CreateChildNode(TreeNode parentNode, int parentId, List<RightDto> searchList)
        {
            //找到该节点下的子项（父节点值等于该节点编号ID）
            var nodes = from right in searchList
                        where right.PID.Equals(parentId)
                        select right;

            //创建该节点子节点
            foreach (var item in nodes)
            {
                TreeNode node = new TreeNode() { Text = item.RightName, Name = item.RightId.ToString() };

                switch (Convert.ToInt32(parentNode.Tag))
                {
                    case 1:
                        node.ForeColor = Color.Red;
                        //表示二级菜单
                        node.Tag = Convert.ToInt32(parentNode.Tag) + 1;
                        break;
                    case 2:
                        node.ForeColor = Color.IndianRed;
                        //表示三级菜单
                        node.Tag = Convert.ToInt32(parentNode.Tag) + 1;
                        break;
                    case 3:
                        node.ForeColor = Color.BurlyWood;
                        break;

                }

                //父节点添加子节点
                parentNode.Nodes.Add(node);
                //调用自身：递归
                CreateChildNode(node, item.RightId, searchList);
            }
        }
        #endregion

        #region 用户管理模块

        /// <summary>
        /// dgv选择改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            var userDto = CheckAndGetBindingDto();

            if (userDto.UserId != 0)
            {
                this.txtUserId.Text = userDto.UserId.ToString();
                this.txtName.Text = userDto.UserName;
            }

        }

        /// <summary>
        /// 获取绑定的DTO对象
        /// </summary>
        /// <returns></returns>
        private UserDto CheckAndGetBindingDto()
        {
            var count = this.dgvUserList.SelectedRows.Count;

            var userDto = new UserDto();

            if (count == 0)
            {
                MessageBox.Show("请选中列表中一项");
            }

            var dgvOrderListCurrentRow = this.dgvUserList.CurrentRow;
            if (dgvOrderListCurrentRow != null)
            {
                userDto = ((UserDto)dgvOrderListCurrentRow.DataBoundItem);
            }
            return userDto;
        }

        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var userName = this.txtUserName.Text.Trim();
            var userPwd = this.txtUserPwd.Text.Trim();
            //检查
            if (userName.Length == 0 || userPwd.Length == 0)
            {
                MessageBox.Show("添加空白用户的么？ 请输入用户名和密码");
                return;
            }

            try
            {

                var userService = AutofacContainer.GetInstance().GetObject<IUserService>();

                var user = new UserDto() { UserName = userName, UserPwd = userPwd ,StatusId = 1};

                var result = userService.AddUser(user);
                if (result)
                {
                    MessageBox.Show($"添加用户:{userName}成功！");

                    //数据绑定 更新界面
                    _dgvBindingSource.Add(user as object);

                    this.dgvUserList.Rows[_dgvBindingSource.Count - 1].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 启用账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnable_Click(object sender, EventArgs e)
        {
            var userDto = CheckAndGetBindingDto();

            if (userDto.UserId == 0)
            {
                return;
            }

            if (userDto.StatusId == 1)
            {
                MessageBox.Show("本身就没禁用，无需启用！！");
                return;
            }

            var userService = AutofacContainer.GetInstance().GetObject<IUserService>();

            var result = userService.UpdateUserState(userDto);
            if (result)
            {
                MessageBox.Show("账号启用成功！");

                #region 界面自动刷新----保留这里

                var dataList = (IList<UserDto>)_dgvBindingSource.List;
                var first = dataList.FirstOrDefault(o => o.UserId == userDto.UserId);

                if (first != null)
                {
                    first.StatusId = 1;
                    dgvUserList.SelectionChanged -= dgvUserList_SelectionChanged;
                    _dgvBindingSource.ResetBindings(true);
                    //this.dgvUserList.ClearSelection();
                    dgvUserList.SelectionChanged += dgvUserList_SelectionChanged;
                }
                #endregion
                //this.dgvUserList.Rows[_dgvBindingSource.Count - 1].Selected = true;

            }
        }

        /// <summary>
        /// 禁用账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisable_Click(object sender, EventArgs e)
        {
            var userDto = CheckAndGetBindingDto();

            if (userDto.UserId == 0)
            {
                return;
            }

            if (userDto.StatusId == 0)
            {
                MessageBox.Show("本身就是禁用，无需禁用！！");
                return;
            }

            var userService = AutofacContainer.GetInstance().GetObject<IUserService>();

            var result = userService.UpdateUserState(userDto);
            if (result)
            {
                MessageBox.Show("账号禁用成功！");

                #region 界面自动刷新----保留这里

                var dataList = (IList<UserDto>)_dgvBindingSource.List;
                var first = dataList.FirstOrDefault(o => o.UserId == userDto.UserId);

                if (first != null)
                {
                    first.StatusId = 0;
                    dgvUserList.SelectionChanged -= dgvUserList_SelectionChanged;
                    _dgvBindingSource.ResetBindings(true);
                    //this.dgvUserList.ClearSelection();
                    dgvUserList.SelectionChanged += dgvUserList_SelectionChanged;
                }
                #endregion
            }
        }
        /// <summary>
        /// 更新账户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            var userDto = CheckAndGetBindingDto();

            if (userDto.UserId == 0)
            {
                return;
            }

            var userName = this.txtUserName.Text.Trim();
            var userPwd = this.txtUserPwd.Text.Trim();
            //检查
            if (userName.Length == 0 || userPwd.Length == 0)
            {
                MessageBox.Show("修改为空么？ 请输入用户名和密码");
                return;
            }

            try
            {

                var userService = AutofacContainer.GetInstance().GetObject<IUserService>();

                var userEditDto = new UserEditDto()
                {
                    UserId = userDto.UserId,
                    UserName = userName,
                    UserPwd = userPwd,
                    CreateTime = DateTime.Now
                };




                var result = userService.UpdateUser(userEditDto);
                if (result)
                {
                    MessageBox.Show($"更新用户:{userName}成功！");

                    #region 界面自动刷新----保留这里

                    var dataList = (IList<UserDto>)_dgvBindingSource.List;
                    var first = dataList.FirstOrDefault(o => o.UserId == userDto.UserId);

                    if (first != null)
                    {
                        first.UserName = userName;
                        first.UserPwd = userPwd;
                        dgvUserList.SelectionChanged -= dgvUserList_SelectionChanged;
                        _dgvBindingSource.ResetBindings(true);
                        //this.dgvUserList.ClearSelection();
                        dgvUserList.SelectionChanged += dgvUserList_SelectionChanged;
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.Message);
            }

        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelUser_Click(object sender, EventArgs e)
        {
            var userDto = CheckAndGetBindingDto();

            if (userDto.UserId == 0)
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show(" 此操作非常危险  您正在删除账号：" + userDto.UserName + " 该账号关联的用户角色删除？确定么", "谨慎操作", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }


            try
            {

                var userService = AutofacContainer.GetInstance().GetObject<IUserService>();

                var result = userService.DeleteUser(userDto);
                if (result)
                {
                    MessageBox.Show("删除用户：" + userDto.UserName + "及角色信息成功！");

                    //数据绑定
                    var dataList = (IList<UserDto>)_dgvBindingSource.List;
                    var first = dataList.FirstOrDefault(o => o.UserId == userDto.UserId);
                    dataList.Remove(first);
                    dgvUserList.SelectionChanged -= dgvUserList_SelectionChanged;
                    _dgvBindingSource.ResetBindings(true);
                    this.dgvUserList.ClearSelection();
                    dgvUserList.SelectionChanged += dgvUserList_SelectionChanged;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(" 出现异常：" + ex.Message);
            }
        }

        #endregion

        #region  角色管理模块


        /// <summary>
        /// 角色列表索引改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListBoxRoles.SelectedIndex != -1)
            {
                this.txtRoleName.Text = ((RoleDto)this.ListBoxRoles.SelectedItem).RoleName;
                this.txtRoleDesc.Text = ((RoleDto)this.ListBoxRoles.SelectedItem).RoleDesc;
            }

        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var name = this.txtRoleName.Text.Trim();
            var description = this.txtRoleDesc.Text.Trim();

            if (name.Length == 0 || description.Length == 0)
            {
                MessageBox.Show("请输入角色名和描述再添加！！");
                return;
            }




            try
            {
                var roleService = AutofacContainer.GetInstance().GetObject<IRoleService>();
                var roleDto = new RoleDto() { RoleName = name, RoleDesc = description };
                var result = roleService.AddRole(roleDto);

                if (result)
                {
                    MessageBox.Show("添加角色成功");

                    //更新界面
                    var dataList = (IList<RoleDto>)ListBoxRoles.DataSource;

                    dataList.Add(roleDto);
                    ListBoxRoles.ClearSelected();
                    ListBoxRoles.SelectedIndex = dataList.Count - 1;
                    //消除默认选中事件
                    //btnClear_Click(null, null);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }



        }

        /// <summary>
        /// 清空界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ListBoxRoles.SelectedIndex = -1;
            this.txtRoleName.Text = "";
            this.txtRoleDesc.Text = "";
        }



        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRole_Click(object sender, EventArgs e)
        {
            if (this.ListBoxRoles.SelectedItems.Count != 1)
            {
                MessageBox.Show("不要多选或者不选 ok？，选择一项再删除");
                return;
            }

            var roleId = Convert.ToInt32(this.ListBoxRoles.SelectedValue);

            try
            {
                var roleService = AutofacContainer.GetInstance().GetObject<IRoleService>();
                var result = roleService.DeleteRole(roleId);
                if (result)
                {
                    MessageBox.Show("删除角色 以及相应的用户角色关系  角色权限关系 成功！");

                    //数据绑定
                    var dataList = (IList<RoleDto>)this.ListBoxRoles.DataSource;
                    var first = dataList.FirstOrDefault(o => o.RoleId == roleId);
                    dataList.Remove(first);

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("异常：" + exception.Message);
            }




        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEidtRoleName_Click(object sender, EventArgs e)
        {

            var name = this.txtRoleName.Text.Trim();

            var description = this.txtRoleDesc.Text.Trim();

            if (name.Length == 0 || description.Length == 0)
            {
                MessageBox.Show("请输入角色名和描述再修改！！");
                return;
            }

            var roleId = Convert.ToInt32(this.ListBoxRoles.SelectedValue);

            try
            {
                var roleService = AutofacContainer.GetInstance().GetObject<IRoleService>();


                var result = roleService.UpdateRole(new RoleDto() { RoleId = roleId, RoleDesc = description, RoleName = name });

                if (result)
                {
                    MessageBox.Show("修改角色成功");

                    //更新界面
                    var dataList = (IList<RoleDto>)ListBoxRoles.DataSource;

                    var first = dataList.FirstOrDefault(o => o.RoleId == roleId);

                    if (first != null)
                    {
                        first.RoleDesc = description;
                        first.RoleName = name;

                        ((BindingList<RoleDto>)ListBoxRoles.DataSource).ResetBindings();
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }

        }


        #endregion

        #region 用户分配角色模块

        /// <summary>
        /// 为用户分配角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserHasRole_Click(object sender, EventArgs e)
        {
            if (this.ListBoxRoles.SelectedItems.Count == 0)
            {
                MessageBox.Show("请按住CTRL键选择角色！");
                return;
            }


            //获取用户Id
            var userId = Convert.ToInt32(this.txtUserId.Text);

            List<int> roleIdList = new List<int>();
            List<string> roleNameList = new List<string>();
            //获取角色Id
            foreach (var item in this.ListBoxRoles.SelectedItems)
            {
                roleIdList.Add(((RoleDto)item).RoleId);
                roleNameList.Add(((RoleDto)item).RoleName);
            }

            try
            {
                var userService = AutofacContainer.GetInstance().GetObject<IUserService>();

                var result = userService.GiveUserRoles(userId, roleIdList);
                if (result)
                {
                    MessageBox.Show("权限分配成功  用户拥有权限：" + String.Join(",", roleNameList.ToArray()));
                    //消除默认选中事件
                    btnClear_Click(null, null);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("异常" + ex);
            }

        }

        #endregion

        #region 查询角色权限模块

        /// <summary>
        /// 查询角色拥有的权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboRoleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstMenuRightList == null) return;

            var selectRoleId = ((RoleDto)this.cboRoleList.SelectedItem).RoleId;

            var roleService = AutofacContainer.GetInstance().GetObject<IRoleService>();

            //获取角色拥有的权限
            List<RightDto> roleIdRightList = roleService.GetRightListByRoleId(selectRoleId);

            //创建根节点
            this.tvRoleRightList.Nodes.Clear();//清空节点
            TreeNode rootNode = new TreeNode() { Text = "该角色拥有的权限", ForeColor = Color.Gold, Tag = 1 };
            this.tvRoleRightList.Nodes.Add(rootNode);

            CreateChildNode(rootNode, 0, roleIdRightList);

            this.tvRoleRightList.ExpandAll();//展开所有菜单
        }

        #endregion

        #region 角色分配权限模块

        /// <summary>
        /// 给角色分配权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGiveRoleRights_Click(object sender, EventArgs e)
        {

            //判断是否有勾选左侧权限树  遍历权限树  或者权限Id集合

            List<int> userSelectRightIds = TreeViewHelper.GetRightIds(this.tvAllRightList.TopNode);

            if (userSelectRightIds.Count == 0)
            {
                MessageBox.Show("请勾选权限再为当前角色分配！！！");
                return;
            }

            //有勾选  先删除角色所有的权限  然后新增左侧勾选的权限
            var selectRoleId = ((RoleDto)this.cboRoleList.SelectedItem).RoleId;

            try
            {
                var roleService = AutofacContainer.GetInstance().GetObject<IRoleService>();
                var result = roleService.GiveRoleRights(selectRoleId, userSelectRightIds);

                if (result)
                {
                    MessageBox.Show("为当前角色分配权限成功！");
                    cboRoleList_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常：" + ex.Message);
            }
        }

        #endregion


        /// <summary>
        /// 查询用户拥有的权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserToSeachRight_SelectionChanged(object sender, EventArgs e)
        {
            var dataGridViewRow = this.dgvUserToSeachRight.CurrentRow;
            int userId = 0;
            if (dataGridViewRow != null)
            {
                 userId = ((UserDto) dataGridViewRow.DataBoundItem).UserId;

                this.txtUserId.Text = userId.ToString();
            }

            try
            {
                var userService = AutofacContainer.GetInstance().GetObject<IUserService>();
                List<RightDto> userRights= userService.GetUserRights(userId);

                //创建根节点
                this.UserRightsTView.Nodes.Clear();//清空节点
                TreeNode rootNode = new TreeNode() { Text = "该用户拥有的权限", ForeColor = Color.Gold, Tag = 1 };
                this.UserRightsTView.Nodes.Add(rootNode);

                //查找一级节点  在数据中PID==0
                CreateChildNode(rootNode, 0, userRights);

                this.UserRightsTView.Nodes[0].ExpandAll();//展开一级菜单

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        #region 展开收缩treeview  多级联动

        private void btnRoleExpand_Click(object sender, EventArgs e)
        {
            this.tvRoleRightList.ExpandAll();//展开所有菜单
        }
        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.tvAllRightList.ExpandAll();//展开所有菜单
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.tvAllRightList.CollapseAll();
        }

        //清除所有选中
        private void btnClearSelect_Click(object sender, EventArgs e)
        {
            this.tvAllRightList.TopNode.Checked = false;
            TreeViewHelper.CheckControl(new TreeViewEventArgs(this.tvAllRightList.TopNode, TreeViewAction.ByMouse));
        }

        //权限勾选和取消
        private void tvAllRightList_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewHelper.CheckControl(e);
        }
        private void tvRoleRightList_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewHelper.CheckControl(e);
        }
        #endregion

        #region 权限管理tabPage切换  防止 增加、修改用户啥的重新绑定一遍
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //修改影响
            if (((TabControl)sender).SelectedTab == tabControl1.TabPages[0])
            {
                this.ListBoxRoles.SelectedIndex = -1;
            }
            //重新加载用户
            if (((TabControl)sender).SelectedTab == tabControl1.TabPages[2])
            {

                var userService = AutofacContainer.GetInstance().GetObject<IUserService>();

                this.dgvUserToSeachRight.DataSource = userService.GetUserList();

            }

        }


        #endregion

        #region 单元格格式化 变为文本

        private void dgvUserList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == StatusId.Index)
                if (Convert.ToInt32(e.Value) == 0)
                    e.Value = "禁用";
                else
                    e.Value = "启用";
        }

        private void DgvUserToSeachRight_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == UserState.Index)
                if (Convert.ToInt32(e.Value) == 0)
                    e.Value = "禁用";
                else
                    e.Value = "启用";
        }

        #endregion
    }
}
