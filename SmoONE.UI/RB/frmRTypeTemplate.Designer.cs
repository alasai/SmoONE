using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRTypeTemplate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRTypeTemplate()
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
            this.gridRBModelData = new Smobiler.Core.Controls.GridView();
            this.Create = new Smobiler.Core.Controls.ToolbarItem();
            this.Delete = new Smobiler.Core.Controls.ToolbarItem();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            // 
            // gridRBModelData
            // 
            this.gridRBModelData.Layout = "frmRBModelLayout";
            this.gridRBModelData.Location = new System.Drawing.Point(0, 63);
            this.gridRBModelData.Name = "gridRBModelData";
            this.gridRBModelData.PageSize = 10;
            this.gridRBModelData.ShowGridLines = false;
            this.gridRBModelData.Size = new System.Drawing.Size(300, 437);
            this.gridRBModelData.TabIndex = 2;
            this.gridRBModelData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridRBModelData_CellClick);
            // 
            // Create
            // 
            this.Create.IconID = "!\\ue148043146223";
            this.Create.Name = "Create";
            this.Create.Text = "创建模板";
            this.Create.Visible = false;
            // 
            // Delete
            // 
            this.Delete.IconID = "!\\uf05c043146223";
            this.Delete.Name = "Delete";
            this.Delete.Text = "删除";
            this.Delete.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "创建消费模板";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblInfor.Location = new System.Drawing.Point(0, 180);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(300, 30);
            this.lblInfor.TabIndex = 5;
            this.lblInfor.Text = "当前暂无消费模板，请创建！";
            // 
            // frmRTypeTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridRBModelData,
            this.btnSave,
            this.lblInfor});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "消费模板列表";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.Create,
            this.Delete});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmConsModelList_Load);
            this.TitleImageClick += new System.EventHandler(this.frmConsModelList_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmConsModelList_KeyDown);
            this.Name = "frmRTypeTemplate";

        }
        #endregion

        internal Smobiler.Core.Controls.GridView gridRBModelData;
        internal Smobiler.Core.Controls.ToolbarItem Create;
        internal Smobiler.Core.Controls.ToolbarItem Delete;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Label lblInfor;
    }
}