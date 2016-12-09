using System;
using Smobiler.Core;
namespace SmoONE.UI.Department
{
    partial class frmDepartment : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmDepartment()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.gridDepData = new Smobiler.Core.Controls.GridView();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            this.treeDepData = new Smobiler.Core.Controls.TreeView();
            // 
            // gridDepData
            // 
            this.gridDepData.AllowSlip = true;
            this.gridDepData.Layout = "frmDepartmentLayout";
            this.gridDepData.Location = new System.Drawing.Point(0, 55);
            this.gridDepData.Name = "gridDepData";
            this.gridDepData.PageSize = 8;
            this.gridDepData.ShowGridLines = false;
            this.gridDepData.Size = new System.Drawing.Size(300, 270);
            this.gridDepData.TabIndex = 2;
            this.gridDepData.ZIndex = 2;
            this.gridDepData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridDepData_CellClick);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.BorderRadius = 2;
            this.btnCreate.FontSize = 17F;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnCreate.HoverForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(10, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(280, 35);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "创建部门";
            this.btnCreate.ZIndex = 1;
            this.btnCreate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblInfor.Location = new System.Drawing.Point(0, 180);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(300, 30);
            this.lblInfor.TabIndex = 4;
            this.lblInfor.Text = "当前暂无部门，请创建！";
            this.lblInfor.Visible = false;
            this.lblInfor.ZIndex = 4;
            // 
            // treeDepData
            // 
            this.treeDepData.ExpandAll = true;
            this.treeDepData.FontSize = 15F;
            this.treeDepData.Location = new System.Drawing.Point(0, 55);
            this.treeDepData.Name = "treeDepData";
            this.treeDepData.NodeCollapseIcon = "!\\ue315045045045";
            this.treeDepData.NodeExpandIcon = "!\\ue313045045045";
            this.treeDepData.NodeHeight = 45F;
            this.treeDepData.SelectBackColor = System.Drawing.Color.WhiteSmoke;
            this.treeDepData.Size = new System.Drawing.Size(300, 270);
            this.treeDepData.TabIndex = 5;
            this.treeDepData.ZIndex = 3;
            this.treeDepData.NodeSelected += new System.EventHandler(this.treeDepData_NodeSelected);
            // 
            // frmDepartment
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnCreate,
            this.gridDepData,
            this.treeDepData,
            this.lblInfor});
            this.FooterBarLayout = "frmDepartmentModeLayout";
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "部门";
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmDepartment_FooterBarLayoutItemClick);
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.TitleImageClick += new System.EventHandler(this.frmDepartment_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmDepartment_KeyDown);
            this.Name = "frmDepartment";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridDepData;
        private Smobiler.Core.Controls.Button btnCreate;
        private Smobiler.Core.Controls.Label lblInfor;
        private Smobiler.Core.Controls.TreeView treeDepData;
    }
}