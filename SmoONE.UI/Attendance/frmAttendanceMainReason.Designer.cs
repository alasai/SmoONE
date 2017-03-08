using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
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
            this.txtReason = new Smobiler.Core.Controls.TextBox();
            this.Line2 = new Smobiler.Core.Controls.Line();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // txtReason
            // 
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new Smobiler.Core.Padding(5F, 0F, 0F, 0F);
            this.txtReason.Size = new System.Drawing.Size(300, 100);
            this.txtReason.TabIndex = 3;
            this.txtReason.WaterMarkText = "(必填)";
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
            // Label6
            // 
            this.Label6.BackColorAlpha = 0;
            this.Label6.FontSize = 13F;
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(0, 100);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.Label6.Size = new System.Drawing.Size(300, 25);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "理由长度不能超过200！";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(270, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "提交";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // frmAttendanceMainLayoutDialog
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtReason,
            this.Line2,
            this.Label6,
            this.btnSave});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleImageClick += new System.EventHandler(this.frmAttendanceMainLayoutDialog_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmAttendanceMainLayoutDialog_KeyDown);
            this.Name = "frmAttendanceMainLayoutDialog";

        }
        #endregion
        private Smobiler.Core.Controls.TextBox txtReason;
        internal Smobiler.Core.Controls.Line Line2;
        internal Smobiler.Core.Controls.Label Label6;
        private Smobiler.Core.Controls.Button btnSave;
    }
}