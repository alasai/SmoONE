using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmVerificationCode : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmVerificationCode()
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
            this.lblTel = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.txtVcode1 = new Smobiler.Core.Controls.TextBox();
            // 
            // lblTel
            // 
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblTel.Location = new System.Drawing.Point(20, 10);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(260, 30);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "验证码已发送至手机：";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave.Location = new System.Drawing.Point(10, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "完成";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // txtVcode1
            // 
            this.txtVcode1.Border = new Smobiler.Core.Border(1);
            this.txtVcode1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtVcode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtVcode1.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtVcode1.Location = new System.Drawing.Point(20, 50);
            this.txtVcode1.MaxLength = 4;
            this.txtVcode1.Name = "txtVcode1";
            this.txtVcode1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.txtVcode1.Size = new System.Drawing.Size(260, 45);
            this.txtVcode1.TabIndex = 4;
            this.txtVcode1.WaterMarkText = "请输入验证码";
            // 
            // frmVerificationCode
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTel,
            this.btnSave,
            this.txtVcode1});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "填写验证码";
            this.Load += new System.EventHandler(this.frmVerificationCode_Load);
            this.TitleImageClick += new System.EventHandler(this.frmVerificationCode_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmVerificationCode_KeyDown);
            this.Name = "frmVerificationCode";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblTel;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.TextBox txtVcode1;
    }
}