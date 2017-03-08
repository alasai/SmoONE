using Smobiler.Core;

namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public frmAttendanceCreate()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
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
            this.lblStartWork = new Smobiler.Core.Controls.Label();
            this.lblEndWork = new Smobiler.Core.Controls.Label();
            this.lblPMStartWork = new Smobiler.Core.Controls.Label();
            this.lblPMEndWork = new Smobiler.Core.Controls.Label();
            this.lblDate1 = new Smobiler.Core.Controls.Label();
            this.btnDate = new Smobiler.Core.Controls.Button();
            this.btnDate2 = new Smobiler.Core.Controls.Button();
            this.btnATMode = new Smobiler.Core.Controls.Button();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.lblException = new Smobiler.Core.Controls.Label();
            this.btnUser = new Smobiler.Core.Controls.Button();
            this.btnUser2 = new Smobiler.Core.Controls.Button();
            this.lblAddress1 = new Smobiler.Core.Controls.Label();
            this.lblAddress = new Smobiler.Core.Controls.Label();
            this.btnAddress2 = new Smobiler.Core.Controls.Button();
            this.txtADeviation = new Smobiler.Core.Controls.TextBox();
            this.lblAllowableDeviation = new Smobiler.Core.Controls.Label();
            this.btnAllowableDeviation2 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.linePMupWork = new Smobiler.Core.Controls.Line();
            this.linePMoffWork = new Smobiler.Core.Controls.Line();
            this.lineDate = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.lineException1 = new Smobiler.Core.Controls.Line();
            this.lineAddress = new Smobiler.Core.Controls.Line();
            this.lineException = new Smobiler.Core.Controls.Line();
            this.lineAllowableDeviation = new Smobiler.Core.Controls.Line();
            this.dpStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpEndWork = new Smobiler.Core.Controls.DatePicker();
            this.dpPMStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpPMEndWork = new Smobiler.Core.Controls.DatePicker();
            this.lineATMode = new Smobiler.Core.Controls.Line();
            this.layoutDialog1 = new Smobiler.Core.Controls.LayoutDialog();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.lblADeviation = new Smobiler.Core.Controls.Label();
            this.dpAMStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpAMEndWork = new Smobiler.Core.Controls.DatePicker();
            this.gps1 = new Smobiler.Core.Controls.GPS();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            // 
            // lblStartWork
            // 
            this.lblStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblStartWork.Location = new System.Drawing.Point(0, 45);
            this.lblStartWork.Name = "lblStartWork";
            this.lblStartWork.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblStartWork.Size = new System.Drawing.Size(100, 35);
            this.lblStartWork.TabIndex = 2;
            this.lblStartWork.Text = "上班时间";
            // 
            // lblEndWork
            // 
            this.lblEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblEndWork.Location = new System.Drawing.Point(0, 80);
            this.lblEndWork.Name = "lblEndWork";
            this.lblEndWork.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblEndWork.Size = new System.Drawing.Size(100, 35);
            this.lblEndWork.TabIndex = 4;
            this.lblEndWork.Text = "下班时间";
            // 
            // lblPMStartWork
            // 
            this.lblPMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPMStartWork.Location = new System.Drawing.Point(0, 115);
            this.lblPMStartWork.Name = "lblPMStartWork";
            this.lblPMStartWork.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblPMStartWork.Size = new System.Drawing.Size(100, 35);
            this.lblPMStartWork.TabIndex = 6;
            this.lblPMStartWork.Text = "下午上班";
            // 
            // lblPMEndWork
            // 
            this.lblPMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPMEndWork.Location = new System.Drawing.Point(0, 150);
            this.lblPMEndWork.Name = "lblPMEndWork";
            this.lblPMEndWork.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblPMEndWork.Size = new System.Drawing.Size(100, 35);
            this.lblPMEndWork.TabIndex = 8;
            this.lblPMEndWork.Text = "下午下班";
            // 
            // lblDate1
            // 
            this.lblDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblDate1.Location = new System.Drawing.Point(0, 185);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblDate1.Size = new System.Drawing.Size(100, 35);
            this.lblDate1.TabIndex = 10;
            this.lblDate1.Text = "日期";
            // 
            // btnDate
            // 
            this.btnDate.FontSize = 12F;
            this.btnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnDate.HoverBackColor = System.Drawing.Color.White;
            this.btnDate.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnDate.Location = new System.Drawing.Point(100, 185);
            this.btnDate.Name = "btnDate";
            this.btnDate.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnDate.Size = new System.Drawing.Size(175, 35);
            this.btnDate.TabIndex = 11;
            this.btnDate.Text = "工作日";
            this.btnDate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDate_Click);
            // 
            // btnDate2
            // 
            this.btnDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnDate2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnDate2.HoverBackColor = System.Drawing.Color.White;
            this.btnDate2.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnDate2.Location = new System.Drawing.Point(275, 185);
            this.btnDate2.Name = "btnDate2";
            this.btnDate2.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnDate2.Size = new System.Drawing.Size(25, 35);
            this.btnDate2.TabIndex = 12;
            this.btnDate2.Text = ">";
            this.btnDate2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDate_Click);
            // 
            // btnATMode
            // 
            this.btnATMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnATMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnATMode.HoverBackColor = System.Drawing.Color.White;
            this.btnATMode.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnATMode.Location = new System.Drawing.Point(0, 220);
            this.btnATMode.Name = "btnATMode";
            this.btnATMode.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnATMode.Size = new System.Drawing.Size(300, 35);
            this.btnATMode.TabIndex = 13;
            this.btnATMode.Text = "切换到一天两次上下班";
            this.btnATMode.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATMode_Click);
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblName.Location = new System.Drawing.Point(0, 10);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(125, 35);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "名称";
            // 
            // txtName
            // 
            this.txtName.FontSize = 12F;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtName.Location = new System.Drawing.Point(125, 10);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtName.Size = new System.Drawing.Size(175, 35);
            this.txtName.TabIndex = 18;
            this.txtName.WaterMarkText = "（必输）";
            // 
            // lblException
            // 
            this.lblException.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblException.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblException.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblException.Location = new System.Drawing.Point(0, 265);
            this.lblException.Name = "lblException";
            this.lblException.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblException.Size = new System.Drawing.Size(125, 35);
            this.lblException.TabIndex = 20;
            this.lblException.Text = "考勤成员";
            // 
            // btnUser
            // 
            this.btnUser.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUser.FontSize = 12F;
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnUser.HoverBackColor = System.Drawing.Color.White;
            this.btnUser.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUser.Location = new System.Drawing.Point(125, 265);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnUser.Size = new System.Drawing.Size(150, 35);
            this.btnUser.TabIndex = 21;
            this.btnUser.Text = "0人";
            this.btnUser.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnUser_Click);
            // 
            // btnUser2
            // 
            this.btnUser2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnUser2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUser2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnUser2.HoverBackColor = System.Drawing.Color.White;
            this.btnUser2.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUser2.Location = new System.Drawing.Point(275, 265);
            this.btnUser2.Name = "btnUser2";
            this.btnUser2.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnUser2.Size = new System.Drawing.Size(25, 35);
            this.btnUser2.TabIndex = 22;
            this.btnUser2.Text = ">";
            this.btnUser2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnUser_Click);
            // 
            // lblAddress1
            // 
            this.lblAddress1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAddress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAddress1.Location = new System.Drawing.Point(0, 300);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Padding = new Smobiler.Core.Padding(4F, 5F, 0F, 0F);
            this.lblAddress1.Size = new System.Drawing.Size(125, 80);
            this.lblAddress1.TabIndex = 23;
            this.lblAddress1.Text = "考勤地点";
            this.lblAddress1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblAddress
            // 
            this.lblAddress.FontSize = 12F;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblAddress.Location = new System.Drawing.Point(125, 300);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new Smobiler.Core.Padding(0F, 5F, 2F, 0F);
            this.lblAddress.Size = new System.Drawing.Size(150, 80);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // btnAddress2
            // 
            this.btnAddress2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnAddress2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnAddress2.HoverBackColor = System.Drawing.Color.White;
            this.btnAddress2.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnAddress2.Location = new System.Drawing.Point(275, 300);
            this.btnAddress2.Name = "btnAddress2";
            this.btnAddress2.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnAddress2.Size = new System.Drawing.Size(25, 80);
            this.btnAddress2.TabIndex = 25;
            this.btnAddress2.Text = ">";
            this.btnAddress2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnAddress1_Click);
            // 
            // txtADeviation
            // 
            this.txtADeviation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtADeviation.FontSize = 12F;
            this.txtADeviation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtADeviation.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtADeviation.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtADeviation.Location = new System.Drawing.Point(125, 380);
            this.txtADeviation.Name = "txtADeviation";
            this.txtADeviation.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.txtADeviation.Size = new System.Drawing.Size(150, 35);
            this.txtADeviation.TabIndex = 26;
            this.txtADeviation.Text = "300";
            this.txtADeviation.TextChanged += new System.EventHandler(this.txtADeviation_TextChanged);
            // 
            // lblAllowableDeviation
            // 
            this.lblAllowableDeviation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAllowableDeviation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAllowableDeviation.Location = new System.Drawing.Point(0, 380);
            this.lblAllowableDeviation.Name = "lblAllowableDeviation";
            this.lblAllowableDeviation.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblAllowableDeviation.Size = new System.Drawing.Size(125, 35);
            this.lblAllowableDeviation.TabIndex = 27;
            this.lblAllowableDeviation.Text = "允许偏差";
            // 
            // btnAllowableDeviation2
            // 
            this.btnAllowableDeviation2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllowableDeviation2.FontSize = 12F;
            this.btnAllowableDeviation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnAllowableDeviation2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnAllowableDeviation2.Location = new System.Drawing.Point(275, 380);
            this.btnAllowableDeviation2.Name = "btnAllowableDeviation2";
            this.btnAllowableDeviation2.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnAllowableDeviation2.Size = new System.Drawing.Size(25, 35);
            this.btnAllowableDeviation2.TabIndex = 28;
            this.btnAllowableDeviation2.Text = "米";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 29;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 80);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 30;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 115);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 31;
            // 
            // linePMupWork
            // 
            this.linePMupWork.BackColor = System.Drawing.Color.LightGray;
            this.linePMupWork.Location = new System.Drawing.Point(0, 150);
            this.linePMupWork.Name = "linePMupWork";
            this.linePMupWork.Size = new System.Drawing.Size(300, 1);
            this.linePMupWork.TabIndex = 32;
            // 
            // linePMoffWork
            // 
            this.linePMoffWork.BackColor = System.Drawing.Color.LightGray;
            this.linePMoffWork.Location = new System.Drawing.Point(0, 185);
            this.linePMoffWork.Name = "linePMoffWork";
            this.linePMoffWork.Size = new System.Drawing.Size(300, 1);
            this.linePMoffWork.TabIndex = 33;
            // 
            // lineDate
            // 
            this.lineDate.BackColor = System.Drawing.Color.LightGray;
            this.lineDate.Location = new System.Drawing.Point(0, 220);
            this.lineDate.Name = "lineDate";
            this.lineDate.Size = new System.Drawing.Size(300, 1);
            this.lineDate.TabIndex = 34;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 10);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 35;
            // 
            // lineException1
            // 
            this.lineException1.BackColor = System.Drawing.Color.LightGray;
            this.lineException1.Location = new System.Drawing.Point(0, 265);
            this.lineException1.Name = "lineException1";
            this.lineException1.Size = new System.Drawing.Size(300, 1);
            this.lineException1.TabIndex = 36;
            // 
            // lineAddress
            // 
            this.lineAddress.BackColor = System.Drawing.Color.LightGray;
            this.lineAddress.Location = new System.Drawing.Point(0, 380);
            this.lineAddress.Name = "lineAddress";
            this.lineAddress.Size = new System.Drawing.Size(300, 1);
            this.lineAddress.TabIndex = 37;
            // 
            // lineException
            // 
            this.lineException.BackColor = System.Drawing.Color.LightGray;
            this.lineException.Location = new System.Drawing.Point(0, 300);
            this.lineException.Name = "lineException";
            this.lineException.Size = new System.Drawing.Size(300, 1);
            this.lineException.TabIndex = 40;
            // 
            // lineAllowableDeviation
            // 
            this.lineAllowableDeviation.BackColor = System.Drawing.Color.LightGray;
            this.lineAllowableDeviation.Location = new System.Drawing.Point(0, 415);
            this.lineAllowableDeviation.Name = "lineAllowableDeviation";
            this.lineAllowableDeviation.Size = new System.Drawing.Size(300, 1);
            this.lineAllowableDeviation.TabIndex = 41;
            // 
            // dpStartWork
            // 
            this.dpStartWork.FontSize = 12F;
            this.dpStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpStartWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpStartWork.Location = new System.Drawing.Point(100, 45);
            this.dpStartWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpStartWork.Name = "dpStartWork";
            this.dpStartWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpStartWork.TabIndex = 42;
            this.dpStartWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpStartWork_DatePicked);
            // 
            // dpEndWork
            // 
            this.dpEndWork.FontSize = 12F;
            this.dpEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpEndWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpEndWork.Location = new System.Drawing.Point(100, 80);
            this.dpEndWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpEndWork.Name = "dpEndWork";
            this.dpEndWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpEndWork.TabIndex = 43;
            this.dpEndWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpEndWork_DatePicked);
            // 
            // dpPMStartWork
            // 
            this.dpPMStartWork.FontSize = 12F;
            this.dpPMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpPMStartWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpPMStartWork.Location = new System.Drawing.Point(100, 115);
            this.dpPMStartWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpPMStartWork.Name = "dpPMStartWork";
            this.dpPMStartWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpPMStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpPMStartWork.TabIndex = 44;
            this.dpPMStartWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpPMStartWork_DatePicked);
            // 
            // dpPMEndWork
            // 
            this.dpPMEndWork.FontSize = 12F;
            this.dpPMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpPMEndWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpPMEndWork.Location = new System.Drawing.Point(100, 150);
            this.dpPMEndWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpPMEndWork.Name = "dpPMEndWork";
            this.dpPMEndWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpPMEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpPMEndWork.TabIndex = 45;
            this.dpPMEndWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpPMEndWork_DatePicked);
            // 
            // lineATMode
            // 
            this.lineATMode.BackColor = System.Drawing.Color.LightGray;
            this.lineATMode.Location = new System.Drawing.Point(0, 255);
            this.lineATMode.Name = "lineATMode";
            this.lineATMode.Size = new System.Drawing.Size(300, 1);
            this.lineATMode.TabIndex = 46;
            // 
            // layoutDialog1
            // 
            this.layoutDialog1.Name = "layoutDialog1";
            // 
            // popList1
            // 
            popListGroup1.IndexerKey = "";
            popListItem1.Text = "300米";
            popListItem1.Value = "300";
            popListItem2.Text = "500米";
            popListItem2.Value = "500";
            popListItem3.Text = "800米";
            popListItem3.Value = "800";
            popListItem4.Text = "1000米";
            popListItem4.Value = "1000";
            popListItem5.Text = "自定义（300~5000）米";
            popListItem5.Value = "definition";
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2,
            popListItem3,
            popListItem4,
            popListItem5});
            this.popList1.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popList1.Name = "popList1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "提交";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // lblADeviation
            // 
            this.lblADeviation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblADeviation.FontSize = 12F;
            this.lblADeviation.ForeColor = System.Drawing.Color.Red;
            this.lblADeviation.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblADeviation.Location = new System.Drawing.Point(0, 415);
            this.lblADeviation.Name = "lblADeviation";
            this.lblADeviation.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblADeviation.Size = new System.Drawing.Size(300, 20);
            this.lblADeviation.TabIndex = 49;
            this.lblADeviation.Text = "偏差值300-5000米";
            this.lblADeviation.ZIndex = 1;
            // 
            // dpAMStartWork
            // 
            this.dpAMStartWork.CurrentDate = new System.DateTime(2017, 1, 19, 10, 21, 0, 0);
            this.dpAMStartWork.FontSize = 12F;
            this.dpAMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpAMStartWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpAMStartWork.Location = new System.Drawing.Point(100, 45);
            this.dpAMStartWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpAMStartWork.Name = "dpAMStartWork";
            this.dpAMStartWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpAMStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpAMStartWork.TabIndex = 50;
            this.dpAMStartWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpAMStartWork_DatePicked);
            // 
            // dpAMEndWork
            // 
            this.dpAMEndWork.FontSize = 12F;
            this.dpAMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpAMEndWork.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpAMEndWork.Location = new System.Drawing.Point(100, 80);
            this.dpAMEndWork.Mode = Smobiler.Core.DatePickerMode.CountDownTimer;
            this.dpAMEndWork.Name = "dpAMEndWork";
            this.dpAMEndWork.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpAMEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpAMEndWork.TabIndex = 51;
            this.dpAMEndWork.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpAMEndWork_DatePicked);
            // 
            // gps1
            // 
            this.gps1.Name = "gps1";
            this.gps1.GotLocation += new Smobiler.Core.GpsCallBackHandler(this.gps1_GotLocation);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnDelete.BorderRadius = 2;
            this.btnDelete.FontSize = 17F;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(151)))), ((int)(((byte)(34)))));
            this.btnDelete.HoverForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(156, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 35);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "删除";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDelete_Click);
            // 
            // frmAttendanceCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.layoutDialog1,
            this.popList1,
            this.gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblStartWork,
            this.lblEndWork,
            this.lblPMStartWork,
            this.lblPMEndWork,
            this.lblDate1,
            this.btnDate,
            this.btnDate2,
            this.btnATMode,
            this.lblName,
            this.txtName,
            this.lblException,
            this.btnUser,
            this.btnUser2,
            this.lblAddress1,
            this.lblAddress,
            this.btnAddress2,
            this.txtADeviation,
            this.lblAllowableDeviation,
            this.btnAllowableDeviation2,
            this.dpStartWork,
            this.dpEndWork,
            this.dpPMStartWork,
            this.dpPMEndWork,
            this.lblADeviation,
            this.dpAMStartWork,
            this.dpAMEndWork,
            this.btnDelete,
            this.btnSave,
            this.line1,
            this.line2,
            this.line3,
            this.linePMupWork,
            this.linePMoffWork,
            this.lineDate,
            this.line4,
            this.lineException1,
            this.lineAddress,
            this.lineException,
            this.lineAllowableDeviation,
            this.lineATMode});
            this.Size = new System.Drawing.Size(300, 550);
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "考勤";
            this.Load += new System.EventHandler(this.frmAttendanceCreate_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceCreate_KeyDown);
            this.Name = "frmAttendanceCreate";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblStartWork;
        private Smobiler.Core.Controls.Label lblEndWork;
        private Smobiler.Core.Controls.Label lblPMStartWork;
        private Smobiler.Core.Controls.Label lblPMEndWork;
        private Smobiler.Core.Controls.Label lblDate1;
        private Smobiler.Core.Controls.Button btnDate;
        private Smobiler.Core.Controls.Button btnDate2;
        private Smobiler.Core.Controls.Button btnATMode;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.TextBox txtName;
        private Smobiler.Core.Controls.Label lblException;
        private Smobiler.Core.Controls.Button btnUser;
        private Smobiler.Core.Controls.Button btnUser2;
        private Smobiler.Core.Controls.Label lblAddress1;
        private Smobiler.Core.Controls.Label lblAddress;
        private Smobiler.Core.Controls.Button btnAddress2;
        private Smobiler.Core.Controls.TextBox txtADeviation;
        private Smobiler.Core.Controls.Label lblAllowableDeviation;
        private Smobiler.Core.Controls.Label btnAllowableDeviation2;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line linePMupWork;
        private Smobiler.Core.Controls.Line linePMoffWork;
        private Smobiler.Core.Controls.Line lineDate;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line lineException1;
        private Smobiler.Core.Controls.Line lineAddress;
        private Smobiler.Core.Controls.Line lineException;
        private Smobiler.Core.Controls.Line lineAllowableDeviation;
        private Smobiler.Core.Controls.DatePicker dpStartWork;
        private Smobiler.Core.Controls.DatePicker dpEndWork;
        private Smobiler.Core.Controls.DatePicker dpPMStartWork;
        private Smobiler.Core.Controls.DatePicker dpPMEndWork;
        private Smobiler.Core.Controls.Line lineATMode;
        private Smobiler.Core.Controls.LayoutDialog layoutDialog1;
        private Smobiler.Core.Controls.PopList popList1;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Label lblADeviation;
        private Smobiler.Core.Controls.DatePicker dpAMStartWork;
        private Smobiler.Core.Controls.DatePicker dpAMEndWork;
        private Smobiler.Core.Controls.GPS gps1;
        private Smobiler.Core.Controls.Button btnDelete;
    }
}
