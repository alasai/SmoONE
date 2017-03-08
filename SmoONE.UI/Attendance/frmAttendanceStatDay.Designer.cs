using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatDay : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatDay()
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
            this.line1 = new Smobiler.Core.Controls.Line();
            this.btnDate = new Smobiler.Core.Controls.Button();
            // 
            // gridATdata
            // 
            this.gridATdata.AllowSlip = true;
            this.gridATdata.Layout = "frmAttendanceStatDayLayout";
            this.gridATdata.Location = new System.Drawing.Point(0, 35);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 8;
            this.gridATdata.Size = new System.Drawing.Size(300, 460);
            this.gridATdata.TabIndex = 2;
            this.gridATdata.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATdata_CellClick);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 35);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 6;
            // 
            // btnDate
            // 
            this.btnDate.FontSize = 12F;
            this.btnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnDate.HoverBackColor = System.Drawing.Color.White;
            this.btnDate.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(300, 35);
            this.btnDate.TabIndex = 7;
            this.btnDate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ButDate_Click);
            // 
            // frmAttendanceStatDay
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridATdata,
            this.line1,
            this.btnDate});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.Load += new System.EventHandler(this.frmAttendanceStatDay_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatDay_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatDay_KeyDown);
            this.Name = "frmAttendanceStatDay";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridATdata;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Button btnDate;
    }
}