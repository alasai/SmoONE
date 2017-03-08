using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmATFootLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmATFootLayout()
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
            this.lblDesc = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // lblDesc
            // 
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblDesc.Size = new System.Drawing.Size(196, 55);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "已选中 0 人";
            this.lblDesc.ZIndex = 1;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.LightGray;
            this.Line1.Location = new System.Drawing.Point(0, 55);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300, 1);
            this.Line1.TabIndex = 4;
            this.Line1.ZIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.Enabled = false;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(205, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "确定";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // frmATFootLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblDesc,
            this.Line1,
            this.btnSave});
            this.Size = new System.Drawing.Size(300, 55);
            this.Name = "frmATFootLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblDesc;
        internal Smobiler.Core.Controls.Line Line1;
        private Smobiler.Core.Controls.Button btnSave;
    }
}