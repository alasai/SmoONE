using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmCheckOrCCTo : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCheckOrCCTo()
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
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.gridUserData = new Smobiler.Core.Controls.GridView();
            // 
            // textBox1
            // 
            this.textBox1.BorderRadius = 2;
            this.textBox1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.textBox1.Location = new System.Drawing.Point(13, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.WaterMarkText = "搜索";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColorAlpha = 0;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "联系人";
            // 
            // gridUserData
            // 
            this.gridUserData.AutoHeight = true;
            this.gridUserData.Layout = "frmUserLayout";
            this.gridUserData.Location = new System.Drawing.Point(0, 65);
            this.gridUserData.Name = "gridUserData";
            this.gridUserData.PageSize = 8;
            this.gridUserData.ShowGridLines = false;
            this.gridUserData.Size = new System.Drawing.Size(300, 398);
            this.gridUserData.TabIndex = 4;
            this.gridUserData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridUserData_CellClick);
            // 
            // frmCheckOrCCTo
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textBox1,
            this.label1,
            this.gridUserData});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "联系人";
            this.Load += new System.EventHandler(this.frmCheckOrCCTo_Load);
            this.TitleImageClick += new System.EventHandler(this.frmCheckOrCCTo_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmCheckOrCCTo_KeyDown);
            this.Name = "frmCheckOrCCTo";

        }
        #endregion

        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.GridView gridUserData;
    }
}