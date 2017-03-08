using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatMan : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatMan()
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
            this.gridATdata = new Smobiler.Core.Controls.GridView();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // gridATdata
            // 
            this.gridATdata.AllowSlip = true;
            this.gridATdata.AutoHeight = true;
            this.gridATdata.Layout = "frmATStatisticsDayLayout";
            this.gridATdata.Location = new System.Drawing.Point(0, 35);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 8;
            this.gridATdata.Size = new System.Drawing.Size(300, 458);
            this.gridATdata.TabIndex = 2;
            this.gridATdata.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATdata_CellClick);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(300, 35);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "2017Äê2ÔÂ9ÈÕ";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 35);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 4;
            // 
            // frmAttendanceStatMan
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridATdata,
            this.lblDate,
            this.line1});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.Load += new System.EventHandler(this.frmAttendanceStatMan_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatMan_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatMan_KeyDown);
            this.Name = "frmAttendanceStatMan";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridATdata;
        private Smobiler.Core.Controls.Label lblDate;
        private Smobiler.Core.Controls.Line line1;
    }
}