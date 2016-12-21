using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmWork : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmWork()
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
            Smobiler.Core.Controls.ImageTabBarItem imageTabBarItem1 = new Smobiler.Core.Controls.ImageTabBarItem();
            Smobiler.Core.Controls.ImageTabBarItem imageTabBarItem2 = new Smobiler.Core.Controls.ImageTabBarItem();
            Smobiler.Core.Controls.ImageTabBarItem imageTabBarItem3 = new Smobiler.Core.Controls.ImageTabBarItem();
            this.iconMenuData = new Smobiler.Core.Controls.IconMenuView();
            this.imageTabBar1 = new Smobiler.Core.Controls.ImageTabBar();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.Work = new Smobiler.Core.Controls.ToolbarItem();
            this.Me = new Smobiler.Core.Controls.ToolbarItem();
            this.line2 = new Smobiler.Core.Controls.Line();
            // 
            // iconMenuData
            // 
            this.iconMenuData.BorderColor = System.Drawing.Color.Gray;
            this.iconMenuData.ForeColor = System.Drawing.Color.Gray;
            this.iconMenuData.GridLines = true;
            this.iconMenuData.Location = new System.Drawing.Point(0, 90);
            this.iconMenuData.MenuItemHeight = 80F;
            this.iconMenuData.Name = "iconMenuData";
            this.iconMenuData.Size = new System.Drawing.Size(300, 275);
            this.iconMenuData.TabIndex = 2;
            this.iconMenuData.MenuItemClick += new Smobiler.Core.Controls.IconMenuItemClickHandler(this.iconMenuData_MenuItemClick);
            // 
            // imageTabBar1
            // 
            this.imageTabBar1.BackColor = System.Drawing.Color.White;
            this.imageTabBar1.ForeColor = System.Drawing.Color.Gray;
            imageTabBarItem1.ImageResourceID = "shenpi";
            imageTabBarItem1.SelectImageResourceID = "shenpi";
            imageTabBarItem1.Text = "待我审批";
            imageTabBarItem2.ImageResourceID = "wofaqi";
            imageTabBarItem2.SelectImageResourceID = "wofaqi";
            imageTabBarItem2.Text = "我发起的";
            imageTabBarItem3.ImageResourceID = "chaosong";
            imageTabBarItem3.SelectImageResourceID = "chaosong";
            imageTabBarItem3.Text = "抄送我的";
            this.imageTabBar1.Items.AddRange(new Smobiler.Core.Controls.ImageTabBarItem[] {
            imageTabBarItem1,
            imageTabBarItem2,
            imageTabBarItem3});
            this.imageTabBar1.Name = "imageTabBar1";
            this.imageTabBar1.SelectForeColor = System.Drawing.Color.Gray;
            this.imageTabBar1.Size = new System.Drawing.Size(300, 80);
            this.imageTabBar1.TabIndex = 3;
            this.imageTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.imageTabBar1_ItemClick);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.DarkGray;
            this.line1.Location = new System.Drawing.Point(0, 80);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 4;
            // 
            // Work
            // 
            this.Work.IconID = "work2";
            this.Work.Name = "Work";
            this.Work.SelectIconID = "work2";
            // 
            // Me
            // 
            this.Me.IconID = "me";
            this.Me.Name = "Me";
            this.Me.SelectIconID = "me";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.DarkGray;
            this.line2.Location = new System.Drawing.Point(0, 90);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 5;
            // 
            // frmWork
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.iconMenuData,
            this.imageTabBar1,
            this.line1,
            this.line2});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "工作";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.Work,
            this.Me});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.Select, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209))))), System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145))))));
            this.Load += new System.EventHandler(this.frmWork_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmWork_ToolbarItemClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmWork_KeyDown);
            this.Name = "frmWork";

        }
        #endregion

        private Smobiler.Core.Controls.IconMenuView iconMenuData;
        private Smobiler.Core.Controls.ImageTabBar imageTabBar1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.ToolbarItem Work;
        private Smobiler.Core.Controls.ToolbarItem Me;
        private Smobiler.Core.Controls.Line line2;
    }
}