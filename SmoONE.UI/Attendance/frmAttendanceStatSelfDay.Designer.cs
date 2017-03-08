using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatSelfDay : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatSelfDay()
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
            Smobiler.Core.Controls.PopListGroup popListGroup1 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListGroup popListGroup2 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem2 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem3 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem4 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem5 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem6 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem7 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem8 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem9 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem10 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem11 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem12 = new Smobiler.Core.Controls.PopListItem();
            this.btnYear = new Smobiler.Core.Controls.Button();
            this.btnMonth = new Smobiler.Core.Controls.Button();
            this.btnCheck = new Smobiler.Core.Controls.Button();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.gridATdata = new Smobiler.Core.Controls.GridView();
            this.popListYear = new Smobiler.Core.Controls.PopList();
            this.popListMonth = new Smobiler.Core.Controls.PopList();
            // 
            // btnYear
            // 
            this.btnYear.FontSize = 12F;
            this.btnYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnYear.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnYear.HoverBackColor = System.Drawing.Color.White;
            this.btnYear.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(145, 35);
            this.btnYear.TabIndex = 2;
            this.btnYear.Text = " ▼ 2017年";
            this.btnYear.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ButYear_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.FontSize = 12F;
            this.btnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnMonth.HoverBackColor = System.Drawing.Color.White;
            this.btnMonth.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnMonth.Location = new System.Drawing.Point(145, 0);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(42, 35);
            this.btnMonth.TabIndex = 3;
            this.btnMonth.Text = "2月▼";
            this.btnMonth.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ButMonth_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCheck.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnCheck.HoverBackColor = System.Drawing.Color.White;
            this.btnCheck.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCheck.Location = new System.Drawing.Point(187, 0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.btnCheck.Size = new System.Drawing.Size(113, 35);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = ">";
            this.btnCheck.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ButCheck_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 35);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 5;
            // 
            // gridATdata
            // 
            this.gridATdata.AllowSlip = true;
            this.gridATdata.AutoHeight = true;
            this.gridATdata.Layout = "frmAttendanceStatDayLayout";
            this.gridATdata.Location = new System.Drawing.Point(0, 35);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 8;
            this.gridATdata.Size = new System.Drawing.Size(300, 460);
            this.gridATdata.TabIndex = 6;
            this.gridATdata.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATdata_CellClick);
            // 
            // popListYear
            // 
            popListGroup1.IndexerKey = "0";
            popListGroup1.Text = "请选择年份";
            this.popListYear.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popListYear.Name = "popListYear";
            this.popListYear.Selected += new System.EventHandler(this.popListYear_Selected);
            // 
            // popListMonth
            // 
            popListGroup2.IndexerKey = "";
            popListItem1.Text = "1";
            popListItem2.Text = "2";
            popListItem3.Text = "3";
            popListItem4.Text = "4";
            popListItem5.Text = "5";
            popListItem6.Text = "6";
            popListItem7.Text = "7";
            popListItem8.Text = "8";
            popListItem9.Text = "9";
            popListItem10.Text = "10";
            popListItem11.Text = "11";
            popListItem12.Text = "12";
            popListGroup2.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2,
            popListItem3,
            popListItem4,
            popListItem5,
            popListItem6,
            popListItem7,
            popListItem8,
            popListItem9,
            popListItem10,
            popListItem11,
            popListItem12});
            popListGroup2.Text = "请选择月份";
            this.popListMonth.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup2});
            this.popListMonth.Name = "popListMonth";
            this.popListMonth.Selected += new System.EventHandler(this.popListMonth_Selected);
            // 
            // frmAttendanceStatSelfDay
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popListYear,
            this.popListMonth});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnYear,
            this.btnMonth,
            this.btnCheck,
            this.line1,
            this.gridATdata});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "我的考勤历史";
            this.Load += new System.EventHandler(this.frmAttendanceStatSelfDay_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatSelfDay_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatSelfDay_KeyDown);
            this.Name = "frmAttendanceStatSelfDay";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnYear;
        private Smobiler.Core.Controls.Button btnMonth;
        private Smobiler.Core.Controls.Button btnCheck;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.GridView gridATdata;
        private Smobiler.Core.Controls.PopList popListYear;
        private Smobiler.Core.Controls.PopList popListMonth;
    }
}