using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmATStatSelfDetailTypeLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmATStatSelfDetailTypeLayout()
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
            this.lblLocation = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.lblReason = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // image1
            // 
            this.image1.BackColorAlpha = 0;
            this.image1.Location = new System.Drawing.Point(10, 35);
            this.image1.Name = "image1";
            this.image1.ResourceID = "!\\ue55f255000000";
            this.image1.Size = new System.Drawing.Size(15, 15);
            this.image1.TabIndex = 2;
            this.image1.ZIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.DataMember = "AL_Position";
            this.lblLocation.DisplayMember = "AL_Position";
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblLocation.Location = new System.Drawing.Point(0, 30);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Padding = new Smobiler.Core.Padding(25F, 0F, 10F, 0F);
            this.lblLocation.Size = new System.Drawing.Size(300, 30);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.ZIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.DataMember = "AL_Date";
            this.lblDate.DisplayMember = "AL_DateDesc";
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Padding(10F, 0F, 10F, 0F);
            this.lblDate.Size = new System.Drawing.Size(306, 30);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "签到 2017年2月15日 9:30";
            this.lblDate.ZIndex = 1;
            // 
            // lblReason
            // 
            this.lblReason.AutoVisibleInLayout = true;
            this.lblReason.DataMember = "AL_Reason";
            this.lblReason.DisplayMember = "AL_Reason";
            this.lblReason.ForeColor = System.Drawing.Color.Orange;
            this.lblReason.Location = new System.Drawing.Point(0, 60);
            this.lblReason.Name = "lblReason";
            this.lblReason.Padding = new Smobiler.Core.Padding(10F, 10F, 10F, 0F);
            this.lblReason.Size = new System.Drawing.Size(300, 60);
            this.lblReason.TabIndex = 5;
            this.lblReason.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblReason.ZIndex = 4;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 120);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 6;
            this.line1.ZIndex = 3;
            // 
            // frmATStatSelfDetailTypeLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblDate,
            this.lblLocation,
            this.image1,
            this.lblReason,
            this.line1});
            this.Size = new System.Drawing.Size(300, 120);
            this.Name = "frmATStatSelfDetailTypeLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label lblLocation;
        private Smobiler.Core.Controls.Label lblDate;
        private Smobiler.Core.Controls.Label lblReason;
        private Smobiler.Core.Controls.Line line1;
    }
}