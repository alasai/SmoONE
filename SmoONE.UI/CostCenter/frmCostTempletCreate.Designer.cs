using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostTempletCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostTempletCreate()
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
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnType1 = new Smobiler.Core.Controls.Button();
            this.lblAEACheckers = new Smobiler.Core.Controls.Label();
            this.lblFCheckers = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.lblAEACheckers1 = new Smobiler.Core.Controls.Label();
            this.lblFCheckers1 = new Smobiler.Core.Controls.Label();
            this.imgbtnAEACheckers = new Smobiler.Core.Controls.ImageButton();
            this.popType = new Smobiler.Core.Controls.PopList();
            this.imgbtnFCheckers = new Smobiler.Core.Controls.ImageButton();
            this.line10 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.lblAEACheckers2 = new Smobiler.Core.Controls.Label();
            this.lblFCheckers2 = new Smobiler.Core.Controls.Label();
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
            this.label3.Text = "类型";
            this.label3.ZIndex = 1;
            // 
            // btnType
            // 
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType.FontSize = 12F;
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnType.HoverBackColor = System.Drawing.Color.White;
            this.btnType.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.Location = new System.Drawing.Point(66, 10);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnType.Size = new System.Drawing.Size(209, 35);
            this.btnType.TabIndex = 3;
            this.btnType.Text = "选择（必填）";
            this.btnType.ZIndex = 2;
            this.btnType.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // btnType1
            // 
            this.btnType1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnType1.HoverBackColor = System.Drawing.Color.White;
            this.btnType1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType1.Location = new System.Drawing.Point(275, 10);
            this.btnType1.Name = "btnType1";
            this.btnType1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnType1.Size = new System.Drawing.Size(25, 35);
            this.btnType1.TabIndex = 4;
            this.btnType1.Text = ">";
            this.btnType1.ZIndex = 3;
            this.btnType1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype_Click);
            // 
            // lblAEACheckers
            // 
            this.lblAEACheckers.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblAEACheckers.BorderColor = System.Drawing.Color.LightGray;
            this.lblAEACheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAEACheckers.Location = new System.Drawing.Point(0, 55);
            this.lblAEACheckers.Name = "lblAEACheckers";
            this.lblAEACheckers.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblAEACheckers.Size = new System.Drawing.Size(75, 35);
            this.lblAEACheckers.TabIndex = 5;
            this.lblAEACheckers.Text = "行政审批人";
            this.lblAEACheckers.ZIndex = 4;
            // 
            // lblFCheckers
            // 
            this.lblFCheckers.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblFCheckers.BorderColor = System.Drawing.Color.LightGray;
            this.lblFCheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblFCheckers.Location = new System.Drawing.Point(0, 155);
            this.lblFCheckers.Name = "lblFCheckers";
            this.lblFCheckers.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.lblFCheckers.Size = new System.Drawing.Size(75, 35);
            this.lblFCheckers.TabIndex = 6;
            this.lblFCheckers.Text = "财务审批人";
            this.lblFCheckers.ZIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "提交";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnSave_Click);
            // 
            // lblAEACheckers1
            // 
            this.lblAEACheckers1.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblAEACheckers1.BorderColor = System.Drawing.Color.LightGray;
            this.lblAEACheckers1.ForeColor = System.Drawing.Color.Silver;
            this.lblAEACheckers1.Location = new System.Drawing.Point(75, 55);
            this.lblAEACheckers1.Name = "lblAEACheckers1";
            this.lblAEACheckers1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblAEACheckers1.Size = new System.Drawing.Size(225, 35);
            this.lblAEACheckers1.TabIndex = 8;
            this.lblAEACheckers1.Text = "（添加1-4位审批人，点击头像可删除）";
            this.lblAEACheckers1.ZIndex = 5;
            // 
            // lblFCheckers1
            // 
            this.lblFCheckers1.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.lblFCheckers1.BorderColor = System.Drawing.Color.LightGray;
            this.lblFCheckers1.ForeColor = System.Drawing.Color.Silver;
            this.lblFCheckers1.Location = new System.Drawing.Point(75, 155);
            this.lblFCheckers1.Name = "lblFCheckers1";
            this.lblFCheckers1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.lblFCheckers1.Size = new System.Drawing.Size(225, 35);
            this.lblFCheckers1.TabIndex = 9;
            this.lblFCheckers1.Text = "（添加1-4位审批人，点击头像可删除）";
            this.lblFCheckers1.ZIndex = 9;
            // 
            // imgbtnAEACheckers
            // 
            this.imgbtnAEACheckers.HoverBackColor = System.Drawing.Color.White;
            this.imgbtnAEACheckers.Location = new System.Drawing.Point(65, 90);
            this.imgbtnAEACheckers.Name = "imgbtnAEACheckers";
            this.imgbtnAEACheckers.ResourceID = "add";
            this.imgbtnAEACheckers.Size = new System.Drawing.Size(35, 35);
            this.imgbtnAEACheckers.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgbtnAEACheckers.TabIndex = 10;
            this.imgbtnAEACheckers.ZIndex = 7;
            this.imgbtnAEACheckers.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnAEACheckers_Click);
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // imgbtnFCheckers
            // 
            this.imgbtnFCheckers.HoverBackColor = System.Drawing.Color.White;
            this.imgbtnFCheckers.Location = new System.Drawing.Point(65, 190);
            this.imgbtnFCheckers.Name = "imgbtnFCheckers";
            this.imgbtnFCheckers.ResourceID = "add";
            this.imgbtnFCheckers.Size = new System.Drawing.Size(35, 35);
            this.imgbtnFCheckers.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgbtnFCheckers.TabIndex = 11;
            this.imgbtnFCheckers.ZIndex = 11;
            this.imgbtnFCheckers.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.imgbtnFCheckers_Click);
            // 
            // line10
            // 
            this.line10.BackColor = System.Drawing.Color.LightGray;
            this.line10.Location = new System.Drawing.Point(0, 10);
            this.line10.Name = "line10";
            this.line10.Size = new System.Drawing.Size(300, 1);
            this.line10.TabIndex = 12;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 13;
            // 
            // lblAEACheckers2
            // 
            this.lblAEACheckers2.BorderColor = System.Drawing.Color.LightGray;
            this.lblAEACheckers2.Location = new System.Drawing.Point(0, 90);
            this.lblAEACheckers2.Name = "lblAEACheckers2";
            this.lblAEACheckers2.Size = new System.Drawing.Size(300, 55);
            this.lblAEACheckers2.TabIndex = 14;
            this.lblAEACheckers2.ZIndex = 6;
            // 
            // lblFCheckers2
            // 
            this.lblFCheckers2.BorderColor = System.Drawing.Color.LightGray;
            this.lblFCheckers2.Location = new System.Drawing.Point(0, 190);
            this.lblFCheckers2.Name = "lblFCheckers2";
            this.lblFCheckers2.Size = new System.Drawing.Size(300, 55);
            this.lblFCheckers2.TabIndex = 15;
            this.lblFCheckers2.ZIndex = 10;
            // 
            // frmCostTempletCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.popType});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.label3,
            this.btnType,
            this.btnType1,
            this.lblAEACheckers,
            this.lblAEACheckers1,
            this.lblAEACheckers2,
            this.imgbtnAEACheckers,
            this.lblFCheckers,
            this.lblFCheckers1,
            this.lblFCheckers2,
            this.imgbtnFCheckers,
            this.line10,
            this.line1});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "成本中心类型模板";
            this.Load += new System.EventHandler(this.frmCostTempletCreate_Load);
            this.TitleImageClick += new System.EventHandler(this.frmCostTempletCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmCostTempletCreate_KeyDown);
            this.Name = "frmCostTempletCreate";

        }
        #endregion

        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Button btnType1;
        internal Smobiler.Core.Controls.Label lblAEACheckers;
        internal Smobiler.Core.Controls.Label lblFCheckers;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Label lblAEACheckers1;
        private Smobiler.Core.Controls.Label lblFCheckers1;
        private Smobiler.Core.Controls.ImageButton imgbtnAEACheckers;
        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.ImageButton imgbtnFCheckers;
        private Smobiler.Core.Controls.Line line10;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Label lblAEACheckers2;
        private Smobiler.Core.Controls.Label lblFCheckers2;
    }
}