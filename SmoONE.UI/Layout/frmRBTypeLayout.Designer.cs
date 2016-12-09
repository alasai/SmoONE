using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmRBTypeLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBTypeLayout()
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
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.lblTypeName = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // Image1
            // 
            this.Image1.BorderRadius = 10;
            this.Image1.DataMember = "TYPE";
            this.Image1.DisplayMember = "TYPE";
            this.Image1.ID = "";
            this.Image1.Location = new System.Drawing.Point(10, 12);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(35, 35);
            this.Image1.TabIndex = 2;
            // 
            // lblTypeName
            // 
            this.lblTypeName.DataMember = "TYPE";
            this.lblTypeName.DisplayMember = "TYPENAME";
            this.lblTypeName.Location = new System.Drawing.Point(54, 0);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.lblTypeName.Size = new System.Drawing.Size(246, 60);
            this.lblTypeName.TabIndex = 3;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 4;
            // 
            // frmRBTypeLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image1,
            this.lblTypeName,
            this.line1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmRBTypeLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Image Image1;
        internal Smobiler.Core.Controls.Label lblTypeName;
        private Smobiler.Core.Controls.Line line1;
    }
}