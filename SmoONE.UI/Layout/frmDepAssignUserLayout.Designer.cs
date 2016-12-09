using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmDepAssignUserLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmDepAssignUserLayout()
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
            this.lblPortrait = new Smobiler.Core.Controls.Label();
            this.lblUser = new Smobiler.Core.Controls.Label();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.Check = new Smobiler.Core.Controls.CheckBox();
            this.lblDep = new Smobiler.Core.Controls.Label();
            // 
            // lblPortrait
            // 
            this.lblPortrait.AutoVisibleInLayout = true;
            this.lblPortrait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblPortrait.BorderRadius = 10;
            this.lblPortrait.ForeColor = System.Drawing.Color.White;
            this.lblPortrait.Location = new System.Drawing.Point(4, 7);
            this.lblPortrait.Name = "lblPortrait";
            this.lblPortrait.Size = new System.Drawing.Size(35, 35);
            this.lblPortrait.TabIndex = 2;
            this.lblPortrait.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.DataMember = "U_ID";
            this.lblUser.DisplayMember = "U_Name";
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUser.Location = new System.Drawing.Point(47, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(109, 50);
            this.lblUser.TabIndex = 3;
            // 
            // imgPortrait
            // 
            this.imgPortrait.AutoVisibleInLayout = true;
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.DataMember = "U_Portrait";
            this.imgPortrait.DisplayMember = "U_Portrait";
            this.imgPortrait.ID = "";
            this.imgPortrait.Location = new System.Drawing.Point(4, 7);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(35, 35);
            this.imgPortrait.TabIndex = 4;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(47, 50);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(253, 1);
            this.line1.TabIndex = 5;
            // 
            // Check
            // 
            this.Check.Border = new Smobiler.Core.Border(1);
            this.Check.BorderColor = System.Drawing.Color.DarkGray;
            this.Check.Checked = false;
            this.Check.CheckedBackColor = System.Drawing.Color.White;
            this.Check.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.Check.DataMember = "SelectCheck";
            this.Check.DisplayMember = "SelectCheck";
            this.Check.Location = new System.Drawing.Point(270, 15);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(20, 20);
            this.Check.TabIndex = 6;
            this.Check.UnCheckedBackColor = System.Drawing.Color.White;
            // 
            // lblDep
            // 
            this.lblDep.DataMember = "U_DepID";
            this.lblDep.DisplayMember = "U_DepName";
            this.lblDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDep.Location = new System.Drawing.Point(156, 0);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(108, 50);
            this.lblDep.TabIndex = 7;
            // 
            // frmDepAssignUserLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblPortrait,
            this.lblUser,
            this.imgPortrait,
            this.line1,
            this.Check,
            this.lblDep});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmDepAssignUserLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblPortrait;
        private Smobiler.Core.Controls.Label lblUser;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.CheckBox Check;
        private Smobiler.Core.Controls.Label lblDep;
    }
}