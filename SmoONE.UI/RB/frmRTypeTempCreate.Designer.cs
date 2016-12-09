using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRTypeTempCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRTypeTempCreate()
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
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtMoney = new Smobiler.Core.Controls.TextBox();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.btnRBType = new Smobiler.Core.Controls.Button();
            this.btnRBType1 = new Smobiler.Core.Controls.Button();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 10);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "消费金额";
            // 
            // txtMoney
            // 
            this.txtMoney.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtMoney.FontSize = 12F;
            this.txtMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtMoney.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.txtMoney.InputType = Smobiler.Core.TextBoxInputType.Number;
            this.txtMoney.Location = new System.Drawing.Point(88, 10);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.txtMoney.Size = new System.Drawing.Size(168, 35);
            this.txtMoney.TabIndex = 3;
            this.txtMoney.WaterMarkText = "0.00";
            // 
            // Label1
            // 
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.FontSize = 12F;
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label1.Location = new System.Drawing.Point(255, 10);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.Label1.Size = new System.Drawing.Size(45, 35);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "元";
            // 
            // Label5
            // 
            this.Label5.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0, 55);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(88, 35);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "消费类别";
            // 
            // btnRBType
            // 
            this.btnRBType.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnRBType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRBType.FontSize = 12F;
            this.btnRBType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnRBType.HoverBackColor = System.Drawing.Color.White;
            this.btnRBType.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBType.Location = new System.Drawing.Point(88, 55);
            this.btnRBType.Name = "btnRBType";
            this.btnRBType.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnRBType.Size = new System.Drawing.Size(188, 35);
            this.btnRBType.TabIndex = 6;
            this.btnRBType.Text = "选择（必填）";
            this.btnRBType.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBType_Click);
            // 
            // btnRBType1
            // 
            this.btnRBType1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnRBType1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRBType1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBType1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnRBType1.HoverBackColor = System.Drawing.Color.White;
            this.btnRBType1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBType1.Location = new System.Drawing.Point(276, 55);
            this.btnRBType1.Name = "btnRBType1";
            this.btnRBType1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnRBType1.Size = new System.Drawing.Size(25, 35);
            this.btnRBType1.TabIndex = 7;
            this.btnRBType1.Text = ">";
            this.btnRBType1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBType_Click);
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 100);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(4F, 5F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(88, 100);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "备注";
            this.Label3.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.FontSize = 12F;
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNote.Location = new System.Drawing.Point(87, 100);
            this.txtNote.MaxLength = 200;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.txtNote.Size = new System.Drawing.Size(213, 100);
            this.txtNote.TabIndex = 9;
            this.txtNote.WaterMarkText = "请输入费用明细描述（必填）";
            // 
            // Label6
            // 
            this.Label6.BackColorAlpha = 0;
            this.Label6.FontSize = 13F;
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(0, 200);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.Label6.Size = new System.Drawing.Size(300, 25);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "备注长度不能超过200！";
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "保存";
            this.save.Visible = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 10);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 11;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 45);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 12;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 55);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 13;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 90);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 14;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 100);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 15;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(0, 200);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 1);
            this.line6.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "提交";
            this.btnSave.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnDelete.BorderRadius = 2;
            this.btnDelete.FontSize = 17F;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(151)))), ((int)(((byte)(34)))));
            this.btnDelete.HoverForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(156, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDelete_Click);
            // 
            // frmRTypeTempCreate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.txtMoney,
            this.Label1,
            this.Label5,
            this.btnRBType,
            this.btnRBType1,
            this.Label3,
            this.txtNote,
            this.Label6,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line6,
            this.btnSave,
            this.btnDelete});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "消费模板创建";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmConsModelCreate_Load);
            this.TitleImageClick += new System.EventHandler(this.frmConsModelCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmConsModelCreate_KeyDown);
            this.Name = "frmRTypeTempCreate";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtMoney;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Button btnRBType;
        internal Smobiler.Core.Controls.Button btnRBType1;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.ToolbarItem save;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Button btnDelete;
    }
}