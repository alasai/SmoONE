using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatSelfDetail : Smobiler.Core.Controls.MobileForm
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
            this.gridView1 = new Smobiler.Core.Controls.ListView();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // gridView1
            // 
            this.gridView1.BackColor = System.Drawing.Color.White;
            this.gridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.Size(300, 450);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColr = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            // 
            // frmAttendanceStatSelfDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.gridView1});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatSelfDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatSelfDetail_Load);
            this.Name = "frmAttendanceStatSelfDetail";

        }
        #endregion

        private Smobiler.Core.Controls.ListView gridView1;
        private SmoONE.UI.Layout.Title title1;
    }
}