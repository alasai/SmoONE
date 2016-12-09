using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmCostTempletLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostTempletLayout()
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
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.lblAEACheckers = new Smobiler.Core.Controls.Label();
            this.lblFCheckers = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            // 
            // lblID
            // 
            this.lblID.DataMember = "CC_TT_TemplateID";
            this.lblID.DisplayMember = "CC_TT_TemplateID";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(186, 20);
            this.lblID.TabIndex = 2;
            this.lblID.ZIndex = 1;
            // 
            // lblType
            // 
            this.lblType.DataMember = "CC_TT_TypeName";
            this.lblType.DisplayMember = "CC_TT_TypeName";
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblType.Location = new System.Drawing.Point(186, 0);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.lblType.Size = new System.Drawing.Size(114, 20);
            this.lblType.TabIndex = 3;
            this.lblType.ZIndex = 2;
            // 
            // lblAEACheckers
            // 
            this.lblAEACheckers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lblAEACheckers.BackColorAlpha = 0;
            this.lblAEACheckers.DataMember = "CC_TT_AEACheckers";
            this.lblAEACheckers.DisplayMember = "CC_TT_AEACheckers";
            this.lblAEACheckers.FontSize = 12F;
            this.lblAEACheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblAEACheckers.Location = new System.Drawing.Point(12, 60);
            this.lblAEACheckers.Name = "lblAEACheckers";
            this.lblAEACheckers.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 5F);
            this.lblAEACheckers.Size = new System.Drawing.Size(126, 20);
            this.lblAEACheckers.TabIndex = 4;
            this.lblAEACheckers.ZIndex = 7;
            // 
            // lblFCheckers
            // 
            this.lblFCheckers.BackColorAlpha = 0;
            this.lblFCheckers.DataMember = "CC_TT_FinancialCheckers";
            this.lblFCheckers.DisplayMember = "CC_TT_FinancialCheckers";
            this.lblFCheckers.FontSize = 12F;
            this.lblFCheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblFCheckers.Location = new System.Drawing.Point(162, 60);
            this.lblFCheckers.Name = "lblFCheckers";
            this.lblFCheckers.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 5F);
            this.lblFCheckers.Size = new System.Drawing.Size(126, 20);
            this.lblFCheckers.TabIndex = 5;
            this.lblFCheckers.ZIndex = 10;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 85);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 6;
            this.line1.ZIndex = 3;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(10F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "审批流程：";
            this.label2.ZIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.label3.BorderRadius = 2;
            this.label3.FontSize = 14F;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 40);
            this.label3.TabIndex = 8;
            this.label3.ZIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColorAlpha = 0;
            this.label4.FontSize = 12F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(162, 40);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Padding(2F, 7F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "财务审批";
            this.label4.ZIndex = 9;
            // 
            // label5
            // 
            this.label5.FontSize = 16F;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label5.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label5.Location = new System.Drawing.Point(140, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = ">";
            this.label5.ZIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.label6.BackColorAlpha = 0;
            this.label6.FontSize = 12F;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Padding(2F, 7F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "行政审批";
            this.label6.ZIndex = 6;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.label7.BorderRadius = 2;
            this.label7.FontSize = 14F;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(160, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 40);
            this.label7.TabIndex = 12;
            this.label7.ZIndex = 5;
            // 
            // frmCostTempletLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblID,
            this.lblType,
            this.line1,
            this.label2,
            this.label3,
            this.label7,
            this.label6,
            this.lblAEACheckers,
            this.label5,
            this.label4,
            this.lblFCheckers});
            this.Size = new System.Drawing.Size(300, 85);
            this.Name = "frmCostTempletLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Label lblType;
        internal Smobiler.Core.Controls.Label lblAEACheckers;
        internal Smobiler.Core.Controls.Label lblFCheckers;
        private Smobiler.Core.Controls.Line line1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
    }
}