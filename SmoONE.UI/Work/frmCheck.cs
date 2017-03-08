using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Application;
using SmoONE.DTOs;
using SmoONE.Domain;
using System.Data;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  我审批的列表界面
    // ******************************************************************
    partial class frmCheck : Smobiler.Core.MobileForm
    {
        #region "definition"
        private string type="";//类型
        private string state = "";//状态
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCheck_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmCheck_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// tabBar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            type = "";
            state = "";
            Bind ();
        }

       /// <summary>
       /// 获取初始化数据
       /// </summary>
        private void Bind()
        {
            try
            {
               
                List<LeaveDto> listLeaveDto = new List<LeaveDto>();
                List<ReimbursementDto> listRBDto = new List<ReimbursementDto>();
                switch (textTabBar1.SelectItemIndex)
                {
                    case 0:
                        //获取当前用户待审批的请假数据
                        listLeaveDto = AutofacConfig.leaveService.GetNewByCheckUsers(Client.Session["U_ID"].ToString());
                        //获取当前用户待审批的报销数据
                        listRBDto = AutofacConfig.rBService.GetNewByCheckUsers(Client.Session["U_ID"].ToString());
                        break;
                    case 1:
                        //获取当前用户已审批的请假数据
                        listLeaveDto = AutofacConfig.leaveService.GetCheckedByCheckUsers(Client.Session["U_ID"].ToString());
                        //获取当前用户已审批的报销数据
                        listRBDto = AutofacConfig.rBService.GetCheckedByCheckUsers(Client.Session["U_ID"].ToString());
                        break;
                }
                List<DataGridview> listCheck = new List<DataGridview>();//审批数据
               UserDetails userDetails = new UserDetails();
                //如果待我审批或我审批的请假数据条数大于0，则添加到审批数据                
                if (listLeaveDto.Count > 0)
                {
                    foreach (LeaveDto leave in listLeaveDto)
                    {
                        DataGridview dataGItem = new DataGridview();
                        dataGItem.ID = leave.L_ID;
                        if (string.IsNullOrEmpty(leave.U_Portrait) == true)
                        {
                            //UserDetailDto user = AutofacConfig.userService.GetUserByUserID(leave.U_ID);
                            //switch (user.U_Sex)
                            //{
                            //    case (int)Sex.男:
                            //        dataGItem.U_Portrait = "boy";
                            //        break;
                            //    case (int)Sex.女:
                            //        dataGItem.U_Portrait = "girl";
                            //        break;
                            //}
                           
                            UserDetailDto user = userDetails.getUser(leave.U_ID);
                            if (user != null)
                            {
                                dataGItem.U_Portrait = user.U_Portrait;
                            }
                        }
                        else
                        {
                            dataGItem.U_Portrait = leave.U_Portrait;
                        }
                        dataGItem.Name = leave.U_Name + "的" + DataGridviewType.请假;
                        dataGItem.Type = ((int )Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString())).ToString();
                        dataGItem.CreateDate = leave.L_CreateDate.ToString("yyyy/MM/dd");
                        switch (leave.L_Status)
                        {
                            case (int)L_Status.新建:
                                if (string.IsNullOrEmpty(leave.L_CheckUsers) == false)
                                {
                                    dataGItem.L_StatusDesc = "等待我审批";
                                }
                                else
                                {
                                    dataGItem.L_StatusDesc = "等待我审批";
                                }
                                break;
                            case (int)L_Status.已审批:
                                dataGItem.L_StatusDesc = "已审批（完成）";
                                break;
                            case (int)L_Status.已拒绝:
                                dataGItem.L_StatusDesc = "已审批（拒绝）";
                                break;
                        }
                        listCheck.Add(dataGItem);
                    }
                }

                //如果待我审批或我审批的报销数据条数大于0，则添加到审批数据     
                if (listRBDto.Count > 0)
                {
                    foreach (ReimbursementDto reimbursement in listRBDto)
                    {
                        DataGridview dataGItem = new DataGridview();
                        dataGItem.ID = reimbursement.RB_ID;
                        if (string.IsNullOrEmpty(reimbursement.U_Portrait) == true)
                        {
                            UserDetailDto user = userDetails.getUser(reimbursement.U_ID);
                            if (user != null)
                            {
                                dataGItem.U_Portrait = user.U_Portrait;
                            }
                            //UserDetailDto user = AutofacConfig.userService.GetUserByUserID(reimbursement.U_ID);
                            //switch (user.U_Sex)
                            //{
                            //    case (int)Sex.男:
                            //        dataGItem.U_Portrait = "boy";
                            //        break;
                            //    case (int)Sex.女:
                            //        dataGItem.U_Portrait = "girl";
                            //        break;
                            //}
                        }
                        else
                        {
                            dataGItem.U_Portrait = reimbursement.U_Portrait;
                        }
                        dataGItem.Name = reimbursement.U_Name + "的" + DataGridviewType.报销;
                        dataGItem.Type = ((int )Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString())).ToString();
                        dataGItem.CreateDate = reimbursement.RB_CreateDate.ToString("yyyy/MM/dd");
                        switch (reimbursement.RB_Status)
                        {
                            case (int)RB_Status.新建:
                                switch (textTabBar1.SelectItemIndex)
                                {
                                    case 0:
                                            dataGItem.L_StatusDesc = "等待责任人审批";
                                        break;
                                }
                                break;
                            case (int)RB_Status.责任人审批:
                                switch (textTabBar1.SelectItemIndex)
                                {
                                    case 0:
                                        dataGItem.L_StatusDesc = "等待行政审批";
                                        break;
                                    case 1:
                                        dataGItem.L_StatusDesc = "责任人已审批";
                                        break;
                                }
                                break;
                            case (int)RB_Status.行政审批:
                                switch (textTabBar1.SelectItemIndex)
                                {
                                    case 0:
                                        dataGItem.L_StatusDesc = "等待财务审批";
                                        break;
                                    case 1:
                                        dataGItem.L_StatusDesc = "行政已审批";
                                        break;
                                }
                                break;
                            case (int)RB_Status.财务审批:
                                switch (textTabBar1.SelectItemIndex)
                                {
                                    case 1:
                                        dataGItem.L_StatusDesc = "财务已审批";
                                        break;
                                }
                                break;
                            case (int)RB_Status.已拒绝:
                                dataGItem.L_StatusDesc = "已审批（拒绝）";
                                break;
                        }
                        listCheck.Add(dataGItem);
                    }
                }

                gridCheckData.Rows.Clear();//清空我审批列表数据
                if (listCheck.Count > 0)
                {
                    gridCheckData.DataSource = listCheck;//绑定gridview数据
                    gridCheckData.DataBind();
                }
              
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        /// <summary>
        /// 获取筛选数据
        /// </summary>
        private void GetCheckData()
        {
            List<LeaveDto> listLeaveDto = new List<LeaveDto>();
            List<ReimbursementDto> listRBDto = new List<ReimbursementDto>();
            if (string.IsNullOrWhiteSpace(type) == false & string.IsNullOrWhiteSpace(state) == false)
            {
                switch (Convert.ToInt32(type))
                {
                    case (int)DataGridviewType.请假:
                        switch (textTabBar1.SelectItemIndex)
                        {
                            case 0:
                                //获取当前用户待审批的请假数据
                                listLeaveDto = AutofacConfig.leaveService.GetNewByCheckUsers(Client.Session["U_ID"].ToString());
                                break;
                            case 1:
                                //根据请假状态获取当前用户已审批的请假数据
                               listLeaveDto = AutofacConfig.leaveService.QueryCheckedByCheckUsers(Client.Session["U_ID"].ToString(), Convert.ToInt32(state));
                               break;
                        }
                        break;
                    case (int)DataGridviewType.报销:
                        switch (textTabBar1.SelectItemIndex)
                        {
                            case 0:
                                //根据报销状态获取当前用户待审批的报销数据
                                listRBDto = AutofacConfig.rBService.QueryNewByCheckUsers(Client.Session["U_ID"].ToString(), Convert.ToInt32(state));
                                break;
                            case 1:
                                //根据报销状态获取当前用户已审批的报销数据
                                listRBDto = AutofacConfig.rBService.QueryCheckedByCheckUsers(Client.Session["U_ID"].ToString(), Convert.ToInt32(state));
                                break;
                        }
                       
                        break;
                }
            }
            List<DataGridview> listCheck = new List<DataGridview>();//审批数据

            //如果待我审批或我审批的请假数据条数大于0，则添加到审批数据     
            if (listLeaveDto.Count > 0)
            {
                foreach (LeaveDto leave in listLeaveDto)
                {
                    DataGridview dataGItem = new DataGridview();
                    dataGItem.ID = leave.L_ID;
                    if (string.IsNullOrEmpty(leave.U_Portrait) == true)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(leave.U_ID);
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                dataGItem.U_Portrait = "boy";
                                break;
                            case (int)Sex.女:
                                dataGItem.U_Portrait = "girl";
                                break;
                        }
                    }
                    else
                    {
                        dataGItem.U_Portrait = leave.U_Portrait;
                    }
                    dataGItem.Name = leave.U_Name + "的" + DataGridviewType.请假;
                    dataGItem.Type = ((int )Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString())).ToString();
                    switch (leave.L_Status)
                    {
                        case (int)L_Status.新建:
                            dataGItem.L_StatusDesc = "等待审批";
                            break;
                        case (int)L_Status.已审批:
                            dataGItem.L_StatusDesc = "已审批（完成）";
                            break;
                        case (int)L_Status.已拒绝:
                            dataGItem.L_StatusDesc = "已审批（拒绝）";
                            break;
                    }
                    listCheck.Add(dataGItem);
                }
            }

            //如果待我审批或我审批的报销数据条数大于0，则添加到审批数据     
            if (listRBDto.Count > 0)
            {
                foreach (ReimbursementDto reimbursement in listRBDto)
                {
                    DataGridview dataGItem = new DataGridview();
                    dataGItem.ID = reimbursement.RB_ID;
                    if (string.IsNullOrEmpty(reimbursement.U_Portrait) == true)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(reimbursement.U_ID);
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                dataGItem.U_Portrait = "boy";
                                break;
                            case (int)Sex.女:
                                dataGItem.U_Portrait = "girl";
                                break;
                        }
                    }
                    else
                    {
                        dataGItem.U_Portrait = reimbursement.U_Portrait;
                    }
                    dataGItem.Name = reimbursement.U_Name + "的" + DataGridviewType.报销;
                    dataGItem.Type = ((int )Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString())).ToString();
                    switch (reimbursement.RB_Status)
                    {
                        case (int)RB_Status.新建:
                            switch (textTabBar1.SelectItemIndex)
                            {
                                case 0:
                                    dataGItem.L_StatusDesc = "等待责任人审批";
                                    break;
                            }
                            break;
                        case (int)RB_Status.责任人审批:
                            switch (textTabBar1.SelectItemIndex)
                            {
                                case 0:
                                    dataGItem.L_StatusDesc = "等待行政审批";
                                    break;
                                case 1:
                                    dataGItem.L_StatusDesc = "责任人已审批";
                                    break;
                            }
                            break;
                        case (int)RB_Status.行政审批:
                            switch (textTabBar1.SelectItemIndex)
                            {
                                case 0:
                                    dataGItem.L_StatusDesc = "等待财务审批";
                                    break;
                                case 1:
                                    dataGItem.L_StatusDesc = "行政已审批";
                                    break;
                            }
                            break;
                        case (int)RB_Status.财务审批:
                            switch (textTabBar1.SelectItemIndex)
                            {
                                case 1:
                                    dataGItem.L_StatusDesc = "财务已审批";
                                    break;
                            }
                            break;
                        case (int)RB_Status.已拒绝:
                            dataGItem.L_StatusDesc = "已审批（拒绝）";
                            break;
                    }
                    listCheck.Add(dataGItem);
                }
            }
            gridCheckData.Rows.Clear();//清空列表数据
            if (listCheck.Count > 0)
            {
                gridCheckData.DataSource = listCheck;
                gridCheckData.DataBind();
            }
           
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCheck_Load(object sender, EventArgs e)
        {
            type = "";
            state = "";
            Bind();
        }

        /// <summary>
        /// gridCheckData点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCheckData_CellClick(object sender, GridViewCellEventArgs e)
        {
            string ID = e.Cell.Items["lblId"].Value.ToString();
           switch (Convert .ToInt32(e.Cell.Items["lblType"].Value))
            {
                //跳转到请假详细界面
                case (int)DataGridviewType.请假:
                    Leave.frmLeaveDetail frmLeaveDetail = new Leave.frmLeaveDetail();
                    frmLeaveDetail.lID = ID;
                    Redirect(frmLeaveDetail, (MobileForm form, object args) =>
                    {
                        if (frmLeaveDetail.ShowResult == ShowResult.Yes)
                        {
                            Bind();
                            type = "";
                            state = "";
                        }
                    });
                    break;
                //跳转到报销详细界面
                case (int)DataGridviewType.报销:
                   RB.frmRBDetail frmRBDetail = new RB.frmRBDetail();
                    frmRBDetail.ID = ID;
                    Redirect(frmRBDetail, (MobileForm form, object args) =>
                    {
                        if (frmRBDetail.ShowResult == ShowResult.Yes)
                        {
                            Bind();
                            type = "";
                            state = "";
                        }
                    });
                    break;
            }
           
        }
        /// <summary>
        /// 筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnSearch_Click(object sender, EventArgs e)
        {
            popList1.Groups.Clear();
            DataCheckPoplist poplist =new  DataCheckPoplist();
            DataTable grouptable = poplist.GetPopGroup();
              if ( grouptable.Rows.Count > 0)
              {
                  foreach (DataRow  Grow in grouptable.Rows)
                  {
                        PopListGroup poli = new PopListGroup();
                        popList1.Groups.Add(poli);
                        poli.Text = Grow["GroupName"].ToString ();
                        DataTable table=new DataTable ();
                         switch (textTabBar1.SelectItemIndex)
                            {
                                case 0:
                                   table  = poplist.GetPendingCheckPopItem();
                                    break;
                                 case 1:
                                   table  = poplist.GetCheckPopItem();
                                     break ;
                            }
                      if (table .Rows .Count >0)
                      {
                           foreach (DataRow  rowli in table.Rows)
                            {
                                if (rowli["ParentID"].ToString().Equals(Grow["GroupID"].ToString()))
                               {
                                   poli.Items.Add(rowli["PopItemName"].ToString(), rowli["ParentID"].ToString() + "-" + rowli["Status"].ToString());
                                   if (type.Trim().Length > 0 & state .Trim ().Length >0)
                                   {
                                       if ((type.Trim() + "-" + state.Trim()).Equals(rowli["ParentID"].ToString() + "-" + rowli["Status"].ToString()))
                                       {
                                           popList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                                       }
                                   }
                               }
                             }
                      }
                  }
              }
            popList1.Show();
        }
        
        /// <summary>
        /// 筛选查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popList1_Selected(object sender, EventArgs e)
        {
            if (popList1.Selection != null)
            {
                foreach (PopListItem poitem in popList1.Selections)
                {

                    type = (popList1.Selection.Value.ToString()).Split('-')[0].ToString();
                    state = (popList1.Selection.Value.ToString()).Split('-')[1].ToString();          
                }
                GetCheckData();
            }
        }
    }
}