using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatSelfDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatSelfDetail()
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
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            // 
            // gridView1
            // 
            this.gridView1.AllowSlip = true;
            this.gridView1.Layout = "";
            this.gridView1.Name = "gridView1";
            this.gridView1.PageSize = 8;
            this.gridView1.ShowGridLines = false;
            this.gridView1.Size = new System.Drawing.Size(300, 480);
            this.gridView1.TabIndex = 2;
            // 
            // frmAttendanceStatSelfDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridView1});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.Load += new System.EventHandler(this.frmAttendanceStatSelfDetail_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatSelfDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatSelfDetail_KeyDown);
            this.Name = "frmAttendanceStatSelfDetail";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridView1;
    }
}