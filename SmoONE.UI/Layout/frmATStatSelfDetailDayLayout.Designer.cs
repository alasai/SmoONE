using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmATStatSelfDetailDayLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmATStatSelfDetailDayLayout()
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
            this.lblDay = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblDay
            // 
            this.lblDay.DataMember = "AL_Date";
            this.lblDay.DisplayMember = "AL_DateDesc";
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDay.Name = "lblDay";
            this.lblDay.Padding = new Smobiler.Core.Padding(10F, 0F, 10F, 0F);
            this.lblDay.Size = new System.Drawing.Size(300, 50);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "2017Äê1ÔÂ22ÈÕ";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 50);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 3;
            this.line1.ZIndex = 3;
            // 
            // frmATStatSelfDetailDayLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblDay,
            this.line1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmATStatSelfDetailDayLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblDay;
        private Smobiler.Core.Controls.Line line1;
    }
}