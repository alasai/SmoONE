using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmConsumptionLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConsumptionLayout()
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
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.lbldate = new Smobiler.Core.Controls.Label();
            this.LblID = new Smobiler.Core.Controls.Label();
            this.imgType = new Smobiler.Core.Controls.ImageButton();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // lblnote
            // 
            this.lblnote.DataMember = "RBROW_NOTE";
            this.lblnote.DisplayMember = "RBROW_NOTE";
            this.lblnote.FontSize = 12F;
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblnote.Location = new System.Drawing.Point(150, 0);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Padding(2F, 10F, 10F, 0F);
            this.lblnote.Size = new System.Drawing.Size(150, 60);
            this.lblnote.TabIndex = 3;
            this.lblnote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblnote.ZIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.DataMember = "ID";
            this.lblMoney.DisplayMember = "RBROW_AMOUNT";
            this.lblMoney.ForeColor = System.Drawing.Color.Orange;
            this.lblMoney.Format = "￥{0:N}";
            this.lblMoney.Location = new System.Drawing.Point(55, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new Smobiler.Core.Padding(0F, 10F, 0F, 0F);
            this.lblMoney.Size = new System.Drawing.Size(95, 30);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblMoney.ZIndex = 2;
            // 
            // lbldate
            // 
            this.lbldate.DataMember = "RBROW_DATE";
            this.lbldate.DisplayMember = "RBROW_DATE";
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lbldate.Format = "{0:d}";
            this.lbldate.Location = new System.Drawing.Point(55, 30);
            this.lbldate.Name = "lbldate";
            this.lbldate.Padding = new Smobiler.Core.Padding(0F, 0F, 0F, 10F);
            this.lbldate.Size = new System.Drawing.Size(95, 30);
            this.lbldate.TabIndex = 5;
            this.lbldate.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.lbldate.ZIndex = 3;
            // 
            // LblID
            // 
            this.LblID.BackColor = System.Drawing.Color.Gray;
            this.LblID.DisplayMember = "ID";
            this.LblID.Location = new System.Drawing.Point(172, 8);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(38, 30);
            this.LblID.TabIndex = 6;
            this.LblID.Visible = false;
            // 
            // imgType
            // 
            this.imgType.BorderRadius = 10;
            this.imgType.DisplayMember = "RBROW_TYPE";
            this.imgType.Location = new System.Drawing.Point(5, 7);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(45, 45);
            this.imgType.TabIndex = 6;
            this.imgType.TextMember = "RBROW_TYPENAME";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 7;
            // 
            // frmConsumptionLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblMoney,
            this.lblnote,
            this.lbldate,
            this.imgType,
            this.line1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmConsumptionLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblnote;
        internal Smobiler.Core.Controls.Label lblMoney;
        internal Smobiler.Core.Controls.Label lbldate;
        private Smobiler.Core.Controls.Label LblID;
        private Smobiler.Core.Controls.ImageButton imgType;
        private Smobiler.Core.Controls.Line line1;
    }
}