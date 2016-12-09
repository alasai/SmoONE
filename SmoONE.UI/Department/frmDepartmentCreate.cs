using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.CommLib;
using SmoONE.DTOs;
using SmoONE.Domain;

namespace SmoONE.UI.Department
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  部门创建或编辑界面
    // ******************************************************************
    partial class frmDepartmentCreate : Smobiler.Core.MobileForm
    {
        #region "definition"
        public string D_ID;//部门编号
        string leader="";//责任人
        string D_Portrait="";//部门头像
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDep_Name.Text .Trim ().Length <= 0)
                {
                    throw new Exception("请输入部门名称！");
                }
              
                if (leader.Length <= 0)
                {
                    throw new Exception("请输入责任人！");
                }
                DepInputDto department = new DepInputDto();
                department.Dep_Name = txtDep_Name.Text;
                if (txtProDay.Text.Trim().Length > 0)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtProDay.Text.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                    {
                        throw new Exception("项目人天必须为大于0的数字！");
                    }

                    else
                    {
                        department.Dep_ProDay = Convert.ToDecimal(txtProDay.Text);
                    }
                }
                else
                {
                    department.Dep_ProDay = 0;
                }
                if (txtOtherDay.Text.Trim().Length > 0)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtProDay.Text.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                    {
                        throw new Exception("项目其他人天必须为大于0的数字！");
                    }
                    else
                    {
                        department.Dep_OtherDay = Convert.ToDecimal(txtOtherDay.Text);
                    }
                }
                else
                {
                    department.Dep_OtherDay = 0;
                }
                department.Dep_UpdateUser = Client.Session["U_ID"].ToString();
                department.Dep_Leader = leader;
                if (string.IsNullOrEmpty(D_Portrait) == false)
                {
                    department.Dep_Icon = D_Portrait;
                }
                else
                {
                    department.Dep_Icon = "";
                }
                if (string.IsNullOrEmpty(D_ID) == false)
                {
                    department.Dep_ID = D_ID;
                    List<UserDto> listuserDto=  AutofacConfig .userService  .GetUserByDepID(D_ID);
                    List <string > listUser=new List<string> ();
                    foreach (UserDto user in listuserDto)
                    {
                        listUser.Add (user.U_ID);
                    }
                    department.UserIDs=listUser;
                    ReturnInfo result = AutofacConfig.departmentService.UpdateDepartment(department);
                    if (result.IsSuccess == false)
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                    else
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("部门保存成功！", ToastLength.SHORT);
                    }
                }
                else
                {
                    frmDepAssignUser frmDepAssignUser = new frmDepAssignUser();
                    frmDepAssignUser.department = department;
                    Redirect(frmDepAssignUser);
                }
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 获取责任人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeader_Click(object sender, EventArgs e)
        {
            popLeader.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popLeader.Groups.Add(poli);
            poli.Text = "责任人选择";
            List<UserDto> listuser = AutofacConfig.userService.GetAllUsers();
            foreach (UserDto user in listuser)
            {
                poli.Items.Add(user.U_Name, user.U_ID);
                if (leader.Trim().Length > 0)
                {
                    if (leader.Trim().Equals(user.U_ID))
                    {
                        popLeader.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            popLeader.Show();
        }

        private void frmDepartmentCreate_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        private void Bind()
        {
            try 
            {
                if (D_ID != null)
                {
                    DepDetailDto dep = AutofacConfig.departmentService.GetDepartmentByDepID(D_ID);
                    if (dep == null)
                    {
                        throw new Exception("部门" + D_ID + "不存在，请检查！");
                    }
                    txtDep_Name.Text = dep.Dep_Name;
                    txtProDay.Text = dep.Dep_ProDay.ToString();
                    txtOtherDay.Text = dep.Dep_OtherDay.ToString();
                    leader = dep.Dep_Leader;
                    if (string.IsNullOrEmpty(dep.Dep_Icon) == false)
                    {
                        D_Portrait = dep.Dep_Icon;
                        imgPortrait.ResourceID = dep.Dep_Icon;
                    }
                    else
                    {
                        imgPortrait.ResourceID = "bumenicon";
                    }
                    UserDetailDto userinfo = AutofacConfig.userService.GetUserByUserID(leader);
                    btnLeader.Text = userinfo.U_Name;
                    btnSave.Text = "提交";
                    btnAssignUser.Visible = true;
                    btnSave.Top = 270;
                }
                else
                {
                    btnAssignUser.Visible =false ;
                    btnSave.Top = 225;
                }
            }
                catch (Exception ex)
            {
                    MessageBox .Show (ex.Message );
             }
        }
        /// <summary>
        /// 责任人赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popLeader_Selected(object sender, EventArgs e)
        {
            if (popLeader.Selection != null)
            {
                if (AutofacConfig.departmentService.IsLeader(popLeader.Selection.Value) == false)
                {
                    leader = popLeader.Selection.Value;
                    btnLeader.Text = popLeader.Selection.Text;
                }
                else
                {
                    Toast(popLeader.Selection.Text+"已是部门责任人，请先解散部门！");
                }
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartmentCreate_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmDepartmentCreate_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 上传部门头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            cameraPortrait.GetPhoto();
        }
        /// <summary>
        /// 保存并赋值头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraPortrait_ImageCaptured(object sender, BinaryData e)
        {
            if (string.IsNullOrEmpty(e.ErrorInfo))
            {

                if (imgPortrait.ResourceID.Trim().Length > 0 & string.IsNullOrEmpty(D_Portrait)==false )
                {
                    e.SaveFile(D_Portrait+".png");
                    imgPortrait.ResourceID = D_Portrait;
                    imgPortrait.Refresh();
                }
                else
                {
                    e.SaveFile(e.ResourceID + ".png");
                    D_Portrait = e.ResourceID;
                    imgPortrait.ResourceID = e.ResourceID;
                    imgPortrait.Refresh();
                }
            }
        }
        /// <summary>
        /// 跳转到分配部门界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssignUser_Click(object sender, EventArgs e)
        {
            if (D_ID != null)
            {
                DepDetailDto dep = AutofacConfig.departmentService.GetDepartmentByDepID(D_ID);
                if (dep != null)
                {
                    DepInputDto department = new DepInputDto();
                    department.Dep_ID = dep.Dep_ID;
                    department.Dep_Name = dep.Dep_Name;
                    department.Dep_Leader = dep.Dep_Leader;
                    department.Dep_Icon = dep.Dep_Icon;
                    frmDepAssignUser frmDepAssignUser = new frmDepAssignUser();
                    frmDepAssignUser.department = department;
                    Redirect(frmDepAssignUser);
                }

            }
        }
    }
}