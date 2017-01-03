using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmRefuseLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRefuseLayout()
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
            this.txtReason = new Smobiler.Core.Controls.TextBox();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnOK = new Smobiler.Core.Controls.Button();
            this.Line2 = new Smobiler.Core.Controls.Line();
            // 
            // txtReason
            // 
            this.txtReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtReason.MaxLength = 400;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new Smobiler.Core.Padding(4F, 5F, 0F, 0F);
            this.txtReason.Size = new System.Drawing.Size(300, 90);
            this.txtReason.TabIndex = 3;
            this.txtReason.WaterMarkText = "请输入1-200字的拒绝理由";
            // 
            // btnCancel
            // 
            this.btnCancel.Border = new Smobiler.Core.Border(1);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.BorderRadius = 2;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.HoverBackColor = System.Drawing.Color.White;
            this.btnCancel.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.Location = new System.Drawing.Point(10, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            // 
            // btnOK
            // 
            this.btnOK.Border = new Smobiler.Core.Border(1);
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnOK.BorderRadius = 2;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnOK.HoverBackColor = System.Drawing.Color.White;
            this.btnOK.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnOK.Location = new System.Drawing.Point(154, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 40);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.LightGray;
            this.Line2.Location = new System.Drawing.Point(0, 90);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(300, 1);
            this.Line2.TabIndex = 6;
            this.Line2.ZIndex = 8;
            // 
            // frmRefuseLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtReason,
            this.btnCancel,
            this.btnOK,
            this.Line2});
            this.Size = new System.Drawing.Size(300, 150);
            this.Name = "frmRefuseLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.TextBox txtReason;
        private Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnOK;
        internal Smobiler.Core.Controls.Line Line2;
    }
}