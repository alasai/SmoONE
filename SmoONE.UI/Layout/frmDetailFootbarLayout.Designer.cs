using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmDetailFootbarLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmDetailFootbarLayout()
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
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.btnAgreed = new Smobiler.Core.Controls.Button();
            this.btnRefuse = new Smobiler.Core.Controls.Button();
            this.Line1 = new Smobiler.Core.Controls.Line();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.BorderRadius = 2;
            this.btnEdit.FontSize = 17F;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnEdit.HoverForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(205, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "±à¼­";
            this.btnEdit.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // btnAgreed
            // 
            this.btnAgreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(187)))), ((int)(((byte)(91)))));
            this.btnAgreed.BorderRadius = 2;
            this.btnAgreed.FontSize = 17F;
            this.btnAgreed.ForeColor = System.Drawing.Color.White;
            this.btnAgreed.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(174)))), ((int)(((byte)(79)))));
            this.btnAgreed.HoverForeColor = System.Drawing.Color.White;
            this.btnAgreed.Location = new System.Drawing.Point(10, 10);
            this.btnAgreed.Name = "btnAgreed";
            this.btnAgreed.Size = new System.Drawing.Size(85, 35);
            this.btnAgreed.TabIndex = 3;
            this.btnAgreed.Text = "Í¬Òâ";
            this.btnAgreed.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // btnRefuse
            // 
            this.btnRefuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnRefuse.BorderRadius = 2;
            this.btnRefuse.FontSize = 17F;
            this.btnRefuse.ForeColor = System.Drawing.Color.White;
            this.btnRefuse.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(151)))), ((int)(((byte)(34)))));
            this.btnRefuse.HoverForeColor = System.Drawing.Color.White;
            this.btnRefuse.Location = new System.Drawing.Point(108, 10);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(85, 35);
            this.btnRefuse.TabIndex = 4;
            this.btnRefuse.Text = "¾Ü¾ø";
            this.btnRefuse.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300, 1);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 4;
            // 
            // frmDetailFootbarLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnEdit,
            this.btnAgreed,
            this.btnRefuse,
            this.Line1});
            this.Size = new System.Drawing.Size(300, 55);
            this.Name = "frmDetailFootbarLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnEdit;
        private Smobiler.Core.Controls.Button btnAgreed;
        private Smobiler.Core.Controls.Button btnRefuse;
        internal Smobiler.Core.Controls.Line Line1;
    }
}