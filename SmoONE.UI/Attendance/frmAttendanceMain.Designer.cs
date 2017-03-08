using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceMain : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceMain()
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
            this.lblWeekDay = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.gridATdata = new Smobiler.Core.Controls.GridView();
            this.gps1 = new Smobiler.Core.Controls.GPS();
            this.layoutDialog1 = new Smobiler.Core.Controls.LayoutDialog();
            this.lblInfo = new Smobiler.Core.Controls.Label();
            this.DetailLayout = new Smobiler.Core.Controls.LayoutDialog();
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblWeekDay.Bold = true;
            this.lblWeekDay.FontSize = 35F;
            this.lblWeekDay.ForeColor = System.Drawing.Color.White;
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblWeekDay.Size = new System.Drawing.Size(300, 60);
            this.lblWeekDay.TabIndex = 2;
            this.lblWeekDay.Text = "星期二";
            this.lblWeekDay.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblDate.Bold = true;
            this.lblDate.FontSize = 16F;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(0, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Padding(10F, 5F, 0F, 0F);
            this.lblDate.Size = new System.Drawing.Size(300, 35);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "2012年7月26日";
            this.lblDate.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblDate.ZIndex = 1;
            // 
            // gridATdata
            // 
            this.gridATdata.AllowSlip = true;
            this.gridATdata.Layout = "frmAttendanceMainLayout";
            this.gridATdata.Location = new System.Drawing.Point(0, 95);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 8;
            this.gridATdata.ShowGridLines = false;
            this.gridATdata.Size = new System.Drawing.Size(300, 275);
            this.gridATdata.TabIndex = 4;
            this.gridATdata.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATdata_CellClick);
            this.gridATdata.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.gridATdata_ItemClick);
            // 
            // gps1
            // 
            this.gps1.Name = "gps1";
            this.gps1.TimeOut = 6000;
            // 
            // layoutDialog1
            // 
            this.layoutDialog1.Layout = "frmAttendanceMainLayoutDialog";
            this.layoutDialog1.Name = "layoutDialog1";
            // 
            // lblInfo
            // 
            this.lblInfo.BorderColor = System.Drawing.Color.Gray;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblInfo.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblInfo.Location = new System.Drawing.Point(10, 164);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblInfo.Size = new System.Drawing.Size(280, 30);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "目前暂无考勤模板！";
            this.lblInfo.Visible = false;
            // 
            // DetailLayout
            // 
            this.DetailLayout.Layout = "frmAttendanceMainDetailLayout";
            this.DetailLayout.Name = "DetailLayout";
            // 
            // frmAttendanceMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.gps1,
            this.layoutDialog1,
            this.DetailLayout});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblWeekDay,
            this.gridATdata,
            this.lblInfo,
            this.lblDate});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "考勤";
            this.Load += new System.EventHandler(this.frmAttendanceMain_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceMain_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceMain_KeyDown);
            this.Name = "frmAttendanceMain";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblWeekDay;
        private Smobiler.Core.Controls.Label lblDate;
        private Smobiler.Core.Controls.GridView gridATdata;
        private Smobiler.Core.Controls.GPS gps1;
        private Smobiler.Core.Controls.LayoutDialog layoutDialog1;
        private Smobiler.Core.Controls.Label lblInfo;
        private Smobiler.Core.Controls.LayoutDialog DetailLayout;
    }
}
