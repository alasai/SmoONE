using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRTypeTempChoose : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRTypeTempChoose()
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
            this.gridRBModel = new Smobiler.Core.Controls.GridView();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            // 
            // gridRBModel
            // 
            this.gridRBModel.Layout = "frmRBModelLayout";
            this.gridRBModel.Location = new System.Drawing.Point(0, 2);
            this.gridRBModel.Name = "gridRBModel";
            this.gridRBModel.ShowGridLines = false;
            this.gridRBModel.Size = new System.Drawing.Size(300, 498);
            this.gridRBModel.TabIndex = 2;
            this.gridRBModel.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridRBModel_CellClick);
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.Location = new System.Drawing.Point(60, 180);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(180, 30);
            this.lblInfor.TabIndex = 3;
            this.lblInfor.Text = "当前暂无消费模板，请";
            // 
            // btnCreate
            // 
            this.btnCreate.Bold = true;
            this.btnCreate.BorderColor = System.Drawing.Color.White;
            this.btnCreate.FontSize = 18F;
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnCreate.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.Location = new System.Drawing.Point(190, 180);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.btnCreate.Size = new System.Drawing.Size(70, 30);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "创建！";
            this.btnCreate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // frmRTypeTempChoose
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridRBModel,
            this.lblInfor,
            this.btnCreate});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "消费模板选择";
            this.Load += new System.EventHandler(this.femRBRowModel_Load);
            this.TitleImageClick += new System.EventHandler(this.femRBRowModel_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.femRBRowModel_KeyDown);
            this.Name = "frmRTypeTempChoose";

        }
        #endregion

        internal Smobiler.Core.Controls.GridView gridRBModel;
        private Smobiler.Core.Controls.Label lblInfor;
        private Smobiler.Core.Controls.Button btnCreate;
    }
}