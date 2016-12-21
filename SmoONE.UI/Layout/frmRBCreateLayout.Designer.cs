using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmRBCreateLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBCreateLayout()
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
            this.Check = new Smobiler.Core.Controls.CheckBox();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.lbldate = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.imgType = new Smobiler.Core.Controls.ImageButton();
            // 
            // Check
            // 
            this.Check.Border = new Smobiler.Core.Border(1);
            this.Check.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Check.Checked = false;
            this.Check.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.Check.Location = new System.Drawing.Point(10, 22);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(15, 15);
            this.Check.TabIndex = 2;
            this.Check.UnCheckedBackColor = System.Drawing.Color.White;
            this.Check.ZIndex = 1;
            // 
            // lblMoney
            // 
            this.lblMoney.DataMember = "RBROW_AMOUNT";
            this.lblMoney.DisplayMember = "RBROW_AMOUNT";
            this.lblMoney.ForeColor = System.Drawing.Color.Orange;
            this.lblMoney.Format = "￥{0}";
            this.lblMoney.Location = new System.Drawing.Point(75, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new Smobiler.Core.Padding(0F, 10F, 0F, 0F);
            this.lblMoney.Size = new System.Drawing.Size(75, 30);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblMoney.ZIndex = 3;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.LightGray;
            this.Line1.Location = new System.Drawing.Point(0, 60);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300, 1);
            this.Line1.TabIndex = 5;
            this.Line1.ZIndex = 6;
            // 
            // lbldate
            // 
            this.lbldate.DataMember = "RBROW_DATE";
            this.lbldate.DisplayMember = "RBROW_DATE";
            this.lbldate.FontSize = 13F;
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lbldate.Format = "{0:d}";
            this.lbldate.Location = new System.Drawing.Point(75, 30);
            this.lbldate.Name = "lbldate";
            this.lbldate.Padding = new Smobiler.Core.Padding(0F, 0F, 0F, 10F);
            this.lbldate.Size = new System.Drawing.Size(75, 30);
            this.lbldate.TabIndex = 6;
            this.lbldate.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.lbldate.ZIndex = 4;
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
            this.lblnote.TabIndex = 7;
            this.lblnote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblnote.ZIndex = 5;
            // 
            // imgType
            // 
            this.imgType.BorderRadius = 10;
            this.imgType.DataMember = "ID";
            this.imgType.DisplayMember = "RBROW_TYPE";
            this.imgType.FontSize = 10F;
            this.imgType.Location = new System.Drawing.Point(25, 7);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(45, 45);
            this.imgType.TabIndex = 8;
            this.imgType.TextMember = "RBROW_TYPENAME";
            // 
            // frmRBCreateLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Check,
            this.lblMoney,
            this.lbldate,
            this.lblnote,
            this.imgType,
            this.Line1,
            });
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmRBCreateLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.CheckBox Check;
        internal Smobiler.Core.Controls.Label lblMoney;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Label lbldate;
        internal Smobiler.Core.Controls.Label lblnote;
        private Smobiler.Core.Controls.ImageButton imgType;
    }
}