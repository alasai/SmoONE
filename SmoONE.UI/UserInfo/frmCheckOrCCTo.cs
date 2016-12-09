using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Application;
using SmoONE.DTOs;
using SmoONE.Domain;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容： 审批人或抄送人选择列表界面
    // ******************************************************************
    partial class frmCheckOrCCTo : Smobiler.Core.MobileForm
    {
        #region "definition"
        string userName="";//用户名称
        public bool isCTemUser;//是否是成本中心模板审批人员选择
        public bool isCCTO;//是否是抄送人员选择
       public bool isCheck;//是否是审批人员选择
       public string userInfo = "";//选中的用户
       AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
      #endregion
       private void frmCheckOrCCTo_Load(object sender, EventArgs e)
        {
            GetDate();
        }
        /// <summary>
       /// gridUserData点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void gridUserData_CellClick(object sender, GridViewCellEventArgs e)
        {
            //点击后关闭当前界面
            userInfo = e.Cell.Items["lblUser"].Value + "," + e.Cell.Items["lblUser"].Text + "," + e.Cell.Items["imgPortrait"].Value;
            ShowResult = ShowResult.Yes;
            Close();
        }
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1 .Text .Trim ().Length >0)
            {
                userName = textBox1.Text.Trim();
                GetDate();
            }
            
        }
        /// <summary>
        /// 获取审批人或抄送人数据数据
        /// </summary>
        private void GetDate()
        {
            List<UserDto> listUser =new List<UserDto>();//审批人或抄送人数据
             if (isCheck == true || isCTemUser == true)
            {
                //获取审批人数据或成本中心模板审批人数据
                listUser = AutofacConfig.userService.QueryCheckUsers(userName);
            }
            if (isCCTO  == true)
            {
                //获取抄送人数据
                listUser = AutofacConfig.userService.QueryCCUsers(userName);
            }
            gridUserData.Rows.Clear();//清空审批人或抄送人列表数据

            //如果审批人或抄送人数据大于0，则绑定数据
            if (listUser.Count() > 0)
            {
                foreach (UserDto user in listUser)
                {
                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                    {
                        UserDetailDto userinfo = AutofacConfig.userService.GetUserByUserID(user.U_ID);
                        switch (userinfo.U_Sex)
                        {
                            case (int)Sex.男:
                                user.U_Portrait = "boy";
                                break;
                            case (int)Sex.女:
                                user.U_Portrait = "girl";
                                break;
                        }
                    }
                    else
                    {
                        user.U_Portrait = user.U_Portrait;
                    }
                }
                gridUserData.DataSource = listUser;
                gridUserData.DataBind();

            }
           
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCheckOrCCTo_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCheckOrCCTo_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
    }
}