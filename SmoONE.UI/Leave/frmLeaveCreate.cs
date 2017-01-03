using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.Application;
using SmoONE.Domain ;
using SmoONE.CommLib;
using SmoONE.DTOs;

namespace SmoONE.UI.Leave
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  请假创建或编辑界面
    // ******************************************************************
    partial class frmLeaveCreate : Smobiler.Core.MobileForm
    {
        #region "definition"
        public string LID;//请假编号
        private string type=""; //请假类别

        private int checkTop = 0;//审阅人top
        private int imgCheckLeft = 0;
        private string addCheckUser = "";//添加审批人
        private List<string> listCheckUsers = new List<string>(); //审阅人
        private List<ImageButton> listbtnCheckUsersP = new List<ImageButton>();//审阅人头像控件
        private List<Button> listbtnCheckUsers = new List<Button>();//审阅人名称控件

        private int ccTop=0;//抄送人top
        private int imgCCLeft = 0;
        private string addCCUser = "";//添加抄送人
        private List<string> listCCToUsers = new List<string>(); //抄送人
        private List<ImageButton> listbtnCCToUsersP = new List<ImageButton>();//抄送人头像控件
        private List<Button> listbtnCCToUsers = new List<Button>();//抄送人名称控件
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveCreate_Load(object sender, EventArgs e)
        {
            checkTop = lblCheck.Top + lblCheck.Height ;
            ccTop = lblCCTo.Top + lblCCTo.Height;
            Bind();
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                //当请假编号不为空时，获取请假信息
                if (LID != null)
                {
                    //获取请假信息
                    LeaveDetailDto leave = AutofacConfig.leaveService.GetByID(LID);
                    type = leave.L_TypeID;
                    btnType.Text = AutofacConfig.leaveService.GetTypeNameByID(leave.L_TypeID);
                    dpkStartDate.CurrentDate = leave.L_StartDate;
                    dpkEndDate.CurrentDate = leave.L_EndDate;
                    txtLday.Text = leave.L_LDay.ToString();
                    txtReason.Text = leave.L_Reason;
                    //获取图片
                    if (string.IsNullOrEmpty(leave.L_Img1) == false)
                    {
                        imgL.ResourceID = leave.L_Img1;
                    }
                   //获取审批人
                    if (leave.L_CheckUsers != null)
                    {
                        string[] CheckUsers = leave.L_CheckUsers.Split(',');
                        foreach (string checkUser in CheckUsers)
                        {
                            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(checkUser);
                            addCheckUser = checkUser + "," + user.U_Name + "," + user.U_Portrait;
                            addCheckusers();
                        }
                    }
                    //获取抄送人
                    if (string.IsNullOrEmpty(leave.L_CCTo)==false )
                    {
                        string[] CCToUsers = leave.L_CCTo.Split(',');
                        foreach (string ccToUser in CCToUsers)
                        {
                            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(ccToUser);
                            addCCUser = ccToUser + "," + user.U_Name + "," + user.U_Portrait;
                            addCCTousers();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 类别选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntype_Click(object sender, EventArgs e)
        {
            popType.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popType.Groups.Add(poli);
            poli.Text = "类别选择";
            //获取类别，并绑定poplist数据
            List <LeaveType >  listLType= AutofacConfig.leaveService.GetAllType ();
            foreach (LeaveType leaveType in listLType)
            {
                poli.Items.Add( leaveType.L_T_Name , leaveType .L_T_ID );
                if (type.Trim().Length > 0)
                {
                    if (type.Trim().Equals(leaveType.L_T_ID))
                    {
                        popType.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }

            popType.ShowDialog();
        }


        /// <summary>
        /// 类别赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popType_Selected(object sender, EventArgs e)
        {
            if (popType.Selection != null)
            {
                type = popType.Selection.Value;
                btnType.Text = popType.Selection.Text;
            }
        }

        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveCreate_TitleImageClick(object sender, EventArgs e)
        {
            //关闭当前界面
            Close();
        }

        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }

        /// <summary>
        /// 提交事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (type.Trim().Length <=0)
                {
                    throw new Exception("请输入请假类别！");
                }
                if (dpkStartDate.CurrentDate > dpkEndDate.CurrentDate)
                {
                    throw new Exception("开始时间必须小于结束时间！");
                }
                if (txtLday.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入请假天数！");
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtLday.Text.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                    {
                        throw new Exception("请假天数必须为大于0的数字！");
                    }
                }
                if (txtReason.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入请假事由！");
                }
                if (listCheckUsers.Count <= 0)
                {
                    throw new Exception("请输入审批人！");
                }

               //赋值请假信息
                LeaveInputDto leave = new LeaveInputDto();
                leave.L_TypeID = type;
                leave.L_StartDate = dpkStartDate.CurrentDate;
                leave.L_EndDate = dpkEndDate.CurrentDate;
                leave.L_LDay =  Convert .ToDecimal (txtLday.Text .Trim());
                leave.L_Reason = txtReason.Text.Trim();
                if (imgL.ResourceID.Trim().Length > 0)
                {
                    leave.L_Img1 = imgL.ResourceID.Trim();
                }
                else
                {
                    leave.L_Img1 = "";
                }
                if (listCheckUsers.Count > 0)
                {
                    string CheckUsers = "";
                    foreach (string checkuser in listCheckUsers)
                    {
                        if (string.IsNullOrWhiteSpace(CheckUsers) == true)
                        {
                            CheckUsers = checkuser;
                        }
                        else
                        {
                            CheckUsers += "," + checkuser;
                        }
                    }
                    leave.L_CheckUsers = CheckUsers;
                }
                string CCToUsers = "";
                if (listCCToUsers.Count > 0)
                {
                   
                    foreach (string user in listCCToUsers)
                    {
                        if (string.IsNullOrWhiteSpace(CCToUsers) == true)
                        {
                            CCToUsers = user;
                        }
                        else
                        {
                            CCToUsers += "," + user;
                        }
                    }
                }
                leave.L_CCTo = CCToUsers;
                 ReturnInfo result;
                 if (string.IsNullOrEmpty(LID) == false)
                 {
                     leave.L_ID = LID;
                     leave.L_UpdateUser  = Client.Session["U_ID"].ToString();
                     //更新请假信息
                     result = AutofacConfig.leaveService.UpdateLeave (leave);
                 }
                 else
                 {
                     //创建请假
                     leave.L_CreateUser = Client.Session["U_ID"].ToString();
                     result = AutofacConfig.leaveService.AddLeave(leave);
                 }
                //如果返回值true表示请假信息创建或更新成功，否则失败并抛出错误
                if (result.IsSuccess == true)
                {
                    ShowResult = ShowResult.Yes;
                        Close();
                    Toast("您的请假条已成功提交！", ToastLength.SHORT);
                   
                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
       
        /// <summary>
        /// 添加审阅人事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnAddCheck_Click(object sender, EventArgs e)
        {
            if (listCheckUsers.Count >= 4)
            {
                Toast ("最多只能添加4位审批人！", ToastLength.SHORT);
            }
            else
            {
                frmCheckOrCCTo frm = new frmCheckOrCCTo();
                frm.isCheck = true;
                Redirect(frm, (MobileForm form, object args) =>
                    {
                        if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            if (string.IsNullOrWhiteSpace(frm.userInfo) == false)
                            {
                                string Check = frm.userInfo;
                                if (listCheckUsers.Contains(Check.Split(',')[0]) == true)
                                {
                                    Toast("该审批人" + Check.Split(',')[1] + "已在列表中！");
                                }
                                else
                                {

                                    addCheckUser = Check;
                                    addCheckusers();
                                }
                            }
                        }
                    });
            }
        }
        /// <summary>
        /// 抄送人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnAddCCTo_Click(object sender, EventArgs e)
        {
            if (listCCToUsers.Count >= 4)
            {
                Toast("最多只能添加4位抄送人！", ToastLength.SHORT);
            }
            else
            {
                frmCheckOrCCTo frm = new frmCheckOrCCTo();
                frm.isCCTO = true;
                Redirect(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                    {
                        if (string.IsNullOrWhiteSpace(frm.userInfo) == false)
                        {
                            string CCToUser = frm.userInfo;
                            if (listCCToUsers.Contains(CCToUser.Split(',')[0]) == true)
                            {
                                Toast("该抄送人" + CCToUser.Split(',')[1] + "已在列表中！");
                            }
                            else
                            {
                                addCCUser = CCToUser;
                                addCCTousers();
                            }
                        }
                    }
                });
            }
        }

        //添加审批人
        private void addCheckusers()
        {
            if (addCheckUser.Trim().Length > 0 & listCheckUsers.Count <= 4)
            {
                if (listCheckUsers.Contains(addCheckUser) == false)
                {
                    listCheckUsers.Add(addCheckUser.Split(',')[0]);
                    int imgCheckWSize = 35;
                    ImageButton imgbtn = new ImageButton();
                    if (string.IsNullOrEmpty(addCheckUser.Split(',')[2]) == true)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(addCheckUser.Split(',')[0]);
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                imgbtn.ResourceID = "boy";
                                break;
                            case (int)Sex.女:
                                imgbtn.ResourceID = "girl";
                                break;
                        }
                    }
                    else
                    {
                        imgbtn.ResourceID = addCheckUser.Split(',')[2];
                    }

                    imgbtn.Width = imgCheckWSize;
                    imgbtn.Height = imgCheckWSize;
                    imgbtn.ZIndex = (Controls.Count + 1);
                    imgbtn.BorderRadius = 10;
                    imgbtn.Name = "imgbtnCheck" + addCheckUser.Split(',')[0];
                    imgbtn.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
                    imgbtn.Tag = addCheckUser.Split(',')[0];
                    Controls.Add(imgbtn);//界面添加审批人头像控件
                    listbtnCheckUsersP.Add(imgbtn);//添加审批人头像控件
                    imgbtn.Click += btnDelCheckClick;//删除审批人事件

                    Button btn = new Button();
                    btn.Text = addCheckUser.Split(',')[1];
                    btn.Name = "btnCheck" + addCheckUser.Split(',')[0];
                    btn.Width = imgCheckWSize;
                    btn.Height = 20;
                    btn.BackColor = System.Drawing.Color.White;
                    btn.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44);
                    btn.FontSize = 10;
                    btn.Tag = addCheckUser.Split(',')[0];
                    btn.ZIndex = (Controls.Count + 1);
                    Controls.Add(btn);//界面添加审批人名称控件
                    listbtnCheckUsers.Add(btn);//添加审批人名称控件
                    btn.Click += btnDelCheckClick;//删除审批人事件

                }

                addCheckUser = "";

            }
            CheckusersSort();
        }
        /// <summary>
        /// 添加抄送人
        /// </summary>
        private void addCCTousers()
        {

            if (addCCUser.Trim().Length > 0 & listCCToUsers.Count <= 4)
            {
                if (listCCToUsers.Contains(addCCUser) == false)
                {
                    listCCToUsers.Add(addCCUser.Split(',')[0]);
                    int imgCCWSize = 35;
                    ImageButton imgbtn = new ImageButton();
                    if (string.IsNullOrEmpty(addCCUser.Split(',')[2]) == true)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(addCCUser.Split(',')[0]);
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                imgbtn.ResourceID = "boy";
                                break;
                            case (int)Sex.女:
                                imgbtn.ResourceID = "girl";
                                break;
                        }
                    }
                    else
                    {
                        imgbtn.ResourceID = addCCUser.Split(',')[2];
                    }
                   

                    imgbtn.Width = imgCCWSize;
                    imgbtn.Height = imgCCWSize;
                    imgbtn.ZIndex = (Controls.Count + 1);
                    imgbtn.BorderRadius = 10;
                    imgbtn.Name = "imgbtnCC" + addCCUser.Split(',')[0];
                    imgbtn.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
                    imgbtn.Tag = addCCUser.Split(',')[0];
                    Controls.Add(imgbtn);//界面添加抄送人头像控件
                    listbtnCCToUsersP.Add(imgbtn);//添加抄送人头像控件
                    imgbtn.Click += btnDelCCToClick;//删除抄送人事件

                    Button btn = new Button();
                    btn.Text = addCCUser.Split(',')[1];
                    btn.Name = "btnCC" + addCCUser.Split(',')[0];
                    btn.Width = imgCCWSize;
                    btn.Height = 20;
                    btn.BackColor = System.Drawing.Color.White;
                    btn.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44);
                    btn.FontSize = 10;
                    btn.Tag = addCCUser.Split(',')[0];
                    btn.ZIndex = (Controls.Count + 1);
                    Controls.Add(btn);//界面添加抄送人名称控件
                    listbtnCCToUsers.Add(btn);//添加抄送人名称控件
                    btn.Click += btnDelCCToClick;//删除抄送人事件
                }

                addCCUser = "";

            }
            CCToUsersSort();
        }

        /// <summary>
        /// 点击删除请假审批人事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnDelCheckClick(object sender, EventArgs e)
        {
            try
            {
                object checkUser = ((MobileControl)sender).Tag;//获取财务审批人头像
                if (checkUser != null)
                {
                    listCheckUsers.Remove(checkUser.ToString());//删除财务审批人
                    foreach (ImageButton imgbtnCheck in listbtnCheckUsersP)
                    {
                        if (imgbtnCheck.Name.Equals("imgbtnCheck" + checkUser))
                        {
                            listbtnCheckUsersP.Remove(imgbtnCheck);//删除财务审批头像控件
                            Controls.Remove((MobileControl)imgbtnCheck);//删除界面中财务审批头像控件
                            break;
                        }

                    }
                    foreach (Button btnCheck in listbtnCheckUsers)
                    {
                        if (btnCheck.Name.Equals("btnCheck" + checkUser))
                        {
                            listbtnCheckUsers.Remove(btnCheck);//删除财务审批名称控件
                            Controls.Remove((MobileControl)btnCheck);//删除界面中财务审批名称控件
                            break;
                        }
                    }

                    checkTop = lblCheck.Top + lblCheck.Height;
                    CheckusersSort();//审批人相关控件排序
                    checkUser = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 点击删除请假抄送人事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnDelCCToClick(object sender, EventArgs e)
        {
            try
            {
                object CCUser = ((MobileControl)sender).Tag;//获取抄送人头像
                if (CCUser != null)
                {
                    listCCToUsers.Remove(CCUser.ToString());//删除抄送人
                    foreach (ImageButton imgbtnFChecker in listbtnCCToUsersP)
                    {
                        if (imgbtnFChecker.Name.Equals("imgbtnCC" + CCUser))
                        {
                            listbtnCCToUsersP.Remove(imgbtnFChecker);//删除抄送人头像控件
                            Controls.Remove((MobileControl)imgbtnFChecker);//删除界面中抄送人头像控件
                            break;
                        }

                    }
                    foreach (Button btnFChecker in listbtnCCToUsers)
                    {
                        if (btnFChecker.Name.Equals("btnCC" + CCUser))
                        {
                            listbtnCCToUsers.Remove(btnFChecker);//删除抄送人名称控件
                            Controls.Remove((MobileControl)btnFChecker);//删除界面中抄送人名称控件
                            break;
                        }
                    }

                    ccTop = lblCCTo.Top + lblCCTo.Height;
                    CCToUsersSort();//抄送人相关控件排序
                    CCUser = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 审阅人控件排序
        /// </summary>
        private void CheckusersSort()
        {
            int imgCheckWSize = 35;
            int imgCheckHSize = 55;
            imgCheckLeft = 65;
            if (listCheckUsers.Count > 0 & listCheckUsers.Count <= 4)
            {
                //如果已经添加了4位审批人，则隐藏添加抄送人控件，否则显示
                if (listCheckUsers.Count == 4)
                {
                    imgbtnAddCheck.Visible = false;
                }
                else
                {
                    imgbtnAddCheck.Visible = true;
                }
                foreach (string checkuser in listCheckUsers)
                {
                    foreach (Button btnCheckUser in listbtnCheckUsers)
                    {
                        if (btnCheckUser.Name.Equals("btnCheck" + checkuser))
                        {
                                if ((imgCheckLeft + imgCheckWSize) > 300)
                                {
                                    imgCheckLeft = 0;
                                    checkTop = checkTop + imgCheckHSize;
                                    if (checkTop > Height)
                                    {
                                        Height = Height + imgCheckHSize;
                                    }
                                }

                                foreach (ImageButton imgbtnCheckUser in listbtnCheckUsersP)
                                {
                                    if (imgbtnCheckUser.Name.Equals("imgbtnCheck" + checkuser))
                                    {
                                        imgbtnCheckUser.Left = imgCheckLeft;
                                        imgbtnCheckUser.Top = checkTop;

                                        btnCheckUser.Left = imgCheckLeft;
                                        btnCheckUser.Top = imgbtnCheckUser.Top + imgbtnCheckUser.Height;
                                        imgCheckLeft += (imgCheckWSize + 10);
                                        break;
                                    }
                                }
                            continue;
                        }
                    }
                }
            }
            imgbtnAddCheck.Top = checkTop;
            imgbtnAddCheck.Left = imgCheckLeft;
            lblCCTo.Top = lblCheck2.Top + lblCheck2.Height + 10;
            lblCCTo1.Top = lblCCTo.Top;
            ccTop = lblCCTo.Top + lblCCTo.Height;
            lblCCTo2.Top = ccTop;
            imgbtnAddCCTo.Top = ccTop;
            CCToUsersSort();
        }

        /// <summary>
        /// 抄送人控件排序
        /// </summary>
        private void CCToUsersSort()
        {
            int imgCCWSize = 35;
            int imgCCHSize = 55;
            imgCCLeft = 65;
            if (listCCToUsers.Count > 0 & listCCToUsers.Count <= 4)
            {
                //如果已经添加了4位抄送人，则隐藏添加抄送人控件，否则显示
                if (listCCToUsers.Count == 4)
                {

                    imgbtnAddCCTo.Visible = false;
                }
                else
                {
                    imgbtnAddCCTo.Visible = true;
                }
                foreach (string ccToUser in listCCToUsers)
                {
                    foreach (Button btnCCUser in listbtnCCToUsers)
                    {
                        if (btnCCUser.Name.Equals("btnCC" + ccToUser))
                        {
                          
                                if ((imgCCLeft + imgCCWSize) > 300)
                                {
                                    imgCCLeft = 0;
                                    ccTop = ccTop + imgCCHSize;
                                    if (ccTop > Height)
                                    {
                                        Height = Height + imgCCHSize;
                                    }
                                }
                              
                                foreach (ImageButton imgbtnCC in listbtnCCToUsersP)
                                {
                                    if (imgbtnCC.Name.Equals("imgbtnCC" + ccToUser))
                                    {
                                        imgbtnCC.Left = imgCCLeft;
                                        imgbtnCC.Top = ccTop;

                                        btnCCUser.Left = imgCCLeft;
                                        btnCCUser.Top = imgbtnCC.Top + imgbtnCC.Height;
                                        imgCCLeft += (imgCCWSize + 10);
                                        break;
                                    }
                                }
                            continue;
                      }
                    }
                }
            }
            imgbtnAddCCTo.Top = ccTop;
            lblCCTo2.Height = imgCCHSize;
            imgbtnAddCCTo.Left = imgCCLeft;
            btnSave.Top = lblCCTo2.Top + lblCCTo2.Height + 10;
            if (Height < (btnSave.Top + btnSave.Height))
            {
                Height = btnSave.Top + btnSave.Height + 10;
            }

        }
        
        /// <summary>
        /// 拍照上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupPhoto_Click(object sender, EventArgs e)
        {
            camera1.GetPhoto();
        }
        /// <summary>
        /// 删除图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelPhoto_Click(object sender, EventArgs e)
        {
            if (imgL.ResourceID.Length > 0)
            {
                MessageBox.Show("是否确定删除图片？", "删除", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == Smobiler.Core.ShowResult.Yes)
                    {
                        imgL.ResourceID = "";
                        imgL.Refresh();
                    }
                }
                       );
            }
            else
            {
                Toast("您没有上传图片，不能删除！",ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void camera1_ImageCaptured(object sender, BinaryData e)
        {
            if (string.IsNullOrEmpty(e.ErrorInfo))
            {

                if (imgL.ResourceID.Trim().Length > 0)
                {
                    e.SaveFile(imgL.ResourceID + ".png");//保存图片文件到本地运行项目的image文件夹中
                    imgL.Refresh();//当图片上传文件名相同时，刷新界面图片内容
                }
                else
                {
                    e.SaveFile(e.ResourceID + ".png");//保存图片文件到本地运行项目的image文件夹中
                    imgL.ResourceID = e.ResourceID;
                }
            }
        }
    }
}