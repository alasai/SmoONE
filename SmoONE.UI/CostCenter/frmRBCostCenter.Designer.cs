using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmRBCostCenter : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBCostCenter()
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
            this.gridCCData = new Smobiler.Core.Controls.ListView();
            this.imgbtnSearch = new SmoONE.UI.Layout.ImageButton();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // gridCCData
            // 
            this.gridCCData.Location = new System.Drawing.Point(0, 80);
            this.gridCCData.Name = "gridCCData";
            this.gridCCData.ShowSplitLine = true;
            this.gridCCData.Size = new System.Drawing.Size(300, 420);
            this.gridCCData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridCCData.TemplateControlName = "frmCostCenterLayout";
            // 
            // imgbtnSearch
            // 
            this.imgbtnSearch.FontSize = 13F;
            this.imgbtnSearch.ForeColor = System.Drawing.Color.Black;
            this.imgbtnSearch.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.imgbtnSearch.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imgbtnSearch.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.imgbtnSearch.Location = new System.Drawing.Point(260, 50);
            this.imgbtnSearch.Name = "imgbtnSearch";
            this.imgbtnSearch.ResourceID = "search";
            this.imgbtnSearch.Size = new System.Drawing.Size(40, 30);
            this.imgbtnSearch.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Zoom;
            this.imgbtnSearch.Press += new System.EventHandler(this.imgbtnSearch_Press);
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColr = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.title1.Location = new System.Drawing.Point(15, 25);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "成本中心";
            // 
            // frmRBCostCenter
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridCCData,
            this.imgbtnSearch,
            this.title1});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRBCostCenter_KeyDown);
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.Name = "frmRBCostCenter";

        }
        #endregion

        private Smobiler.Core.Controls.ListView gridCCData;
        private SmoONE.UI.Layout.ImageButton imgbtnSearch;
        public Smobiler.Core.Controls.PopList popList1;
        private Layout.Title title1;
    }
}