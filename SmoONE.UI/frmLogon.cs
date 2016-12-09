using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.CommLib;
using SmoONE.Domain;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  登录界面
    // ******************************************************************
    partial class frmLogon : Smobiler.Core.MobileForm
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                string userID=txtTel.Text.Trim();
                string pwd =txtPwd.Text.Trim();
                if (userID.Length <= 0)
                {
                    throw new Exception("请输入手机号码！");
                }
                if (pwd.Length <= 0)
                {
                    throw new Exception("请输入密码！");
                }
                if (pwd.Length < 6 || pwd.Length > 12)
                {
                    throw new Exception("密码必须为6-12位！");
                }
              
                //密码处理,经过加密
                string encryptPwd = AutofacConfig.userService.Encrypt(DateTime.Now.ToString("yyyyMMddHHmmss") + pwd);
                ReturnInfo result = AutofacConfig.userService.Login(userID, encryptPwd);
            
                if (result.IsSuccess == true)
                {
                    List<Role> role = AutofacConfig.userService.GetRoleByUserID(userID);
                    Client.Session["U_ID"] = userID;
                    Client.Session["Roler"] = role;
                  frmWork frmWork = new frmWork();
                  Redirect(frmWork);
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
        /// 退出客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_KeyDown(object sender, KeyDownEventArgs e)
        {
            Client.Exit();
        }

        /// <summary>
        /// 跳转到注册界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            SmoONE.UI.frmRegisterTel frmRegister = new SmoONE.UI.frmRegisterTel();
            Redirect(frmRegister);
        }
        /// <summary>
        /// 验证登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = txtTel.Text.Trim();
                if (userID.Length <= 0)
                {
                    throw new Exception("请输入手机号码！");
                }

                frmVerificationCode frmVerificationCode = new frmVerificationCode();
                frmVerificationCode.Tel = userID;
                frmVerificationCode.isVerifyLogon = true;
                Redirect(frmVerificationCode);
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}