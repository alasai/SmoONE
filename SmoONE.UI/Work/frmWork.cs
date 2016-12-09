using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Domain;


namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  工作界面
    // ******************************************************************
    partial class frmWork : Smobiler.Core.MobileForm
    {
        #region "definition"
        /// <summary>
        /// 菜单组字典
        /// </summary>
        /// <remarks></remarks>
        private Dictionary<string, IconMenuViewGroup> MenuGroupDict;//二级菜单
        private DateTime toasttime;//toast时间
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// TabBar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            switch (imageTabBar1.SelectItemIndex)
            {
                case 0:
                    frmCheck frmCheck = new frmCheck();
                    Redirect(frmCheck);
                        break;
                case 1:
                        frmCreated frmCreated = new frmCreated();
                        Redirect(frmCreated);
                        break;
                case 2:
                        frmCCTo frmCCTo = new frmCCTo();
                        Redirect(frmCCTo);
                        break;
            }
        }
        /// <summary>
        /// iconMenuData点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconMenuData_MenuItemClick(object sender, IconMenuItemEventArgs e)
        {
            MenuItem(e.Item.ID);
        }

        /// <summary>
        /// Toolbar方法
        /// </summary>
        /// <param name="toolbarItemName"></param>
        private void ProcessToolbarFormName(string toolbarItemName)
        {
            try
            {
                switch (toolbarItemName)
                {
                    case "":
                        this.Close();
                        break;
                    case "Me":
                        frmUser frm = new frmUser();
                        this.Redirect(frm, (MobileForm sender1, object args) => ProcessToolbarFormName(frm.toolbarItemName));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Toolbar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWork_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            ProcessToolbarFormName(e.Name);
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWork_Load(object sender, EventArgs e)
        {
            MenuGroupDict = new Dictionary<string, IconMenuViewGroup>();
            //获取菜单
            MenuGroup();
        }
        /// <summary>
        ///获取菜单
        /// </summary>
        private void MenuGroup()
        {
            try
            {
                List<Menu> listmenu = AutofacConfig.userService.GetMenuByUserID(Client.Session["U_ID"].ToString());
                this.iconMenuData.Groups.Clear();
                MenuGroupDict.Clear();
                IconMenuViewGroup grp = new IconMenuViewGroup("Default", "");
                //获取所有菜单组
                foreach (Menu menu in listmenu)
                {
                    if (string.IsNullOrWhiteSpace(menu.M_ParentID) == true)
                    {
                        //添加一级菜单
                        grp.Items.Add(new IconMenuViewItem(menu.M_MenuID, menu.M_Description, menu.M_Portrait, menu.M_MenuID));
                        //添加二级菜单
                        List<Menu> listsecondMenu = AutofacConfig.userService.GetSubMenuByUserID(Client.Session["U_ID"].ToString(), menu.M_MenuID);
                        if (listsecondMenu.Count > 0)
                        {
                            Menu menuItem = AutofacConfig.userService.GetMenuByMenuID(menu.M_MenuID);
                            IconMenuViewGroup mvGroupItem = new IconMenuViewGroup(menuItem.M_MenuID, menuItem.M_Description);
                            foreach (Menu secondMenu in listsecondMenu)
                            {
                                mvGroupItem.Items.Add(new IconMenuViewItem(secondMenu.M_MenuID, secondMenu.M_Description, secondMenu.M_Portrait, secondMenu.M_MenuID));
                                if (MenuGroupDict.ContainsKey(menu.M_MenuID) == false)
                                    MenuGroupDict.Add(menu.M_MenuID, mvGroupItem);
                            }

                        }

                    }
                }
                this.iconMenuData.Groups.Add(grp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 菜单点击事件方法
        /// </summary>
        /// <param name="id"></param>
        private void MenuItem(string id)
        {
	        if (MenuGroupDict.ContainsKey(id) == true) 
            {
                //显示当前菜单的二级菜单
		        this.iconMenuData.ShowDialogMenu(MenuGroupDict[id]);
	        } 
            else
            {
                switch (id)
                {

                    case "Leave":
                            Leave.frmLeaveCreate frmLeaveCreate = new Leave.frmLeaveCreate();
                            Redirect(frmLeaveCreate);
                            break;
                    case "Reimbursement":
                            RB.frmRBCreate frmRBCreate = new RB.frmRBCreate();
                            Redirect(frmRBCreate);
                            break;
                    case "RB_Rows":
                            RB.frmRBRows frmRBRows = new RB.frmRBRows();
                            Redirect(frmRBRows);
                            break;
                    case "RB_RType_Template":
                            RB.frmRTypeTemplate frmRTypeTemplate = new RB.frmRTypeTemplate();
                            Redirect(frmRTypeTemplate);
                            break;
                    case "Department":
                            Department.frmDepartment frmDepartment = new Department.frmDepartment();
                            Redirect(frmDepartment);
                            break;
                    case "CostCenter":
                            CostCenter.frmCostCenter frmCostCenter = new CostCenter.frmCostCenter();
                            Redirect(frmCostCenter);
                            break;
                    case "CC_Type_Template":
                            CostCenter.frmCostTemplet frmCostTemplet = new CostCenter.frmCostTemplet();
                            Redirect(frmCostTemplet);
                            break;
                }
		    }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWork_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }
        /// <summary>
        /// Toast
        /// </summary>
        private void HandleToast()
        {
            if (toasttime.AddSeconds(3) >= DateTime.Now)
            {

                this.Client.Exit();
            }
            else
            {
                toasttime = DateTime.Now;
                this.Toast("再按一次退出系统", ToastLength.SHORT);
            }
        }
    }
}