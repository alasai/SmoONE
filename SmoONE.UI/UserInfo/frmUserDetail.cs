using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;

namespace SmoONE.UI.UserInfo
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  用户详情界面
    // ******************************************************************
    partial class frmUserDetail : Smobiler.Core.MobileForm
    {
        #region "definition"
        internal string U_ID;//用户编号
        private Sex sex;//性别
        private string email = "";//邮件
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void frmUserDetail_Load(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(U_ID) == true)
                {
                    throw new Exception("请输入电话号码！");

                }
                UserDetailDto user = AutofacConfig.userService.GetUserByUserID(U_ID);
                if (user != null)
                {
                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                    {
                        switch (user.U_Sex)
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
                        imgPortrait.ResourceID = user.U_Portrait;
                    }
                    string name = user.U_Name;
                    sex = (Sex)user.U_Sex;
                    switch (sex)
                    {
                        case Sex.男:
                            lblName.Text = name+"  男";
                            break;
                        case Sex.女:
                            lblName.Text = name + "  女";
                            break;

                    }
                    lblTel.Text = U_ID;
                    lblBirthday.Text = user.U_Birthday.ToString ("yyyy/MM/dd");
                    email = user.U_Email;
                    lblEmail.Text = user.U_Email;
                }
                else
                {
                    throw new Exception("用户" + U_ID + "不存在，请检查！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 打电话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTel_Click(object sender, EventArgs e)
        {
            Client.TelCall(U_ID);
        }
        /// <summary>
        /// 发短信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMes_Click(object sender, EventArgs e)
        {
            Client.SendSMS("", U_ID);
        }
        /// <summary>
        /// 发邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmail_Click(object sender, EventArgs e)
        {
            Client.SendEmail("","",email );
        }
        /// <summary>
        ///  手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserDetail_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmUserDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}