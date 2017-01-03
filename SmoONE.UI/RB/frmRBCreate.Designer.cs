using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRBCreate : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBCreate()
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
            this.btnRBCC = new Smobiler.Core.Controls.Button();
            this.btnRBCC1 = new Smobiler.Core.Controls.Button();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.TxtNote = new Smobiler.Core.Controls.TextBox();
            this.gridRBRowData = new Smobiler.Core.Controls.GridView();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            // 
            // Label4
            // 
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 10);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "成本中心";
            // 
            // btnRBCC
            // 
            this.btnRBCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRBCC.FontSize = 12F;
            this.btnRBCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBCC.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnRBCC.HoverBackColor = System.Drawing.Color.White;
            this.btnRBCC.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBCC.Location = new System.Drawing.Point(88, 10);
            this.btnRBCC.Name = "btnRBCC";
            this.btnRBCC.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnRBCC.Size = new System.Drawing.Size(188, 35);
            this.btnRBCC.TabIndex = 3;
            this.btnRBCC.Text = "选择（必填）";
            this.btnRBCC.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBCC_Click);
            // 
            // btnRBCC1
            // 
            this.btnRBCC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRBCC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBCC1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnRBCC1.HoverBackColor = System.Drawing.Color.White;
            this.btnRBCC1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBCC1.Location = new System.Drawing.Point(276, 10);
            this.btnRBCC1.Name = "btnRBCC1";
            this.btnRBCC1.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnRBCC1.Size = new System.Drawing.Size(25, 35);
            this.btnRBCC1.TabIndex = 4;
            this.btnRBCC1.Text = ">";
            this.btnRBCC1.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnRBCC_Click);
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblNote.Location = new System.Drawing.Point(0, 55);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(4F, 5F, 0F, 0F);
            this.lblNote.Size = new System.Drawing.Size(88, 100);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "报销备注";
            this.lblNote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // TxtNote
            // 
            this.TxtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.TxtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TxtNote.FontSize = 12F;
            this.TxtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.TxtNote.Location = new System.Drawing.Point(88, 55);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.TxtNote.Size = new System.Drawing.Size(213, 100);
            this.TxtNote.TabIndex = 6;
            this.TxtNote.WaterMarkText = "（选填）";
            // 
            // gridRBRowData
            // 
            this.gridRBRowData.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.gridRBRowData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridRBRowData.Layout = "frmRBCreateLayout";
            this.gridRBRowData.Location = new System.Drawing.Point(0, 165);
            this.gridRBRowData.Name = "gridRBRowData";
            this.gridRBRowData.ShowGridLines = false;
            this.gridRBRowData.Size = new System.Drawing.Size(300, 335);
            this.gridRBRowData.TabIndex = 7;
            this.gridRBRowData.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.gridRBRowData_CellClick);
            this.gridRBRowData.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.gridRBRowData_ItemClick);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 10);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 8;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 45);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 9;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 55);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 10;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 155);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 11;
            // 
            // frmRBCreate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.btnRBCC,
            this.btnRBCC1,
            this.lblNote,
            this.TxtNote,
            this.gridRBRowData,
            this.line1,
            this.line2,
            this.line3,
            this.line4});
            this.FooterBarLayout = "frmRBFootbarLayout";
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "报销创建";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmRBCreate_FooterBarLayoutItemClick);
            this.Load += new System.EventHandler(this.frmRBCreate_Load);
            this.TitleImageClick += new System.EventHandler(this.frmRBCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmRBCreate_KeyDown);
            this.Name = "frmRBCreate";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Button btnRBCC;
        internal Smobiler.Core.Controls.Button btnRBCC1;
        internal Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.TextBox TxtNote;
        internal Smobiler.Core.Controls.GridView gridRBRowData;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line4;
    }
}