using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmCheck : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCheck()
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
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem1 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem2 = new Smobiler.Core.Controls.TextTabBarItem();
            this.gridCheckData = new Smobiler.Core.Controls.GridView();
            this.textTabBar1 = new Smobiler.Core.Controls.TextTabBar();
            this.imgbtnSearch = new Smobiler.Core.Controls.ImageButton();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            this.line9 = new Smobiler.Core.Controls.Line();
            // 
            // gridCheckData
            // 
            this.gridCheckData.AllowSlip = true;
            this.gridCheckData.Layout = "frmLeaveLayout";
            this.gridCheckData.Location = new System.Drawing.Point(0, 75);
            this.gridCheckData.Name = "gridCheckData";
            this.gridCheckData.PageSize = 8;
            this.gridCheckData.ShowGridLines = false;
            this.gridCheckData.Size = new System.Drawing.Size(300, 474);
            this.gridCheckData.TabIndex = 2;
            this.gridCheckData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridCheckData_CellClick);
            // 
            // textTabBar1
            // 
            this.textTabBar1.BackColor = System.Drawing.Color.White;
            this.textTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            textTabBarItem1.Text = "待我审批的";
            textTabBarItem1.Value = "0";
            textTabBarItem2.Text = "我已审批的";
            textTabBarItem2.Value = "1";
            this.textTabBar1.Items.AddRange(new Smobiler.Core.Controls.TextTabBarItem[] {
            textTabBarItem1,
            textTabBarItem2});
            this.textTabBar1.Location = new System.Drawing.Point(10, 0);
            this.textTabBar1.Name = "textTabBar1";
            this.textTabBar1.Size = new System.Drawing.Size(280, 35);
            this.textTabBar1.TabIndex = 3;
            this.textTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.textTabBar1_ItemClick);
            // 
            // imgbtnSearch
            // 
            this.imgbtnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.imgbtnSearch.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.imgbtnSearch.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.imgbtnSearch.Location = new System.Drawing.Point(250, 46);
            this.imgbtnSearch.Name = "imgbtnSearch";
            this.imgbtnSearch.ResourceID = "search";
            this.imgbtnSearch.Size = new System.Drawing.Size(40, 30);
            this.imgbtnSearch.TabIndex = 4;
            this.imgbtnSearch.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnSearch_Click);
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 76);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 5;
            // 
            // frmCheck
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridCheckData,
            this.textTabBar1,
            this.imgbtnSearch,
            this.line9});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "我审批的";
            this.Load += new System.EventHandler(this.frmCheck_Load);
            this.TitleImageClick += new System.EventHandler(this.frmCheck_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmCheck_KeyDown);
            this.Name = "frmCheck";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridCheckData;
        private Smobiler.Core.Controls.TextTabBar textTabBar1;
        private Smobiler.Core.Controls.ImageButton imgbtnSearch;
        private Smobiler.Core.Controls.PopList popList1;
        private Smobiler.Core.Controls.Line line9;
    }
}