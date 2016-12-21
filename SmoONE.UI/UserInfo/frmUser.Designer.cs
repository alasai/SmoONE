using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmUser : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmUser()
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
            this.Work = new Smobiler.Core.Controls.ToolbarItem();
            this.Me = new Smobiler.Core.Controls.ToolbarItem();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.btnUp = new Smobiler.Core.Controls.Button();
            this.btnName1 = new Smobiler.Core.Controls.Button();
            this.btnSex1 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.btnName = new Smobiler.Core.Controls.Button();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnSex = new Smobiler.Core.Controls.Button();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.dpkBirthday = new Smobiler.Core.Controls.DatePicker();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.btnEmail1 = new Smobiler.Core.Controls.Button();
            this.btnEmail = new Smobiler.Core.Controls.Button();
            this.btnPwd = new Smobiler.Core.Controls.Button();
            this.line7 = new Smobiler.Core.Controls.Line();
            this.line8 = new Smobiler.Core.Controls.Line();
            this.ldEditUserInfo = new Smobiler.Core.Controls.LayoutDialog();
            this.cameraPortrait = new Smobiler.Core.Controls.Camera();
            this.popSex = new Smobiler.Core.Controls.PopList();
            this.line9 = new Smobiler.Core.Controls.Line();
            // 
            // Work
            // 
            this.Work.IconID = "work";
            this.Work.Name = "Work";
            this.Work.SelectIconID = "work";
            // 
            // Me
            // 
            this.Me.IconID = "me2";
            this.Me.Name = "Me";
            this.Me.SelectIconID = "me2";
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.FontSize = 12F;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "头像";
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.Enlarged = true;
            this.imgPortrait.ID = "";
            this.imgPortrait.Location = new System.Drawing.Point(224, 12);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(41, 41);
            this.imgPortrait.TabIndex = 3;
            // 
            // btnUp
            // 
            this.btnUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUp.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnUp.HoverBackColor = System.Drawing.Color.White;
            this.btnUp.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUp.Location = new System.Drawing.Point(265, 10);
            this.btnUp.Name = "btnUp";
            this.btnUp.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnUp.Size = new System.Drawing.Size(35, 45);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = ">";
            this.btnUp.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnUp_Click);
            // 
            // btnName1
            // 
            this.btnName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnName1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnName1.HoverBackColor = System.Drawing.Color.White;
            this.btnName1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnName1.Location = new System.Drawing.Point(265, 55);
            this.btnName1.Name = "btnName1";
            this.btnName1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnName1.Size = new System.Drawing.Size(35, 45);
            this.btnName1.TabIndex = 5;
            this.btnName1.Text = ">";
            this.btnName1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnName_Click);
            // 
            // btnSex1
            // 
            this.btnSex1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSex1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnSex1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnSex1.HoverBackColor = System.Drawing.Color.White;
            this.btnSex1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnSex1.Location = new System.Drawing.Point(265, 100);
            this.btnSex1.Name = "btnSex1";
            this.btnSex1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnSex1.Size = new System.Drawing.Size(35, 45);
            this.btnSex1.TabIndex = 6;
            this.btnSex1.Text = ">";
            this.btnSex1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSex_Click);
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.FontSize = 12F;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "昵称";
            this.label2.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 55);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 9;
            // 
            // btnName
            // 
            this.btnName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnName.HoverBackColor = System.Drawing.Color.White;
            this.btnName.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnName.Location = new System.Drawing.Point(0, 75);
            this.btnName.Name = "btnName";
            this.btnName.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.btnName.Size = new System.Drawing.Size(265, 25);
            this.btnName.TabIndex = 10;
            this.btnName.Text = "lincy";
            this.btnName.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnName_Click);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 100);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.FontSize = 12F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "性别";
            this.label3.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // btnSex
            // 
            this.btnSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnSex.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnSex.Location = new System.Drawing.Point(0, 120);
            this.btnSex.Name = "btnSex";
            this.btnSex.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.btnSex.Size = new System.Drawing.Size(265, 25);
            this.btnSex.TabIndex = 13;
            this.btnSex.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSex_Click);
            // 
            // label4
            // 
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.FontSize = 12F;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(0, 145);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(300, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "生日";
            this.label4.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // dpkBirthday
            // 
            this.dpkBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dpkBirthday.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.dpkBirthday.Location = new System.Drawing.Point(0, 165);
            this.dpkBirthday.Name = "dpkBirthday";
            this.dpkBirthday.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.dpkBirthday.Size = new System.Drawing.Size(300, 25);
            this.dpkBirthday.TabIndex = 15;
            this.dpkBirthday.DatePicked += new Smobiler.Core.Controls.DatePicker.DatePickedEventHandler(this.dpkBirthday_DatePicked);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 145);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 16;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 190);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 17;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 235);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.FontSize = 12F;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(0, 190);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(265, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "邮件";
            this.label6.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // btnEmail1
            // 
            this.btnEmail1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEmail1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnEmail1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnEmail1.HoverBackColor = System.Drawing.Color.White;
            this.btnEmail1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnEmail1.Location = new System.Drawing.Point(265, 190);
            this.btnEmail1.Name = "btnEmail1";
            this.btnEmail1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnEmail1.Size = new System.Drawing.Size(35, 45);
            this.btnEmail1.TabIndex = 22;
            this.btnEmail1.Text = ">";
            this.btnEmail1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnEmail_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEmail.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnEmail.Location = new System.Drawing.Point(0, 210);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.btnEmail.Size = new System.Drawing.Size(265, 25);
            this.btnEmail.TabIndex = 23;
            this.btnEmail.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnEmail_Click);
            // 
            // btnPwd
            // 
            this.btnPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnPwd.HoverBackColor = System.Drawing.Color.White;
            this.btnPwd.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnPwd.Location = new System.Drawing.Point(0, 245);
            this.btnPwd.Name = "btnPwd";
            this.btnPwd.Size = new System.Drawing.Size(300, 35);
            this.btnPwd.TabIndex = 27;
            this.btnPwd.Text = "登录密码修改";
            this.btnPwd.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnPwd_Click);
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.LightGray;
            this.line7.Location = new System.Drawing.Point(0, 280);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(300, 1);
            this.line7.TabIndex = 28;
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.Color.LightGray;
            this.line8.Location = new System.Drawing.Point(0, 245);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(300, 1);
            this.line8.TabIndex = 29;
            // 
            // ldEditUserInfo
            // 
            this.ldEditUserInfo.Layout = "EditUserInfoLayout";
            this.ldEditUserInfo.Name = "ldEditUserInfo";
            this.ldEditUserInfo.ItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.ldEditUserInfo_ItemClick);
            // 
            // cameraPortrait
            // 
            this.cameraPortrait.AllowEdit = true;
            this.cameraPortrait.Name = "cameraPortrait";
            this.cameraPortrait.QualityMode = Smobiler.Core.Controls.ImageQualityMode.Compressed;
            this.cameraPortrait.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.cameraPortrait_ImageCaptured);
            // 
            // popSex
            // 
            this.popSex.Name = "popSex";
            this.popSex.Selected += new System.EventHandler(this.popSex_Selected);
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 10);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 30;
            // 
            // frmUser
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.ldEditUserInfo,
            this.cameraPortrait,
            this.popSex});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.imgPortrait,
            this.btnUp,
            this.btnName1,
            this.btnSex1,
            this.label2,
            this.btnName,
            this.label3,
            this.btnSex,
            this.label4,
            this.dpkBirthday,
            this.label6,
            this.btnEmail1,
            this.btnEmail,
            this.btnPwd,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line7,
            this.line8,
            this.line9});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "我的";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.Work,
            this.Me});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.Select, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145))))), System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145))))));
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmUser_ToolbarItemClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmUser_KeyDown);
            this.Name = "frmUser";

        }
        #endregion

        private Smobiler.Core.Controls.ToolbarItem Work;
        private Smobiler.Core.Controls.ToolbarItem Me;
        internal Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Image imgPortrait;
        internal Smobiler.Core.Controls.Button btnUp;
        internal Smobiler.Core.Controls.Button btnName1;
        internal Smobiler.Core.Controls.Button btnSex1;
        internal Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Button btnName;
        private Smobiler.Core.Controls.Line line2;
        internal Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button btnSex;
        internal Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.DatePicker dpkBirthday;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Button btnEmail1;
        private Smobiler.Core.Controls.Button btnEmail;
        private Smobiler.Core.Controls.Button btnPwd;
        private Smobiler.Core.Controls.Line line7;
        private Smobiler.Core.Controls.Line line8;
        private Smobiler.Core.Controls.LayoutDialog ldEditUserInfo;
        private Smobiler.Core.Controls.Camera cameraPortrait;
        private Smobiler.Core.Controls.PopList popSex;
        private Smobiler.Core.Controls.Line line9;
    }
}