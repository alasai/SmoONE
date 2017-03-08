using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatMonth : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatMonth()
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
            Smobiler.Core.Controls.PopListGroup popListGroup2 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem11 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem12 = new Smobiler.Core.Controls.PopListItem();
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
            this.btnYear = new Smobiler.Core.Controls.Button();
            this.lblYear = new Smobiler.Core.Controls.Label();
            this.BtnMonth = new Smobiler.Core.Controls.Button();
            this.lblMonth = new Smobiler.Core.Controls.Label();
            this.popListYear = new Smobiler.Core.Controls.PopList();
            this.popListMonth = new Smobiler.Core.Controls.PopList();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.progress1 = new Smobiler.Core.Controls.Progress();
            this.proMSInTime = new Smobiler.Core.Controls.Progress();
            this.proMSCLate = new Smobiler.Core.Controls.Progress();
            this.proMSLEarly = new Smobiler.Core.Controls.Progress();
            this.proMSNoSign = new Smobiler.Core.Controls.Progress();
            this.btnATInTime = new Smobiler.Core.Controls.Button();
            this.btnATLate = new Smobiler.Core.Controls.Button();
            this.btnLEarly = new Smobiler.Core.Controls.Button();
            this.btnATNoSign = new Smobiler.Core.Controls.Button();
            this.btnMSAllCount = new Smobiler.Core.Controls.Button();
            this.btnMSInTimeCount = new Smobiler.Core.Controls.Button();
            this.btnMSLEarlyCount = new Smobiler.Core.Controls.Button();
            this.btnMSCLateCount = new Smobiler.Core.Controls.Button();
            this.btnMSNoSignCount = new Smobiler.Core.Controls.Button();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.btnATAbsentCount = new Smobiler.Core.Controls.Button();
            this.btnATAbsent = new Smobiler.Core.Controls.Button();
            this.proATAbsent = new Smobiler.Core.Controls.Progress();
            this.label12 = new Smobiler.Core.Controls.Label();
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnYear.Enabled = false;
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnYear.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnYear.HoverForeColor = System.Drawing.Color.White;
            this.btnYear.Name = "btnYear";
            this.btnYear.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnYear.Size = new System.Drawing.Size(145, 35);
            this.btnYear.TabIndex = 2;
            this.btnYear.Text = "2017";
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(145, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(19, 35);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "年";
            // 
            // BtnMonth
            // 
            this.BtnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnMonth.Enabled = false;
            this.BtnMonth.ForeColor = System.Drawing.Color.White;
            this.BtnMonth.Location = new System.Drawing.Point(164, 0);
            this.BtnMonth.Name = "BtnMonth";
            this.BtnMonth.Size = new System.Drawing.Size(20, 35);
            this.BtnMonth.TabIndex = 4;
            this.BtnMonth.Text = "2";
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(184, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(116, 35);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "月  ";
            // 
            // popListYear
            // 
            popListGroup1.IndexerKey = "";
            popListItem1.Text = "2008";
            popListItem2.Text = "2009";
            popListItem3.Text = "2010";
            popListItem4.Text = "2011";
            popListItem5.Text = "2012";
            popListItem6.Text = "2013";
            popListItem7.Text = "2014";
            popListItem8.Text = "2015";
            popListItem9.Text = "2016";
            popListItem10.Text = "2017";
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
            popListItem10});
            popListGroup1.Text = "请选择年份";
            this.popListYear.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popListYear.Name = "popListYear";
            this.popListYear.Selected += new System.EventHandler(this.popListYear_Selected);
            // 
            // popListMonth
            // 
            popListGroup2.IndexerKey = "";
            popListItem11.Text = "1";
            popListItem12.Text = "2";
            popListItem13.Text = "3";
            popListItem14.Text = "4";
            popListItem15.Text = "5";
            popListItem16.Text = "6";
            popListItem17.Text = "7";
            popListItem18.Text = "8";
            popListItem19.Text = "9";
            popListItem20.Text = "0";
            popListItem21.Text = "11";
            popListItem22.Text = "12";
            popListGroup2.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem11,
            popListItem12,
            popListItem13,
            popListItem14,
            popListItem15,
            popListItem16,
            popListItem17,
            popListItem18,
            popListItem19,
            popListItem20,
            popListItem21,
            popListItem22});
            popListGroup2.Text = "请选择月份";
            this.popListMonth.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup2});
            this.popListMonth.Name = "popListMonth";
            this.popListMonth.Selected += new System.EventHandler(this.popListMonth_Selected);
            // 
            // lblID
            // 
            this.lblID.DataMember = "AT_TypeID";
            this.lblID.DisplayMember = "Dep_Name";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Location = new System.Drawing.Point(0, 35);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "应签到";
            this.lblID.ZIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoVisibleInLayout = true;
            this.label8.DataMember = "WorkDate1";
            this.label8.DisplayMember = "WorkDate1";
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label8.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label8.Location = new System.Drawing.Point(0, 35);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label8.Size = new System.Drawing.Size(300, 40);
            this.label8.TabIndex = 7;
            this.label8.ZIndex = 1;
            // 
            // label1
            // 
            this.label1.DataMember = "AT_TypeID";
            this.label1.DisplayMember = "Dep_Name";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(0, 75);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label1.TabIndex = 8;
            this.label1.Text = "准时";
            this.label1.ZIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoVisibleInLayout = true;
            this.label2.DataMember = "WorkDate1";
            this.label2.DisplayMember = "WorkDate1";
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(0, 75);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(300, 40);
            this.label2.TabIndex = 9;
            this.label2.ZIndex = 6;
            // 
            // label3
            // 
            this.label3.DataMember = "AT_TypeID";
            this.label3.DisplayMember = "Dep_Name";
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(0, 115);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label3.TabIndex = 10;
            this.label3.Text = "迟到";
            this.label3.ZIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoVisibleInLayout = true;
            this.label4.DataMember = "WorkDate1";
            this.label4.DisplayMember = "WorkDate1";
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(0, 115);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label4.Size = new System.Drawing.Size(300, 40);
            this.label4.TabIndex = 11;
            this.label4.ZIndex = 11;
            // 
            // label5
            // 
            this.label5.DataMember = "AT_TypeID";
            this.label5.DisplayMember = "Dep_Name";
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, 155);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label5.TabIndex = 12;
            this.label5.Text = "早退";
            this.label5.ZIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoVisibleInLayout = true;
            this.label6.DataMember = "WorkDate1";
            this.label6.DisplayMember = "WorkDate1";
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label6.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label6.Location = new System.Drawing.Point(0, 155);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label6.Size = new System.Drawing.Size(300, 40);
            this.label6.TabIndex = 13;
            this.label6.ZIndex = 16;
            // 
            // label7
            // 
            this.label7.DataMember = "AT_TypeID";
            this.label7.DisplayMember = "Dep_Name";
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(0, 195);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label7.TabIndex = 14;
            this.label7.Text = "未签到";
            this.label7.ZIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoVisibleInLayout = true;
            this.label9.DataMember = "WorkDate1";
            this.label9.DisplayMember = "WorkDate1";
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label9.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label9.Location = new System.Drawing.Point(0, 195);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label9.Size = new System.Drawing.Size(300, 40);
            this.label9.TabIndex = 15;
            this.label9.ZIndex = 21;
            // 
            // progress1
            // 
            this.progress1.BorderRadius = 10;
            this.progress1.Location = new System.Drawing.Point(10, 65);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(260, 5);
            this.progress1.TabIndex = 16;
            this.progress1.ZIndex = 5;
            // 
            // proMSInTime
            // 
            this.proMSInTime.BorderRadius = 10;
            this.proMSInTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(187)))), ((int)(((byte)(91)))));
            this.proMSInTime.Location = new System.Drawing.Point(10, 105);
            this.proMSInTime.Name = "proMSInTime";
            this.proMSInTime.Size = new System.Drawing.Size(260, 5);
            this.proMSInTime.TabIndex = 17;
            this.proMSInTime.ZIndex = 10;
            // 
            // proMSCLate
            // 
            this.proMSCLate.BorderRadius = 10;
            this.proMSCLate.ForeColor = System.Drawing.Color.Yellow;
            this.proMSCLate.Location = new System.Drawing.Point(10, 145);
            this.proMSCLate.Name = "proMSCLate";
            this.proMSCLate.Size = new System.Drawing.Size(260, 5);
            this.proMSCLate.TabIndex = 18;
            this.proMSCLate.ZIndex = 15;
            // 
            // proMSLEarly
            // 
            this.proMSLEarly.BorderRadius = 10;
            this.proMSLEarly.ForeColor = System.Drawing.Color.Orange;
            this.proMSLEarly.Location = new System.Drawing.Point(10, 185);
            this.proMSLEarly.Name = "proMSLEarly";
            this.proMSLEarly.Size = new System.Drawing.Size(260, 5);
            this.proMSLEarly.TabIndex = 19;
            this.proMSLEarly.ZIndex = 20;
            // 
            // proMSNoSign
            // 
            this.proMSNoSign.BorderRadius = 10;
            this.proMSNoSign.ForeColor = System.Drawing.Color.Red;
            this.proMSNoSign.Location = new System.Drawing.Point(10, 225);
            this.proMSNoSign.Name = "proMSNoSign";
            this.proMSNoSign.Size = new System.Drawing.Size(260, 5);
            this.proMSNoSign.TabIndex = 20;
            this.proMSNoSign.ZIndex = 25;
            // 
            // btnATInTime
            // 
            this.btnATInTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATInTime.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnATInTime.HoverBackColor = System.Drawing.Color.White;
            this.btnATInTime.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATInTime.Location = new System.Drawing.Point(270, 75);
            this.btnATInTime.Name = "btnATInTime";
            this.btnATInTime.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.btnATInTime.Size = new System.Drawing.Size(30, 30);
            this.btnATInTime.TabIndex = 22;
            this.btnATInTime.Text = ">";
            this.btnATInTime.ZIndex = 9;
            this.btnATInTime.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // btnATLate
            // 
            this.btnATLate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATLate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnATLate.HoverBackColor = System.Drawing.Color.White;
            this.btnATLate.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATLate.Location = new System.Drawing.Point(270, 115);
            this.btnATLate.Name = "btnATLate";
            this.btnATLate.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.btnATLate.Size = new System.Drawing.Size(30, 30);
            this.btnATLate.TabIndex = 23;
            this.btnATLate.Text = ">";
            this.btnATLate.ZIndex = 14;
            this.btnATLate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // btnLEarly
            // 
            this.btnLEarly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLEarly.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnLEarly.HoverBackColor = System.Drawing.Color.White;
            this.btnLEarly.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLEarly.Location = new System.Drawing.Point(270, 155);
            this.btnLEarly.Name = "btnLEarly";
            this.btnLEarly.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.btnLEarly.Size = new System.Drawing.Size(30, 30);
            this.btnLEarly.TabIndex = 24;
            this.btnLEarly.Text = ">";
            this.btnLEarly.ZIndex = 19;
            this.btnLEarly.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // btnATNoSign
            // 
            this.btnATNoSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATNoSign.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnATNoSign.HoverBackColor = System.Drawing.Color.White;
            this.btnATNoSign.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATNoSign.Location = new System.Drawing.Point(270, 195);
            this.btnATNoSign.Name = "btnATNoSign";
            this.btnATNoSign.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.btnATNoSign.Size = new System.Drawing.Size(30, 30);
            this.btnATNoSign.TabIndex = 25;
            this.btnATNoSign.Text = ">";
            this.btnATNoSign.ZIndex = 24;
            this.btnATNoSign.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // btnMSAllCount
            // 
            this.btnMSAllCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSAllCount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnMSAllCount.HoverBackColor = System.Drawing.Color.White;
            this.btnMSAllCount.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSAllCount.Location = new System.Drawing.Point(80, 35);
            this.btnMSAllCount.Name = "btnMSAllCount";
            this.btnMSAllCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSAllCount.TabIndex = 26;
            this.btnMSAllCount.Text = "0人";
            this.btnMSAllCount.ZIndex = 3;
            // 
            // btnMSInTimeCount
            // 
            this.btnMSInTimeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSInTimeCount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnMSInTimeCount.HoverBackColor = System.Drawing.Color.White;
            this.btnMSInTimeCount.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSInTimeCount.Location = new System.Drawing.Point(80, 75);
            this.btnMSInTimeCount.Name = "btnMSInTimeCount";
            this.btnMSInTimeCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSInTimeCount.TabIndex = 27;
            this.btnMSInTimeCount.Text = "0人";
            this.btnMSInTimeCount.ZIndex = 8;
            this.btnMSInTimeCount.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // btnMSLEarlyCount
            // 
            this.btnMSLEarlyCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSLEarlyCount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnMSLEarlyCount.HoverBackColor = System.Drawing.Color.White;
            this.btnMSLEarlyCount.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSLEarlyCount.Location = new System.Drawing.Point(80, 155);
            this.btnMSLEarlyCount.Name = "btnMSLEarlyCount";
            this.btnMSLEarlyCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSLEarlyCount.TabIndex = 28;
            this.btnMSLEarlyCount.Text = "0人";
            this.btnMSLEarlyCount.ZIndex = 18;
            this.btnMSLEarlyCount.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // btnMSCLateCount
            // 
            this.btnMSCLateCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSCLateCount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnMSCLateCount.HoverBackColor = System.Drawing.Color.White;
            this.btnMSCLateCount.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSCLateCount.Location = new System.Drawing.Point(80, 115);
            this.btnMSCLateCount.Name = "btnMSCLateCount";
            this.btnMSCLateCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSCLateCount.TabIndex = 29;
            this.btnMSCLateCount.Text = "0人";
            this.btnMSCLateCount.ZIndex = 13;
            this.btnMSCLateCount.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // btnMSNoSignCount
            // 
            this.btnMSNoSignCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSNoSignCount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnMSNoSignCount.HoverBackColor = System.Drawing.Color.White;
            this.btnMSNoSignCount.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSNoSignCount.Location = new System.Drawing.Point(80, 195);
            this.btnMSNoSignCount.Name = "btnMSNoSignCount";
            this.btnMSNoSignCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSNoSignCount.TabIndex = 30;
            this.btnMSNoSignCount.Text = "0人";
            this.btnMSNoSignCount.ZIndex = 23;
            this.btnMSNoSignCount.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // label11
            // 
            this.label11.DataMember = "AT_TypeID";
            this.label11.DisplayMember = "Dep_Name";
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label11.Location = new System.Drawing.Point(0, 235);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label11.TabIndex = 32;
            this.label11.Text = "全天旷工";
            this.label11.ZIndex = 27;
            // 
            // btnATAbsentCount
            // 
            this.btnATAbsentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnATAbsentCount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnATAbsentCount.HoverBackColor = System.Drawing.Color.White;
            this.btnATAbsentCount.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnATAbsentCount.Location = new System.Drawing.Point(80, 235);
            this.btnATAbsentCount.Name = "btnATAbsentCount";
            this.btnATAbsentCount.Size = new System.Drawing.Size(190, 30);
            this.btnATAbsentCount.TabIndex = 33;
            this.btnATAbsentCount.Text = "0人";
            this.btnATAbsentCount.ZIndex = 28;
            this.btnATAbsentCount.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // btnATAbsent
            // 
            this.btnATAbsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATAbsent.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnATAbsent.HoverBackColor = System.Drawing.Color.White;
            this.btnATAbsent.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATAbsent.Location = new System.Drawing.Point(270, 235);
            this.btnATAbsent.Name = "btnATAbsent";
            this.btnATAbsent.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.btnATAbsent.Size = new System.Drawing.Size(30, 30);
            this.btnATAbsent.TabIndex = 34;
            this.btnATAbsent.Text = ">";
            this.btnATAbsent.ZIndex = 29;
            this.btnATAbsent.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnATTypeSign_Click);
            // 
            // proATAbsent
            // 
            this.proATAbsent.BorderRadius = 10;
            this.proATAbsent.ForeColor = System.Drawing.Color.Red;
            this.proATAbsent.Location = new System.Drawing.Point(10, 268);
            this.proATAbsent.Name = "proATAbsent";
            this.proATAbsent.Size = new System.Drawing.Size(260, 5);
            this.proATAbsent.TabIndex = 35;
            this.proATAbsent.ZIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoVisibleInLayout = true;
            this.label12.DataMember = "WorkDate1";
            this.label12.DisplayMember = "WorkDate1";
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label12.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label12.Location = new System.Drawing.Point(0, 235);
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label12.Size = new System.Drawing.Size(300, 40);
            this.label12.TabIndex = 36;
            this.label12.ZIndex = 26;
            // 
            // frmAttendanceStatMonth
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popListYear,
            this.popListMonth});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnYear,
            this.lblYear,
            this.BtnMonth,
            this.lblMonth,
            this.label8,
            this.lblID,
            this.btnMSAllCount,
            this.progress1,
            this.label2,
            this.label1,
            this.btnMSInTimeCount,
            this.btnATInTime,
            this.proMSInTime,
            this.label4,
            this.label3,
            this.btnMSCLateCount,
            this.btnATLate,
            this.proMSCLate,
            this.label6,
            this.label5,
            this.btnMSLEarlyCount,
            this.btnLEarly,
            this.proMSLEarly,
            this.label9,
            this.label7,
            this.btnMSNoSignCount,
            this.btnATNoSign,
            this.proMSNoSign,
            this.label12,
            this.label11,
            this.btnATAbsentCount,
            this.btnATAbsent,
            this.proATAbsent});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "考勤月报表";
            this.Load += new System.EventHandler(this.frmAttendanceStatMonth_Load);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceStatMonth_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceStatMonth_KeyDown);
            this.Name = "frmAttendanceStatMonth";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnYear;
        private Smobiler.Core.Controls.Label lblYear;
        private Smobiler.Core.Controls.Button BtnMonth;
        private Smobiler.Core.Controls.Label lblMonth;
        private Smobiler.Core.Controls.PopList popListYear;
        private Smobiler.Core.Controls.PopList popListMonth;
        internal Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Label label8;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Progress progress1;
        private Smobiler.Core.Controls.Progress proMSInTime;
        private Smobiler.Core.Controls.Progress proMSCLate;
        private Smobiler.Core.Controls.Progress proMSLEarly;
        private Smobiler.Core.Controls.Progress proMSNoSign;
        private Smobiler.Core.Controls.Button btnATInTime;
        private Smobiler.Core.Controls.Button btnATLate;
        private Smobiler.Core.Controls.Button btnLEarly;
        private Smobiler.Core.Controls.Button btnATNoSign;
        private Smobiler.Core.Controls.Button btnMSAllCount;
        private Smobiler.Core.Controls.Button btnMSInTimeCount;
        private Smobiler.Core.Controls.Button btnMSLEarlyCount;
        private Smobiler.Core.Controls.Button btnMSCLateCount;
        private Smobiler.Core.Controls.Button btnMSNoSignCount;
        internal Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.Button btnATAbsentCount;
        private Smobiler.Core.Controls.Button btnATAbsent;
        private Smobiler.Core.Controls.Progress proATAbsent;
        internal Smobiler.Core.Controls.Label label12;
    }
}