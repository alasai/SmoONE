using System;
using Smobiler.Core;
namespace SmoONE.UI.Department
{
    partial class frmDepartmentCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmDepartmentCreate()
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
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtDep_Name = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnLeader = new Smobiler.Core.Controls.Button();
            this.btnLeader1 = new Smobiler.Core.Controls.Button();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.popLeader = new Smobiler.Core.Controls.PopList();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.btnUp = new Smobiler.Core.Controls.Button();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.cameraPortrait = new Smobiler.Core.Controls.Camera();
            this.btnAssignUser = new Smobiler.Core.Controls.Button();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 60);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(66, 35);
            this.Label4.Text = "部门名称";
            this.Label4.ZIndex = 1;
            // 
            // txtDep_Name
            // 
            this.txtDep_Name.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtDep_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtDep_Name.FontSize = 12F;
            this.txtDep_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtDep_Name.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtDep_Name.Location = new System.Drawing.Point(66, 60);
            this.txtDep_Name.Name = "txtDep_Name";
            this.txtDep_Name.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 30F, 0F);
            this.txtDep_Name.Size = new System.Drawing.Size(234, 35);
            this.txtDep_Name.WaterMarkText = "（必填）";
            this.txtDep_Name.ZIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 150);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.Text = "责任人";
            // 
            // btnLeader
            // 
            this.btnLeader.BackColor = System.Drawing.Color.White;
            this.btnLeader.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnLeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLeader.BorderRadius = 0;
            this.btnLeader.FontSize = 12F;
            this.btnLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLeader.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnLeader.Location = new System.Drawing.Point(66, 150);
            this.btnLeader.Name = "btnLeader";
            this.btnLeader.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnLeader.Size = new System.Drawing.Size(209, 35);
            this.btnLeader.Text = "选择（必填）";
            this.btnLeader.Press += new System.EventHandler(this.btnLeader_Click);
            // 
            // btnLeader1
            // 
            this.btnLeader1.BackColor = System.Drawing.Color.White;
            this.btnLeader1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnLeader1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLeader1.BorderRadius = 0;
            this.btnLeader1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLeader1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnLeader1.Location = new System.Drawing.Point(275, 150);
            this.btnLeader1.Name = "btnLeader1";
            this.btnLeader1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnLeader1.Size = new System.Drawing.Size(25, 35);
            this.btnLeader1.Text = ">";
            this.btnLeader1.Press += new System.EventHandler(this.btnLeader_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "下一步";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // popLeader
            // 
            this.popLeader.Name = "popLeader";
            this.popLeader.Selected += new System.EventHandler(this.popLeader_Selected);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(0, 105);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(66, 35);
            this.label5.Text = "部门头像";
            this.label5.ZIndex = 3;
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.Location = new System.Drawing.Point(242, 107);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "bumenicon";
            this.imgPortrait.Size = new System.Drawing.Size(31, 31);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.imgPortrait.ZIndex = 5;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUp.BorderRadius = 0;
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUp.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnUp.Location = new System.Drawing.Point(275, 105);
            this.btnUp.Name = "btnUp";
            this.btnUp.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnUp.Size = new System.Drawing.Size(25, 35);
            this.btnUp.Text = ">";
            this.btnUp.Press += new System.EventHandler(this.btnUp_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(66, 105);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(209, 35);
            this.label6.ZIndex = 4;
            // 
            // cameraPortrait
            // 
            this.cameraPortrait.Name = "cameraPortrait";
            this.cameraPortrait.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.cameraPortrait_ImageCaptured);
            // 
            // btnAssignUser
            // 
            this.btnAssignUser.BackColor = System.Drawing.Color.White;
            this.btnAssignUser.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnAssignUser.BorderColor = System.Drawing.Color.LightGray;
            this.btnAssignUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAssignUser.Location = new System.Drawing.Point(0, 195);
            this.btnAssignUser.Name = "btnAssignUser";
            this.btnAssignUser.Size = new System.Drawing.Size(300, 35);
            this.btnAssignUser.Text = "分配部门人员";
            this.btnAssignUser.Press += new System.EventHandler(this.btnAssignUser_Click);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColr = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "部门";
            // 
            // frmDepartmentCreate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.cameraPortrait,
            this.popLeader});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.btnLeader,
            this.btnLeader1,
            this.btnSave,
            this.btnUp,
            this.Label4,
            this.txtDep_Name,
            this.label5,
            this.label6,
            this.imgPortrait,
            this.btnAssignUser,
            this.title1});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmDepartmentCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmDepartmentCreate_Load);
            this.Name = "frmDepartmentCreate";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtDep_Name;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Button btnLeader;
        internal Smobiler.Core.Controls.Button btnLeader1;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.PopList popLeader;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Image imgPortrait;
        internal Smobiler.Core.Controls.Button btnUp;
        internal Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Camera cameraPortrait;
        private Smobiler.Core.Controls.Button btnAssignUser;
        private SmoONE.UI.Layout.Title title1;
    }
}