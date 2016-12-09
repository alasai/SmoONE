using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  消费模板列表界面
    // ******************************************************************
    partial class frmRTypeTemplate : Smobiler.Core.MobileForm
    {
        #region "Properties"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                List<RB_RType_TemplateDto> RBRTypeTemplate = AutofacConfig.rBService.GetTemplateByCreateUser(Client.Session["U_ID"].ToString());    //根据当前用户ID查询消费模板
                DataTable table = new DataTable();
                table.Columns.Add("RB_RTT_TemplateID");         //消费模板编号
                table.Columns.Add("RB_RTT_TypeID");             //消费类型编号
                table.Columns.Add("RB_RTT_TypeName");           //消费类型名称
                table.Columns.Add("RB_RTT_Amount");             //消费金额
                table.Columns.Add("RB_RTT_Note");               //消费备注  
                foreach (RB_RType_TemplateDto row in RBRTypeTemplate)
                {
                    String TypeName = AutofacConfig.rBService.GetTypeNameByID(row.RB_RTT_TypeID);
                    table.Rows.Add(row.RB_RTT_TemplateID, row.RB_RTT_TypeID, TypeName, row.RB_RTT_Amount, row.RB_RTT_Note);
                }
                this.gridRBModelData.Rows.Clear(); //清空消费模板列表数据
                if (table.Rows.Count > 0)              //当行项中有数据时
                {   
                    this.lblInfor.Visible = false;            //隐藏提示文字
                    //赋值数据
                    this.gridRBModelData.DataSource = table;
                    this.gridRBModelData.DataBind();
                }
                else
                {
                    this.lblInfor.Visible = true ; 
                   
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 初始化页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsModelList_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();      //加载数据
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// gridRBModelData,点击进入模板详情页面       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridRBModelData_CellClick(object sender, GridViewCellEventArgs e)
        {          
            frmRTypeTempCreate frm = new frmRTypeTempCreate();              //进入模板创建或者详情页面
            frm.ID = e.Cell.Items["lblRT_Money"].Value.ToString();
            this.Redirect(frm, (MobileForm sender1, object args) =>
            {
                if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                {
                    Bind();            //重新加载数据
                }
            });
        }
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsModelList_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();         //关闭当前页面
            }
        }
  
        /// <summary>
        /// TitleImage点击事件，左上角退出当前页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsModelList_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();         //关闭当前页面
        }
        /// <summary>
        /// 创建消费模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmRTypeTempCreate frm = new frmRTypeTempCreate();         //进入模板创建页面
            this.Redirect(frm, (MobileForm from, object args) =>
            {
                if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                {
                    Bind();
                }
            });
        }      
    }
}