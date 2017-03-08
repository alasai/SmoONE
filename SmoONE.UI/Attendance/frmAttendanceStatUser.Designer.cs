using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatUser : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatUser()
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
            this.gridATUserData = new Smobiler.Core.Controls.GridView();
            this.lblATMonth = new Smobiler.Core.Controls.Label();
            // 
            // gridATUserData
            // 
            this.gridATUserData.AllowSlip = true;
            this.gridATUserData.AutoHeight = true;
            this.gridATUserData.Layout = "frmUserLayout";
            this.gridATUserData.Location = new System.Drawing.Point(0, 35);
            this.gridATUserData.Name = "gridATUserData";
            this.gridATUserData.PageSize = 8;
            this.gridATUserData.ShowGridLines = false;
            this.gridATUserData.Size = new System.Drawing.Size(300, 421);
            this.gridATUserData.TabIndex = 2;
            this.gridATUserData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATUserData_CellClick);
            // 
            // lblATMonth
            // 
            this.lblATMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblATMonth.ForeColor = System.Drawing.Color.White;
            this.lblATMonth.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblATMonth.Name = "lblATMonth";
            this.lblATMonth.Size = new System.Drawing.Size(300, 35);
            this.lblATMonth.TabIndex = 3;
            // 
            // frmAttendanceStatUser
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridATUserData,
            this.lblATMonth});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "¿¼ÇÚÔÂ±¨±í";
            this.Load += new System.EventHandler(this.frmAttendanceStatUser_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatUser_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatUser_KeyDown);
            this.Name = "frmAttendanceStatUser";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridATUserData;
        private Smobiler.Core.Controls.Label lblATMonth;
    }
}