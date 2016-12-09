using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmRBROWLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBROWLayout()
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
            this.imgType = new Smobiler.Core.Controls.ImageButton();
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.lbldate = new Smobiler.Core.Controls.Label();
            // 
            // imgType
            // 
            this.imgType.BorderRadius = 10;
            this.imgType.DisplayMember = "RBROW_TYPE";
            this.imgType.FontSize = 10F;
            this.imgType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.imgType.Location = new System.Drawing.Point(5, 7);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(45, 45);
            this.imgType.TabIndex = 2;
            this.imgType.TextMember = "RBROW_TYPENAME";
            this.imgType.ZIndex = 1;
            // 
            // lblnote
            // 
            this.lblnote.DisplayMember = "RBROW_NOTE";
            this.lblnote.FontSize = 12F;
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblnote.Location = new System.Drawing.Point(150, 0);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Padding(2F, 10F, 10F, 0F);
            this.lblnote.Size = new System.Drawing.Size(150, 60);
            this.lblnote.TabIndex = 5;
            this.lblnote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblnote.ZIndex = 4;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 60);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 7;
            // 
            // lblMoney
            // 
            this.lblMoney.DataMember = "RBROW_AMOUNT";
            this.lblMoney.DisplayMember = "RBROW_AMOUNT";
            this.lblMoney.ForeColor = System.Drawing.Color.Orange;
            this.lblMoney.Format = "￥{0}";
            this.lblMoney.Location = new System.Drawing.Point(55, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new Smobiler.Core.Padding(0F, 10F, 0F, 0F);
            this.lblMoney.Size = new System.Drawing.Size(95, 30);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblMoney.ZIndex = 3;
            // 
            // lbldate
            // 
            this.lbldate.DataMember = "RBROW_DATE";
            this.lbldate.DisplayMember = "RBROW_DATE";
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lbldate.Location = new System.Drawing.Point(55, 30);
            this.lbldate.Name = "lbldate";
            this.lbldate.Padding = new Smobiler.Core.Padding(0F, 0F, 0F, 10F);
            this.lbldate.Size = new System.Drawing.Size(95, 30);
            this.lbldate.TabIndex = 9;
            this.lbldate.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.lbldate.ZIndex = 4;
            // 
            // frmRBROWLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.line2,
            this.imgType,
            this.lblMoney,
            this.lblnote,
            this.lbldate});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmRBROWLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.ImageButton imgType;
        internal Smobiler.Core.Controls.Label lblnote;
        private Smobiler.Core.Controls.Line line2;
        internal Smobiler.Core.Controls.Label lblMoney;
        internal Smobiler.Core.Controls.Label lbldate;

    }
}