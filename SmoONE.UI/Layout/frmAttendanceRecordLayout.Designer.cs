using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceRecordLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceRecordLayout()
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
            this.lblCC_ID = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // lblCC_ID
            // 
            this.lblCC_ID.DataMember = "AL_LogID";
            this.lblCC_ID.DisplayMember = "AL_Date";
            this.lblCC_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC_ID.Name = "lblCC_ID";
            this.lblCC_ID.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblCC_ID.Size = new System.Drawing.Size(265, 40);
            this.lblCC_ID.TabIndex = 2;
            this.lblCC_ID.ZIndex = 1;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 40);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 3;
            this.line1.ZIndex = 3;
            // 
            // label2
            // 
            this.label2.DataMember = "CC_ID";
            this.label2.DisplayMember = "CC_ID";
            this.label2.FontSize = 20F;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(265, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(45, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = ">";
            this.label2.ZIndex = 1;
            // 
            // frmAttendanceRecordLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblCC_ID,
            this.line1,
            this.label2});
            this.Size = new System.Drawing.Size(300, 40);
            this.Name = "frmAttendanceRecordLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblCC_ID;
        private Smobiler.Core.Controls.Line line1;
        internal Smobiler.Core.Controls.Label label2;
    }
}