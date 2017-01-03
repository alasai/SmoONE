using Smobiler.Core;

namespace SmoONE.UI.Leave
{
    partial class frmLeaveCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public frmLeaveCreate()
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnType1 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.dpkStartDate = new Smobiler.Core.Controls.DatePicker();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.dpkEndDate = new Smobiler.Core.Controls.DatePicker();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtLday = new Smobiler.Core.Controls.TextBox();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.txtReason = new Smobiler.Core.Controls.TextBox();
            this.lblImg = new Smobiler.Core.Controls.Label();
            this.lblCheck = new Smobiler.Core.Controls.Label();
            this.lblCheck1 = new Smobiler.Core.Controls.Label();
            this.imgbtnAddCheck = new Smobiler.Core.Controls.ImageButton();
            this.popType = new Smobiler.Core.Controls.PopList();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.lblCCTo1 = new Smobiler.Core.Controls.Label();
            this.lblCCTo = new Smobiler.Core.Controls.Label();
            this.imgbtnAddCCTo = new Smobiler.Core.Controls.ImageButton();
            this.imgL = new Smobiler.Core.Controls.Image();
            this.btnupPhoto = new Smobiler.Core.Controls.Button();
            this.btndelPhoto = new Smobiler.Core.Controls.Button();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.camera1 = new Smobiler.Core.Controls.Camera();
            this.line9 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            this.line7 = new Smobiler.Core.Controls.Line();
            this.line8 = new Smobiler.Core.Controls.Line();
            this.line11 = new Smobiler.Core.Controls.Line();
            this.line12 = new Smobiler.Core.Controls.Line();
            this.line13 = new Smobiler.Core.Controls.Line();
            this.lblCheck2 = new Smobiler.Core.Controls.Label();
            this.lblCCTo2 = new Smobiler.Core.Controls.Label();
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "请假类型";
            this.label1.ZIndex = 1;
            // 
            // btnType
            // 
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType.FontSize = 12F;
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnType.HoverBackColor = System.Drawing.Color.White;
            this.btnType.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.Location = new System.Drawing.Point(66, 10);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnType.Size = new System.Drawing.Size(209, 35);
            this.btnType.TabIndex = 4;
            this.btnType.Text = "选择（必填）";
            this.btnType.ZIndex = 2;
            this.btnType.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // btnType1
            // 
            this.btnType1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnType1.HoverBackColor = System.Drawing.Color.White;
            this.btnType1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType1.Location = new System.Drawing.Point(275, 10);
            this.btnType1.Name = "btnType1";
            this.btnType1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnType1.Size = new System.Drawing.Size(25, 35);
            this.btnType1.TabIndex = 5;
            this.btnType1.Text = ">";
            this.btnType1.ZIndex = 3;
            this.btnType1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "开始时间";
            this.label2.ZIndex = 4;
            // 
            // dpkStartDate
            // 
            this.dpkStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkStartDate.FontSize = 12F;
            this.dpkStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkStartDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpkStartDate.Location = new System.Drawing.Point(66, 55);
            this.dpkStartDate.Name = "dpkStartDate";
            this.dpkStartDate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpkStartDate.Size = new System.Drawing.Size(234, 35);
            this.dpkStartDate.TabIndex = 7;
            this.dpkStartDate.ZIndex = 5;
            // 
            // Label3
            // 
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 90);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(66, 35);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "结束时间";
            this.Label3.ZIndex = 6;
            // 
            // dpkEndDate
            // 
            this.dpkEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkEndDate.FontSize = 12F;
            this.dpkEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkEndDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.dpkEndDate.Location = new System.Drawing.Point(66, 90);
            this.dpkEndDate.Name = "dpkEndDate";
            this.dpkEndDate.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.dpkEndDate.Size = new System.Drawing.Size(234, 35);
            this.dpkEndDate.TabIndex = 9;
            this.dpkEndDate.ZIndex = 7;
            // 
            // Label4
            // 
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 135);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(66, 35);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "请假天数";
            this.Label4.ZIndex = 8;
            // 
            // txtLday
            // 
            this.txtLday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtLday.FontSize = 12F;
            this.txtLday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtLday.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtLday.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtLday.Location = new System.Drawing.Point(66, 135);
            this.txtLday.Name = "txtLday";
            this.txtLday.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtLday.Size = new System.Drawing.Size(234, 35);
            this.txtLday.TabIndex = 11;
            this.txtLday.WaterMarkText = "（必填）";
            this.txtLday.ZIndex = 9;
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0, 180);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(4F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(66, 80);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "请假事由";
            this.Label5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.Label5.ZIndex = 10;
            // 
            // txtReason
            // 
            this.txtReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtReason.FontSize = 12F;
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtReason.Location = new System.Drawing.Point(66, 180);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.txtReason.Size = new System.Drawing.Size(235, 80);
            this.txtReason.TabIndex = 13;
            this.txtReason.WaterMarkText = "（必填）";
            this.txtReason.ZIndex = 11;
            // 
            // lblImg
            // 
            this.lblImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblImg.Location = new System.Drawing.Point(0, 270);
            this.lblImg.Name = "lblImg";
            this.lblImg.Padding = new Smobiler.Core.Padding(4F, 5F, 0F, 0F);
            this.lblImg.Size = new System.Drawing.Size(66, 80);
            this.lblImg.TabIndex = 14;
            this.lblImg.Text = "图片";
            this.lblImg.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblImg.ZIndex = 12;
            // 
            // lblCheck
            // 
            this.lblCheck.BorderColor = System.Drawing.Color.LightGray;
            this.lblCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCheck.Location = new System.Drawing.Point(0, 360);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblCheck.Size = new System.Drawing.Size(66, 35);
            this.lblCheck.TabIndex = 15;
            this.lblCheck.Text = "审批人";
            this.lblCheck.ZIndex = 17;
            // 
            // lblCheck1
            // 
            this.lblCheck1.BorderColor = System.Drawing.Color.LightGray;
            this.lblCheck1.ForeColor = System.Drawing.Color.Silver;
            this.lblCheck1.Location = new System.Drawing.Point(66, 360);
            this.lblCheck1.Name = "lblCheck1";
            this.lblCheck1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblCheck1.Size = new System.Drawing.Size(234, 35);
            this.lblCheck1.TabIndex = 18;
            this.lblCheck1.Text = "（添加1-4位审批人，点击头像可删除）";
            this.lblCheck1.ZIndex = 18;
            // 
            // imgbtnAddCheck
            // 
            this.imgbtnAddCheck.Location = new System.Drawing.Point(65, 395);
            this.imgbtnAddCheck.Name = "imgbtnAddCheck";
            this.imgbtnAddCheck.ResourceID = "add";
            this.imgbtnAddCheck.Size = new System.Drawing.Size(35, 35);
            this.imgbtnAddCheck.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgbtnAddCheck.TabIndex = 20;
            this.imgbtnAddCheck.ZIndex = 20;
            this.imgbtnAddCheck.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnAddCheck_Click);
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
            this.btnSave.Location = new System.Drawing.Point(10, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "提交";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // lblCCTo1
            // 
            this.lblCCTo1.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblCCTo1.BorderColor = System.Drawing.Color.LightGray;
            this.lblCCTo1.ForeColor = System.Drawing.Color.Silver;
            this.lblCCTo1.Location = new System.Drawing.Point(66, 460);
            this.lblCCTo1.Name = "lblCCTo1";
            this.lblCCTo1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblCCTo1.Size = new System.Drawing.Size(234, 35);
            this.lblCCTo1.TabIndex = 22;
            this.lblCCTo1.Text = "（添加0-4位抄送人，点击头像可删除）";
            this.lblCCTo1.ZIndex = 22;
            // 
            // lblCCTo
            // 
            this.lblCCTo.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblCCTo.BorderColor = System.Drawing.Color.LightGray;
            this.lblCCTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCCTo.Location = new System.Drawing.Point(0, 460);
            this.lblCCTo.Name = "lblCCTo";
            this.lblCCTo.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblCCTo.Size = new System.Drawing.Size(66, 35);
            this.lblCCTo.TabIndex = 23;
            this.lblCCTo.Text = "抄送人";
            this.lblCCTo.ZIndex = 21;
            // 
            // imgbtnAddCCTo
            // 
            this.imgbtnAddCCTo.Location = new System.Drawing.Point(65, 495);
            this.imgbtnAddCCTo.Name = "imgbtnAddCCTo";
            this.imgbtnAddCCTo.ResourceID = "add";
            this.imgbtnAddCCTo.Size = new System.Drawing.Size(35, 35);
            this.imgbtnAddCCTo.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgbtnAddCCTo.TabIndex = 24;
            this.imgbtnAddCCTo.ZIndex = 24;
            this.imgbtnAddCCTo.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnAddCCTo_Click);
            // 
            // imgL
            // 
            this.imgL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgL.Enlarged = true;
            this.imgL.Location = new System.Drawing.Point(66, 270);
            this.imgL.Name = "imgL";
            this.imgL.Padding = new Smobiler.Core.Padding(0F, 2F, 0F, 0F);
            this.imgL.Size = new System.Drawing.Size(235, 50);
            this.imgL.TabIndex = 25;
            this.imgL.ZIndex = 13;
            // 
            // btnupPhoto
            // 
            this.btnupPhoto.Border = new Smobiler.Core.Border(1);
            this.btnupPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnupPhoto.BorderRadius = 5;
            this.btnupPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnupPhoto.Location = new System.Drawing.Point(114, 322);
            this.btnupPhoto.Name = "btnupPhoto";
            this.btnupPhoto.Size = new System.Drawing.Size(65, 20);
            this.btnupPhoto.TabIndex = 26;
            this.btnupPhoto.Text = "上传";
            this.btnupPhoto.ZIndex = 15;
            this.btnupPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnupPhoto_Click);
            // 
            // btndelPhoto
            // 
            this.btndelPhoto.Border = new Smobiler.Core.Border(1);
            this.btndelPhoto.BorderColor = System.Drawing.Color.Red;
            this.btndelPhoto.BorderRadius = 5;
            this.btndelPhoto.ForeColor = System.Drawing.Color.Red;
            this.btndelPhoto.Location = new System.Drawing.Point(189, 322);
            this.btndelPhoto.Name = "btndelPhoto";
            this.btndelPhoto.Size = new System.Drawing.Size(65, 20);
            this.btndelPhoto.TabIndex = 27;
            this.btndelPhoto.Text = "删除";
            this.btndelPhoto.ZIndex = 16;
            this.btndelPhoto.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btndelPhoto_Click);
            // 
            // Label9
            // 
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(66, 320);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(235, 30);
            this.Label9.TabIndex = 28;
            this.Label9.ZIndex = 14;
            // 
            // camera1
            // 
            this.camera1.Name = "camera1";
            this.camera1.QualityMode = Smobiler.Core.Controls.ImageQualityMode.Compressed;
            this.camera1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.camera1_ImageCaptured);
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 10);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 29;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 30;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 55);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 31;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 90);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 32;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 125);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 33;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 135);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 34;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(0, 170);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 1);
            this.line6.TabIndex = 35;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.LightGray;
            this.line7.Location = new System.Drawing.Point(0, 180);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(300, 1);
            this.line7.TabIndex = 36;
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.Color.LightGray;
            this.line8.Location = new System.Drawing.Point(0, 260);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(300, 1);
            this.line8.TabIndex = 37;
            // 
            // line11
            // 
            this.line11.BackColor = System.Drawing.Color.LightGray;
            this.line11.Location = new System.Drawing.Point(0, 350);
            this.line11.Name = "line11";
            this.line11.Size = new System.Drawing.Size(300, 1);
            this.line11.TabIndex = 39;
            // 
            // line12
            // 
            this.line12.BackColor = System.Drawing.Color.LightGray;
            this.line12.Location = new System.Drawing.Point(0, 270);
            this.line12.Name = "line12";
            this.line12.Size = new System.Drawing.Size(300, 1);
            this.line12.TabIndex = 40;
            // 
            // line13
            // 
            this.line13.BackColor = System.Drawing.Color.LightGray;
            this.line13.Location = new System.Drawing.Point(0, 360);
            this.line13.Name = "line13";
            this.line13.Size = new System.Drawing.Size(300, 1);
            this.line13.TabIndex = 41;
            // 
            // lblCheck2
            // 
            this.lblCheck2.BorderColor = System.Drawing.Color.LightGray;
            this.lblCheck2.Location = new System.Drawing.Point(0, 395);
            this.lblCheck2.Name = "lblCheck2";
            this.lblCheck2.Size = new System.Drawing.Size(300, 55);
            this.lblCheck2.TabIndex = 42;
            this.lblCheck2.ZIndex = 19;
            // 
            // lblCCTo2
            // 
            this.lblCCTo2.BorderColor = System.Drawing.Color.LightGray;
            this.lblCCTo2.Location = new System.Drawing.Point(0, 495);
            this.lblCCTo2.Name = "lblCCTo2";
            this.lblCCTo2.Size = new System.Drawing.Size(300, 50);
            this.lblCCTo2.TabIndex = 44;
            this.lblCCTo2.ZIndex = 23;
            // 
            // frmLeaveCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popType,
            this.camera1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.label1,
            this.btnType,
            this.btnType1,
            this.label2,
            this.dpkStartDate,
            this.Label3,
            this.dpkEndDate,
            this.Label4,
            this.txtLday,
            this.Label5,
            this.txtReason,
            this.lblImg,
            this.imgL,
            this.Label9,
            this.btnupPhoto,
            this.btndelPhoto,
            this.lblCheck,
            this.lblCheck1,
            this.lblCheck2,
            this.imgbtnAddCheck,
            this.lblCCTo,
            this.lblCCTo1,
            this.lblCCTo2,
            this.imgbtnAddCCTo,
            this.line9,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line6,
            this.line7,
            this.line8,
            this.line11,
            this.line12,
            this.line13});
            this.Size = new System.Drawing.Size(300, 600);
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "我的请假";
            this.Load += new System.EventHandler(this.frmLeaveCreate_Load);
            this.TitleImageClick += new System.EventHandler(this.frmLeaveCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmLeaveCreate_KeyDown);
            this.Name = "frmLeaveCreate";

        }
        #endregion

        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Button btnType1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.DatePicker dpkStartDate;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.DatePicker dpkEndDate;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtLday;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.TextBox txtReason;
        internal Smobiler.Core.Controls.Label lblImg;
        internal Smobiler.Core.Controls.Label lblCheck;
        private Smobiler.Core.Controls.Label lblCheck1;
        private Smobiler.Core.Controls.ImageButton imgbtnAddCheck;
        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Label lblCCTo1;
        internal Smobiler.Core.Controls.Label lblCCTo;
        private Smobiler.Core.Controls.ImageButton imgbtnAddCCTo;
        internal Smobiler.Core.Controls.Image imgL;
        internal Smobiler.Core.Controls.Button btnupPhoto;
        internal Smobiler.Core.Controls.Button btndelPhoto;
        internal Smobiler.Core.Controls.Label Label9;
        private Smobiler.Core.Controls.Camera camera1;
        private Smobiler.Core.Controls.Line line9;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
        private Smobiler.Core.Controls.Line line7;
        private Smobiler.Core.Controls.Line line8;
        private Smobiler.Core.Controls.Line line11;
        private Smobiler.Core.Controls.Line line12;
        private Smobiler.Core.Controls.Line line13;
        private Smobiler.Core.Controls.Label lblCheck2;
        private Smobiler.Core.Controls.Label lblCCTo2;

    }
}