using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmRBModelLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBModelLayout()
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
            this.lblRT_Type = new Smobiler.Core.Controls.Label();
            this.lblRT_Money = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // imgType
            // 
            this.imgType.BorderRadius = 10;
            this.imgType.DisplayMember = "RB_RTT_TypeID";
            this.imgType.FontSize = 10F;
            this.imgType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.imgType.Location = new System.Drawing.Point(10, 12);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(35, 35);
            this.imgType.TabIndex = 2;
            this.imgType.TextMember = "RBROW_TYPENAME";
            this.imgType.ZIndex = 1;
            // 
            // lblRT_Type
            // 
            this.lblRT_Type.DisplayMember = "RB_RTT_TypeName";
            this.lblRT_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblRT_Type.Location = new System.Drawing.Point(54, 0);
            this.lblRT_Type.Name = "lblRT_Type";
            this.lblRT_Type.Padding = new Smobiler.Core.Padding(0F, 10F, 0F, 0F);
            this.lblRT_Type.Size = new System.Drawing.Size(96, 30);
            this.lblRT_Type.TabIndex = 3;
            this.lblRT_Type.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblRT_Type.ZIndex = 2;
            // 
            // lblRT_Money
            // 
            this.lblRT_Money.DataMember = "RB_RTT_TemplateID";
            this.lblRT_Money.DisplayMember = "RB_RTT_Amount";
            this.lblRT_Money.ForeColor = System.Drawing.Color.Orange;
            this.lblRT_Money.Format = "￥{0}";
            this.lblRT_Money.Location = new System.Drawing.Point(54, 30);
            this.lblRT_Money.Name = "lblRT_Money";
            this.lblRT_Money.Padding = new Smobiler.Core.Padding(0F, 0F, 0F, 10F);
            this.lblRT_Money.Size = new System.Drawing.Size(96, 30);
            this.lblRT_Money.TabIndex = 4;
            this.lblRT_Money.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.lblRT_Money.ZIndex = 3;
            // 
            // lblnote
            // 
            this.lblnote.DisplayMember = "RB_RTT_Note";
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
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 6;
            // 
            // frmRBModelLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgType,
            this.lblRT_Type,
            this.lblRT_Money,
            this.lblnote,
            this.line1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmRBModelLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.ImageButton imgType;
        internal Smobiler.Core.Controls.Label lblRT_Type;
        internal Smobiler.Core.Controls.Label lblRT_Money;
        internal Smobiler.Core.Controls.Label lblnote;
        private Smobiler.Core.Controls.Line line1;


    }
}