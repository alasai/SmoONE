using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatistics : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatistics()
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
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem1 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem2 = new Smobiler.Core.Controls.TextTabBarItem();
            this.gridATdata = new Smobiler.Core.Controls.GridView();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.btnYear = new Smobiler.Core.Controls.Button();
            this.popListYear = new Smobiler.Core.Controls.PopList();
            this.popListMonth = new Smobiler.Core.Controls.PopList();
            this.btnMonth = new Smobiler.Core.Controls.Button();
            this.textTabBar1 = new Smobiler.Core.Controls.TextTabBar();
            this.btnCheck = new Smobiler.Core.Controls.Button();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            // 
            // gridATdata
            // 
            this.gridATdata.AllowSlip = true;
            this.gridATdata.AutoHeight = true;
            this.gridATdata.Layout = "frmAttendanceStatisticsLayout";
            this.gridATdata.Location = new System.Drawing.Point(0, 90);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 8;
            this.gridATdata.Size = new System.Drawing.Size(300, 401);
            this.gridATdata.TabIndex = 2;
            this.gridATdata.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATdata_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(2, 16);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "textBox1";
            // 
            // btnYear
            // 
            this.btnYear.FontSize = 12F;
            this.btnYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnYear.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnYear.HoverBackColor = System.Drawing.Color.White;
            this.btnYear.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnYear.Location = new System.Drawing.Point(0, 55);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(145, 35);
            this.btnYear.TabIndex = 5;
            this.btnYear.Text = " ▼ 2017年";
            this.btnYear.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ButYear_Click);
            // 
            // popListYear
            // 
            popListGroup1.IndexerKey = "";
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
            // btnMonth
            // 
            this.btnMonth.FontSize = 12F;
            this.btnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnMonth.HoverBackColor = System.Drawing.Color.White;
            this.btnMonth.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnMonth.Location = new System.Drawing.Point(145, 55);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(42, 35);
            this.btnMonth.TabIndex = 10;
            this.btnMonth.Text = "2月▼";
            this.btnMonth.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ButMonth_Click);
            // 
            // textTabBar1
            // 
            this.textTabBar1.BackColor = System.Drawing.Color.White;
            this.textTabBar1.BorderRadius = 2;
            this.textTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            textTabBarItem1.Text = "人员统计";
            textTabBarItem1.Value = "Men";
            textTabBarItem2.Text = "天数统计";
            textTabBarItem2.Value = "Day";
            this.textTabBar1.Items.AddRange(new Smobiler.Core.Controls.TextTabBarItem[] {
            textTabBarItem1,
            textTabBarItem2});
            this.textTabBar1.Location = new System.Drawing.Point(10, 10);
            this.textTabBar1.Name = "textTabBar1";
            this.textTabBar1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.textTabBar1.SelectForeColor = System.Drawing.Color.White;
            this.textTabBar1.Size = new System.Drawing.Size(280, 35);
            this.textTabBar1.TabIndex = 4;
            this.textTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.textTabBar1_ItemClick);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCheck.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnCheck.HoverBackColor = System.Drawing.Color.White;
            this.btnCheck.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCheck.Location = new System.Drawing.Point(187, 55);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.btnCheck.Size = new System.Drawing.Size(113, 35);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ButCheck_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 90);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 12;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 55);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 13;
            // 
            // frmAttendanceStatistics
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popListYear,
            this.popListMonth});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridATdata,
            this.textBox1,
            this.btnYear,
            this.textTabBar1,
            this.btnMonth,
            this.btnCheck,
            this.line1,
            this.line2});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "考勤统计";
            this.Load += new System.EventHandler(this.frmAttendanceStatistics_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatistics_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatistics_KeyDown);
            this.Name = "frmAttendanceStatistics";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridATdata;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button btnYear;
        private Smobiler.Core.Controls.PopList popListYear;
        private Smobiler.Core.Controls.PopList popListMonth;
        private Smobiler.Core.Controls.Button btnMonth;
        private Smobiler.Core.Controls.TextTabBar textTabBar1;
        private Smobiler.Core.Controls.Button btnCheck;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
    }
}
