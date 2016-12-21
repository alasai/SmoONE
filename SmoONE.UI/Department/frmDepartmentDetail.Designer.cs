using System;
using Smobiler.Core;
namespace SmoONE.UI.Department
{
    partial class frmDepartmentDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmDepartmentDetail()
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
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.gridUserData = new Smobiler.Core.Controls.GridView();
            this.lblProDay = new Smobiler.Core.Controls.Label();
            this.lblOtherDay = new Smobiler.Core.Controls.Label();
            this.lblLeader = new Smobiler.Core.Controls.Label();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.line9 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.line7 = new Smobiler.Core.Controls.Line();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.btnDelete = new Smobiler.Core.Controls.Button();
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
            // 
            // lblName
            // 
            this.lblName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblName.FontSize = 12F;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblName.Location = new System.Drawing.Point(66, 10);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblName.Size = new System.Drawing.Size(234, 35);
            this.lblName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(0, 100);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "目标人天";
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 135);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(101, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "目标其他人天";
            // 
            // label5
            // 
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(0, 180);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(66, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "责任人";
            // 
            // gridUserData
            // 
            this.gridUserData.AllowSlip = true;
            this.gridUserData.AutoHeight = false;
            this.gridUserData.Layout = "frmUserLayout";
            this.gridUserData.Location = new System.Drawing.Point(0, 215);
            this.gridUserData.Name = "gridUserData";
            this.gridUserData.PageSize = 8;
            this.gridUserData.ShowGridLines = false;
            this.gridUserData.Size = new System.Drawing.Size(300, 185);
            this.gridUserData.TabIndex = 7;
            // 
            // lblProDay
            // 
            this.lblProDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblProDay.FontSize = 12F;
            this.lblProDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblProDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblProDay.Location = new System.Drawing.Point(66, 100);
            this.lblProDay.Name = "lblProDay";
            this.lblProDay.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblProDay.Size = new System.Drawing.Size(234, 35);
            this.lblProDay.TabIndex = 8;
            // 
            // lblOtherDay
            // 
            this.lblOtherDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblOtherDay.FontSize = 12F;
            this.lblOtherDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblOtherDay.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblOtherDay.Location = new System.Drawing.Point(101, 135);
            this.lblOtherDay.Name = "lblOtherDay";
            this.lblOtherDay.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblOtherDay.Size = new System.Drawing.Size(199, 35);
            this.lblOtherDay.TabIndex = 9;
            // 
            // lblLeader
            // 
            this.lblLeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLeader.FontSize = 12F;
            this.lblLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblLeader.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblLeader.Location = new System.Drawing.Point(66, 180);
            this.lblLeader.Name = "lblLeader";
            this.lblLeader.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblLeader.Size = new System.Drawing.Size(234, 35);
            this.lblLeader.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.BorderRadius = 2;
            this.btnEdit.FontSize = 17F;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.HoverForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(10, 410);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 35);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnEdit_Click);
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
            this.line2.Location = new System.Drawing.Point(0, 55);
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
            this.line5.Location = new System.Drawing.Point(0, 180);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 17;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(0, 215);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 1);
            this.line6.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 55);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "部门头像";
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.LightGray;
            this.line7.Location = new System.Drawing.Point(0, 90);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(300, 1);
            this.line7.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(66, 55);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(234, 35);
            this.label6.TabIndex = 21;
            this.label6.ZIndex = 4;
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.Enlarged = true;
            this.imgPortrait.ID = "bumenicon";
            this.imgPortrait.Location = new System.Drawing.Point(260, 57);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "bumenicon";
            this.imgPortrait.Size = new System.Drawing.Size(30, 30);
            this.imgPortrait.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgPortrait.TabIndex = 22;
            this.imgPortrait.ZIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnDelete.BorderRadius = 2;
            this.btnDelete.FontSize = 17F;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(151)))), ((int)(((byte)(34)))));
            this.btnDelete.HoverForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(156, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 35);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDelete_Click);
            // 
            // frmDepartmentDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.lblName,
            this.label2,
            this.label3,
            this.label5,
            this.gridUserData,
            this.lblProDay,
            this.lblOtherDay,
            this.lblLeader,
            this.btnEdit,
            this.label1,
            this.label6,
            this.imgPortrait,
            this.btnDelete,
            this.line7,
            this.line9,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line6});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "部门";
            this.Load += new System.EventHandler(this.frmDepartmentDetail_Load);
            this.TitleImageClick += new System.EventHandler(this.frmDepartmentDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmDepartmentDetail_KeyDown);
            this.Name = "frmDepartmentDetail";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.GridView gridUserData;
        internal Smobiler.Core.Controls.Label lblProDay;
        internal Smobiler.Core.Controls.Label lblOtherDay;
        internal Smobiler.Core.Controls.Label lblLeader;
        private Smobiler.Core.Controls.Button btnEdit;
        private Smobiler.Core.Controls.Line line9;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
        internal Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Line line7;
        internal Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Button btnDelete;
    }
}