using System;
using Smobiler.Core;
namespace SmoONE.UI.Department
{
    partial class frmDepartmentCreate : Smobiler.Core.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.txtProDay = new Smobiler.Core.Controls.TextBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtOtherDay = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnLeader = new Smobiler.Core.Controls.Button();
            this.btnLeader1 = new Smobiler.Core.Controls.Button();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.popLeader = new Smobiler.Core.Controls.PopList();
            this.line9 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.btnUp = new Smobiler.Core.Controls.Button();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.line7 = new Smobiler.Core.Controls.Line();
            this.line8 = new Smobiler.Core.Controls.Line();
            this.cameraPortrait = new Smobiler.Core.Controls.Camera();
            this.btnAssignUser = new Smobiler.Core.Controls.Button();
            // 
            // Label4
            // 
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 10);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(66, 35);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "部门名称";
            this.Label4.ZIndex = 1;
            // 
            // txtDep_Name
            // 
            this.txtDep_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtDep_Name.FontSize = 12F;
            this.txtDep_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtDep_Name.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtDep_Name.Location = new System.Drawing.Point(66, 10);
            this.txtDep_Name.Name = "txtDep_Name";
            this.txtDep_Name.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtDep_Name.Size = new System.Drawing.Size(234, 35);
            this.txtDep_Name.TabIndex = 3;
            this.txtDep_Name.WaterMarkText = "（必填）";
            this.txtDep_Name.ZIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "目标项目人天";
            // 
            // txtProDay
            // 
            this.txtProDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtProDay.FontSize = 12F;
            this.txtProDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtProDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtProDay.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtProDay.Location = new System.Drawing.Point(97, 100);
            this.txtProDay.Name = "txtProDay";
            this.txtProDay.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtProDay.Size = new System.Drawing.Size(203, 35);
            this.txtProDay.TabIndex = 5;
            this.txtProDay.WaterMarkText = "（选填）";
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(0, 135);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(97, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "目标其他人天";
            // 
            // txtOtherDay
            // 
            this.txtOtherDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtOtherDay.FontSize = 12F;
            this.txtOtherDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtOtherDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtOtherDay.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtOtherDay.Location = new System.Drawing.Point(97, 135);
            this.txtOtherDay.Name = "txtOtherDay";
            this.txtOtherDay.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.txtOtherDay.Size = new System.Drawing.Size(203, 35);
            this.txtOtherDay.TabIndex = 7;
            this.txtOtherDay.WaterMarkText = "（选填）";
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 180);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "责任人";
            // 
            // btnLeader
            // 
            this.btnLeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLeader.FontSize = 12F;
            this.btnLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLeader.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnLeader.HoverBackColor = System.Drawing.Color.White;
            this.btnLeader.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLeader.Location = new System.Drawing.Point(66, 180);
            this.btnLeader.Name = "btnLeader";
            this.btnLeader.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnLeader.Size = new System.Drawing.Size(209, 35);
            this.btnLeader.TabIndex = 9;
            this.btnLeader.Text = "选择（必填）";
            this.btnLeader.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnLeader_Click);
            // 
            // btnLeader1
            // 
            this.btnLeader1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLeader1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLeader1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnLeader1.HoverBackColor = System.Drawing.Color.White;
            this.btnLeader1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLeader1.Location = new System.Drawing.Point(275, 180);
            this.btnLeader1.Name = "btnLeader1";
            this.btnLeader1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnLeader1.Size = new System.Drawing.Size(25, 35);
            this.btnLeader1.TabIndex = 10;
            this.btnLeader1.Text = ">";
            this.btnLeader1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnLeader_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "下一步";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // popLeader
            // 
            this.popLeader.Name = "popLeader";
            this.popLeader.Selected += new System.EventHandler(this.popLeader_Selected);
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 10);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 12;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 13;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 100);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 14;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 135);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 15;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 170);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 16;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 215);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 17;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(0, 180);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 1);
            this.line6.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(0, 55);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(66, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "部门头像";
            this.label5.ZIndex = 3;
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.Enlarged = true;
            this.imgPortrait.ID = "bumenicon";
            this.imgPortrait.Location = new System.Drawing.Point(242, 57);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "bumenicon";
            this.imgPortrait.Size = new System.Drawing.Size(31, 31);
            this.imgPortrait.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgPortrait.TabIndex = 20;
            this.imgPortrait.ZIndex = 5;
            // 
            // btnUp
            // 
            this.btnUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUp.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnUp.HoverBackColor = System.Drawing.Color.White;
            this.btnUp.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUp.Location = new System.Drawing.Point(275, 55);
            this.btnUp.Name = "btnUp";
            this.btnUp.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnUp.Size = new System.Drawing.Size(25, 35);
            this.btnUp.TabIndex = 21;
            this.btnUp.Text = ">";
            this.btnUp.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnUp_Click);
            // 
            // label6
            // 
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(66, 55);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(209, 35);
            this.label6.TabIndex = 22;
            this.label6.ZIndex = 4;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.LightGray;
            this.line7.Location = new System.Drawing.Point(0, 55);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(300, 1);
            this.line7.TabIndex = 23;
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.Color.LightGray;
            this.line8.Location = new System.Drawing.Point(0, 90);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(300, 1);
            this.line8.TabIndex = 24;
            // 
            // cameraPortrait
            // 
            this.cameraPortrait.Name = "cameraPortrait";
            this.cameraPortrait.QualityMode = Smobiler.Core.Controls.ImageQualityMode.Compressed;
            this.cameraPortrait.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.cameraPortrait_ImageCaptured);
            // 
            // btnAssignUser
            // 
            this.btnAssignUser.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnAssignUser.BorderColor = System.Drawing.Color.LightGray;
            this.btnAssignUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAssignUser.HoverBackColor = System.Drawing.Color.White;
            this.btnAssignUser.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAssignUser.Location = new System.Drawing.Point(0, 225);
            this.btnAssignUser.Name = "btnAssignUser";
            this.btnAssignUser.Size = new System.Drawing.Size(300, 35);
            this.btnAssignUser.TabIndex = 25;
            this.btnAssignUser.Text = "分配部门人员";
            this.btnAssignUser.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnAssignUser_Click);
            // 
            // frmDepartmentCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popLeader,
            this.cameraPortrait});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.txtProDay,
            this.label2,
            this.txtOtherDay,
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
            this.line7,
            this.line8,
            this.line9,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line6});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "部门";
            this.Load += new System.EventHandler(this.frmDepartmentCreate_Load);
            this.TitleImageClick += new System.EventHandler(this.frmDepartmentCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmDepartmentCreate_KeyDown);
            this.Name = "frmDepartmentCreate";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtDep_Name;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.TextBox txtProDay;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.TextBox txtOtherDay;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Button btnLeader;
        internal Smobiler.Core.Controls.Button btnLeader1;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.PopList popLeader;
        private Smobiler.Core.Controls.Line line9;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Image imgPortrait;
        internal Smobiler.Core.Controls.Button btnUp;
        internal Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Line line7;
        private Smobiler.Core.Controls.Line line8;
        private Smobiler.Core.Controls.Camera cameraPortrait;
        private Smobiler.Core.Controls.Button btnAssignUser;
    }
}