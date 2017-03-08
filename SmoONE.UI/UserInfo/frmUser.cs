using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Application;
using SmoONE.CommLib;
using System.Threading.Tasks;
using SmoONE.Domain;
using System.Data;
using SmoONE.DTOs;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  当前用户详情界面
    // ******************************************************************
    partial class frmUser : Smobiler.Core.MobileForm
    {
        #region "definition"
        internal string toolbarItemName = "";
        private int eInfo;
        private Sex sex;//性别
        private DateTime toasttime;//toast时间
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ldEditUserInfo_ItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            try
            {
                switch (e.CellItem.Name)
                {
                    case "btnCancel":
                        ldEditUserInfo.Close();
                        break;
                    case "btnOK":
                        string errinfo;
                        if (eInfo == (int)EuserInfo.修改登录密码)
                        {
                            errinfo = "原密码";
                        }
                        else
                        {
                            errinfo = ((EuserInfo)Enum.ToObject(typeof(EuserInfo), eInfo)).ToString();
                        }
                        if (e.CellItem.Text.Trim().Length <= 0)
                        {
                            throw new Exception("请输入" + errinfo);
                        }

                        if (eInfo == (int)EuserInfo.修改登录密码)
                        {
                            //判断用户密码是否正确
                            string Pwd = e.Cell.Items["txtEditInfo"].Text.Trim();
                            string encryptPwd = AutofacConfig.userService.Encrypt(Pwd);
                            bool  result = AutofacConfig.userService.IsPwd(Client.Session["U_ID"].ToString(), encryptPwd);
                            if (result== false)
                            {
                                e.Cell.Items["txtEditInfo"].Text="";
                                throw new Exception("你输入的原密码不正确，请重新输入！");
                            }
                            else
                            {
                                frmChangePWD frmChangePWD = new frmChangePWD();
                                frmChangePWD.oldPwd = encryptPwd;
                                Redirect(frmChangePWD);
                            }
                        }
                        else
                        {
                           
                                UserInputDto upuser = new UserInputDto();
                                upuser.U_ID = Client.Session["U_ID"].ToString();
                                switch (eInfo)
                                {
                                    case (int)EuserInfo.修改昵称:
                                        upuser.U_Name = e.Cell.Items["txtEditInfo"].Text.Trim();
                                        break;
                                    case (int)EuserInfo.修改邮件:
                                        upuser.U_Email = e.Cell.Items["txtEditInfo"].Text.Trim();
                                        break;
                                }
                               
                                ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);

                                if (result.IsSuccess == false)
                                {
                                    throw new Exception(result.ErrorInfo);
                                }
                                else
                                {
                                    ldEditUserInfo.Close();
                                    GetUser();
                                }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message , ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 修改昵称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnName_Click(object sender, EventArgs e)
        {
            eInfo =(int) EuserInfo.修改昵称;
            ShowlayoutDialog();
        }
        /// <summary>
        /// 显示layoutDialog
        /// </summary>
        private void ShowlayoutDialog()

        {
            string editLbltxt;
            if (eInfo == (int)EuserInfo.修改登录密码)
            {
                editLbltxt = "修改密码前请填写原密码";
            }
            else
            {
                editLbltxt = ((EuserInfo)Enum.ToObject(typeof(EuserInfo), eInfo)).ToString();
            }
            ldEditUserInfo.LayoutData.Items["lblEditInfo"].DefaultValue = editLbltxt;
            switch (eInfo)
            {
                case (int)EuserInfo.修改昵称:
                    if (btnName.Text.Trim().Length > 0)
                    {
                        ldEditUserInfo.LayoutData.Items["txtEditInfo"].DefaultValue = btnName.Text.Trim();

                    }
                    else
                    {
                        ldEditUserInfo.LayoutData.Items["txtEditInfo"].DefaultValue = "";
                    }
                    break;
                case (int)EuserInfo.修改邮件:
                    if (btnEmail.Text.Trim().Length > 0)
                    {
                        ldEditUserInfo.LayoutData.Items["txtEditInfo"].DefaultValue = btnEmail.Text.Trim();
                    }
                    else
                    {
                        ldEditUserInfo.LayoutData.Items["txtEditInfo"].DefaultValue = "";
                    }
                    break;
                case (int)EuserInfo.修改登录密码:
                    ldEditUserInfo.LayoutData.Items["txtEditInfo"].DefaultValue = "";
                    break;

            }
            ldEditUserInfo.Show();
        }
       
        /// <summary>
        /// 修改Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmail_Click(object sender, EventArgs e)
        {
            eInfo = (int)EuserInfo.修改邮件;
            ShowlayoutDialog();
        }
        /// <summary>
        /// 修改登录密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPwd_Click(object sender, EventArgs e)
        {
            eInfo = (int)EuserInfo.修改登录密码 ;
            ShowlayoutDialog();
        }
        /// <summary>
        /// 修改出生日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpkBirthday_DatePicked(object sender, DatePickerEventArgs e)
        {
             UserDetailDto user = AutofacConfig.userService.GetUserByUserID(Client.Session["U_ID"].ToString());
             if (user != null)
             {
                 UserInputDto upuser = new UserInputDto();
                 upuser.U_ID = Client.Session["U_ID"].ToString();
                 upuser.U_Birthday = dpkBirthday.CurrentDate;
                 ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                 //返回结果如果为false，则修改失败
                 if (result.IsSuccess == false)
                 {
                     dpkBirthday.CurrentDate = (DateTime )upuser.U_Birthday;
                     Toast(result.ErrorInfo, ToastLength.SHORT);
                 }
             }
        }
        /// <summary>
        /// 修改用户头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraPortrait_ImageCaptured(object sender, BinaryData e)
        {
            if (e.IsError == false)
            {
                     UserInputDto upuser = new UserInputDto();
                     upuser.U_ID = Client.Session["U_ID"].ToString();
                     upuser.U_Portrait = e.ResourceID;
                     ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                     if (result.IsSuccess == false)
                     {
                         Toast(result.ErrorInfo, ToastLength.SHORT);
                     }
                     else
                     {
                         e.SaveFile(e.ResourceID + ".png");
                         imgPortrait.ResourceID = e.ResourceID;
                         imgPortrait.Refresh();
                     }
            }
        }
        /// <summary>
        /// 修改性别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popSex_Selected(object sender, EventArgs e)
        {
            if (popSex.Selection != null)
            {
                    UserInputDto upuser = new UserInputDto();
                    upuser.U_ID = Client.Session["U_ID"].ToString();
                    upuser.U_Sex = (Sex)Convert.ToInt32(popSex.Selection.Value);
                    ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                    if (result.IsSuccess == true)
                    {
                        sex =(Sex) Convert.ToInt32(popSex.Selection.Value);
                        btnSex.Text = popSex.Selection.Text;
                    }
                    else
                    {
                        Toast(result.ErrorInfo, ToastLength.SHORT);
                    }
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUser_Load(object sender, EventArgs e)
        {
           GetUser();
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        private void GetUser()
        {
            try
            {
                    UserDetails userDetails = new UserDetails();
                    UserDetailDto user = userDetails.getUser(Client.Session["U_ID"].ToString());
                    if (user !=null )
                     {
                        imgPortrait.ResourceID = user.U_Portrait;
                        btnName.Text = user.U_Name;
                        sex = (Sex)user.U_Sex;
                        switch (sex)
                        {
                            case Sex.男:
                                btnSex.Text = "男";
                                break;
                            case Sex.女:
                                btnSex.Text = "女";
                                break;

                        }
                        dpkBirthday.CurrentDate = user.U_Birthday;
                        btnEmail.Text = user.U_Email;
                }
                else
                {
                    throw new Exception("用户" + Client.Session["U_ID"].ToString() + "不存在，请检查！");
                }
                //UserDetailDto user = AutofacConfig.userService.GetUserByUserID(Client.Session["U_ID"].ToString());
                //if (user != null)
                //{
                //    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                //    {
                //        switch (user.U_Sex)
                //        {
                //            case (int)Sex.男:
                //                imgPortrait.ResourceID = "boy";
                //                break;
                //            case (int)Sex.女:
                //                imgPortrait.ResourceID = "girl";
                //                break;
                //        }
                //    }
                //    else
                //    {
                //        imgPortrait.ResourceID = user.U_Portrait;
                //    }
                //    btnName.Text = user.U_Name;
                //    sex = (Sex)user.U_Sex;
                //    switch (sex)
                //    {
                //        case Sex.男:
                //            btnSex.Text = "男";
                //            break;
                //        case Sex.女:
                //            btnSex.Text = "女";
                //            break;

                //    }

                //    dpkBirthday.CurrentDate = user.U_Birthday;
                //    btnEmail.Text = user.U_Email;
                //}
                //else
                //{
                //    throw new Exception("用户" + Client.Session["U_ID"].ToString() + "不存在，请检查！");
                //}
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
        private void frmUser_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (!e.Name.Equals( Me))
            {
                toolbarItemName = e.Name;
                Close();
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUser_KeyDown(object sender, KeyDownEventArgs e)
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
                //退出客户端
                this.Client.Exit();
            }
            else
            {
                toasttime = DateTime.Now;
                this.Toast("再按一次退出系统", ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 上传头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            cameraPortrait.GetPhoto();
        }
        /// <summary>
        /// 选择性别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSex_Click(object sender, EventArgs e)
        {
            popSex.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popSex.Groups.Add(poli);
            poli.Text = "性别选择";
            UserSex UserSex = new UserSex();
            DataTable table = UserSex.GetSex();
            foreach (DataRow  row in table.Rows)
            {
                poli.Items.Add(row["SexName"].ToString(), row["SexID"].ToString());
                    if (((int)sex).Equals(row["SexID"]))
                    {
                        popSex.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
   
            }
            popSex.ShowDialog();
    }
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否退出当前系统？", MessageBoxButtons.YesNo, (object o, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == Smobiler.Core.ShowResult.Yes)
                    {

                        this.Close();
                        frmLogon frmLogon = new frmLogon();
                       Redirect(frmLogon);
                        //退出客户端
                        //this.Client.Exit();
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message, ToastLength.SHORT);
                }
            });
        }
       
    }
    
}