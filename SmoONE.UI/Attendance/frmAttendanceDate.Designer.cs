using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceDate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceDate()
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
            Smobiler.Core.Controls.RadioButton radioButton50 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton51 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton52 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton53 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton54 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton55 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton56 = new Smobiler.Core.Controls.RadioButton();
            this.radioDate = new Smobiler.Core.Controls.RadioGroup();
            this.imgbtnCalendar = new Smobiler.Core.Controls.ImageButton();
            this.lblADeviation = new Smobiler.Core.Controls.Label();
            this.btnDate2 = new Smobiler.Core.Controls.Button();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            // 
            // radioDate
            // 
            this.radioDate.ButtonHeight = 35F;
            radioButton50.ID = "1";
            radioButton50.Text = "星期一";
            radioButton50.Value = "1";
            radioButton51.ID = "2";
            radioButton51.Text = "星期二";
            radioButton51.Value = "2";
            radioButton52.ID = "3";
            radioButton52.Text = "星期三";
            radioButton52.Value = "3";
            radioButton53.ID = "4";
            radioButton53.Text = "星期四";
            radioButton53.Value = "4";
            radioButton54.ID = "5";
            radioButton54.Text = "星期五";
            radioButton54.Value = "5";
            radioButton55.ID = "6";
            radioButton55.Text = "星期六";
            radioButton55.Value = "6";
            radioButton56.ID = "7";
            radioButton56.Text = "星期日";
            radioButton56.Value = "7";
            this.radioDate.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton50,
            radioButton51,
            radioButton52,
            radioButton53,
            radioButton54,
            radioButton55,
            radioButton56});
            this.radioDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.radioDate.MultiSelect = true;
            this.radioDate.Name = "radioDate";
            this.radioDate.Padding = new Smobiler.Core.Padding(4F, 0F, 4F, 0F);
            this.radioDate.Size = new System.Drawing.Size(300, 245);
            this.radioDate.TabIndex = 2;
            this.radioDate.CheckChanged += new Smobiler.Core.Controls.RadioGroupCheckChangedEventHandler(this.radioDate_CheckChanged);
            // 
            // imgbtnCalendar
            // 
            this.imgbtnCalendar.FontSize = 15F;
            this.imgbtnCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.imgbtnCalendar.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.imgbtnCalendar.HoverBackColor = System.Drawing.Color.White;
            this.imgbtnCalendar.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.imgbtnCalendar.ImageDirection = Smobiler.Core.Direction.Left;
            this.imgbtnCalendar.Location = new System.Drawing.Point(0, 255);
            this.imgbtnCalendar.Name = "imgbtnCalendar";
            this.imgbtnCalendar.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.imgbtnCalendar.ResourceID = "!\\ue916102099099";
            this.imgbtnCalendar.Size = new System.Drawing.Size(275, 35);
            this.imgbtnCalendar.TabIndex = 3;
            this.imgbtnCalendar.Text = "自定义日期";
            this.imgbtnCalendar.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnCalendar_Click);
            // 
            // lblADeviation
            // 
            this.lblADeviation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblADeviation.FontSize = 12F;
            this.lblADeviation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblADeviation.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblADeviation.Location = new System.Drawing.Point(0, 290);
            this.lblADeviation.Name = "lblADeviation";
            this.lblADeviation.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblADeviation.Size = new System.Drawing.Size(300, 20);
            this.lblADeviation.TabIndex = 4;
            this.lblADeviation.Text = "可单独设置某一天的考勤时间";
            this.lblADeviation.ZIndex = 1;
            // 
            // btnDate2
            // 
            this.btnDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnDate2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnDate2.HoverBackColor = System.Drawing.Color.White;
            this.btnDate2.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnDate2.Location = new System.Drawing.Point(275, 255);
            this.btnDate2.Name = "btnDate2";
            this.btnDate2.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnDate2.Size = new System.Drawing.Size(25, 35);
            this.btnDate2.TabIndex = 5;
            this.btnDate2.Text = ">";
            this.btnDate2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnCalendar_Click);
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 245);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 6;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 255);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 7;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 290);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 8;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 9;
            // 
            // frmAttendanceDate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.radioDate,
            this.imgbtnCalendar,
            this.lblADeviation,
            this.btnDate2,
            this.line4,
            this.line1,
            this.line2,
            this.line3});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "日期";
            this.Load += new System.EventHandler(this.frmAttendanceDate_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceDate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceDate_KeyDown);
            this.Name = "frmAttendanceDate";

        }
        #endregion

        private Smobiler.Core.Controls.RadioGroup radioDate;
        private Smobiler.Core.Controls.ImageButton imgbtnCalendar;
        private Smobiler.Core.Controls.Label lblADeviation;
        private Smobiler.Core.Controls.Button btnDate2;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
    }
}