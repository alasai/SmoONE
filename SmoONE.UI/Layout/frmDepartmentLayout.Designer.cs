using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmDepartmentLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmDepartmentLayout()
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
            this.lblId = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            // 
            // lblId
            // 
            this.lblId.DataMember = "Dep_ID";
            this.lblId.DisplayMember = "Dep_Name";
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblId.Location = new System.Drawing.Point(54, 0);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new Smobiler.Core.Padding(0F, 10F, 10F, 0F);
            this.lblId.Size = new System.Drawing.Size(256, 30);
            this.lblId.TabIndex = 2;
            this.lblId.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblId.ZIndex = 1;
            // 
            // label1
            // 
            this.label1.DataMember = "Dep_Leader";
            this.label1.DisplayMember = "U_Name";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 10F);
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 3;
            this.label1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Bottom;
            this.label1.ZIndex = 2;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 4;
            this.line1.ZIndex = 3;
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.DataMember = "Dep_Icon";
            this.imgPortrait.DisplayMember = "Dep_Icon";
            this.imgPortrait.ID = "";
            this.imgPortrait.Location = new System.Drawing.Point(10, 12);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(35, 35);
            this.imgPortrait.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgPortrait.TabIndex = 5;
            // 
            // frmDepartmentLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblId,
            this.label1,
            this.imgPortrait,
             this.line1,
            });
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmDepartmentLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblId;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Image imgPortrait;
    }
}