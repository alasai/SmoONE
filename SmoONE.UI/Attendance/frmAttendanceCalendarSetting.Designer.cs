using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceCalendarSetting : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceCalendarSetting()
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
            this.calendar1 = new Smobiler.Core.Controls.Calendar();
            this.btnCDType = new Smobiler.Core.Controls.Button();
            this.lblRest = new Smobiler.Core.Controls.Label();
            this.lblStartWork = new Smobiler.Core.Controls.Label();
            this.lblEndWork = new Smobiler.Core.Controls.Label();
            this.lblPMStartWork = new Smobiler.Core.Controls.Label();
            this.lblPMEndWork = new Smobiler.Core.Controls.Label();
            this.dpPMEndWork = new Smobiler.Core.Controls.DatePicker();
            this.dpPMStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpAMEndWork = new Smobiler.Core.Controls.DatePicker();
            this.dpAMStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpEndWork = new Smobiler.Core.Controls.DatePicker();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.lineEndWork = new Smobiler.Core.Controls.Line();
            this.linePMStartWork = new Smobiler.Core.Controls.Line();
            this.linePMEndWork = new Smobiler.Core.Controls.Line();
            this.lineType = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            // 
            // calendar1
            // 
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(300, 200);
            this.calendar1.TabIndex = 2;
            this.calendar1.DatePicked += new Smobiler.Core.Controls.Calendar.DatePickedEventHandler(this.calendar1_DatePicked);
            // 
            // btnCDType
            // 
            this.btnCDType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCDType.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCDType.Location = new System.Drawing.Point(0, 350);
            this.btnCDType.Name = "btnCDType";
            this.btnCDType.Size = new System.Drawing.Size(300, 35);
            this.btnCDType.TabIndex = 4;
            this.btnCDType.Text = "设置为休息";
            this.btnCDType.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATMode_Click);
            // 
            // lblRest
            // 
            this.lblRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblRest.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblRest.Location = new System.Drawing.Point(0, 210);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(300, 35);
            this.lblRest.TabIndex = 5;
            this.lblRest.Text = "休息";
            // 
            // lblStartWork
            // 
            this.lblStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblStartWork.Location = new System.Drawing.Point(0, 210);
            this.lblStartWork.Name = "lblStartWork";
            this.lblStartWork.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblStartWork.Size = new System.Drawing.Size(100, 35);
            this.lblStartWork.TabIndex = 6;
            this.lblStartWork.Text = "上班时间";
            // 
            // lblEndWork
            // 
            this.lblEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblEndWork.Location = new System.Drawing.Point(0, 245);
            this.lblEndWork.Name = "lblEndWork";
            this.lblEndWork.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblEndWork.Size = new System.Drawing.Size(100, 35);
            this.lblEndWork.TabIndex = 7;
            this.lblEndWork.Text = "下班时间";
            // 
            // lblPMStartWork
            // 
            this.lblPMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPMStartWork.Location = new System.Drawing.Point(0, 280);
            this.lblPMStartWork.Name = "lblPMStartWork";
            this.lblPMStartWork.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblPMStartWork.Size = new System.Drawing.Size(100, 35);
            this.lblPMStartWork.TabIndex = 8;
            this.lblPMStartWork.Text = "下午上班";
            // 
            // lblPMEndWork
            // 
            this.lblPMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPMEndWork.Location = new System.Drawing.Point(0, 315);
            this.lblPMEndWork.Name = "lblPMEndWork";
            this.lblPMEndWork.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblPMEndWork.Size = new System.Drawing.Size(100, 35);
            this.lblPMEndWork.TabIndex = 9;
            this.lblPMEndWork.Text = "下午下班";
            // 
            // dpPMEndWork
            // 
            this.dpPMEndWork.FontSize = 12F;
            this.dpPMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpPMEndWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpPMEndWork.Location = new System.Drawing.Point(100, 315);
            this.dpPMEndWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpPMEndWork.Name = "dpPMEndWork";
            this.dpPMEndWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpPMEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpPMEndWork.TabIndex = 10;
            this.dpPMEndWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpPMEndWork_DatePicked);
            // 
            // dpPMStartWork
            // 
            this.dpPMStartWork.FontSize = 12F;
            this.dpPMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpPMStartWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpPMStartWork.Location = new System.Drawing.Point(100, 280);
            this.dpPMStartWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpPMStartWork.Name = "dpPMStartWork";
            this.dpPMStartWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpPMStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpPMStartWork.TabIndex = 11;
            this.dpPMStartWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpPMStartWork_DatePicked);
            // 
            // dpAMEndWork
            // 
            this.dpAMEndWork.FontSize = 12F;
            this.dpAMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpAMEndWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpAMEndWork.Location = new System.Drawing.Point(100, 245);
            this.dpAMEndWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpAMEndWork.Name = "dpAMEndWork";
            this.dpAMEndWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpAMEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpAMEndWork.TabIndex = 12;
            this.dpAMEndWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpAMEndWork_DatePicked);
            // 
            // dpAMStartWork
            // 
            this.dpAMStartWork.CurrentDate = new System.DateTime(2017, 1, 19, 10, 21, 0, 0);
            this.dpAMStartWork.FontSize = 12F;
            this.dpAMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpAMStartWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpAMStartWork.Location = new System.Drawing.Point(100, 210);
            this.dpAMStartWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpAMStartWork.Name = "dpAMStartWork";
            this.dpAMStartWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpAMStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpAMStartWork.TabIndex = 13;
            this.dpAMStartWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpAMStartWork_DatePicked);
            // 
            // dpStartWork
            // 
            this.dpStartWork.FontSize = 12F;
            this.dpStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpStartWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpStartWork.Location = new System.Drawing.Point(100, 210);
            this.dpStartWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpStartWork.Name = "dpStartWork";
            this.dpStartWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpStartWork.TabIndex = 14;
            this.dpStartWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpStartWork_DatePicked);
            // 
            // dpEndWork
            // 
            this.dpEndWork.FontSize = 12F;
            this.dpEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpEndWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpEndWork.Location = new System.Drawing.Point(100, 245);
            this.dpEndWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpEndWork.Name = "dpEndWork";
            this.dpEndWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpEndWork.TabIndex = 15;
            this.dpEndWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpEndWork_DatePicked);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 245);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 16;
            // 
            // lineEndWork
            // 
            this.lineEndWork.BackColor = System.Drawing.Color.LightGray;
            this.lineEndWork.Location = new System.Drawing.Point(0, 280);
            this.lineEndWork.Name = "lineEndWork";
            this.lineEndWork.Size = new System.Drawing.Size(300, 1);
            this.lineEndWork.TabIndex = 17;
            // 
            // linePMStartWork
            // 
            this.linePMStartWork.BackColor = System.Drawing.Color.LightGray;
            this.linePMStartWork.Location = new System.Drawing.Point(0, 315);
            this.linePMStartWork.Name = "linePMStartWork";
            this.linePMStartWork.Size = new System.Drawing.Size(300, 1);
            this.linePMStartWork.TabIndex = 18;
            // 
            // linePMEndWork
            // 
            this.linePMEndWork.BackColor = System.Drawing.Color.LightGray;
            this.linePMEndWork.Location = new System.Drawing.Point(0, 350);
            this.linePMEndWork.Name = "linePMEndWork";
            this.linePMEndWork.Size = new System.Drawing.Size(300, 1);
            this.linePMEndWork.TabIndex = 19;
            // 
            // lineType
            // 
            this.lineType.BackColor = System.Drawing.Color.LightGray;
            this.lineType.Location = new System.Drawing.Point(0, 385);
            this.lineType.Name = "lineType";
            this.lineType.Size = new System.Drawing.Size(300, 1);
            this.lineType.TabIndex = 20;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 210);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 21;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 200);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 22;
            // 
            // frmAttendanceCalendarSetting
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.calendar1,
            this.btnCDType,
            this.lblRest,
            this.lblStartWork,
            this.lblEndWork,
            this.lblPMStartWork,
            this.lblPMEndWork,
            this.dpPMEndWork,
            this.dpPMStartWork,
            this.dpAMEndWork,
            this.dpAMStartWork,
            this.dpStartWork,
            this.dpEndWork,
            this.line2,
            this.lineEndWork,
            this.linePMStartWork,
            this.linePMEndWork,
            this.lineType,
            this.line1,
            this.line3});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "日历设置";
            this.Load += new System.EventHandler(this.frmAttendanceCalendarSetting_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceCalendarSetting_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceCalendarSetting_KeyDown);
            this.Name = "frmAttendanceCalendarSetting";

        }
        #endregion

        private Smobiler.Core.Controls.Calendar calendar1;
        private Smobiler.Core.Controls.Button btnCDType;
        private Smobiler.Core.Controls.Label lblRest;
        private Smobiler.Core.Controls.Label lblStartWork;
        private Smobiler.Core.Controls.Label lblEndWork;
        private Smobiler.Core.Controls.Label lblPMStartWork;
        private Smobiler.Core.Controls.Label lblPMEndWork;
        private Smobiler.Core.Controls.DatePicker dpPMEndWork;
        private Smobiler.Core.Controls.DatePicker dpPMStartWork;
        private Smobiler.Core.Controls.DatePicker dpAMEndWork;
        private Smobiler.Core.Controls.DatePicker dpAMStartWork;
        private Smobiler.Core.Controls.DatePicker dpStartWork;
        private Smobiler.Core.Controls.DatePicker dpEndWork;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line lineEndWork;
        private Smobiler.Core.Controls.Line linePMStartWork;
        private Smobiler.Core.Controls.Line linePMEndWork;
        private Smobiler.Core.Controls.Line lineType;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line3;
    }
}