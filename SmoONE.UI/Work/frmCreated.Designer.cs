using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmCreated : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCreated()
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
            this.gridCrateData = new Smobiler.Core.Controls.GridView();
            // 
            // gridCrateData
            // 
            this.gridCrateData.AllowSlip = true;
            this.gridCrateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.gridCrateData.Layout = "frmLeaveLayout";
            this.gridCrateData.Name = "gridCrateData";
            this.gridCrateData.PageSize = 8;
            this.gridCrateData.ShowGridLines = false;
            this.gridCrateData.Size = new System.Drawing.Size(300, 469);
            this.gridCrateData.TabIndex = 2;
            this.gridCrateData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridCrateData_CellClick);
            // 
            // frmCreated
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridCrateData});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "我发起的";
            this.Load += new System.EventHandler(this.frmCreated_Load);
            this.TitleImageClick += new System.EventHandler(this.frmCreated_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmCreated_KeyDown);
            this.Name = "frmCreated";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridCrateData;
    }
}