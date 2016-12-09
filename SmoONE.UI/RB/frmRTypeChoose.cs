using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler SmoONE1.0
    // 创建时间： 2016/11
    // 主要内容：  消费类型选择列表
    // ******************************************************************
    partial class frmRTypeChoose : Smobiler.Core.MobileForm
    {
        #region "definition"
        internal string TYPEID;                //消费类型编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void frmRBRowType_Load(object sender, EventArgs e)
        {
            try
            {                
                Bind();//绑定数据库数据操作
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
         /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                //显示数据报销类型
                List<Domain.RB_RType> Types = AutofacConfig.rBService.GetAllType();
                DataTable typetable = new DataTable();
                typetable.Columns.Add("TYPE", typeof(System.String));          //消费类型编号
                typetable.Columns.Add("TYPENAME", typeof(System.String));      //消费类型名称
                foreach (SmoONE.Domain.RB_RType row in Types)
                {
                    typetable.Rows.Add(row.RB_RT_ID,row.RB_RT_Name);
                }
                this.gridRBRowTypeData.Rows.Clear();//清空消费类型选择列表数据
                if (typetable.Rows.Count > 0)
                {
                    this.gridRBRowTypeData.DataSource = typetable;
                    this.gridRBRowTypeData.DataBind();
                }
               
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// gridRBRowTypeData点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridRBRowTypeData_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                //选中某个消费类型后，将选中的消费类型ID和名称传递到上一个页面
                TYPEID = e.Cell.Items["lblTypeName"].Value + "/" + e.Cell.Items["lblTypeName"].Text;
                this.ShowResult = Smobiler.Core.ShowResult.Yes;
                this.Close();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// TitleImage事件，左上角按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBRowType_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();         //关闭当前页面
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBRowType_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();         //关闭当前页面
            }
        }
       
    }
}