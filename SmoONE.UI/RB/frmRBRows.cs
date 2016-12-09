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
    // 主要内容：  消费记录列表界面
    // ******************************************************************
    partial class frmRBRows : Smobiler.Core.MobileForm
    {
        #region "definition"
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
                List<RB_RowsDto> RBRows = AutofacConfig.rBService.GetRowsByCreateUser(Client.Session["U_ID"].ToString());
                //消费记录测试数据
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(System.Int32));               //消费记录编号
                table.Columns.Add("RB_NO", typeof(System.String));           //报销单编号
                table.Columns.Add("RBROW_DATE", typeof(System.String));      //消费日期
                table.Columns.Add("RBROW_TYPE", typeof(System.String));      //消费类型编号
                table.Columns.Add("RBROW_TYPENAME", typeof(System.String));  //消费类型名称
                table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));   //消费金额
                table.Columns.Add("RBROW_NOTE", typeof(System.String));      //消费备注
                foreach (RB_RowsDto rows in RBRows)
                {
                    table.Rows.Add(rows.R_ID, rows.RB_ID, rows.R_ConsumeDate.ToString("yyyy/MM/dd"), rows.R_TypeID, rows.R_TypeName, rows.R_Amount, rows.R_Note);
                }

                this.gridRBRowData.Rows.Clear();//清空消费记录列表数据
                if (table.Rows.Count > 0)    //当行项中有数据时
                {
                   
                    this.lblInfor.Visible = false;          //隐藏提示文字
                    this.gridRBRowData.DataSource = table;
                    this.gridRBRowData.DataBind();
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
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBMain_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();            //初始化数据
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// gridRBRowData点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridRBRowData_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                frmRowsCreate frm = new frmRowsCreate();      //进入消费记录详情页面
                frm.ID = e.Cell.Items["lblMoney"].Value.ToString();
                this.Redirect(frm, (MobileForm sender1, object args) =>
                {
                    if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                    {
                        Bind();//重新加载数据
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBMain_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();             //关闭当前页面
            }
        }
        /// <summary>
        /// TitleImage事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBMain_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();             //关闭当前页面
        }
    
        /// <summary>
        /// 创建消费记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmRowsCreate frm = new frmRowsCreate();
            this.Redirect(frm, (MobileForm from, object args) =>
            {
                if (frm.ShowResult == Smobiler.Core.ShowResult.Yes)
                {
                    Bind();          //重新加载数据
                }
            });
        }
    }
}