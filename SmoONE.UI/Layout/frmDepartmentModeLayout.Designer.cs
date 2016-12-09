using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmDepartmentModeLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmDepartmentModeLayout()
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
            this.btnDLayout = new Smobiler.Core.Controls.Button();
            // 
            // btnDLayout
            // 
            this.btnDLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnDLayout.HoverBackColor = System.Drawing.Color.White;
            this.btnDLayout.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnDLayout.Name = "btnDLayout";
            this.btnDLayout.Size = new System.Drawing.Size(300, 35);
            this.btnDLayout.TabIndex = 2;
            this.btnDLayout.Text = "�㼶չʾ";
            this.btnDLayout.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDLayout_Click);
            // 
            // frmDepartmentModeLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDLayout});
            this.Size = new System.Drawing.Size(300, 35);
            this.Name = "frmDepartmentModeLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnDLayout;
    }
}