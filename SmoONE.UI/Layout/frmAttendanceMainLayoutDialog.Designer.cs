using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceMainLayoutDialog : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceMainLayoutDialog()
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
            this.lblTitle = new Smobiler.Core.Controls.Label();
            this.txtReason = new Smobiler.Core.Controls.TextBox();
            this.Line2 = new Smobiler.Core.Controls.Line();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnConfirm = new Smobiler.Core.Controls.Button();
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "迟到理由：";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(0, 30);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.txtReason.Size = new System.Drawing.Size(300, 70);
            this.txtReason.TabIndex = 3;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.LightGray;
            this.Line2.Location = new System.Drawing.Point(0, 100);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(300, 1);
            this.Line2.TabIndex = 4;
            this.Line2.ZIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Border = new Smobiler.Core.Border(1);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.BorderRadius = 2;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.HoverBackColor = System.Drawing.Color.White;
            this.btnCancel.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.Location = new System.Drawing.Point(10, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Border = new Smobiler.Core.Border(1);
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnConfirm.BorderRadius = 2;
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnConfirm.HoverBackColor = System.Drawing.Color.White;
            this.btnConfirm.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnConfirm.Location = new System.Drawing.Point(155, 110);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 40);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确定";
            // 
            // frmAttendanceMainLayoutDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTitle,
            this.txtReason,
            this.Line2,
            this.btnCancel,
            this.btnConfirm});
            this.Size = new System.Drawing.Size(300, 160);
            this.Name = "frmAttendanceMainLayoutDialog";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblTitle;
        private Smobiler.Core.Controls.TextBox txtReason;
        internal Smobiler.Core.Controls.Line Line2;
        private Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnConfirm;
    }
}