using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmCCTo : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCCTo()
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
            // 
            // gridCCData
            // 
            this.gridCCData.AllowSlip = true;
            this.gridCCData.Layout = "frmLeaveLayout";
            this.gridCCData.Name = "gridCCData";
            this.gridCCData.PageSize = 8;
            this.gridCCData.ShowGridLines = false;
            this.gridCCData.Size = new System.Drawing.Size(300, 480);
            this.gridCCData.TabIndex = 2;
            this.gridCCData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridCCData_CellClick);
            // 
            // frmCCTo
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridCCData});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "³­ËÍÎÒµÄ";
            this.Load += new System.EventHandler(this.frmCCTo_Load);
            this.TitleImageClick += new System.EventHandler(this.frmCCTo_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmCCTo_KeyDown);
            this.Name = "frmCCTo";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridCCData;
    }
}