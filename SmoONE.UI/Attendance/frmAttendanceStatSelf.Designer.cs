using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatSelf : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatSelf()
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
            this.lblBack = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblDay = new Smobiler.Core.Controls.Label();
            this.gridATdata = new Smobiler.Core.Controls.GridView();
            this.lblYear = new Smobiler.Core.Controls.Label();
            this.btnMonth = new Smobiler.Core.Controls.Button();
            this.popListMonth = new Smobiler.Core.Controls.PopList();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblAll = new Smobiler.Core.Controls.Label();
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblBack.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(300, 145);
            this.lblBack.TabIndex = 2;
            // 
            // image1
            // 
            this.image1.BorderRadius = 10;
            this.image1.Location = new System.Drawing.Point(10, 10);
            this.image1.Name = "image1";
            this.image1.ResourceID = "1";
            this.image1.Size = new System.Drawing.Size(60, 60);
            this.image1.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.image1.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.BackColorAlpha = 0;
            this.lblName.FontSize = 18F;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(90, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 30);
            this.lblName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColorAlpha = 0;
            this.label1.FontSize = 20F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "月";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(90, 75);
            this.line1.Name = "line1";
            this.line1.Orientation = Smobiler.Core.OrientationAlignment.Vertical;
            this.line1.Size = new System.Drawing.Size(1, 65);
            this.line1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColorAlpha = 0;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(90, 75);
            this.label2.Name = "label2";
            this.label2.TabIndex = 9;
            this.label2.Text = "正常考勤";
            // 
            // lblDay
            // 
            this.lblDay.BackColorAlpha = 0;
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblDay.Location = new System.Drawing.Point(90, 105);
            this.lblDay.Name = "lblDay";
            this.lblDay.TabIndex = 11;
            this.lblDay.Text = "0天";
            // 
            // gridATdata
            // 
            this.gridATdata.AutoHeight = true;
            this.gridATdata.Layout = "frmAttendanceStatSelfLayout";
            this.gridATdata.Location = new System.Drawing.Point(0, 145);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 8;
            this.gridATdata.ShowGridLines = false;
            this.gridATdata.Size = new System.Drawing.Size(300, 331);
            this.gridATdata.TabIndex = 13;
            this.gridATdata.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATdata_CellClick);
            // 
            // lblYear
            // 
            this.lblYear.BackColorAlpha = 0;
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblYear.Location = new System.Drawing.Point(10, 75);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 30);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "2017年";
            // 
            // btnMonth
            // 
            this.btnMonth.BackColorAlpha = 0;
            this.btnMonth.Enabled = false;
            this.btnMonth.FontSize = 25F;
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnMonth.Location = new System.Drawing.Point(10, 105);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(30, 30);
            this.btnMonth.TabIndex = 15;
            this.btnMonth.Text = "2";
            this.btnMonth.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.ButMonth_Click);
            // 
            // popListMonth
            // 
            popListGroup1.IndexerKey = "";
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
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
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
            popListGroup1.Text = "请选择月份";
            this.popListMonth.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popListMonth.Name = "popListMonth";
            this.popListMonth.Selected += new System.EventHandler(this.popListMonth_Selected);
            // 
            // label3
            // 
            this.label3.BackColorAlpha = 0;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(190, 75);
            this.label3.Name = "label3";
            this.label3.TabIndex = 16;
            this.label3.Text = "应签到";
            // 
            // lblAll
            // 
            this.lblAll.BackColorAlpha = 0;
            this.lblAll.ForeColor = System.Drawing.Color.White;
            this.lblAll.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblAll.Location = new System.Drawing.Point(190, 105);
            this.lblAll.Name = "lblAll";
            this.lblAll.TabIndex = 17;
            this.lblAll.Text = "0次";
            // 
            // frmAttendanceStatSelf
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popListMonth});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblBack,
            this.image1,
            this.lblName,
            this.label1,
            this.line1,
            this.label2,
            this.lblDay,
            this.gridATdata,
            this.lblYear,
            this.btnMonth,
            this.label3,
            this.lblAll});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "考勤报表";
            this.Load += new System.EventHandler(this.frmAttendanceStatSelf_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatSelf_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatSelf_KeyDown);
            this.Name = "frmAttendanceStatSelf";

        }
        #endregion
        private Smobiler.Core.Controls.Label lblBack;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblDay;
        private Smobiler.Core.Controls.GridView gridATdata;
        private Smobiler.Core.Controls.Label lblYear;
        private Smobiler.Core.Controls.Button btnMonth;
        private Smobiler.Core.Controls.PopList popListMonth;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblAll;
    }
}