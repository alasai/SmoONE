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
            this.btnDMode = new Smobiler.Core.Controls.Button();
            // 
            // btnDMode
            // 
            this.btnDMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnDMode.HoverBackColor = System.Drawing.Color.White;
            this.btnDMode.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnDMode.Name = "btnDMode";
            this.btnDMode.Size = new System.Drawing.Size(300, 35);
            this.btnDMode.TabIndex = 2;
            this.btnDMode.Text = "�㼶չʾ";
            this.btnDMode.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDLayout_Click);
            // 
            // frmDepartmentModeLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDMode});
            this.Size = new System.Drawing.Size(300, 35);
            this.Name = "frmDepartmentModeLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnDMode;
    }
}