using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceMainLayoutDialog : Smobiler.Core.Controls.MobileForm
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
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.White;
            this.txtReason.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtReason.Location = new System.Drawing.Point(0, 60);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtReason.Size = new System.Drawing.Size(300, 100);
            this.txtReason.WaterMarkText = "(必填)";
            // 
            // Label6
            // 
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(0, 160);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 30F, 0F);
            this.Label6.Size = new System.Drawing.Size(300, 25);
            this.Label6.Text = "理由长度不能超过200！";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(270, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnCreate_Click);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColr = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            // 
            // frmAttendanceMainLayoutDialog
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
           this .title1 ,
                this.txtReason,
            this.Label6,
            this.btnSave,
           });
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceMainLayoutDialog_KeyDown);
            this.Name = "frmAttendanceMainLayoutDialog";

        }
        #endregion
        private Smobiler.Core.Controls.TextBox txtReason;
        internal Smobiler.Core.Controls.Label Label6;
        private Smobiler.Core.Controls.Button btnSave;
        private SmoONE.UI.Layout.Title title1;
    }
}