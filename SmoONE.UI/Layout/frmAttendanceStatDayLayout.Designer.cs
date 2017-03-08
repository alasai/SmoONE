using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceStatDayLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatDayLayout()
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblDay
            // 
            this.lblDay.DisplayMember = "Day";
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDay.Name = "lblDay";
            this.lblDay.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblDay.Size = new System.Drawing.Size(260, 50);
            this.lblDay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(260, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(40, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = ">";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 50);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 6;
            this.line1.ZIndex = 3;
            // 
            // frmAttendanceStatDayLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblDay,
            this.label2,
            this.line1});
            this.Size = new System.Drawing.Size(300, 50);
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.Load += new System.EventHandler(this.frmAttendanceStatDayLayout_Load);
            this.Name = "frmAttendanceStatDayLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblDay;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Line line1;
    }
}