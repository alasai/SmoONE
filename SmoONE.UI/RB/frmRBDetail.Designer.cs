using System;
using Smobiler.Core;
namespace SmoONE.UI.RB
{
    partial class frmRBDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBDetail()
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
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lblRBNO = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblRBCC = new Smobiler.Core.Controls.Label();
            this.lblnote1 = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.lblReason1 = new Smobiler.Core.Controls.Label();
            this.lblReason = new Smobiler.Core.Controls.Label();
            this.gridRBRowData = new Smobiler.Core.Controls.GridView();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblUserName = new Smobiler.Core.Controls.Label();
            this.lblRBState = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblCreateTime = new Smobiler.Core.Controls.Label();
            // 
            // Label8
            // 
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.FontSize = 13F;
            this.Label8.ForeColor = System.Drawing.Color.Gray;
            this.Label8.Location = new System.Drawing.Point(10, 67);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(55, 25);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "报销编号：";
            // 
            // lblRBNO
            // 
            this.lblRBNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBNO.FontSize = 13F;
            this.lblRBNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRBNO.Location = new System.Drawing.Point(71, 67);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Size = new System.Drawing.Size(219, 25);
            this.lblRBNO.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.FontSize = 13F;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new System.Drawing.Point(10, 117);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 25);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "成本中心：";
            // 
            // lblRBCC
            // 
            this.lblRBCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBCC.FontSize = 13F;
            this.lblRBCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRBCC.Format = "￥{0}";
            this.lblRBCC.Location = new System.Drawing.Point(71, 117);
            this.lblRBCC.Name = "lblRBCC";
            this.lblRBCC.Size = new System.Drawing.Size(219, 25);
            this.lblRBCC.TabIndex = 5;
            // 
            // lblnote1
            // 
            this.lblnote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblnote1.FontSize = 13F;
            this.lblnote1.ForeColor = System.Drawing.Color.Gray;
            this.lblnote1.Location = new System.Drawing.Point(10, 167);
            this.lblnote1.Name = "lblnote1";
            this.lblnote1.Size = new System.Drawing.Size(55, 25);
            this.lblnote1.TabIndex = 6;
            this.lblnote1.Text = "报销备注：";
            // 
            // lblnote
            // 
            this.lblnote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblnote.FontSize = 13F;
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblnote.Location = new System.Drawing.Point(71, 167);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(219, 25);
            this.lblnote.TabIndex = 7;
            // 
            // lblReason1
            // 
            this.lblReason1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblReason1.FontSize = 13F;
            this.lblReason1.ForeColor = System.Drawing.Color.Gray;
            this.lblReason1.Location = new System.Drawing.Point(10, 192);
            this.lblReason1.Name = "lblReason1";
            this.lblReason1.Padding = new Smobiler.Core.Padding(0F, 5F, 0F, 0F);
            this.lblReason1.Size = new System.Drawing.Size(55, 50);
            this.lblReason1.TabIndex = 10;
            this.lblReason1.Text = "拒绝理由：";
            this.lblReason1.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblReason
            // 
            this.lblReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblReason.FontSize = 13F;
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblReason.Location = new System.Drawing.Point(71, 192);
            this.lblReason.Name = "lblReason";
            this.lblReason.Padding = new Smobiler.Core.Padding(0F, 5F, 0F, 0F);
            this.lblReason.Size = new System.Drawing.Size(219, 50);
            this.lblReason.TabIndex = 11;
            this.lblReason.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // gridRBRowData
            // 
            this.gridRBRowData.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.gridRBRowData.BorderColor = System.Drawing.Color.LightGray;
            this.gridRBRowData.Layout = "frmRBROWLayout";
            this.gridRBRowData.Location = new System.Drawing.Point(0, 242);
            this.gridRBRowData.Name = "gridRBRowData";
            this.gridRBRowData.ShowGridLines = false;
            this.gridRBRowData.Size = new System.Drawing.Size(300, 199);
            this.gridRBRowData.TabIndex = 12;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(10, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(280, 1);
            this.line1.TabIndex = 24;
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.DataMember = "U_Portrait";
            this.imgPortrait.DisplayMember = "U_Portrait";
            this.imgPortrait.ID = "Tou";
            this.imgPortrait.Location = new System.Drawing.Point(10, 5);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "Tou";
            this.imgPortrait.Size = new System.Drawing.Size(55, 55);
            this.imgPortrait.TabIndex = 25;
            // 
            // lblUserName
            // 
            this.lblUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUserName.FontSize = 17F;
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblUserName.Location = new System.Drawing.Point(70, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(219, 29);
            this.lblUserName.TabIndex = 26;
            // 
            // lblRBState
            // 
            this.lblRBState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBState.FontSize = 14F;
            this.lblRBState.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRBState.Location = new System.Drawing.Point(70, 40);
            this.lblRBState.Name = "lblRBState";
            this.lblRBState.Size = new System.Drawing.Size(219, 19);
            this.lblRBState.TabIndex = 27;
            this.lblRBState.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.FontSize = 13F;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "总金额：";
            // 
            // lblAmount
            // 
            this.lblAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAmount.FontSize = 13F;
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAmount.Location = new System.Drawing.Point(71, 142);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(219, 25);
            this.lblAmount.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.FontSize = 13F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "创建时间：";
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCreateTime.FontSize = 13F;
            this.lblCreateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCreateTime.Location = new System.Drawing.Point(71, 92);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(219, 25);
            this.lblCreateTime.TabIndex = 31;
            // 
            // frmRBDetail
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label8,
            this.lblRBNO,
            this.Label2,
            this.lblRBCC,
            this.lblnote1,
            this.lblnote,
            this.lblReason1,
            this.lblReason,
            this.line1,
            this.imgPortrait,
            this.lblUserName,
            this.lblRBState,
            this.gridRBRowData,
            this.label1,
            this.lblAmount,
            this.label3,
            this.lblCreateTime});
            this.FooterBarLayout = "frmDetailFootbarLayout";
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "报销详情";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmRBDetail_FooterBarLayoutItemClick);
            this.FooterBarDialogLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmRBDetail_FooterBarDialogLayoutItemClick);
            this.Load += new System.EventHandler(this.frmRBDetail_Load);
            this.TitleImageClick += new System.EventHandler(this.frmRBDetail_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmRBDetail_KeyDown);
            this.Name = "frmRBDetail";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label lblRBNO;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblRBCC;
        internal Smobiler.Core.Controls.Label lblnote1;
        internal Smobiler.Core.Controls.Label lblnote;
        internal Smobiler.Core.Controls.Label lblReason1;
        internal Smobiler.Core.Controls.Label lblReason;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Image imgPortrait;
        internal Smobiler.Core.Controls.Label lblUserName;
        internal Smobiler.Core.Controls.Label lblRBState;
        internal Smobiler.Core.Controls.GridView gridRBRowData;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblAmount;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label lblCreateTime;
    }
}