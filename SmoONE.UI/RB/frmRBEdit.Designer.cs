using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRBEdit : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBEdit()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.lblRBNO = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.btnRBCC = new Smobiler.Core.Controls.Button();
            this.btnChoice = new Smobiler.Core.Controls.Button();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.TxtNote = new Smobiler.Core.Controls.TextBox();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.gridView2 = new Smobiler.Core.Controls.GridView();
            this.gridRBRowData = new Smobiler.Core.Controls.GridView();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Location = new System.Drawing.Point(0, 10);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(88, 35);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "报销编号";
            // 
            // lblRBNO
            // 
            this.lblRBNO.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.lblRBNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBNO.FontSize = 12F;
            this.lblRBNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblRBNO.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblRBNO.Location = new System.Drawing.Point(88, 10);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Padding = new Smobiler.Core.Padding(0F, 0F, 30F, 0F);
            this.lblRBNO.Size = new System.Drawing.Size(213, 35);
            this.lblRBNO.TabIndex = 3;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 55);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "成本中心";
            // 
            // btnRBCC
            // 
            this.btnRBCC.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnRBCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRBCC.FontSize = 12F;
            this.btnRBCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBCC.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnRBCC.Location = new System.Drawing.Point(88, 55);
            this.btnRBCC.Name = "btnRBCC";
            this.btnRBCC.Padding = new Smobiler.Core.Padding(0F, 0F, 5F, 0F);
            this.btnRBCC.Size = new System.Drawing.Size(188, 35);
            this.btnRBCC.TabIndex = 5;
            this.btnRBCC.Text = "选择（必填）";
            this.btnRBCC.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChioce_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnChoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnChoice.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnChoice.HoverBackColor = System.Drawing.Color.White;
            this.btnChoice.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnChoice.Location = new System.Drawing.Point(276, 55);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Padding = new Smobiler.Core.Padding(0F, 0F, 4F, 0F);
            this.btnChoice.Size = new System.Drawing.Size(25, 35);
            this.btnChoice.TabIndex = 6;
            this.btnChoice.Text = ">";
            this.btnChoice.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnChioce_Click);
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblNote.Location = new System.Drawing.Point(0, 100);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Padding(4F, 5F, 0F, 0F);
            this.lblNote.Size = new System.Drawing.Size(88, 100);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "报销备注";
            this.lblNote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // TxtNote
            // 
            this.TxtNote.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.TxtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TxtNote.FontSize = 12F;
            this.TxtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.TxtNote.Location = new System.Drawing.Point(87, 100);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Padding = new Smobiler.Core.Padding(0F, 5F, 30F, 0F);
            this.TxtNote.Size = new System.Drawing.Size(213, 100);
            this.TxtNote.TabIndex = 8;
            this.TxtNote.WaterMarkText = "（选填）";
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(0, 10);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 12;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 45);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 13;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 55);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 14;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(0, 90);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(300, 1);
            this.line4.TabIndex = 15;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(0, 100);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(300, 1);
            this.line5.TabIndex = 16;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(0, 200);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(300, 1);
            this.line6.TabIndex = 17;
            // 
            // GridView1
            // 
            this.GridView1.Layout = "";
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(200, 200);
            // 
            // gridView2
            // 
            this.gridView2.Layout = "";
            this.gridView2.Name = "gridView2";
            this.gridView2.Size = new System.Drawing.Size(200, 200);
            // 
            // gridRBRowData
            // 
            this.gridRBRowData.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.gridRBRowData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridRBRowData.Layout = "frmConsumption1Layout";
            this.gridRBRowData.Location = new System.Drawing.Point(0, 212);
            this.gridRBRowData.Name = "gridRBRowData";
            this.gridRBRowData.ShowGridLines = false;
            this.gridRBRowData.Size = new System.Drawing.Size(300, 288);
            this.gridRBRowData.TabIndex = 21;
            this.gridRBRowData.ZIndex = 1;
            this.gridRBRowData.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.gridRBRowData_ItemClick);
            // 
            // frmRBEdit
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lblRBNO,
            this.Label4,
            this.btnRBCC,
            this.btnChoice,
            this.lblNote,
            this.TxtNote,
            this.gridRBRowData,
            this.line3,
            this.line1,
            this.line2,
            this.line4,
            this.line5,
            this.line6,
            });
            this.FooterBarLayout = "frmRBFootbarLayout";
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "报销编辑";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmRBEdit_FooterBarLayoutItemClick);
            this.Load += new System.EventHandler(this.frmRBEdit_Load);
            this.TitleImageClick += new System.EventHandler(this.frmRBEdit_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmRBEdit_KeyDown);
            this.Name = "frmRBEdit";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lblRBNO;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Button btnRBCC;
        internal Smobiler.Core.Controls.Button btnChoice;
        internal Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.TextBox TxtNote;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line4;
        private Smobiler.Core.Controls.Line line5;
        private Smobiler.Core.Controls.Line line6;
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.GridView gridView2;
        internal Smobiler.Core.Controls.GridView gridRBRowData;
    }
}