using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostTempletDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostTempletDetail()
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
            this.lblFCheckers = new Smobiler.Core.Controls.Label();
            this.lblAEACheckers = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.lblCTempID = new Smobiler.Core.Controls.Label();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.line10 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.lblAEACheckers2 = new Smobiler.Core.Controls.Label();
            this.lblFCheckers2 = new Smobiler.Core.Controls.Label();
            // 
            // lblFCheckers
            // 
            this.lblFCheckers.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblFCheckers.BorderColor = System.Drawing.Color.LightGray;
            this.lblFCheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblFCheckers.Location = new System.Drawing.Point(0, 145);
            this.lblFCheckers.Name = "lblFCheckers";
            this.lblFCheckers.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblFCheckers.Size = new System.Drawing.Size(300, 35);
            this.lblFCheckers.TabIndex = 2;
            this.lblFCheckers.Text = "财务审批人";
            // 
            // lblAEACheckers
            // 
            this.lblAEACheckers.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblAEACheckers.BorderColor = System.Drawing.Color.LightGray;
            this.lblAEACheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAEACheckers.Location = new System.Drawing.Point(0, 100);
            this.lblAEACheckers.Name = "lblAEACheckers";
            this.lblAEACheckers.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblAEACheckers.Size = new System.Drawing.Size(300, 35);
            this.lblAEACheckers.TabIndex = 3;
            this.lblAEACheckers.Text = "行政审批人";
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "类型";
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "模板编号";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.BorderRadius = 2;
            this.btnEdit.FontSize = 17F;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnEdit.HoverForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(13, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(280, 35);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnEdit_Click);
            // 
            // lblCTempID
            // 
            this.lblCTempID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCTempID.FontSize = 12F;
            this.lblCTempID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblCTempID.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblCTempID.Location = new System.Drawing.Point(66, 10);
            this.lblCTempID.Name = "lblCTempID";
            this.lblCTempID.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblCTempID.Size = new System.Drawing.Size(234, 35);
            this.lblCTempID.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblType.FontSize = 12F;
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblType.Location = new System.Drawing.Point(66, 55);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblType.Size = new System.Drawing.Size(234, 35);
            this.lblType.TabIndex = 8;
            // 
            // line10
            // 
            this.line10.BackColor = System.Drawing.Color.LightGray;
            this.line10.Location = new System.Drawing.Point(0, 10);
            this.line10.Name = "line10";
            this.line10.Size = new System.Drawing.Size(300, 1);
            this.line10.TabIndex = 9;
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
            this.line2.Location = new System.Drawing.Point(0, 55);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 11;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 90);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 12;
            // 
            // lblAEACheckers2
            // 
            this.lblAEACheckers2.BorderColor = System.Drawing.Color.LightGray;
            this.lblAEACheckers2.Location = new System.Drawing.Point(0, 279);
            this.lblAEACheckers2.Name = "lblAEACheckers2";
            this.lblAEACheckers2.Size = new System.Drawing.Size(300, 55);
            this.lblAEACheckers2.TabIndex = 13;
            this.lblAEACheckers2.Visible = false;
            this.lblAEACheckers2.ZIndex = 6;
            // 
            // lblFCheckers2
            // 
            this.lblFCheckers2.BorderColor = System.Drawing.Color.LightGray;
            this.lblFCheckers2.Location = new System.Drawing.Point(0, 329);
            this.lblFCheckers2.Name = "lblFCheckers2";
            this.lblFCheckers2.Size = new System.Drawing.Size(300, 55);
            this.lblFCheckers2.TabIndex = 14;
            this.lblFCheckers2.Visible = false;
            this.lblFCheckers2.ZIndex = 10;
            // 
            // frmCostTempletDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblFCheckers,
            this.lblAEACheckers,
            this.label3,
            this.label1,
            this.btnEdit,
            this.lblCTempID,
            this.lblType,
            this.lblAEACheckers2,
            this.lblFCheckers2,
             this.line10,
            this.line1,
            this.line2,
            this.line3,
            });
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "成本中心类型模板";
            this.Load += new System.EventHandler(this.frmCostTempletDetail_Load);
            this.TitleImageClick += new System.EventHandler(this.frmCostTempletDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmCostTempletDetail_KeyDown);
            this.Name = "frmCostTempletDetail";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblFCheckers;
        internal Smobiler.Core.Controls.Label lblAEACheckers;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btnEdit;
        internal Smobiler.Core.Controls.Label lblCTempID;
        internal Smobiler.Core.Controls.Label lblType;
        private Smobiler.Core.Controls.Line line10;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Label lblAEACheckers2;
        private Smobiler.Core.Controls.Label lblFCheckers2;

    }
}