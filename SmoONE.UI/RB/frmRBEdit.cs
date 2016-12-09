using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI.CostCenter;
using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.DTOs;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  报销单编辑界面
    // ******************************************************************
    partial class frmRBEdit : Smobiler.Core.MobileForm
    {

        #region "definition"
        private string RBCC;                 //成本中心编号
        internal string ID;                //报销单编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
       

        /// <summary>
        /// 成本中心选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnChioce_Click(object sender, EventArgs e)
        {
            try
            {
                frmRBCostCenter frmCostCenter = new frmRBCostCenter();    
                this.Redirect(frmCostCenter, (MobileForm sender1, object args) =>
                {
                    try
                    {
                        if (frmCostCenter.ShowResult == Smobiler.Core.ShowResult.Yes)
                        {
                            string CCID = frmCostCenter.CCID;
                            string[] CCS = CCID.Split(new char[] { '/' });
                            RBCC = CCS[0];         //成本中心编号
                            this.btnRBCC.Text = CCS[1];           //成本中心名称
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                });
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
        private void frmRBEdit_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();               //初始化数据
                upCheckState();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
     
        /// <summary>
        /// 初始化数据，将数据显示到页面上
        /// </summary>
        private void Bind()
        {
            try
            {
                //显示报销明细
                List<RB_RowsDto> Rows = AutofacConfig.rBService.GetRowByRBID(ID);
                List<RB_RowsDto> UnReimRows = AutofacConfig.rBService.GetRowsByCreateUser(Client.Session["U_ID"].ToString());
                this.lblRBNO.Text = ID;                 //报销编号
                RBDetailDto Reim = AutofacConfig.rBService.GetByID(ID);
                RBCC = Reim.CC_ID;                //成本中心编号
                CCDetailDto Cost = AutofacConfig.costCenterService.GetCCByID(Reim.CC_ID);
                this.btnRBCC.Text = Cost.CC_Name;               //成本中心名称
                this.TxtNote.Text = Reim.RB_Note;                       //备注
                DataTable rowTable = new DataTable();
                rowTable.Columns.Add("ID", typeof(System.Int32));                       //消费记录编号
                rowTable.Columns.Add("RBCHECKED", typeof(System.Boolean));              //是否选中
                rowTable.Columns.Add("RB_NO", typeof(System.String));                   //报销单编号
                rowTable.Columns.Add("RBROW_DATE", typeof(System.String));              //消费日期
                rowTable.Columns.Add("RBROW_TYPE", typeof(System.String));              //消费类型编号
                rowTable.Columns.Add("RBROW_TYPENAME", typeof(System.String));          //消费类型名称
                rowTable.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));           //消费金额
                rowTable.Columns.Add("RBROW_NOTE", typeof(System.String));              //消费备注 
                foreach (RB_RowsDto Row in Rows)          //将原报销单中的行项添加到数据源中
                {
                    string TypeName = AutofacConfig.rBService.GetTypeNameByID(Row.R_TypeID);
                    
                    rowTable.Rows.Add(Row.R_ID,true,Row.RB_ID, Row.R_ConsumeDate.ToString("yyyy/MM/dd"), Row.R_TypeID, TypeName, Row.R_Amount, Row.R_Note);
                }
                foreach (RB_RowsDto Row in UnReimRows)          //将当前用户未报销的行项添加到数据源中
                {
                    string TypeName = AutofacConfig.rBService.GetTypeNameByID(Row.R_TypeID);
                    rowTable.Rows.Add(Row.R_ID, false, Row.RB_ID, Row.R_ConsumeDate.ToString("yyyy/MM/dd"), Row.R_TypeID, TypeName, Row.R_Amount, Row.R_Note);
                }
                if (rowTable.Rows.Count > 0)
                {
                    
                    rowTable.Columns.Add("ROW_NOTE", typeof(System.String));
                    rowTable.Columns.Add("ROW_DATE", typeof(System.String));
                    this.gridRBRowData.DataSource = rowTable;
                    this.gridRBRowData.DataBind();
                    getAmount();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// gridRBRowData点击事件，更新报销单总金额和全选框状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cell"></param>
        /// <param name="cellItem"></param>
        private void gridRBRowData_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            try
            {
                switch (e.CellItem.Name)
                {
                    //如果选中，计算报销单总金额
                    case "Check":
                        upCheckState();    //更新tooblar全选框状态
                        getAmount();
                        break;                   
                }                 
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 更新全选状态
        /// </summary>
        private void upCheckState()
        {
            int selectUserQty = 0;
            foreach (GridViewRow rows in gridRBRowData.Rows)
            {

                if (Convert.ToBoolean(rows.Cell.Items["Check"].DefaultValue) == true)
                {
                    selectUserQty += 1;
                }
            }
            //当gridView行项选中条数等于gridView行数时，为全选状态，否则为不选状态。
            if (selectUserQty == gridRBRowData.Rows.Count)
            { 
                FooterBarLayoutData.Items["Checkall"].DefaultValue = true;
            }
            else
            {             
                FooterBarLayoutData.Items["Checkall"].DefaultValue = false;
            }
        }
        /// <summary>
        ///计算报销单报销总金额
        /// </summary>
        /// <remarks></remarks>
        public void getAmount()
        {
            try
            {
                decimal sumAmount = 0;
                //判断消费记录是否选中，计算选中的消费记录总金额
                foreach (GridViewRow ROW in gridRBRowData.Rows)
                {
                    if (ROW.Cell.Items["Check"].DefaultValue.Equals(true))
                    {
                        if (ROW.Cell.Items["lblMoney"].Value.ToString().Length > 0)
                        {
                            sumAmount += Convert.ToDecimal(ROW.Cell.Items["lblMoney"].Value);
                        }
                    }
                }
                FooterBarLayoutData.Items["lblAmount"].DefaultValue = string.Format("￥{0}", sumAmount.ToString());     
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 全选
        /// </summary>
        private void getcheckall()
        {
            switch ((bool)FooterBarLayoutData.Items["Checkall"].DefaultValue)
            {
                case true:
                    foreach (GridViewRow rows in gridRBRowData.Rows)
                    {
                        rows.Cell.Items["Check"].DefaultValue = true;
                    }
                    break;
                case false:
                    foreach (GridViewRow rows in gridRBRowData.Rows)
                    {
                        rows.Cell.Items["Check"].DefaultValue = false;
                    }
                    break;
            }
            getAmount();      //计算总金额
        }
        /// <summary>
        /// FooterBar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBEdit_FooterBarLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            try
            {
                switch (e.CellItem.Name)
                {
                    case "Checkall":
                        //消费记录全部选中
                        getcheckall();
                        break;
                    case "btnSave":
                        RBInputDto ReimBur = new RBInputDto();
                        ReimBur.RB_Rows = new List<RB_RowsInputDto>();
                        ReimBur.RB_ID = this.lblRBNO.Text;            //报销单编号
                        ReimBur.CC_ID = RBCC;                   //成本中心编号
                        ReimBur.RB_Note = this.TxtNote.Text;                  //备注
                        //消费记录行项更改
                        foreach (GridViewRow ROW in gridRBRowData.Rows)
                        {
                            //判断消费记录是否选中
                            if (Convert.ToBoolean(ROW.Cell.Items["Check"].DefaultValue) == true)
                            {
                                //把选中行的Row的数据添加到报销单中
                                int RID = Convert.ToInt32(ROW.Cell.Items["imgType"].Value);
                                RB_RowsDto RBRow = AutofacConfig.rBService.GetRowByRowID(RID);
                                RB_RowsInputDto NewRBRow = new RB_RowsInputDto();
                                NewRBRow.R_ID = RBRow.R_ID;
                                NewRBRow.R_TypeID = RBRow.R_TypeID;
                                NewRBRow.R_Amount = RBRow.R_Amount;
                                NewRBRow.R_Note = RBRow.R_Note;
                                NewRBRow.R_ConsumeDate = RBRow.R_ConsumeDate;
                                ReimBur.RB_Rows.Add(NewRBRow);
                            }
                        }
                        ReturnInfo r = AutofacConfig.rBService.UpdateRB(ReimBur);       //将报销记录更新到数据库中
                        if (r.IsSuccess == true)
                        {
                            this.ShowResult = Smobiler.Core.ShowResult.Yes;
                            this.Close();
                            Toast("报销修改保存成功！");
                        }
                        else
                        {
                            throw new Exception(r.ErrorInfo);
                        }
                            break;
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }               
        }
        /// <summary>
        /// 手机自带返回键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBEdit_KeyDown(object sender, KeyDownEventArgs e)
        {
            //按了手机返回键，则返回到上一页
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();            //关闭当前页面
            }
        }        
       
        /// <summary>
        /// TitleImage点击事件，左上角按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBEdit_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();            //关闭当前页面
        }
    }
}