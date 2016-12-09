using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostCenterCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostCenterCreate()
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
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtCC_Name = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnType1 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.dpkStartDate = new Smobiler.Core.Controls.DatePicker();
            this.dpkEndDate = new Smobiler.Core.Controls.DatePicker();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.txtAmount = new Smobiler.Core.Controls.TextBox();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.btnLiableMan = new Smobiler.Core.Controls.Button();
            this.btnLiableMan1 = new Smobiler.Core.Controls.Button();
            this.popType = new Smobiler.Core.Controls.PopList();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnTemplate = new Smobiler.Core.Controls.Button();
            this.btnTemplate1 = new Smobiler.Core.Controls.Button();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.lblDep = new Smobiler.Core.Controls.Label();
            this.popLiable = new Smobiler.Core.Controls.PopList();
            this.line9 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            this.line7 = new Smobiler.Core.Controls.Line();
            this.line8 = new Smobiler.Core.Controls.Line();
            this.line10 = new Smobiler.Core.Controls.Line();
            this.line11 = new Smobiler.Core.Controls.Line();
            this.line12 = new Smobiler.Core.Controls.Line();
            this.line13 = new Smobiler.Core.Controls.Line();
            this.line14 = new Smobiler.Core.Controls.Line();
            // 
            // Label4
            // 
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 10);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(66, 35);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "名称";
            // 
            // txtCC_Name
            // 
            this.txtCC_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCC_Name.FontSize = 12F;
            this.txtCC_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtCC_Name.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtCC_Name.Location = new System.Drawing.Point(66, 10);
            this.txtCC_Name.Name = "txtCC_Name";
            this.txtCC_Name.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtCC_Name.Size = new System.Drawing.Size(234, 35);
            this.txtCC_Name.TabIndex = 3;
            this.txtCC_Name.WaterMarkText = "（必填）";
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "类型";
            // 
            // btnType
            // 
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType.FontSize = 12F;
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnType.HoverBackColor = System.Drawing.Color.White;
            this.btnType.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.Location = new System.Drawing.Point(66, 55);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnType.Size = new System.Drawing.Size(209, 35);
            this.btnType.TabIndex = 5;
            this.btnType.Text = "选择（必填）";
            this.btnType.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // btnType1
            // 
            this.btnType1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnType1.HoverBackColor = System.Drawing.Color.White;
            this.btnType1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType1.Location = new System.Drawing.Point(275, 55);
            this.btnType1.Name = "btnType1";
            this.btnType1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnType1.Size = new System.Drawing.Size(25, 35);
            this.btnType1.TabIndex = 6;
            this.btnType1.Text = ">";
            this.btnType1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(0, 135);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "结束时间";
            // 
            // dpkStartDate
            // 
            this.dpkStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkStartDate.FontSize = 12F;
            this.dpkStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkStartDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpkStartDate.Location = new System.Drawing.Point(66, 100);
            this.dpkStartDate.Mode = Smobiler.Core.DatePickerMode.DateAndTime;
            this.dpkStartDate.Name = "dpkStartDate";
            this.dpkStartDate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpkStartDate.Size = new System.Drawing.Size(234, 35);
            this.dpkStartDate.TabIndex = 9;
            // 
            // dpkEndDate
            // 
            this.dpkEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkEndDate.FontSize = 12F;
            this.dpkEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkEndDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpkEndDate.Location = new System.Drawing.Point(66, 135);
            this.dpkEndDate.Mode = Smobiler.Core.DatePickerMode.DateAndTime;
            this.dpkEndDate.Name = "dpkEndDate";
            this.dpkEndDate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpkEndDate.Size = new System.Drawing.Size(234, 35);
            this.dpkEndDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(0, 180);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(66, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "金额";
            // 
            // txtAmount
            // 
            this.txtAmount.FontSize = 12F;
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtAmount.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtAmount.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtAmount.Location = new System.Drawing.Point(66, 180);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtAmount.Size = new System.Drawing.Size(234, 35);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.WaterMarkText = "（必输）";
            // 
            // label6
            // 
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(0, 225);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(66, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "责任人";
            // 
            // label7
            // 
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(0, 305);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(112, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "成本中心类型模板";
            // 
            // btnLiableMan
            // 
            this.btnLiableMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLiableMan.FontSize = 12F;
            this.btnLiableMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLiableMan.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnLiableMan.HoverBackColor = System.Drawing.Color.White;
            this.btnLiableMan.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLiableMan.Location = new System.Drawing.Point(66, 225);
            this.btnLiableMan.Name = "btnLiableMan";
            this.btnLiableMan.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnLiableMan.Size = new System.Drawing.Size(209, 35);
            this.btnLiableMan.TabIndex = 17;
            this.btnLiableMan.Text = "选择（必填）";
            this.btnLiableMan.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnLiableMan_Click);
            // 
            // btnLiableMan1
            // 
            this.btnLiableMan1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLiableMan1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLiableMan1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnLiableMan1.HoverBackColor = System.Drawing.Color.White;
            this.btnLiableMan1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLiableMan1.Location = new System.Drawing.Point(275, 225);
            this.btnLiableMan1.Name = "btnLiableMan1";
            this.btnLiableMan1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnLiableMan1.Size = new System.Drawing.Size(25, 35);
            this.btnLiableMan1.TabIndex = 18;
            this.btnLiableMan1.Text = ">";
            this.btnLiableMan1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnLiableMan_Click);
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "提交";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // btnTemplate
            // 
            this.btnTemplate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTemplate.FontSize = 12F;
            this.btnTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnTemplate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnTemplate.HoverBackColor = System.Drawing.Color.White;
            this.btnTemplate.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnTemplate.Location = new System.Drawing.Point(112, 305);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnTemplate.Size = new System.Drawing.Size(163, 35);
            this.btnTemplate.TabIndex = 20;
            this.btnTemplate.Text = "选择（必填）";
            this.btnTemplate.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnTemplate_Click);
            // 
            // btnTemplate1
            // 
            this.btnTemplate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTemplate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnTemplate1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnTemplate1.HoverBackColor = System.Drawing.Color.White;
            this.btnTemplate1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnTemplate1.Location = new System.Drawing.Point(275, 305);
            this.btnTemplate1.Name = "btnTemplate1";
            this.btnTemplate1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnTemplate1.Size = new System.Drawing.Size(25, 35);
            this.btnTemplate1.TabIndex = 21;
            this.btnTemplate1.Text = ">";
            this.btnTemplate1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnTemplate_Click);
            // 
            // label9
            // 
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(0, 260);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(66, 35);
            this.label9.TabIndex = 22;
            this.label9.Text = "部门";
            // 
            // lblDep
            // 
            this.lblDep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDep.FontSize = 12F;
            this.lblDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblDep.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblDep.Location = new System.Drawing.Point(66, 260);
            this.lblDep.Name = "lblDep";
            this.lblDep.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblDep.Size = new System.Drawing.Size(234, 35);
            this.lblDep.TabIndex = 23;
            // 
            // popLiable
            // 
            this.popLiable.Name = "popLiable";
            this.popLiable.Selected += new System.EventHandler(this.popLiable_Selected);
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 10);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 24;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 25;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 55);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 26;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 90);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 27;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 100);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 28;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 135);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 29;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(0, 170);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 1);
            this.line6.TabIndex = 30;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.LightGray;
            this.line7.Location = new System.Drawing.Point(0, 180);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(300, 1);
            this.line7.TabIndex = 31;
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.Color.LightGray;
            this.line8.Location = new System.Drawing.Point(0, 215);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(300, 1);
            this.line8.TabIndex = 32;
            // 
            // line10
            // 
            this.line10.BackColor = System.Drawing.Color.LightGray;
            this.line10.Location = new System.Drawing.Point(0, 225);
            this.line10.Name = "line10";
            this.line10.Size = new System.Drawing.Size(300, 1);
            this.line10.TabIndex = 33;
            // 
            // line11
            // 
            this.line11.BackColor = System.Drawing.Color.LightGray;
            this.line11.Location = new System.Drawing.Point(0, 260);
            this.line11.Name = "line11";
            this.line11.Size = new System.Drawing.Size(300, 1);
            this.line11.TabIndex = 34;
            // 
            // line12
            // 
            this.line12.BackColor = System.Drawing.Color.LightGray;
            this.line12.Location = new System.Drawing.Point(0, 295);
            this.line12.Name = "line12";
            this.line12.Size = new System.Drawing.Size(300, 1);
            this.line12.TabIndex = 35;
            // 
            // line13
            // 
            this.line13.BackColor = System.Drawing.Color.LightGray;
            this.line13.Location = new System.Drawing.Point(0, 305);
            this.line13.Name = "line13";
            this.line13.Size = new System.Drawing.Size(300, 1);
            this.line13.TabIndex = 36;
            // 
            // line14
            // 
            this.line14.BackColor = System.Drawing.Color.LightGray;
            this.line14.Location = new System.Drawing.Point(0, 340);
            this.line14.Name = "line14";
            this.line14.Size = new System.Drawing.Size(300, 1);
            this.line14.TabIndex = 37;
            // 
            // frmCostCenterCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popType,
            this.popLiable});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.txtCC_Name,
            this.label3,
            this.btnType,
            this.btnType1,
            this.label1,
            this.label2,
            this.dpkStartDate,
            this.dpkEndDate,
            this.label5,
            this.txtAmount,
            this.label6,
            this.label7,
            this.btnLiableMan,
            this.btnLiableMan1,
            this.btnSave,
            this.btnTemplate,
            this.btnTemplate1,
            this.label9,
            this.lblDep,
            this.line9,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line6,
            this.line7,
            this.line8,
            this.line10,
            this.line11,
            this.line12,
            this.line13,
            this.line14});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "成本中心";
            this.Load += new System.EventHandler(this.frmCostCenterCreate_Load);
            this.TitleImageClick += new System.EventHandler(this.frmCostCenterCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmCostCenterCreate_KeyDown);
            this.Name = "frmCostCenterCreate";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtCC_Name;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Button btnType1;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.DatePicker dpkStartDate;
        internal Smobiler.Core.Controls.DatePicker dpkEndDate;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.TextBox txtAmount;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Button btnLiableMan;
        internal Smobiler.Core.Controls.Button btnLiableMan1;
        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Button btnTemplate;
        internal Smobiler.Core.Controls.Button btnTemplate1;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label lblDep;
        private Smobiler.Core.Controls.PopList popLiable;
        private Smobiler.Core.Controls.Line line9;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
        private Smobiler.Core.Controls.Line line7;
        private Smobiler.Core.Controls.Line line8;
        private Smobiler.Core.Controls.Line line10;
        private Smobiler.Core.Controls.Line line11;
        private Smobiler.Core.Controls.Line line12;
        private Smobiler.Core.Controls.Line line13;
        private Smobiler.Core.Controls.Line line14;
    }
}