using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class EditUserInfoLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public EditUserInfoLayout()
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
            this.lblEditInfo = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.txtEditInfo = new Smobiler.Core.Controls.TextBox();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnOK = new Smobiler.Core.Controls.Button();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            // 
            // lblEditInfo
            // 
            this.lblEditInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEditInfo.FontSize = 19F;
            this.lblEditInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblEditInfo.Name = "lblEditInfo";
            this.lblEditInfo.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblEditInfo.Size = new System.Drawing.Size(270, 45);
            this.lblEditInfo.TabIndex = 2;
            this.lblEditInfo.Text = "修改昵称";
            this.lblEditInfo.ZIndex = 1;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.line1.LineSize = 0.2F;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(270, 1);
            this.line1.TabIndex = 3;
            // 
            // txtEditInfo
            // 
            this.txtEditInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtEditInfo.Location = new System.Drawing.Point(5, 46);
            this.txtEditInfo.Name = "txtEditInfo";
            this.txtEditInfo.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.txtEditInfo.Size = new System.Drawing.Size(260, 30);
            this.txtEditInfo.TabIndex = 4;
            this.txtEditInfo.WaterMarkText = "（必输）";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCancel.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCancel.Location = new System.Drawing.Point(0, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnOK.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnOK.Location = new System.Drawing.Point(135, 95);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 40);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 95);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(270, 1);
            this.line2.TabIndex = 7;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(135, 95);
            this.line3.Name = "line3";
            this.line3.Orientation = Smobiler.Core.OrientationAlignment.Vertical;
            this.line3.Size = new System.Drawing.Size(1, 40);
            this.line3.TabIndex = 8;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.line4.LineSize = 0.2F;
            this.line4.Location = new System.Drawing.Point(5, 76);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(260, 1);
            this.line4.TabIndex = 9;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.line5.LineSize = 0.2F;
            this.line5.Location = new System.Drawing.Point(5, 71);
            this.line5.Name = "line5";
            this.line5.Orientation = Smobiler.Core.OrientationAlignment.Vertical;
            this.line5.Size = new System.Drawing.Size(1, 5);
            this.line5.TabIndex = 10;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.line6.LineSize = 0.2F;
            this.line6.Location = new System.Drawing.Point(265, 71);
            this.line6.Name = "line6";
            this.line6.Orientation = Smobiler.Core.OrientationAlignment.Vertical;
            this.line6.Size = new System.Drawing.Size(1, 5);
            this.line6.TabIndex = 11;
            // 
            // EditUserInfoLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblEditInfo,
            this.txtEditInfo,
            this.btnCancel,
            this.btnOK,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line6});
            this.Size = new System.Drawing.Size(270, 135);
            this.Name = "EditUserInfoLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblEditInfo;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.TextBox txtEditInfo;
        private Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnOK;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
    }
}