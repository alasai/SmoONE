using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceStatSelfLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatSelfLayout()
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
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblNumber = new Smobiler.Core.Controls.Label();
            this.lblDetail = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblID
            // 
            this.lblID.DisplayMember = "AttendType";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(80, 50);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ÒÑÇ©µ½";
            // 
            // lblNumber
            // 
            this.lblNumber.DataMember = "Number";
            this.lblNumber.DisplayMember = "AttendNumber";
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblNumber.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblNumber.Location = new System.Drawing.Point(80, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(180, 50);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0´Î";
            // 
            // lblDetail
            // 
            this.lblDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDetail.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblDetail.Location = new System.Drawing.Point(260, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.lblDetail.Size = new System.Drawing.Size(40, 50);
            this.lblDetail.TabIndex = 4;
            this.lblDetail.Text = ">";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 50);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 5;
            // 
            // frmAttendanceStatSelfLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblID,
            this.lblNumber,
            this.lblDetail,
            this.line1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmAttendanceStatSelfLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblID;
        private Smobiler.Core.Controls.Label lblNumber;
        private Smobiler.Core.Controls.Label lblDetail;
        private Smobiler.Core.Controls.Line line1;
    }
}