using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostCenter : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostCenter()
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
            this.gridCCData = new Smobiler.Core.Controls.GridView();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            // 
            // gridCCData
            // 
            this.gridCCData.AutoHeight = true;
            this.gridCCData.Layout = "frmCostCenterLayout";
            this.gridCCData.Location = new System.Drawing.Point(0, 55);
            this.gridCCData.Name = "gridCCData";
            this.gridCCData.PageSize = 8;
            this.gridCCData.ShowGridLines = false;
            this.gridCCData.Size = new System.Drawing.Size(300, 401);
            this.gridCCData.TabIndex = 2;
            this.gridCCData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridCCData_CellClick);
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
            this.btnCreate.Text = "创建成本中心";
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
            this.lblInfor.Text = "当前暂无成本中心，请创建！";
            this.lblInfor.Visible = false;
            // 
            // frmCostCenter
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridCCData,
            this.btnCreate,
            this.lblInfor});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "成本中心";
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.TitleImageClick += new System.EventHandler(this.frmCostCenter_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmCostCenter_KeyDown);
            this.Name = "frmCostCenter";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridCCData;
        private Smobiler.Core.Controls.Button btnCreate;
        private Smobiler.Core.Controls.Label lblInfor;
    }
}