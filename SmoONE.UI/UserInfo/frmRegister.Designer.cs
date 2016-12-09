using System;
using Smobiler.Core;
namespace SmoONE.UI.UserInfo
{
    partial class frmRegister : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRegister()
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.txtPwd1 = new Smobiler.Core.Controls.TextBox();
            this.imgbtnPwdC1 = new Smobiler.Core.Controls.ImageButton();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.txtPwd2 = new Smobiler.Core.Controls.TextBox();
            this.imgbtnPwdC2 = new Smobiler.Core.Controls.ImageButton();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.radioGroup1 = new Smobiler.Core.Controls.RadioGroup();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "昵称";
            // 
            // txtName
            // 
            this.txtName.FontSize = 12F;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtName.Location = new System.Drawing.Point(66, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 35);
            this.txtName.TabIndex = 3;
            this.txtName.WaterMarkText = "请输入昵称";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "新密码";
            // 
            // txtPwd1
            // 
            this.txtPwd1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPwd1.FontSize = 12F;
            this.txtPwd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtPwd1.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtPwd1.Location = new System.Drawing.Point(66, 45);
            this.txtPwd1.MaxLength = 12;
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtPwd1.Size = new System.Drawing.Size(234, 35);
            this.txtPwd1.TabIndex = 6;
            this.txtPwd1.WaterMarkText = "请输入6-12位密码";
            // 
            // imgbtnPwdC1
            // 
            this.imgbtnPwdC1.FontSize = 10F;
            this.imgbtnPwdC1.Location = new System.Drawing.Point(260, 48);
            this.imgbtnPwdC1.Name = "imgbtnPwdC1";
            this.imgbtnPwdC1.Padding = new Smobiler.Core.Padding(0F, 3F, 0F, 3F);
            this.imgbtnPwdC1.ResourceID = "!\\ue417043146223";
            this.imgbtnPwdC1.Size = new System.Drawing.Size(40, 35);
            this.imgbtnPwdC1.TabIndex = 7;
            this.imgbtnPwdC1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnPwdC1_Click);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(5, 115);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(295, 1);
            this.line2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 80);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "确认密码";
            // 
            // txtPwd2
            // 
            this.txtPwd2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPwd2.FontSize = 12F;
            this.txtPwd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtPwd2.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtPwd2.Location = new System.Drawing.Point(66, 80);
            this.txtPwd2.MaxLength = 12;
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtPwd2.Size = new System.Drawing.Size(231, 35);
            this.txtPwd2.TabIndex = 10;
            this.txtPwd2.WaterMarkText = "请输入6-12位密码";
            // 
            // imgbtnPwdC2
            // 
            this.imgbtnPwdC2.FontSize = 10F;
            this.imgbtnPwdC2.Location = new System.Drawing.Point(260, 80);
            this.imgbtnPwdC2.Name = "imgbtnPwdC2";
            this.imgbtnPwdC2.Padding = new Smobiler.Core.Padding(0F, 3F, 0F, 3F);
            this.imgbtnPwdC2.ResourceID = "!\\ue417043146223";
            this.imgbtnPwdC2.Size = new System.Drawing.Size(40, 35);
            this.imgbtnPwdC2.TabIndex = 11;
            this.imgbtnPwdC2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnPwdC2_Click);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 80);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "开始使用";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // radioGroup1
            // 
            this.radioGroup1.AutoHeight = false;
            this.radioGroup1.FontSize = 12F;
            this.radioGroup1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.radioGroup1.Location = new System.Drawing.Point(0, 150);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.radioGroup1.Size = new System.Drawing.Size(300, 100);
            this.radioGroup1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(0, 115);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(300, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "角色选择";
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 10);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 16;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 250);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 17;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(0, 149);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 1);
            this.line6.TabIndex = 18;
            // 
            // frmRegister
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.txtName,
            this.line1,
            this.label1,
            this.txtPwd1,
            this.imgbtnPwdC1,
            this.line2,
            this.label3,
            this.txtPwd2,
            this.imgbtnPwdC2,
            this.line3,
            this.btnSave,
            this.radioGroup1,
            this.label4,
            this.line4,
            this.line5,
            this.line6});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "设置登录信息";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.Name = "frmRegister";

        }
        #endregion

        internal Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtName;
        private Smobiler.Core.Controls.Line line1;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.TextBox txtPwd1;
        private Smobiler.Core.Controls.ImageButton imgbtnPwdC1;
        private Smobiler.Core.Controls.Line line2;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.TextBox txtPwd2;
        private Smobiler.Core.Controls.ImageButton imgbtnPwdC2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.RadioGroup radioGroup1;
        internal Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
    }
}