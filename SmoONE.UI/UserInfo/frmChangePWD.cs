using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Application;
using System.Threading.Tasks;
using SmoONE.CommLib;
using SmoONE.Domain;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  密码修改界面
    // ******************************************************************
    partial class frmChangePWD : Smobiler.Core.MobileForm
    {
        #region "definition"
        public string oldPwd;//修改密码
        bool isPwdC1 = true ; //新密码是否显示密码字符变量
        bool isPwdC2 = true ;//确认密码是否显示密码字符变量
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 新密码是否显示密码字符事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnPwdC1_Click(object sender, EventArgs e)
        {
            if (isPwdC1 == false)
            {
                txtPwd1.PasswordChar = '*';//设置textbox为密码字符
                imgbtnPwdC1.ResourceID = "!\\ue8f5192192192";
                imgbtnPwdC1.Refresh();
                isPwdC1 = true;
               
            }
            else
            {
                txtPwd1.PasswordChar = ' ';//textbox密码字符为空时，显示明文
                imgbtnPwdC1.ResourceID = "!\\ue417043146223";
                imgbtnPwdC1.Refresh();
                isPwdC1 = false;
            }
        }
        /// <summary>
        /// 确认密码是否显示密码字符事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnPwdC2_Click(object sender, EventArgs e)
        {
            if (isPwdC2 == false)
            {
                txtPwd2.PasswordChar = '*';//设置textbox为密码字符
                imgbtnPwdC2.ResourceID = "!\\ue8f5192192192";
                imgbtnPwdC2.Refresh();
                isPwdC2 = true;

            }
            else
            {
                txtPwd2.PasswordChar = ' ';//textbox密码字符为空时，显示明文
                imgbtnPwdC2.ResourceID = "!\\ue417043146223";
                imgbtnPwdC2.Refresh();
                isPwdC2 = false;
            }
        }
        /// <summary>
        /// 修改保存密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd1 = txtPwd1.Text.Trim();
                string pwd2 = txtPwd2.Text.Trim();
                if (string.IsNullOrEmpty(oldPwd) == false)
                {
                    throw new Exception("请输入原密码！");
                }
                if (pwd1.Length <= 0)
                {
                    throw new Exception("请输入新密码！");
                }
               
                if (pwd2.Length <= 0)
                {
                    throw new Exception("请输入确认密码！");
                }
                if (!pwd1.Equals(pwd2))
                {
                    throw new Exception("两次密码输入不一致，请检查！");
                }
                if (pwd1.Length < 6 || pwd1.Length > 12)
                {
                    throw new Exception("新密码必须为6-12位！");
                }
                if (pwd2.Length < 6 || pwd2.Length > 12)
                {
                    throw new Exception("新密码必须为6-12位！");
                }
                if (oldPwd.Equals(pwd2))
                {
                    throw new Exception("您输入新密码和原密码密码一致，请重新输入！");
                }
                if (oldPwd != null)
                {
                    //新密码处理,经过加密
                    string encryptPwd = AutofacConfig.userService.Encrypt(pwd2);
                    //更改密码
                    ReturnInfo result = AutofacConfig.userService.ChangePwd(Client .Session ["U_ID"].ToString (), oldPwd, encryptPwd);
                   //如果返回true则修改成功，否则弹出错误
                    if (result.IsSuccess == true)
                    {
                        Close();
                        Toast("密码修改成功！", ToastLength.SHORT);
                    }
                    else
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                }
              
            }
            catch(Exception ex)
            {
                Toast(ex.Message ,ToastLength.SHORT );
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChangePWD_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmChangePWD_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        } 

    }
}