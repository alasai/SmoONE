using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmLeaveLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmLeaveLayout()
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
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblId = new Smobiler.Core.Controls.Label();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.DataMember = "U_Portrait";
            this.imgPortrait.DisplayMember = "U_Portrait";
            this.imgPortrait.ID = "";
            this.imgPortrait.Location = new System.Drawing.Point(10, 12);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(35, 35);
            this.imgPortrait.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgPortrait.TabIndex = 2;
            this.imgPortrait.ZIndex = 1;
            // 
            // lblId
            // 
            this.lblId.DataMember = "ID";
            this.lblId.DisplayMember = "Name";
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblId.Location = new System.Drawing.Point(54, 0);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new Smobiler.Core.Padding(0F, 10F, 10F, 0F);
            this.lblId.Size = new System.Drawing.Size(246, 30);
            this.lblId.TabIndex = 3;
            this.lblId.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblId.ZIndex = 2;
            // 
            // lblType
            // 
            this.lblType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblType.DataMember = "Type";
            this.lblType.DisplayMember = "L_StatusDesc";
            this.lblType.ForeColor = System.Drawing.Color.Orange;
            this.lblType.Location = new System.Drawing.Point(54, 30);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Padding(0F, 0F, 0F, 10F);
            this.lblType.Size = new System.Drawing.Size(133, 30);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "µ»¥˝Œ“…Û≈˙";
            this.lblType.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.lblType.ZIndex = 3;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 5;
            this.line1.ZIndex = 5;
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.DataMember = "CreateDate";
            this.label1.DisplayMember = "CreateDate";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(190, 30);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 10F);
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 6;
            this.label1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.label1.ZIndex = 4;
            // 
            // frmLeaveLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblId,
            this.lblType,
            this.label1,
            this.line1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmLeaveLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Label lblId;
        internal Smobiler.Core.Controls.Label lblType;
        private Smobiler.Core.Controls.Line line1;
        internal Smobiler.Core.Controls.Label label1;
    }
}