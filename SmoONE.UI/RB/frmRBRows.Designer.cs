using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRBRows : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBRows()
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
            this.gridRBRowData = new Smobiler.Core.Controls.GridView();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            // 
            // gridRBRowData
            // 
            this.gridRBRowData.Layout = "frmConsumptionLayout";
            this.gridRBRowData.Location = new System.Drawing.Point(0, 55);
            this.gridRBRowData.Name = "gridRBRowData";
            this.gridRBRowData.ShowGridLines = false;
            this.gridRBRowData.Size = new System.Drawing.Size(300, 435);
            this.gridRBRowData.TabIndex = 3;
            this.gridRBRowData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridRBRowData_CellClick);
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
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "创建消费记录";
            this.btnCreate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblInfor.Location = new System.Drawing.Point(0, 180);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(300, 30);
            this.lblInfor.TabIndex = 6;
            this.lblInfor.Text = "当前暂无消费记录，请创建！";
            this.lblInfor.Visible = false;
            // 
            // frmRBRows
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridRBRowData,
            this.btnCreate,
            this.lblInfor});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "消费记录";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmRBMain_Load);
            this.TitleImageClick += new System.EventHandler(this.frmRBMain_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmRBMain_KeyDown);
            this.Name = "frmRBRows";

        }
        #endregion

        internal Smobiler.Core.Controls.GridView gridRBRowData;
        private Smobiler.Core.Controls.Button btnCreate;
        private Smobiler.Core.Controls.Label lblInfor;
    }
}