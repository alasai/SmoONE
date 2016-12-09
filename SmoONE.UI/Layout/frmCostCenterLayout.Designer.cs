using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmCostCenterLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostCenterLayout()
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
            this.lblCC_LiableMan = new Smobiler.Core.Controls.Label();
            this.lblCC_ID = new Smobiler.Core.Controls.Label();
            this.lblCC_Name = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblCC_LiableMan
            // 
            this.lblCC_LiableMan.DataMember = "CC_LiableMan";
            this.lblCC_LiableMan.DisplayMember = "CC_LiableMan";
            this.lblCC_LiableMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC_LiableMan.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblCC_LiableMan.Location = new System.Drawing.Point(190, 0);
            this.lblCC_LiableMan.Name = "lblCC_LiableMan";
            this.lblCC_LiableMan.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.lblCC_LiableMan.Size = new System.Drawing.Size(110, 30);
            this.lblCC_LiableMan.TabIndex = 3;
            this.lblCC_LiableMan.ZIndex = 2;
            // 
            // lblCC_ID
            // 
            this.lblCC_ID.DataMember = "CC_ID";
            this.lblCC_ID.DisplayMember = "CC_ID";
            this.lblCC_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC_ID.Name = "lblCC_ID";
            this.lblCC_ID.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblCC_ID.Size = new System.Drawing.Size(190, 30);
            this.lblCC_ID.TabIndex = 4;
            this.lblCC_ID.ZIndex = 1;
            // 
            // lblCC_Name
            // 
            this.lblCC_Name.DataMember = "CC_Name";
            this.lblCC_Name.DisplayMember = "CC_Name";
            this.lblCC_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblCC_Name.Location = new System.Drawing.Point(0, 30);
            this.lblCC_Name.Name = "lblCC_Name";
            this.lblCC_Name.Padding = new Smobiler.Core.Padding(10F, 0F, 10F, 0F);
            this.lblCC_Name.Size = new System.Drawing.Size(300, 30);
            this.lblCC_Name.TabIndex = 5;
            this.lblCC_Name.ZIndex = 3;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 6;
            this.line1.ZIndex = 3;
            // 
            // frmCostCenterLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblCC_ID,
            this.lblCC_LiableMan,
            this.lblCC_Name,
            this.line1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmCostCenterLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblCC_LiableMan;
        internal Smobiler.Core.Controls.Label lblCC_ID;
        internal Smobiler.Core.Controls.Label lblCC_Name;
        private Smobiler.Core.Controls.Line line1;
    }
}