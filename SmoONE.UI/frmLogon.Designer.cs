using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmLogon : Smobiler.Core.Controls.MobileForm
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
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.btnRegister = new Smobiler.Core.Controls.Button();
            this.btnVerify = new Smobiler.Core.Controls.Button();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(100, 60);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon1";
            this.image1.Size = new System.Drawing.Size(100, 100);
            // 
            // txtTel
            // 
            this.txtTel.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtTel.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtTel.Location = new System.Drawing.Point(55, 175);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(230, 40);
            this.txtTel.WaterMarkText = "请输入手机号码";
            // 
            // label1
            // 
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(15, 175);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(40, 40);
            this.label1.Text = "+86";
            // 
            // label2
            // 
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(15, 215);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.Text = "密码";
            // 
            // txtPwd
            // 
            this.txtPwd.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPwd.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPwd.Location = new System.Drawing.Point(55, 215);
            this.txtPwd.MaxLength = 12;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.SecurityMode = true;
            this.txtPwd.Size = new System.Drawing.Size(230, 40);
            this.txtPwd.WaterMarkText = "请输入6-12位密码";
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnLogon.BorderRadius = 4;
            this.btnLogon.FontSize = 17F;
            this.btnLogon.ForeColor = System.Drawing.Color.White;
            this.btnLogon.Location = new System.Drawing.Point(15, 265);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(270, 40);
            this.btnLogon.Text = "登录";
            this.btnLogon.Press += new System.EventHandler(this.btnLogon_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BorderRadius = 0;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnRegister.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnRegister.Location = new System.Drawing.Point(15, 323);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btnRegister.Size = new System.Drawing.Size(91, 24);
            this.btnRegister.Text = "新用户注册";
            this.btnRegister.Press += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.White;
            this.btnVerify.BorderRadius = 0;
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnVerify.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnVerify.Location = new System.Drawing.Point(177, 323);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnVerify.Size = new System.Drawing.Size(108, 24);
            this.btnVerify.Text = "使用验证码登录";
            this.btnVerify.Press += new System.EventHandler(this.btnVerify_Click);
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
            this.btnVerify});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmLogon_KeyDown);
            this.Name = "frmLogon";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.TextBox txtTel;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtPwd;
       
        private Smobiler.Core.Controls.Button btnLogon;
        private Smobiler.Core.Controls.Button btnRegister;
        private Smobiler.Core.Controls.Button btnVerify;
    }
}