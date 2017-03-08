using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Domain;
using SmoONE.UI.UserInfo;
using SmoONE.CommLib;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  手机验证界面
    // ******************************************************************
    partial class frmVerificationCode : Smobiler.Core.MobileForm
    {
        #region "definition"
        public string Tel;//手机号码
        public bool isVerifyLogon;//是否是验证登录
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVerificationCode_Load(object sender, EventArgs e)
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
                if (Tel != null)
                {              
                    lblTel.Text = "验证码已发送至手机：" + Tel;
                    if (isVerifyLogon==true )
                    {
                        lblHint.Visible = true;
                        lblHint.Top = txtVcode1.Top + txtVcode1.Height;
                        btnSave.Top = lblHint.Top + lblHint.Height;
                        //模拟发送短信验证码
                        ReturnInfo result = AutofacConfig.userService.SimulateSendVCode(Tel);
                        if (result.IsSuccess == false)
                        {
                            throw new Exception(result.ErrorInfo);
                        }
                    }
                    else 
                    {
                        lblHint.Visible = false ;
                        btnSave.Top = txtVcode1.Top + txtVcode1.Height+10;
                        //发送手机验证码，返回true，表示发送成功，否则发送失败，并抛出错误
                        ReturnInfo result = AutofacConfig.userService.SendVCode(Tel,Client .DeviceID);
                        if (result .IsSuccess ==false )
                        {
                            throw new Exception(result.ErrorInfo);
                        }
                    }
                }
                else
                {
                    throw new Exception("请输入手机号码");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtVcode1.Text.Trim();
             if (code .Length >0)
             {
                if (isVerifyLogon == true)
                {
                //判断验证码是否输入正确，当返回值为true时，表示验证成功，否则失败，弹出错误
                ReturnInfo result=    AutofacConfig.userService.LoginByVCode(Tel, code);
                if (result.IsSuccess == true)
                {
                    //获取当前用户角色
                    List<Role> role = AutofacConfig.userService.GetRoleByUserID(Tel);
                    Client.Session["U_ID"] = Tel;
                    Client.Session["Roler"] = role;
                    Close();
                    frmWork frmWork = new frmWork();
                    Redirect(frmWork);
                }
                else
                {
                    Toast(result.ErrorInfo,ToastLength.SHORT);
                }
                }
                else
                {
                    Close();
                    frmRegister frmRegister = new frmRegister();
                    frmRegister.Tel = Tel;
                    frmRegister.VCode = code;
                    Redirect(frmRegister);
                }
             }
            else 
             {
                 Toast("请输入手机验证码！",ToastLength.SHORT);
             }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVerificationCode_TitleImageClick(object sender, EventArgs e)
         {
            Close();
        }
      
         
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVerificationCode_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
    }
}