using System;
using Smobiler.Core;
namespace SmoONE.UI.UserControl
{
    partial class Title : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public Title()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lblTitle = new Smobiler.Core.Controls.Label();
            this.tpTitle = new Smobiler.Core.Controls.Panel();
            this.fontTitle = new Smobiler.Core.Controls.FontIcon();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(45, 0);
            this.lblTitle.Margin = new Smobiler.Core.Controls.Margin(25F, 0F, 0F, 0F);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 50);
            // 
            // tpTitle
            // 
            this.tpTitle.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontTitle});
            this.tpTitle.Location = new System.Drawing.Point(5, 2);
            this.tpTitle.Name = "tpTitle";
            this.tpTitle.Size = new System.Drawing.Size(40, 40);
            this.tpTitle.Touchable = true;
            this.tpTitle.Press += new System.EventHandler(this.tpTitle_Press);
            // 
            // fontTitle
            // 
            this.fontTitle.Name = "fontTitle";
            this.fontTitle.ResourceID = "arrow-left";
            this.fontTitle.Size = new System.Drawing.Size(40, 40);
            // 
            // Title
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTitle,
            this.tpTitle});
            this.Size = new System.Drawing.Size(0, 50);
            this.Name = "Title";

        }
        #endregion
        private Smobiler.Core.Controls.Label lblTitle;
        private Smobiler.Core.Controls.Panel tpTitle;
        private Smobiler.Core.Controls.FontIcon fontTitle;
    }
}