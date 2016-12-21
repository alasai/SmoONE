using System;
using Smobiler.Core;
namespace SmoONE.UI.Department
{
    partial class frmDepAssignUser : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmDepAssignUser()
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
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblDepName = new Smobiler.Core.Controls.Label();
            this.gridUserData = new Smobiler.Core.Controls.GridView();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnAll = new Smobiler.Core.Controls.Button();
            this.checkAll = new Smobiler.Core.Controls.CheckBox();
            this.line9 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblLeader = new Smobiler.Core.Controls.Label();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "部门";
            // 
            // lblDepName
            // 
            this.lblDepName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDepName.FontSize = 12F;
            this.lblDepName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblDepName.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblDepName.Location = new System.Drawing.Point(66, 10);
            this.lblDepName.Name = "lblDepName";
            this.lblDepName.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.lblDepName.Size = new System.Drawing.Size(234, 35);
            this.lblDepName.TabIndex = 3;
            // 
            // gridUserData
            // 
            this.gridUserData.AllowSlip = true;
            this.gridUserData.AutoHeight = false;
            this.gridUserData.Layout = "frmDepAssignUserLayout";
            this.gridUserData.Location = new System.Drawing.Point(0, 135);
            this.gridUserData.Name = "gridUserData";
            this.gridUserData.PageSize = 8;
            this.gridUserData.ShowGridLines = false;
            this.gridUserData.Size = new System.Drawing.Size(300, 250);
            this.gridUserData.TabIndex = 5;
            this.gridUserData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridView1_CellClick);
            this.gridUserData.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.gridView1_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "提交";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // btnAll
            // 
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAll.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnAll.HoverBackColor = System.Drawing.Color.White;
            this.btnAll.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAll.Location = new System.Drawing.Point(0, 100);
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new Smobiler.Core.Padding(0F, 0F, 40F, 0F);
            this.btnAll.Size = new System.Drawing.Size(300, 35);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "全选";
            this.btnAll.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnAll_Click);
            // 
            // checkAll
            // 
            this.checkAll.Border = new Smobiler.Core.Border(1);
            this.checkAll.BorderColor = System.Drawing.Color.DarkGray;
            this.checkAll.Checked = false;
            this.checkAll.CheckedBackColor = System.Drawing.Color.White;
            this.checkAll.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.checkAll.Location = new System.Drawing.Point(270, 108);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(20, 20);
            this.checkAll.TabIndex = 8;
            this.checkAll.UnCheckedBackColor = System.Drawing.Color.White;
            this.checkAll.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.checkAll_CheckChanged);
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 9);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 9;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 10;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 100);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 11;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 135);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 55);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "责任人";
            // 
            // lblLeader
            // 
            this.lblLeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLeader.FontSize = 12F;
            this.lblLeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblLeader.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblLeader.Location = new System.Drawing.Point(66, 55);
            this.lblLeader.Name = "lblLeader";
            this.lblLeader.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.lblLeader.Size = new System.Drawing.Size(234, 35);
            this.lblLeader.TabIndex = 14;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 55);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 15;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 90);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 16;
            // 
            // frmDepAssignUser
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.lblDepName,
            this.gridUserData,
            this.btnSave,
            this.btnAll,
            this.checkAll,
            this.label1,
            this.lblLeader,
            this.line4,
             this.line9,
            this.line1,
            this.line2,
            this.line3,
            this.line5
            });
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "部门人员维护";
            this.Load += new System.EventHandler(this.frmDepAssignUser_Load);
            this.TitleImageClick += new System.EventHandler(this.frmDepAssignUser_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmDepAssignUser_KeyDown);
            this.Name = "frmDepAssignUser";

        }
        #endregion

        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label lblDepName;
        private Smobiler.Core.Controls.GridView gridUserData;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Button btnAll;
        private Smobiler.Core.Controls.CheckBox checkAll;
        private Smobiler.Core.Controls.Line line9;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblLeader;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
    }
}