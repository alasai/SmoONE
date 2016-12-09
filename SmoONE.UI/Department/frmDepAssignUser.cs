using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.CommLib;
using SmoONE.Domain;

namespace SmoONE.UI.Department
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  部门人员分配界面
    // ******************************************************************
    partial class frmDepAssignUser : Smobiler.Core.MobileForm
    {
        #region "definition"
        int selectUserQty = 0;//选中人员数
         public DepInputDto department;//部门信息
         AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
      
        /// <summary>
        /// 手机自带回退键按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepAssignUser_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }

        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepAssignUser_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepAssignUser_Load(object sender, EventArgs e)
        {
            Bind();
           
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                if (department != null)
                {
                    lblDepName.Text = department.Dep_Name;
                    lblLeader.Text = AutofacConfig.userService.GetUserByUserID(department.Dep_Leader).U_Name;
                    List<DataGridviewDepbyUser> listUser = new List<DataGridviewDepbyUser>();
                    List<UserDto> listDepUser = AutofacConfig.userService.GetAllUsers();//获取分配部门人员
                    //部门创建时gridview绑定数据
                    if (string.IsNullOrEmpty(department.Dep_ID) == true )
                    {
                        if (listDepUser.Count > 0)
                        { 
                            //将未分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == true) & (!department.Dep_Leader .Equals(user.U_ID)))
                                {
                                    DataGridviewDepbyUser depUser = new DataGridviewDepbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = "";
                                    depUser.U_DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //将已分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (!department.Dep_Leader.Equals(user.U_ID)))
                                {
                                    DataGridviewDepbyUser depUser = new DataGridviewDepbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = user.U_DepID;
                                    string DepName = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID).Dep_Name;
                                    depUser.U_DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                        }
                    }
                    //部门编辑时gridview绑定数据
                    if (string.IsNullOrEmpty(department.Dep_ID) == false )
                    {
                        if (listDepUser.Count > 0)
                        {
                            //将当前部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (department.Dep_ID.Equals(user.U_DepID)) & (!department.Dep_Leader.Equals(user.U_ID)))
                                {
                                    DataGridviewDepbyUser depUser = new DataGridviewDepbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = department .Dep_ID ;
                                    depUser.U_DepName =department .Dep_Name ;
                                    depUser.SelectCheck = true ;
                                    listUser.Add(depUser);
                                }
                            }
                            //将未分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == true) & (!department.Dep_Leader.Equals(user.U_ID)))
                                {
                                    DataGridviewDepbyUser depUser = new DataGridviewDepbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = "";
                                    depUser.U_DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //将已分配部门且不是当前部门的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (!department.Dep_ID.Equals(user.U_DepID)) & (!department.Dep_Leader.Equals(user.U_ID)))
                                {
                                    DataGridviewDepbyUser depUser = new DataGridviewDepbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = user.U_DepID;
                                    string DepName = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID).Dep_Name;
                                    depUser.U_DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                         }
                    }
                   
                    gridUserData.Rows.Clear();//清空人员列表数据
                    if (listUser.Count > 0)
                    {
                        gridUserData.DataSource = listUser; //绑定gridView数据
                        gridUserData.DataBind();

                    }
                   
                }
                else
                {
                    throw new Exception("请输入部门信息！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
      
        /// <summary>
        /// 全选
        /// </summary>
        private void Checkall()
        {
            switch (checkAll .Checked )
            {
                case true:
                    foreach (GridViewRow rows in gridUserData.Rows)
                    {
                        rows.Cell.Items["Check"].DefaultValue = true;
                    }
                    selectUserQty = gridUserData.Rows.Count;
                    break;
                case false:
                    foreach (GridViewRow rows in gridUserData.Rows)
                    {
                        rows.Cell.Items["Check"].DefaultValue = false;
                    }
                    selectUserQty = 0;
                    break;
            }
        }
        /// <summary>
        /// 分配部门人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listUser = new List<string>(); //用户集合
                string assignUser = "";//已分配部门用户
                string depLeader = "";//部门责任人用户
                listUser.Add(department.Dep_Leader);//添加部门负责人
                //获取责任人的部门
                UserDetailDto leader = AutofacConfig.userService.GetUserByUserID(department.Dep_Leader);
               //如果部门编号不为空且不等于当前部门时，将责任人添加到已分配部门人员中
                if (string.IsNullOrEmpty(leader.U_DepID) == false)
                {   
                    if (string.IsNullOrEmpty(department.Dep_ID) == false)
                    {
                        if (!department.Dep_ID.Equals(leader.U_DepID))
                        {
                            assignUser = lblLeader.Text.Trim();
                        }
                    }
                }
                foreach (GridViewRow rows in gridUserData.Rows)
                {

                    if ((Convert.ToBoolean(rows.Cell.Items["Check"].DefaultValue) == true) &(!department.Dep_Leader.Equals(rows.Cell.Items["lblUser"].Value.ToString())))
                    {
                        string user = rows.Cell.Items["lblUser"].Value.ToString();
                        listUser.Add(user);
                        //获取已分配且不等于当前部门的用户
                        if (string.IsNullOrEmpty(rows.Cell.Items["lblDep"].Value .ToString ())==false )
                        {
                            if (string.IsNullOrEmpty(department.Dep_ID) == false)
                            {
                                if (!department.Dep_ID.Equals(rows.Cell.Items["lblDep"].Value.ToString()))
                                {
                                    //如果是部门责任人，则添加到部门责任人用户depLeader中，否则添加到已分配部门用户assignUser中
                                    if (AutofacConfig.departmentService.IsLeader(rows.Cell.Items["lblUser"].Value.ToString()) == true)
                                    {
                                        if (string.IsNullOrEmpty(depLeader) == true)
                                        {
                                            depLeader = rows.Cell.Items["lblUser"].Text;
                                        }
                                        else
                                        {
                                            depLeader += "," + rows.Cell.Items["lblUser"].Text;
                                        }

                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(assignUser) == true)
                                        {
                                            assignUser = rows.Cell.Items["lblUser"].Text;
                                        }
                                        else
                                        {
                                            assignUser += "," + rows.Cell.Items["lblUser"].Text;
                                        }
                                    }
                                   
                                }
                            }
                        }
                    }
                }
                if (string.IsNullOrEmpty(depLeader) == false)
                {
                    throw new Exception(depLeader+"已是部门责任人，请先解散部门！");
                }
                bool isUPdateDep = false; //是否更新部门人员
                if (string.IsNullOrEmpty(assignUser) == false)
                {
                    MessageBox.Show(assignUser+"已分配部门是否更新部门？", "分配人员", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == Smobiler.Core.ShowResult.Yes)
                        {
                            isUPdateDep = true;
                        }
                    }
                      );
                }
                else
                {
                    isUPdateDep = true;
                }
                ReturnInfo result ;
                if (isUPdateDep == true)
                {
                    department.UserIDs = listUser;
                    if (department.Dep_ID != null)
                    {
                        result = AutofacConfig.departmentService.UpdateDepartment(department);
                    }
                    else
                    {
                        result = AutofacConfig.departmentService.AddDepartment(department);
                    }
                    if (result.IsSuccess == false)
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                    else
                    {

                        Toast("部门人员分配成功！", ToastLength.SHORT);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            Checkall();
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckChanged(object sender, CheckEventArgs e)
        {
            Checkall();
        }
        /// <summary>
        /// gridview点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            upCheckState();
        }
        /// <summary>
        /// 更新全选状态
        /// </summary>
        private void upCheckState()
        {
             selectUserQty = 0;
            foreach (GridViewRow rows in gridUserData.Rows)
            {

                if (Convert.ToBoolean(rows.Cell.Items["Check"].DefaultValue) == true)
                {
                    selectUserQty += 1;
                }
            }
            //当gridView行项选中条数等于gridView行数时，为全选状态，否则为不选状态。
            if (selectUserQty == gridUserData.Rows.Count)
            {
                checkAll.Checked = true;
            }
            else
            {
                checkAll.Checked = false;
            }
        }
        /// <summary>
        /// gridview点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            upCheckState();
        }
    }
}