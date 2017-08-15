using System;
using Smobiler.Core;
namespace SmoONE.UI.UserControl
{
    partial class ImageButton : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public ImageButton()
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
            this.imageEx1 = new Smobiler.Core.Controls.ImageEx();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            // 
            // imageEx1
            // 
            this.imageEx1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageEx1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.imageEx1.Name = "imageEx1";
            this.imageEx1.ResourceID = null;
            this.imageEx1.Size = new System.Drawing.Size(45, 45);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageEx1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 45);
            // 
            // ImageButton
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(45, 45);
            this.Name = "ImageButton";

        }
        #endregion
        private Smobiler.Core.Controls.ImageEx imageEx1;
        private Smobiler.Core.Controls.Panel panel1;
    }
}