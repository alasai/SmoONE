using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatMonthTypeDay : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatMonthTypeDay()
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
            this.gridATTypeDaydata = new Smobiler.Core.Controls.GridView();
            this.lblATMonth = new Smobiler.Core.Controls.Label();
            // 
            // gridATTypeDaydata
            // 
            this.gridATTypeDaydata.AllowSlip = true;
            this.gridATTypeDaydata.AutoHeight = true;
            this.gridATTypeDaydata.Layout = "frmAttendanceStatDayLayout";
            this.gridATTypeDaydata.Location = new System.Drawing.Point(0, 35);
            this.gridATTypeDaydata.Name = "gridATTypeDaydata";
            this.gridATTypeDaydata.PageSize = 8;
            this.gridATTypeDaydata.ShowGridLines = false;
            this.gridATTypeDaydata.Size = new System.Drawing.Size(300, 419);
            this.gridATTypeDaydata.TabIndex = 2;
            this.gridATTypeDaydata.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATTypeDaydata_CellClick);
            // 
            // lblATMonth
            // 
            this.lblATMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblATMonth.ForeColor = System.Drawing.Color.White;
            this.lblATMonth.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblATMonth.Location = new System.Drawing.Point(0, 1);
            this.lblATMonth.Name = "lblATMonth";
            this.lblATMonth.Size = new System.Drawing.Size(300, 35);
            this.lblATMonth.TabIndex = 3;
            this.lblATMonth.Text = "label1";
            // 
            // frmAttendanceStatMonthTypeDay
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridATTypeDaydata,
            this.lblATMonth});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "¿¼ÇÚÔÂ±¨±í";
            this.Load += new System.EventHandler(this.frmAttendanceStatMonthTypeDay_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatMonthTypeDay_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatMonthTypeDay_KeyDown);
            this.Name = "frmAttendanceStatMonthTypeDay";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridATTypeDaydata;
        private Smobiler.Core.Controls.Label lblATMonth;
    }
}