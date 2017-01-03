using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmLogon : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmLogon()
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.txtTel = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtPwd = new Smobiler.Core.Controls.TextBox();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.btnRegister = new Smobiler.Core.Controls.Button();
            this.btnVerify = new Smobiler.Core.Controls.Button();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(100, 5);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon1";
            this.image1.Size = new System.Drawing.Size(100, 100);
            this.image1.TabIndex = 2;
            // 
            // txtTel
            // 
            this.txtTel.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtTel.Location = new System.Drawing.Point(55, 120);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(230, 40);
            this.txtTel.TabIndex = 3;
            this.txtTel.WaterMarkText = "请输入手机号码";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(40, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "+86";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码";
            // 
            // txtPwd
            // 
            this.txtPwd.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtPwd.Location = new System.Drawing.Point(55, 160);
            this.txtPwd.MaxLength = 12;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(230, 40);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.WaterMarkText = "请输入6-12位密码";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.line1.Location = new System.Drawing.Point(15, 160);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(270, 1);
            this.line1.TabIndex = 7;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.line2.Location = new System.Drawing.Point(15, 200);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(270, 1);
            this.line2.TabIndex = 8;
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnLogon.BorderRadius = 2;
            this.btnLogon.FontSize = 17F;
            this.btnLogon.ForeColor = System.Drawing.Color.White;
            this.btnLogon.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnLogon.HoverForeColor = System.Drawing.Color.White;
            this.btnLogon.Location = new System.Drawing.Point(15, 210);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(270, 40);
            this.btnLogon.TabIndex = 9;
            this.btnLogon.Text = "登录";
            this.btnLogon.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnLogon_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnRegister.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnRegister.HoverBackColor = System.Drawing.Color.White;
            this.btnRegister.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnRegister.Location = new System.Drawing.Point(15, 268);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.btnRegister.Size = new System.Drawing.Size(91, 24);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "新用户注册";
            this.btnRegister.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRegister_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnVerify.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnVerify.HoverBackColor = System.Drawing.Color.White;
            this.btnVerify.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnVerify.Location = new System.Drawing.Point(177, 268);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnVerify.Size = new System.Drawing.Size(108, 24);
            this.btnVerify.TabIndex = 11;
            this.btnVerify.Text = "使用验证码登录";
            this.btnVerify.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnVerify_Click);
            // 
            // frmLogon
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.txtTel,
            this.label1,
            this.label2,
            this.txtPwd,
            this.btnLogon,
            this.btnRegister,
            this.btnVerify,
            this.line1,
            this.line2});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("", System.Drawing.Color.White, System.Drawing.Color.White);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmLogon_KeyDown);
            this.Name = "frmLogon";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.TextBox txtTel;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtPwd;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Button btnLogon;
        private Smobiler.Core.Controls.Button btnRegister;
        private Smobiler.Core.Controls.Button btnVerify;
    }
}