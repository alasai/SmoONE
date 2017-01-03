using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Application ;
using SmoONE.Domain;
using SmoONE.CommLib;
using SmoONE.DTOs;
namespace SmoONE.UI.Leave
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  请假详情界面
    // ******************************************************************
    partial class frmLeaveDetail : Smobiler.Core.MobileForm
    {
        #region "definition"
        public string lID;//请假编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveDef_Load(object sender, EventArgs e)
        {
            GetLeave();
        }
        /// <summary>
        /// 根据请假编号获取请假数据
        /// </summary>
        private void GetLeave()
        {
            try
            {
              
                LeaveDetailDto leave = AutofacConfig.leaveService.GetByID(lID);
                if (Convert.IsDBNull(leave) == false)
                {
                    UserDetailDto userInfo = AutofacConfig.userService.GetUserByUserID(leave.L_CreateUser);
                    TitleText = userInfo.U_Name  + "的请假";
                    lblUserName .Text = userInfo.U_Name;
                    if (string.IsNullOrEmpty(userInfo.U_Portrait) == true)
                        {
                            switch (userInfo.U_Sex)
                            {
                                case (int)Sex.男:
                                    imgPortrait.ResourceID = "boy";
                                    break;
                                case (int)Sex.女:
                                    imgPortrait.ResourceID = "girl";
                                    break;
                            }
                        }
                        else
                        {
                            imgPortrait.ResourceID = userInfo.U_Portrait;
                        }
                    switch (leave.L_Status)
                    {
                        case (int)L_Status.新建:
                           string[] CheckUsers = leave.L_CheckUsers.Split (',');
                           lblStateNote.Text = "等待审批";
                            bool iscuserCheck = false;//当前用户是否有审批权限
                            //如果当前用户是审批用户则显示审批权限，同意、拒绝按钮，否则不显示
                            if (CheckUsers.Contains(Client.Session["U_ID"].ToString()) == true)
                            {
                                FooterBarLayoutData.Items["btnAgreed"].Visible = true;
                                FooterBarLayoutData.Items["btnRefuse"].Visible = true;
                                iscuserCheck = true;
                            }
                            else
                            {
                                 FooterBarLayoutData.Items["btnAgreed"].Visible = false;
                                FooterBarLayoutData.Items["btnRefuse"].Visible = false;
                                iscuserCheck = false;
                            }
                            //如果是当前用户是请假条的创建用户，则显示编辑按钮，否则不显示。
                            if (Client.Session["U_ID"].ToString().Equals(leave.L_CreateUser))
                            {
                                FooterBarLayoutData.Items["btnEdit"].Visible = true;
                                if (iscuserCheck == true)
                                {
                                    FooterBarLayoutData.Items["btnAgreed"].Width = 85;
                                    FooterBarLayoutData.Items["btnAgreed"].Left = 10;
                                    FooterBarLayoutData.Items["btnRefuse"].Width = 85;
                                    FooterBarLayoutData.Items["btnRefuse"].Left = 108;
                                    FooterBarLayoutData.Items["btnEdit"].Width = 85;
                                    FooterBarLayoutData.Items["btnEdit"].Left = 205;
                                }
                                else
                                {
                                    FooterBarLayoutData.Items["btnEdit"].Width = 280;
                                    FooterBarLayoutData.Items["btnEdit"].Left = 10;
                                }
                            }
                            else
                            {
                                FooterBarLayoutData.Items["btnEdit"].Visible = false;
                                if (iscuserCheck == true)
                                {
                                    FooterBarLayoutData.Items["btnAgreed"].Width = 134;
                                    FooterBarLayoutData.Items["btnAgreed"].Left = 10;
                                    FooterBarLayoutData.Items["btnRefuse"].Width = 134;
                                    FooterBarLayoutData.Items["btnRefuse"].Left = 156;
                                }
                                else
                                {
                                    FooterBarLayoutData.Items["Line1"].Visible = false;
                                    FooterBarLayoutForm.Close();
                                }
                            }
                          
                            break;
                        case (int)L_Status.已审批:
                            lblStateNote.Text = "已审批（完成）";
                             FooterBarLayoutData.Items["btnAgreed"].Visible = false;
                                FooterBarLayoutData.Items["btnRefuse"].Visible = false;
                                FooterBarLayoutData.Items["btnEdit"].Visible = false;
                                FooterBarLayoutData.Items["Line1"].Visible = false;
                           
                            break;
                        case (int)L_Status.已拒绝:
                            lblStateNote.Text = "已审批（拒绝）";
                          
                            //如果是当前用户是请假条的创建用户，则显示编辑按钮，否则不显示。
                            if (Client.Session["U_ID"].ToString().Equals(leave.L_CreateUser))
                            {
                                FooterBarLayoutData.Items["btnAgreed"].Visible = false;
                                FooterBarLayoutData.Items["btnRefuse"].Visible = false;
                                FooterBarLayoutData.Items["btnEdit"].Visible = true;
                                FooterBarLayoutData.Items["btnEdit"].Width = 280;
                                FooterBarLayoutData.Items["btnEdit"].Left = 10;
                            }
                            {
                                FooterBarLayoutData.Items["Line1"].Visible = false ;
                            }
                            break;
                    }
                    lblLId.Text = lID;
                    lblLType.Text = leave.L_TypeName;
                    lblStartDate.Text = leave.L_StartDate.ToString();
                    lblEndDate.Text = leave.L_EndDate.ToString();
                    lblLDay.Text = leave.L_LDay.ToString()+"天";
                    lblReson.Text = leave.L_Reason;
                    if (string.IsNullOrWhiteSpace(leave.L_Img1) == false)
                    {
                        imgL.ResourceID = leave.L_Img1;
                    }
                   //获取并绑定nodeview数据
                    getNodeItemDate(leave);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        /// <summary>
        /// 添加节点数据
        /// </summary>
        /// <param name="leave"></param>
        private void getNodeItemDate(LeaveDetailDto leave)
        {

           //清除所有节点
            nodeStateDate.Items.Clear();
            //添加节点数据
            NodeViewItem nodeItem = new NodeViewItem();
            nodeItem.Icon = "tijiao";
            UserDetailDto createUser = AutofacConfig.userService.GetUserByUserID(leave.L_CreateUser);
            if (string.IsNullOrEmpty(createUser.U_Portrait) == true)
            {
                switch (createUser.U_Sex)
                {
                    case (int)Sex.男:
                        nodeItem.Image = "boy";
                        break;
                    case (int)Sex.女:
                        nodeItem.Image = "girl";
                        break;
                }
            }
            else
            {
                nodeItem.Image = createUser.U_Portrait;
            }
            if (Client.Session["U_ID"].Equals(leave.L_CreateUser))
            {
                nodeItem.Text = "我";
            }
            else
            {
                nodeItem.Text = createUser.U_Name;
            }          
            nodeItem.SubText = "发起申请";
            nodeItem.Date = leave.L_CreateDate;
            nodeItem.TextColor = System.Drawing.Color.FromArgb(45,45,45);
            nodeItem.SubTextColor = System.Drawing.Color.FromArgb(236, 163, 56);
            nodeItem.DateColor = System.Drawing.Color.FromArgb(145, 145, 145);
            nodeStateDate.Items.Add(nodeItem);//动态添加节点
            switch (leave.L_Status)
            {
                case (int)L_Status.新建:
                    if (string.IsNullOrEmpty(leave.L_CheckUsers) == false)
                    {
                        string[] CheckUsers = leave.L_CheckUsers.Split(',');
                        foreach (string cUser in CheckUsers)
                        {
                            NodeViewItem nodeItem2 = new NodeViewItem();
                            nodeItem2.Icon = "jinxingzhong";
                            UserDetailDto checkUser = AutofacConfig.userService.GetUserByUserID(cUser);
                            if (string.IsNullOrEmpty(checkUser.U_Portrait) == true)
                            {
                                switch (checkUser.U_Sex)
                                {
                                    case (int)Sex.男:
                                        nodeItem2.Image = "boy";
                                        break;
                                    case (int)Sex.女:
                                        nodeItem2.Image = "girl";
                                        break;
                                }
                            }
                            else
                            {
                                nodeItem2.Image = checkUser.U_Portrait;
                            }

                            if (Client.Session["U_ID"].Equals(cUser))
                            {
                                nodeItem2.Text = "我";
                            }
                            else
                            {
                                nodeItem2.Text = checkUser.U_Name;
                            }
                            nodeItem2.SubText = "审批中";
                            nodeItem2.TextColor = System.Drawing.Color.FromArgb(45, 45, 45);
                            nodeItem2.SubTextColor = System.Drawing.Color.FromArgb(236, 163, 56);
                            nodeStateDate.Items.Add(nodeItem2);
                        }
                    }
                    break;
                case (int)L_Status.已审批:
                    NodeViewItem nodeItem3 = new NodeViewItem();
                    nodeItem3.Icon = "wancheng";
                    UserDetailDto checkUser1 = AutofacConfig.userService.GetUserByUserID(leave.L_CurrantCheck);
                    if (string.IsNullOrEmpty(checkUser1.U_Portrait) == true)
                        {
                            switch (checkUser1.U_Sex)
                            {
                                case (int)Sex.男:
                                    nodeItem3.Image = "boy";
                                    break;
                                case (int)Sex.女:
                                    nodeItem3.Image = "girl";
                                    break;
                            }
                        }
                        else
                        {
                            nodeItem3.Image = checkUser1.U_Portrait;
                        }
                     
                    if (Client.Session["U_ID"].Equals(leave.L_CurrantCheck))
                    {
                        nodeItem3.Text = "我";
                    }
                    else
                    {
                        nodeItem3.Text = checkUser1.U_Name;
                    }
                    nodeItem3.SubText = "已同意";
                    nodeItem3.Date = leave.L_UpdateDate;
                    nodeItem3.TextColor = System.Drawing.Color.FromArgb(45, 45, 45);
                    nodeItem3.SubTextColor = System.Drawing.Color.FromArgb(143, 187, 78);
                     nodeItem3.DateColor  = System.Drawing.Color.FromArgb(145, 145, 145);
                    nodeStateDate.Items.Add(nodeItem3);
                    break;
                case (int)L_Status.已拒绝:
                    NodeViewItem nodeItem4 = new NodeViewItem();
                    nodeItem4.Icon = "jujue";
                    UserDetailDto checkUser2 = AutofacConfig.userService.GetUserByUserID(leave.L_CurrantCheck);
                   if (string.IsNullOrEmpty(checkUser2.U_Portrait) == true)
                        {
                            switch (checkUser2.U_Sex)
                            {
                                case (int)Sex.男:
                                    nodeItem4.Image = "boy";
                                    break;
                                case (int)Sex.女:
                                    nodeItem4.Image = "girl";
                                    break;
                            }
                        }
                        else
                        {
                            nodeItem4.Image = checkUser2.U_Portrait;
                        }
                     
                    if (Client.Session["U_ID"].Equals(leave.L_CurrantCheck))
                    {
                        nodeItem4.Text = "我";
                    }
                    else
                    {
                        nodeItem4.Text = checkUser2.U_Name;
                    }
                    nodeItem4.SubText = "已拒绝";
                    nodeItem4.Date = leave.L_UpdateDate;
                    nodeItem4.TextColor = System.Drawing.Color.FromArgb(45, 45, 45);
                    nodeItem4.SubTextColor = System.Drawing.Color.FromArgb(244, 64, 69);
                     nodeItem4.DateColor  = System.Drawing.Color.FromArgb(145, 145, 145);
                    nodeStateDate.Items.Add(nodeItem4);
                    break;
            }
        }

        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveDef_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmLeaveDef_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
      
        /// <summary>
        /// 审批意见（FooterBarDialog点击事件）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveDetail_FooterBarDialogLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            try
            {
                switch (e.CellItem.Name)
                {
                    case "btnCancel":
                        CloseFooterBar();
                        break;
                    case "btnOK":
                        if (FooterBarDialogData.Items["txtReason"].Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入拒绝理由！");
                        }
                        //审批人驳回请假
                        ReturnInfo result = AutofacConfig.leaveService.UpdateLeaveStatus(lID, L_Status.已拒绝, Client.Session["U_ID"].ToString(), FooterBarDialogData.Items["txtReason"].Text.Trim());
                      //如果返回true则审批成功，否则失败并抛出错误
                        if (result.IsSuccess == true)
                      {
                          GetLeave();
                          CloseFooterBar();
                          ShowResult = ShowResult.Yes;
                          Toast("已拒绝请假！", ToastLength.SHORT);
                      }
                      else
                      {
                          throw new Exception (result.ErrorInfo);
                      }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// FooterBar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveDetail_FooterBarLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            if (e.CellItem .Name  == "btnAgreed")
            {
                //MessageBox.Show("是否确定同意审批？", "请假审批", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                //{
                //    if (args.Result == Smobiler.Core.ShowResult.Yes)
                //    {
                        //审批人同意请假
                        ReturnInfo result = AutofacConfig.leaveService.UpdateLeaveStatus(lID, L_Status.已审批, Client.Session["U_ID"].ToString(), "");
                        //如果返回true则审批成功，否则失败并抛出错误
                        if (result.IsSuccess == true)
                        {
                            GetLeave();
                            ShowResult = ShowResult.Yes;
                            Toast("已同意请假审批！", ToastLength.SHORT);
                        }
                        else
                        {
                            Toast(result.ErrorInfo, ToastLength.SHORT);
                        }
                //    }
                //}
                //      );

            }
            if (e.CellItem.Name == "btnRefuse")
            {  //弹出拒绝理由审批意见
                ShowFooterBar("frmRefuseLayout");
            }
            if (e.CellItem.Name == "btnEdit")
            {
                //跳转到编辑界面
                Leave.frmLeaveCreate frmLeaveCreate = new Leave.frmLeaveCreate();
                frmLeaveCreate.LID = lID;
                Redirect(frmLeaveCreate, (MobileForm form, object args) =>
                {
                    if (frmLeaveCreate.ShowResult == ShowResult.Yes)
                    {
                        ShowResult = ShowResult.Yes;
                        GetLeave();
                    }
                });
            }
        }
    }
}