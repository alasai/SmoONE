using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRTypeChoose : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRTypeChoose()
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
            this.gridRBRowTypeData = new Smobiler.Core.Controls.GridView();
            // 
            // gridRBRowTypeData
            // 
            this.gridRBRowTypeData.Layout = "frmRBTypeLayout";
            this.gridRBRowTypeData.Name = "gridRBRowTypeData";
            this.gridRBRowTypeData.ShowGridLines = false;
            this.gridRBRowTypeData.Size = new System.Drawing.Size(300, 498);
            this.gridRBRowTypeData.TabIndex = 2;
            this.gridRBRowTypeData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridRBRowTypeData_CellClick);
            // 
            // frmRTypeChoose
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridRBRowTypeData});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "消费类型选择";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmRBRowType_Load);
            this.TitleImageClick += new System.EventHandler(this.frmRBRowType_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmRBRowType_KeyDown);
            this.Name = "frmRTypeChoose";

        }
        #endregion

        internal Smobiler.Core.Controls.GridView gridRBRowTypeData;
    }
}