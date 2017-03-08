using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmATUser : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmATUser()
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
            this.gridATUserData = new Smobiler.Core.Controls.GridView();
            this.btnAll = new Smobiler.Core.Controls.Button();
            this.checkAll = new Smobiler.Core.Controls.CheckBox();
            this.line3 = new Smobiler.Core.Controls.Line();
            // 
            // gridATUserData
            // 
            this.gridATUserData.AllowSlip = true;
            this.gridATUserData.AutoHeight = true;
            this.gridATUserData.Layout = "frmATUserLayout";
            this.gridATUserData.Location = new System.Drawing.Point(0, 35);
            this.gridATUserData.Name = "gridATUserData";
            this.gridATUserData.PageSize = 8;
            this.gridATUserData.Size = new System.Drawing.Size(300, 430);
            this.gridATUserData.TabIndex = 2;
            this.gridATUserData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridATData_CellClick);
            this.gridATUserData.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.gridATData_ItemClick);
            // 
            // btnAll
            // 
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAll.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnAll.HoverBackColor = System.Drawing.Color.White;
            this.btnAll.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new Smobiler.Core.Padding(0F, 0F, 40F, 0F);
            this.btnAll.Size = new System.Drawing.Size(300, 35);
            this.btnAll.TabIndex = 3;
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
            this.checkAll.Location = new System.Drawing.Point(270, 8);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(20, 20);
            this.checkAll.TabIndex = 4;
            this.checkAll.UnCheckedBackColor = System.Drawing.Color.White;
            this.checkAll.CheckChanged += new Smobiler.Core.Controls.CheckdControlBase.CheckChangedEventHandler(this.checkAll_CheckChanged);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 35);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 5;
            // 
            // frmATUser
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridATUserData,
            this.btnAll,
            this.checkAll,
            this.line3});
            this.FooterBarLayout = "frmATFootLayout";
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "选择成员";
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmATUser_FooterBarLayoutItemClick);
            this.Load += new System.EventHandler(this.frmATUser_Load);
            this.TitleImageClick += new System.EventHandler(this.frmATUser_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmATUser_KeyDown);
            this.Name = "frmATUser";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridATUserData;
        private Smobiler.Core.Controls.Button btnAll;
        private Smobiler.Core.Controls.CheckBox checkAll;
        private Smobiler.Core.Controls.Line line3;
    }
}