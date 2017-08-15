using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatSelf : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.PopListGroup popListGroup2 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem13 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem14 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem15 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem16 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem17 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem18 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem19 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem20 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem21 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem22 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem23 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem24 = new Smobiler.Core.Controls.PopListItem();
            this.pBack = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblYear = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnMonth = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblDay = new Smobiler.Core.Controls.Label();
            this.lblAll = new Smobiler.Core.Controls.Label();
            this.gridATdata = new Smobiler.Core.Controls.ListView();
            this.popListMonth = new Smobiler.Core.Controls.PopList();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // pBack
            // 
            this.pBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.pBack.BorderColor = System.Drawing.Color.DodgerBlue;
            this.pBack.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.lblName,
            this.lblYear,
            this.label2,
            this.label3,
            this.btnMonth,
            this.label1,
            this.lblDay,
            this.lblAll});
            this.pBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBack.Location = new System.Drawing.Point(0, 50);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(300, 145);
            // 
            // image1
            // 
            this.image1.BorderRadius = 10;
            this.image1.Location = new System.Drawing.Point(10, 10);
            this.image1.Name = "image1";
            this.image1.ResourceID = "1";
            this.image1.Size = new System.Drawing.Size(60, 60);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            // 
            // lblName
            // 
            this.lblName.FontSize = 18F;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(90, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 30);
            // 
            // lblYear
            // 
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblYear.Location = new System.Drawing.Point(10, 75);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 30);
            this.lblYear.Text = "2017年";
            // 
            // label2
            // 
            this.label2.Border = new Smobiler.Core.Controls.Border(1F, 0F, 0F, 0F);
            this.label2.BorderColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(90, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.Text = "正常考勤";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(190, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.Text = "应签到";
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnMonth.FontSize = 25F;
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnMonth.Location = new System.Drawing.Point(10, 105);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(30, 30);
            this.btnMonth.Text = "2";
            // 
            // label1
            // 
            this.label1.FontSize = 20F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.Text = "月";
            // 
            // lblDay
            // 
            this.lblDay.Border = new Smobiler.Core.Controls.Border(1F, 0F, 0F, 0F);
            this.lblDay.BorderColor = System.Drawing.Color.White;
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblDay.Location = new System.Drawing.Point(90, 105);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(80, 30);
            this.lblDay.Text = "0天";
            // 
            // lblAll
            // 
            this.lblAll.ForeColor = System.Drawing.Color.White;
            this.lblAll.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblAll.Location = new System.Drawing.Point(190, 105);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(80, 30);
            this.lblAll.Text = "0次";
            // 
            // gridATdata
            // 
            this.gridATdata.BackColor = System.Drawing.Color.White;
            this.gridATdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridATdata.FooterControlName = null;
            this.gridATdata.HeaderControlName = null;
            this.gridATdata.Location = new System.Drawing.Point(0, 195);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.ShowSplitLine = true;
            this.gridATdata.Size = new System.Drawing.Size(300, 305);
            this.gridATdata.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridATdata.TemplateControlName = "frmAttendanceStatSelfLayout";
            // 
            // popListMonth
            // 
            popListItem13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem13.Text = "1";
            popListItem14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem14.Text = "2";
            popListItem15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem15.Text = "3";
            popListItem16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem16.Text = "4";
            popListItem17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem17.Text = "5";
            popListItem18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem18.Text = "6";
            popListItem19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem19.Text = "7";
            popListItem20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem20.Text = "8";
            popListItem21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem21.Text = "9";
            popListItem22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem22.Text = "10";
            popListItem23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem23.Text = "11";
            popListItem24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem24.Text = "12";
            popListGroup2.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem13,
            popListItem14,
            popListItem15,
            popListItem16,
            popListItem17,
            popListItem18,
            popListItem19,
            popListItem20,
            popListItem21,
            popListItem22,
            popListItem23,
            popListItem24});
            popListGroup2.Title = "请选择月份";
            popListGroup2.Value = null;
            this.popListMonth.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup2});
            this.popListMonth.Name = "popListMonth";
            this.popListMonth.Selected += new System.EventHandler(this.popListMonth_Selected);
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
            // frmAttendanceStatSelf
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popListMonth});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.pBack,
            this.gridATdata});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatSelf_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatSelf_Load);
            this.Name = "frmAttendanceStatSelf";

        }
        #endregion
        private Smobiler.Core.Controls.Panel pBack;
        private Smobiler.Core.Controls.ListView gridATdata;
        private Smobiler.Core.Controls.PopList popListMonth;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Image image1;
        public Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblYear;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label  btnMonth;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblDay;
        private Smobiler.Core.Controls.Label lblAll;
    }
}