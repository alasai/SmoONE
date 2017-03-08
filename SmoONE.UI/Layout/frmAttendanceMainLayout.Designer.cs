using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceMainLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceMainLayout()
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
            this.imgUser = new Smobiler.Core.Controls.Image();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.lblTime = new Smobiler.Core.Controls.Label();
            this.lblInfo = new Smobiler.Core.Controls.Label();
            this.btnCheck = new Smobiler.Core.Controls.Button();
            this.webView1 = new Smobiler.Core.Controls.WebView();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.imgReason = new Smobiler.Core.Controls.Image();
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.imgUser.BorderRadius = 2;
            this.imgUser.DataMember = "ID";
            this.imgUser.DisplayMember = "Picture";
            this.imgUser.Location = new System.Drawing.Point(10, 7);
            this.imgUser.Name = "imgUser";
            this.imgUser.ResourceID = "1";
            this.imgUser.Size = new System.Drawing.Size(45, 45);
            this.imgUser.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgUser.TabIndex = 2;
            this.imgUser.ZIndex = 3;
            // 
            // lblType
            // 
            this.lblType.DataMember = "ID";
            this.lblType.DisplayMember = "Description";
            this.lblType.Location = new System.Drawing.Point(65, 1);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Padding(5F, 10F, 0F, 0F);
            this.lblType.Size = new System.Drawing.Size(105, 30);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "上午上班";
            this.lblType.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblType.ZIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.DisplayMember = "Time";
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblTime.Location = new System.Drawing.Point(65, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 10F);
            this.lblTime.Size = new System.Drawing.Size(105, 30);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "09：00";
            this.lblTime.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.lblTime.ZIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.DisplayMember = "Info";
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblInfo.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblInfo.Location = new System.Drawing.Point(185, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.lblInfo.Size = new System.Drawing.Size(115, 60);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "未开始";
            this.lblInfo.ZIndex = 7;
            // 
            // btnCheck
            // 
            this.btnCheck.AutoVisibleInLayout = true;
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheck.BorderRadius = 2;
            this.btnCheck.DisplayMember = "Action";
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(210, 14);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(80, 26);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "签到";
            this.btnCheck.ZIndex = 8;
            // 
            // webView1
            // 
            this.webView1.Location = new System.Drawing.Point(162, 19);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(1, 1);
            this.webView1.TabIndex = 10;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(10, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(290, 1);
            this.line1.TabIndex = 11;
            this.line1.ZIndex = 10;
            // 
            // imgReason
            // 
            this.imgReason.AutoVisibleInLayout = true;
            this.imgReason.DisplayMember = "Img";
            this.imgReason.Location = new System.Drawing.Point(180, 0);
            this.imgReason.Name = "imgReason";
            this.imgReason.ResourceID = "!\\ue85d000146223";
            this.imgReason.Size = new System.Drawing.Size(15, 60);
            this.imgReason.TabIndex = 12;
            // 
            // frmAttendanceMainLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.webView1,
            this.imgUser,
            this.lblType,
            this.lblTime,
            this.lblInfo,
            this.btnCheck,
            this.imgReason,
            this.line1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmAttendanceMainLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Image imgUser;
        private Smobiler.Core.Controls.Label lblType;
        private Smobiler.Core.Controls.Label lblTime;
        private Smobiler.Core.Controls.Label lblInfo;
        private Smobiler.Core.Controls.Button btnCheck;
        private Smobiler.Core.Controls.WebView webView1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Image imgReason;
    }
}