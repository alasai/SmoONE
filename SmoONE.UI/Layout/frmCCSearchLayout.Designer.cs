using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.CostCenter.Layout
{
    partial class frmCCSearchLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCCSearchLayout()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.btnccuser = new Smobiler.Core.Controls.Button();
            this.btnccuser1 = new Smobiler.Core.Controls.Button();
            this.btncurrentUser = new Smobiler.Core.Controls.ImageButton();
            this.txtCCName = new Smobiler.Core.Controls.TextBox();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Line2 = new Smobiler.Core.Controls.Line();
            this.Line3 = new Smobiler.Core.Controls.Line();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnOK = new Smobiler.Core.Controls.Button();
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(66, 35);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "责任人";
            this.Label1.ZIndex = 2;
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(66, 35);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "成本中心";
            this.Label2.ZIndex = 7;
            // 
            // btnccuser
            // 
            this.btnccuser.BorderColor = System.Drawing.Color.LightGray;
            this.btnccuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnccuser.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnccuser.Location = new System.Drawing.Point(66, 0);
            this.btnccuser.Name = "btnccuser";
            this.btnccuser.Size = new System.Drawing.Size(144, 35);
            this.btnccuser.TabIndex = 4;
            this.btnccuser.ZIndex = 3;
            // 
            // btnccuser1
            // 
            this.btnccuser1.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnccuser1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnccuser1.Location = new System.Drawing.Point(210, 0);
            this.btnccuser1.Name = "btnccuser1";
            this.btnccuser1.Size = new System.Drawing.Size(25, 35);
            this.btnccuser1.TabIndex = 5;
            this.btnccuser1.Text = ">";
            this.btnccuser1.ZIndex = 4;
            // 
            // btncurrentUser
            // 
            this.btncurrentUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btncurrentUser.FontSize = 8F;
            this.btncurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btncurrentUser.Location = new System.Drawing.Point(235, 0);
            this.btncurrentUser.Name = "btncurrentUser";
            this.btncurrentUser.ResourceID = "me";
            this.btncurrentUser.Size = new System.Drawing.Size(35, 35);
            this.btncurrentUser.TabIndex = 6;
            this.btncurrentUser.Text = "我";
            this.btncurrentUser.ZIndex = 5;
            // 
            // txtCCName
            // 
            this.txtCCName.BorderColor = System.Drawing.Color.LightBlue;
            this.txtCCName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtCCName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtCCName.Location = new System.Drawing.Point(66, 35);
            this.txtCCName.Name = "txtCCName";
            this.txtCCName.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtCCName.Size = new System.Drawing.Size(204, 35);
            this.txtCCName.TabIndex = 7;
            this.txtCCName.ZIndex = 8;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line1.Location = new System.Drawing.Point(0, 35);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(270, 3);
            this.Line1.TabIndex = 9;
            this.Line1.ZIndex = 6;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line2.Location = new System.Drawing.Point(0, 70);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(270, 1);
            this.Line2.TabIndex = 10;
            this.Line2.ZIndex = 8;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(270, 3);
            this.Line3.TabIndex = 11;
            this.Line3.ZIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCancel.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCancel.Location = new System.Drawing.Point(0, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnOK.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnOK.Location = new System.Drawing.Point(135, 85);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 40);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定";
            // 
            // frmCCSearchLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Line3,
            this.Label1,
            this.btnccuser,
            this.btnccuser1,
            this.btncurrentUser,
            this.Label2,
            this.txtCCName,
            this.btnCancel,
            this.btnOK,
            this.Line1,
            this.Line2,
            });
            this.Size = new System.Drawing.Size(270, 125);
            this.Name = "frmCCSearchLayout";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Button btnccuser;
        internal Smobiler.Core.Controls.Button btnccuser1;
        internal Smobiler.Core.Controls.ImageButton btncurrentUser;
        internal Smobiler.Core.Controls.TextBox txtCCName;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Line Line2;
        internal Smobiler.Core.Controls.Line Line3;

        #endregion
        private Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnOK;
    }
}
