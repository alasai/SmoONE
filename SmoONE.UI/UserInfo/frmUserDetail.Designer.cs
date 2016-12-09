using System;
using Smobiler.Core;
namespace SmoONE.UI.UserInfo
{
    partial class frmUserDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmUserDetail()
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
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.imgbtnTel = new Smobiler.Core.Controls.ImageButton();
            this.imgbtnMes = new Smobiler.Core.Controls.ImageButton();
            this.imgbtnEmail = new Smobiler.Core.Controls.ImageButton();
            this.btnTel = new Smobiler.Core.Controls.Button();
            this.btnMes = new Smobiler.Core.Controls.Button();
            this.btnEmail = new Smobiler.Core.Controls.Button();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblTel = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblBirthday = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lblEmail = new Smobiler.Core.Controls.Label();
            this.line9 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            // 
            // imgPortrait
            // 
            this.imgPortrait.BackColorAlpha = 0;
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.Enlarged = true;
            this.imgPortrait.ID = "";
            this.imgPortrait.Location = new System.Drawing.Point(110, 10);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(80, 80);
            this.imgPortrait.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgPortrait.TabIndex = 2;
            this.imgPortrait.ZIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.FontSize = 12F;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(300, 200);
            this.label1.TabIndex = 3;
            this.label1.ZIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BackColorAlpha = 0;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblName.Location = new System.Drawing.Point(0, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(300, 25);
            this.lblName.TabIndex = 4;
            // 
            // imgbtnTel
            // 
            this.imgbtnTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.imgbtnTel.BorderRadius = 10;
            this.imgbtnTel.FontSize = 10F;
            this.imgbtnTel.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.imgbtnTel.Location = new System.Drawing.Point(32, 125);
            this.imgbtnTel.Name = "imgbtnTel";
            this.imgbtnTel.Padding = new Smobiler.Core.Padding(7F);
            this.imgbtnTel.ResourceID = "!\\ue551255255255";
            this.imgbtnTel.Size = new System.Drawing.Size(35, 35);
            this.imgbtnTel.TabIndex = 5;
            this.imgbtnTel.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnTel_Click);
            // 
            // imgbtnMes
            // 
            this.imgbtnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.imgbtnMes.BorderRadius = 10;
            this.imgbtnMes.FontSize = 10F;
            this.imgbtnMes.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.imgbtnMes.Location = new System.Drawing.Point(132, 125);
            this.imgbtnMes.Name = "imgbtnMes";
            this.imgbtnMes.Padding = new Smobiler.Core.Padding(7F);
            this.imgbtnMes.ResourceID = "!\\ue8af255255255";
            this.imgbtnMes.Size = new System.Drawing.Size(35, 35);
            this.imgbtnMes.TabIndex = 6;
            this.imgbtnMes.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnMes_Click);
            // 
            // imgbtnEmail
            // 
            this.imgbtnEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.imgbtnEmail.BorderRadius = 10;
            this.imgbtnEmail.FontSize = 10F;
            this.imgbtnEmail.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.imgbtnEmail.Location = new System.Drawing.Point(232, 125);
            this.imgbtnEmail.Name = "imgbtnEmail";
            this.imgbtnEmail.Padding = new Smobiler.Core.Padding(7F);
            this.imgbtnEmail.ResourceID = "!\\ue159255255255";
            this.imgbtnEmail.Size = new System.Drawing.Size(39, 35);
            this.imgbtnEmail.TabIndex = 7;
            this.imgbtnEmail.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnEmail_Click);
            // 
            // btnTel
            // 
            this.btnTel.BackColorAlpha = 0;
            this.btnTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnTel.HoverBackColor = System.Drawing.Color.White;
            this.btnTel.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnTel.Location = new System.Drawing.Point(0, 160);
            this.btnTel.Name = "btnTel";
            this.btnTel.Size = new System.Drawing.Size(100, 30);
            this.btnTel.TabIndex = 8;
            this.btnTel.Text = "打电话";
            this.btnTel.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnTel_Click);
            // 
            // btnMes
            // 
            this.btnMes.BackColorAlpha = 0;
            this.btnMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnMes.HoverBackColor = System.Drawing.Color.White;
            this.btnMes.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnMes.Location = new System.Drawing.Point(100, 160);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(100, 30);
            this.btnMes.TabIndex = 9;
            this.btnMes.Text = "发短信";
            this.btnMes.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnMes_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColorAlpha = 0;
            this.btnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEmail.HoverBackColor = System.Drawing.Color.White;
            this.btnEmail.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEmail.Location = new System.Drawing.Point(200, 160);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 30);
            this.btnEmail.TabIndex = 10;
            this.btnEmail.Text = "发邮件";
            this.btnEmail.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnEmail_Click);
            // 
            // label4
            // 
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.FontSize = 12F;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(0, 200);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(300, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "电话";
            this.label4.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // lblTel
            // 
            this.lblTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblTel.Location = new System.Drawing.Point(0, 220);
            this.lblTel.Name = "lblTel";
            this.lblTel.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblTel.Size = new System.Drawing.Size(300, 30);
            this.lblTel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.FontSize = 12F;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(0, 250);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "生日";
            this.label2.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // lblBirthday
            // 
            this.lblBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblBirthday.Location = new System.Drawing.Point(0, 270);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblBirthday.Size = new System.Drawing.Size(300, 30);
            this.lblBirthday.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.FontSize = 12F;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(0, 300);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(300, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "邮件";
            this.label5.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            // 
            // lblEmail
            // 
            this.lblEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblEmail.Location = new System.Drawing.Point(0, 320);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblEmail.Size = new System.Drawing.Size(300, 30);
            this.lblEmail.TabIndex = 16;
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 350);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 17;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 200);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 18;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 250);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 19;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 300);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 20;
            // 
            // frmUserDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.imgPortrait,
            this.lblName,
            this.imgbtnTel,
            this.imgbtnMes,
            this.imgbtnEmail,
            this.btnTel,
            this.btnMes,
            this.btnEmail,
            this.label4,
            this.lblTel,
            this.label2,
            this.lblBirthday,
            this.label5,
            this.lblEmail,
            this.line9,
            this.line1,
            this.line2,
            this.line3});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.Load += new System.EventHandler(this.frmUserDetail_Load);
            this.TitleImageClick += new System.EventHandler(this.frmUserDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmUserDetail_KeyDown);
            this.Name = "frmUserDetail";

        }
        #endregion

        private Smobiler.Core.Controls.Image imgPortrait;
        internal Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.ImageButton imgbtnTel;
        private Smobiler.Core.Controls.ImageButton imgbtnMes;
        private Smobiler.Core.Controls.ImageButton imgbtnEmail;
        private Smobiler.Core.Controls.Button btnTel;
        private Smobiler.Core.Controls.Button btnMes;
        private Smobiler.Core.Controls.Button btnEmail;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label lblTel;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label lblBirthday;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label lblEmail;
        private Smobiler.Core.Controls.Line line9;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
    }
}