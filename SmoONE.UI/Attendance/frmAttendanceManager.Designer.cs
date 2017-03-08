using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceManager : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceManager()
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
            this.gridATData = new Smobiler.Core.Controls.GridView();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            // 
            // gridATData
            // 
            this.gridATData.AllowSlip = true;
            this.gridATData.AutoHeight = true;
            this.gridATData.Layout = "frmAttendanceManagerLayout";
            this.gridATData.Location = new System.Drawing.Point(0, 55);
            this.gridATData.Name = "gridATData";
            this.gridATData.PageSize = 8;
            this.gridATData.ShowGridLines = false;
            this.gridATData.Size = new System.Drawing.Size(300, 457);
            this.gridATData.TabIndex = 2;
            this.gridATData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATData_CellClick);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.BorderRadius = 2;
            this.btnCreate.FontSize = 17F;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnCreate.HoverForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(10, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(280, 35);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "创建考勤";
            this.btnCreate.ZIndex = 1;
            this.btnCreate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // frmAttendanceManager
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridATData,
            this.btnCreate});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "考勤管理";
            this.Load += new System.EventHandler(this.frmAttendanceManager_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceManager_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceManager_KeyDown);
            this.Name = "frmAttendanceManager";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridATData;
        private Smobiler.Core.Controls.Button btnCreate;
    }
}
