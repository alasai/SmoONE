using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.Work
{
    partial class frmWork : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.iconMenuData = new Smobiler.Core.Controls.IconMenuView();
            this.plTabBar = new Smobiler.Core.Controls.Panel();
            this.plShenPi = new Smobiler.Core.Controls.Panel();
            this.imgbtnShenPi = new Smobiler.Core.Controls.ImageButton();
            this.plFaQi = new Smobiler.Core.Controls.Panel();
            this.image3 = new Smobiler.Core.Controls.Image();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.plChaoSong = new Smobiler.Core.Controls.Panel();
            this.image4 = new Smobiler.Core.Controls.Image();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.weiXin1 = new Smobiler.Core.Controls.Native.WeiXin();
            // 
            // title1
            // 
            this.title1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.title1.ResourceID = "list-ul";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.Text = "工作";
            this.title1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            this.toolBar1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.toolBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            toolBarItem1.IconID = "work2";
            toolBarItem1.Name = "Work";
            toolBarItem1.SelectIconID = "work2";
            toolBarItem2.IconID = "me";
            toolBarItem2.Name = "Me";
            toolBarItem2.SelectIconID = "me";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2});
            this.toolBar1.Location = new System.Drawing.Point(91, 373);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.iconMenuData,
            this.plTabBar});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Location = new System.Drawing.Point(74, 112);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(100, 30);
            // 
            // iconMenuData
            // 
            this.iconMenuData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.iconMenuData.Location = new System.Drawing.Point(0, 70);
            this.iconMenuData.MenuItemHeight = 75;
            this.iconMenuData.Name = "iconMenuData";
            this.iconMenuData.Size = new System.Drawing.Size(300, 300);
            this.iconMenuData.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuData_ItemPress);
            // 
            // plTabBar
            // 
            this.plTabBar.BackColor = System.Drawing.Color.White;
            this.plTabBar.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plShenPi,
            this.plFaQi,
            this.plChaoSong});
            this.plTabBar.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plTabBar.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plTabBar.Name = "plTabBar";
            this.plTabBar.Size = new System.Drawing.Size(300, 60);
            // 
            // plShenPi
            // 
            this.plShenPi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plShenPi.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgbtnShenPi});
            this.plShenPi.Flex = 1;
            this.plShenPi.Name = "plShenPi";
            this.plShenPi.Size = new System.Drawing.Size(0, 0);
            this.plShenPi.Touchable = true;
            this.plShenPi.Press += new System.EventHandler(this.plShenPi_Press);
            // 
            // imgbtnShenPi
            // 
            this.imgbtnShenPi.DataMember = null;
            this.imgbtnShenPi.DisplayFormat = null;
            this.imgbtnShenPi.DisplayMember = null;
            this.imgbtnShenPi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.imgbtnShenPi.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.imgbtnShenPi.ImgTextRatio = new Smobiler.Core.Controls.Ratio(3, 7);
            this.imgbtnShenPi.Location = new System.Drawing.Point(5, 15);
            this.imgbtnShenPi.Name = "imgbtnShenPi";
            this.imgbtnShenPi.ResourceID = "shenpi";
            this.imgbtnShenPi.Size = new System.Drawing.Size(90, 30);
            this.imgbtnShenPi.Text = "待我审批";
            this.imgbtnShenPi.Press += new System.EventHandler(this.plShenPi_Press);
            // 
            // plFaQi
            // 
            this.plFaQi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plFaQi.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image3,
            this.label2});
            this.plFaQi.Flex = 1;
            this.plFaQi.Name = "plFaQi";
            this.plFaQi.Size = new System.Drawing.Size(0, 0);
            this.plFaQi.Touchable = true;
            this.plFaQi.Press += new System.EventHandler(this.plFaQi_Press);
            // 
            // image3
            // 
            this.image3.Location = new System.Drawing.Point(5, 17);
            this.image3.Name = "image3";
            this.image3.ResourceID = "wofaqi";
            this.image3.Size = new System.Drawing.Size(20, 25);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 34);
            this.label2.Text = "我发起的";
            // 
            // plChaoSong
            // 
            this.plChaoSong.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image4,
            this.label3});
            this.plChaoSong.Flex = 1;
            this.plChaoSong.Name = "plChaoSong";
            this.plChaoSong.Size = new System.Drawing.Size(0, 0);
            this.plChaoSong.Touchable = true;
            this.plChaoSong.Press += new System.EventHandler(this.plChaoSong_Press);
            // 
            // image4
            // 
            this.image4.Location = new System.Drawing.Point(5, 17);
            this.image4.Name = "image4";
            this.image4.ResourceID = "chaosong";
            this.image4.Size = new System.Drawing.Size(20, 25);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(25, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 34);
            this.label3.Text = "抄送我的";
            // 
            // weiXin1
            // 
            this.weiXin1.Name = "weiXin1";
            // 
            // frmWork
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.weiXin1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.toolBar1,
            this.spContent});
            this.DrawerName = "SmoONE.UI.Layout.LeftPage";
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmWork_KeyDown);
            this.Load += new System.EventHandler(this.frmWork_Load);
            this.Name = "frmWork";

        }
        #endregion
        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.IconMenuView iconMenuData;
        private Smobiler.Core.Controls.Panel plTabBar;
        private Smobiler.Core.Controls.Panel plShenPi;
        private Smobiler.Core.Controls.Panel plFaQi;
        private Smobiler.Core.Controls.Image image3;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Panel plChaoSong;
        private Smobiler.Core.Controls.Image image4;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.ImageButton imgbtnShenPi;
        private Smobiler.Core.Controls.Native.WeiXin weiXin1;
    }
}