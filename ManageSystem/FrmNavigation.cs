//======================================================================
//此系统起始于2019.07.13日沟通、原本不想搞的复杂，后来转念一想，正好借这个项目将自己知识输出。
// 项目框架 使用两层+UI(懒得用Ado.net 麻烦) EF框架采用Database First开发模式  另外配合使用LINQ+Lamda+多线程+异步+分页
// 项目特色点在权限管理这块 涉及5个表


// 版本    修订  	        日期 		           内容   
// 1.0.0   周沆           2019.07.13               了解需求、大概设计界面      
// 1.0.0   周沆           2019.07.15                界面优化、设计主要业务数据库表
// 1.0.0   周沆           2019.07.16                  框架搭建 完成部分部分业务    
// 1.0.0   周沆           2019.07.17                   大体完成主要业务逻辑 
// 1.0.0   周沆           2019.07.18           完成用户角色管理(维护者可以借鉴我的多线程、异步方式代码,方式还是很优美的)
// 1.0.0   周沆           2019.07.19           TreeView 递归显示权限  数据库表优化(无限极菜单)
// 1.0.0   周沆           2019.07.22            完成权限分配、权限控制按钮
// 1.0.1   周沆           2019.07.23          界面优化、代码优化(dataGridView selectionChange事件要注意,绑定数据源都会执行一次(绑定10个执行10次 真滴很恶心)，导致界面很卡(因为每个选项改变都触发了自动查询了数据库))
//1.0.2    周沆           2019.08.19           今天开始重构整个项目  dbFirst  上下文 和 实体分成两个项目 并借鉴DDD项目结构
//1.0.3    周沆           2019.08.20           修改结构 规范泛型仓储和工作单元 (涉及到两个数据库 多增加了一个泛型参数)
//1.0.3    周沆           2019.08.21           DDD结构写起来挺不习惯的  一个小功能 写两个接口 两个实现  修改数据库结构  订单增加物料领取数量  并分类显示领料订单
//1.0.3    周沆           2019.08.22           整进Log4Net  开始以DDD方式重写整个项目
//1.0.4    周沆           2019.08.23           整进Automapper   重写内容
//1.0.5    周沆           2019.08.24           整进AutoFac       重写内容 
//1.0.6    周沆           2019.08.26           整进领域服务(用于业务验证)
//1.0.7    周沆           2019.08.27           修改用户角色权限代码
//1.0.8    周沆           2019.08.28           整进BUS总线 MediatorR
//1.0.9    周沆           2019.08.29           整进领域通知和领域事件处理
//1.0.8    周沆           2019.08.30           程序完成 进入实际测试验证   编写组装和领料 seletionchange事件 同步以前的数据到订单表
//======================================================================



using DDD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DDD.Application.DTO.User;

namespace ManageSystem
{
    public partial class FrmNavigation : Form
    {
        public FrmNavigation()
        {
            InitializeComponent();

            this.lbUserName.Text = Program.objCurrentLoginUser.UserName;

            SetUserControl(Program.objCurrentLoginUser);

        }

        //获取用户权限 设置按钮使能
        private void SetUserControl(LoginOutput loginUser)
        {

            var userRights = loginUser.UserRightList;

            this.btnAddOrder.Enabled = userRights.FirstOrDefault(o => o.RightName == "订单管理") != null;

            this.btnOrderEdit.Enabled = userRights.FirstOrDefault(o => o.RightName == "订单修改") != null;

            this.btnCollectionMaterials.Enabled = userRights.FirstOrDefault(o => o.RightName == "领料管理") != null;

            this.btnAssemble.Enabled = userRights.FirstOrDefault(o => o.RightName == "组装管理") != null;

            this.btnStorage.Enabled = userRights.FirstOrDefault(o => o.RightName == "入库管理") != null;

            this.btnEveryDay.Enabled = userRights.FirstOrDefault(o => o.RightName == "每日完成管理") != null;

            this.btnGatherSearch.Enabled = userRights.FirstOrDefault(o => o.RightName == "综合查询管理") != null;

            this.btnRight.Enabled = userRights.FirstOrDefault(o => o.RightName == "权限管理") == null ? false : true;

            this.btnDBSearch.Enabled = userRights.FirstOrDefault(o => o.RightName == "数据库查询管理") != null;
        }


        private void OpenForm(Form objFrm)
        {
            //判断容器是否有其他窗体
            foreach (var item in this.spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            //嵌入新的窗体
            objFrm.TopLevel = false;//将子窗体设置为非顶级控件  顶级控件不能添加到控件中
            objFrm.FormBorderStyle = FormBorderStyle.None;//去掉子窗体边框  否则会显示窗体标题栏和关闭按钮
            objFrm.Parent = this.spContainer.Panel2;   //
            objFrm.Dock = DockStyle.Fill;//随着容器大小自动调整窗体大小   相当于背景颜色填充  控件大小没有变化
            objFrm.Show();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FrmOrder objFrm = new FrmOrder();
            OpenForm(objFrm);
        }

        private void btnCollectionMaterials_Click(object sender, EventArgs e)
        {
            FrmCollection objFrm = new FrmCollection();
            OpenForm(objFrm);
        }

        private void btnAssemble_Click(object sender, EventArgs e)
        {
            FrmAssemble objFrm = new FrmAssemble();
            OpenForm(objFrm);
        }


        private void btnStorage_Click(object sender, EventArgs e)
        {
            FrmStorage objFrm = new FrmStorage();
            OpenForm(objFrm);
        }

        private void btnGatherSearch_Click(object sender, EventArgs e)
        {
            FrmGatherSearch objFrm = new FrmGatherSearch();
            OpenForm(objFrm);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            FrmUserRightManage objFrm = new FrmUserRightManage();
            OpenForm(objFrm);
        }

        private void btnDBSearch_Click(object sender, EventArgs e)
        {
            DBDataSearch objFrm = new DBDataSearch();
            OpenForm(objFrm);
        }

        private void BtnOrderEdit_Click(object sender, EventArgs e)
        {
            FrmOrderEdit objFrm = new FrmOrderEdit();
            OpenForm(objFrm);
        }

        private void BtnEveryDay_Click(object sender, EventArgs e)
        {
            FrmDayProduct objFrm = new FrmDayProduct();
            OpenForm(objFrm);
        }
    }
}
