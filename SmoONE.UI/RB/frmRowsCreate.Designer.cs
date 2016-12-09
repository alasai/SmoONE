using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRowsCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRowsCreate()
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
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.delete = new Smobiler.Core.Controls.ToolbarItem();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtMoney = new Smobiler.Core.Controls.TextBox();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.btnRBType = new Smobiler.Core.Controls.Button();
            this.btnRBType1 = new Smobiler.Core.Controls.Button();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.DatePicker = new Smobiler.Core.Controls.DatePicker();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.btnRBModel = new Smobiler.Core.Controls.Button();
            this.btnRBModel1 = new Smobiler.Core.Controls.Button();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            this.line7 = new Smobiler.Core.Controls.Line();
            this.line8 = new Smobiler.Core.Controls.Line();
            this.line9 = new Smobiler.Core.Controls.Line();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            // 
            // save
            // 
            this.save.IconID = "!\\ue161043146223";
            this.save.Name = "save";
            this.save.Text = "提交";
            this.save.Visible = false;
            // 
            // delete
            // 
            this.delete.IconID = "!\\ue888043146223";
            this.delete.Name = "delete";
            this.delete.Text = "删除";
            this.delete.Visible = false;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 55);
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
            this.txtMoney.Location = new System.Drawing.Point(88, 55);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.txtMoney.Size = new System.Drawing.Size(168, 35);
            this.txtMoney.TabIndex = 3;
            this.txtMoney.WaterMarkText = "0.00";
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.FontSize = 12F;
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label1.Location = new System.Drawing.Point(255, 55);
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
            this.Label5.Location = new System.Drawing.Point(0, 100);
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
            this.btnRBType.Location = new System.Drawing.Point(88, 100);
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
            this.btnRBType1.Location = new System.Drawing.Point(275, 100);
            this.btnRBType1.Name = "btnRBType1";
            this.btnRBType1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnRBType1.Size = new System.Drawing.Size(25, 35);
            this.btnRBType1.TabIndex = 7;
            this.btnRBType1.Text = ">";
            this.btnRBType1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBType_Click);
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 135);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(88, 35);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "消费日期";
            // 
            // DatePicker
            // 
            this.DatePicker.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.DatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DatePicker.FontSize = 12F;
            this.DatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.DatePicker.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.DatePicker.Location = new System.Drawing.Point(88, 135);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.DatePicker.Size = new System.Drawing.Size(213, 35);
            this.DatePicker.TabIndex = 9;
            // 
            // Label3
            // 
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 180);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(4F, 5F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(88, 100);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "备注";
            this.Label3.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.FontSize = 12F;
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNote.Location = new System.Drawing.Point(88, 180);
            this.txtNote.MaxLength = 200;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.txtNote.Size = new System.Drawing.Size(213, 100);
            this.txtNote.TabIndex = 11;
            this.txtNote.WaterMarkText = "（必填）";
            // 
            // Label6
            // 
            this.Label6.BackColorAlpha = 0;
            this.Label6.FontSize = 13F;
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(1, 280);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.Label6.Size = new System.Drawing.Size(300, 25);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "备注长度不能超过200！";
            // 
            // Label7
            // 
            this.Label7.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label7.Location = new System.Drawing.Point(0, 10);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(88, 35);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "消费模板";
            // 
            // btnRBModel
            // 
            this.btnRBModel.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnRBModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRBModel.FontSize = 12F;
            this.btnRBModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBModel.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnRBModel.HoverBackColor = System.Drawing.Color.White;
            this.btnRBModel.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBModel.Location = new System.Drawing.Point(87, 10);
            this.btnRBModel.Name = "btnRBModel";
            this.btnRBModel.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnRBModel.Size = new System.Drawing.Size(188, 35);
            this.btnRBModel.TabIndex = 14;
            this.btnRBModel.Text = "选择（选填）";
            this.btnRBModel.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBModel_Click);
            // 
            // btnRBModel1
            // 
            this.btnRBModel1.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnRBModel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRBModel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBModel1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnRBModel1.HoverBackColor = System.Drawing.Color.White;
            this.btnRBModel1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBModel1.Location = new System.Drawing.Point(275, 10);
            this.btnRBModel1.Name = "btnRBModel1";
            this.btnRBModel1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnRBModel1.Size = new System.Drawing.Size(25, 35);
            this.btnRBModel1.TabIndex = 15;
            this.btnRBModel1.Text = ">";
            this.btnRBModel1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBModel_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 10);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 16;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 45);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 17;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 55);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 18;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 90);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 19;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 100);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 20;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(0, 170);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 1);
            this.line6.TabIndex = 21;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.LightGray;
            this.line7.Location = new System.Drawing.Point(0, 135);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(300, 1);
            this.line7.TabIndex = 22;
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.Color.LightGray;
            this.line8.Location = new System.Drawing.Point(0, 180);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(300, 1);
            this.line8.TabIndex = 23;
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.LightGray;
            this.line9.Location = new System.Drawing.Point(0, 280);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(300, 1);
            this.line9.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 2;
            this.btnSave.FontSize = 17F;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(209)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 35);
            this.btnSave.TabIndex = 25;
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
            this.btnDelete.Location = new System.Drawing.Point(156, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 35);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnDelete_Click);
            // 
            // frmRowsCreate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.txtMoney,
            this.Label1,
            this.Label5,
            this.btnRBType,
            this.btnRBType1,
            this.Label2,
            this.DatePicker,
            this.Label3,
            this.txtNote,
            this.Label6,
            this.Label7,
            this.btnRBModel,
            this.btnRBModel1,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line6,
            this.line7,
            this.line8,
            this.line9,
            this.btnSave,
            this.btnDelete});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "添加消费记录";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save,
            this.delete});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmConsumption_Load);
            this.TitleImageClick += new System.EventHandler(this.frmConsumption_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmConsumption_KeyDown);
            this.Name = "frmRowsCreate";

        }
        #endregion

        internal Smobiler.Core.Controls.ToolbarItem save;
        internal Smobiler.Core.Controls.ToolbarItem delete;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtMoney;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Button btnRBType;
        internal Smobiler.Core.Controls.Button btnRBType1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.DatePicker DatePicker;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Button btnRBModel;
        internal Smobiler.Core.Controls.Button btnRBModel1;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
        private Smobiler.Core.Controls.Line line7;
        private Smobiler.Core.Controls.Line line8;
        private Smobiler.Core.Controls.Line line9;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Button btnDelete;
    }
}