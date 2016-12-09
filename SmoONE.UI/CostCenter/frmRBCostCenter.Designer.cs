using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmRBCostCenter : Smobiler.Core.MobileForm
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
            this.gridCCData = new Smobiler.Core.Controls.GridView();
            this.imgbtnSearch = new Smobiler.Core.Controls.ImageButton();
            this.layoutDialog1 = new Smobiler.Core.Controls.LayoutDialog();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            this.line9 = new Smobiler.Core.Controls.Line();
            // 
            // gridCCData
            // 
            this.gridCCData.AllowSlip = true;
            this.gridCCData.Layout = "frmCostCenterLayout";
            this.gridCCData.Location = new System.Drawing.Point(0, 31);
            this.gridCCData.Name = "gridCCData";
            this.gridCCData.PageSize = 8;
            this.gridCCData.ShowGridLines = false;
            this.gridCCData.Size = new System.Drawing.Size(300, 445);
            this.gridCCData.TabIndex = 2;
            this.gridCCData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridCCData_CellClick);
            // 
            // imgbtnSearch
            // 
            this.imgbtnSearch.FontSize = 10F;
            this.imgbtnSearch.Location = new System.Drawing.Point(250, 0);
            this.imgbtnSearch.Name = "imgbtnSearch";
            this.imgbtnSearch.ResourceID = "search";
            this.imgbtnSearch.Size = new System.Drawing.Size(40, 30);
            this.imgbtnSearch.TabIndex = 3;
            this.imgbtnSearch.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnSearch_Click);
            // 
            // layoutDialog1
            // 
            this.layoutDialog1.Layout = "frmCCSearchLayout";
            this.layoutDialog1.Name = "layoutDialog1";
            this.layoutDialog1.ItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.layoutDialog1_ItemClick);
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 30);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 4;
            // 
            // frmRBCostCenter
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.layoutDialog1,
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridCCData,
            this.imgbtnSearch,
            this.line9});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "成本中心";
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.TitleImageClick += new System.EventHandler(this.frmRBCostCenter_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmRBCostCenter_KeyDown);
            this.Name = "frmRBCostCenter";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridCCData;
        private Smobiler.Core.Controls.ImageButton imgbtnSearch;
        private Smobiler.Core.Controls.LayoutDialog layoutDialog1;
        private Smobiler.Core.Controls.PopList popList1;
        private Smobiler.Core.Controls.Line line9;
    }
}