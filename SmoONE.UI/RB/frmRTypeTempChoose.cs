using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.DTOs;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  消费模板选择界面
    // ******************************************************************
    partial class frmRTypeTempChoose : Smobiler.Core.MobileForm
    {
        #region "definition"
        internal string RTTemplaetID;           //模板编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// gridRBModel点击事件,选中模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridRBModel_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                //选中某个模板后，将选中模板的编号传递到上一个页面
                RTTemplaetID = e.Cell.Items["lblRT_Money"].Value.ToString();
                this.ShowResult = Smobiler.Core.ShowResult.Yes;
                this.Close();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// TitleImage点击事件，左上角按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void femRBRowModel_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();         //关闭当前页面
        }
        /// <summary>
        /// 手机自带返回操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void femRBRowModel_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();         //关闭当前页面
            }
        }
   
        /// <summary>
        /// 初始化方法，加载数据
        /// </summary>
        private void Bind()
        {
            try
            {
                List<RB_RType_TemplateDto> RBRTypeTemplate = AutofacConfig.rBService.GetTemplateByCreateUser(Client.Session["U_ID"].ToString());    //Steven的用户ID
                DataTable table = new DataTable();
                table.Columns.Add("RB_RTT_TemplateID");
                table.Columns.Add("RB_RTT_TypeID");
                table.Columns.Add("RB_RTT_TypeName");
                table.Columns.Add("RB_RTT_Amount");
                table.Columns.Add("RB_RTT_Note");
                foreach (RB_RType_TemplateDto row in RBRTypeTemplate)
                {
                    String TypeName = AutofacConfig.rBService.GetTypeNameByID(row.RB_RTT_TypeID);
                    table.Rows.Add(row.RB_RTT_TemplateID, row.RB_RTT_TypeID, TypeName, row.RB_RTT_Amount, row.RB_RTT_Note);
                }
                gridRBModel.Rows.Clear(); //清空消费模板选择列表数据
                if (table.Rows.Count > 0)
                {
                    this.lblInfor.Visible = false;
                    this.btnCreate.Visible = false;
                    this.gridRBModel.DataSource = table;
                    this.gridRBModel.DataBind();
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
        private void femRBRowModel_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();                   //加载消费模板数据
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 点击创建按钮，跳转到创建模板页面
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