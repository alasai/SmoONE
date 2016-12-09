using System;
using Smobiler.Core;
namespace SmoONE.UI.Leave
{
    partial class frmLeaveDetail : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmLeaveDetail()
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
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.lblUserName = new Smobiler.Core.Controls.Label();
            this.lblStateNote = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblLId = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lblLType = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.lblStartDate = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.lblEndDate = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.lblReson = new Smobiler.Core.Controls.Label();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.nodeStateDate = new Smobiler.Core.Controls.NodeView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblLDay = new Smobiler.Core.Controls.Label();
            this.imgL = new Smobiler.Core.Controls.Image();
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.DataMember = "U_Portrait";
            this.imgPortrait.DisplayMember = "U_Portrait";
            this.imgPortrait.ID = "";
            this.imgPortrait.Location = new System.Drawing.Point(10, 5);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(55, 55);
            this.imgPortrait.TabIndex = 2;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(10, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(280, 1);
            this.line1.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUserName.FontSize = 17F;
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblUserName.Location = new System.Drawing.Point(71, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(219, 29);
            this.lblUserName.TabIndex = 4;
            // 
            // lblStateNote
            // 
            this.lblStateNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStateNote.FontSize = 14F;
            this.lblStateNote.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStateNote.Location = new System.Drawing.Point(71, 34);
            this.lblStateNote.Name = "lblStateNote";
            this.lblStateNote.Size = new System.Drawing.Size(219, 19);
            this.lblStateNote.TabIndex = 5;
            this.lblStateNote.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.FontSize = 13F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "请假编号：";
            // 
            // lblLId
            // 
            this.lblLId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLId.FontSize = 13F;
            this.lblLId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblLId.Location = new System.Drawing.Point(71, 67);
            this.lblLId.Name = "lblLId";
            this.lblLId.Size = new System.Drawing.Size(219, 25);
            this.lblLId.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.FontSize = 13F;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(10, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "请假类型：";
            // 
            // lblLType
            // 
            this.lblLType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLType.FontSize = 13F;
            this.lblLType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblLType.Location = new System.Drawing.Point(71, 92);
            this.lblLType.Name = "lblLType";
            this.lblLType.Size = new System.Drawing.Size(219, 25);
            this.lblLType.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label7.FontSize = 13F;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(10, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "开始时间：";
            // 
            // lblStartDate
            // 
            this.lblStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStartDate.FontSize = 13F;
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblStartDate.Location = new System.Drawing.Point(71, 117);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(219, 25);
            this.lblStartDate.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label9.FontSize = 13F;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(10, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "结束时间：";
            // 
            // lblEndDate
            // 
            this.lblEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEndDate.FontSize = 13F;
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblEndDate.Location = new System.Drawing.Point(71, 142);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(219, 25);
            this.lblEndDate.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label11.FontSize = 13F;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(10, 192);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Padding(0F, 5F, 0F, 0F);
            this.label11.Size = new System.Drawing.Size(55, 50);
            this.label11.TabIndex = 14;
            this.label11.Text = "请假事由：";
            this.label11.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // lblReson
            // 
            this.lblReson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblReson.FontSize = 13F;
            this.lblReson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblReson.Location = new System.Drawing.Point(71, 192);
            this.lblReson.Name = "lblReson";
            this.lblReson.Padding = new Smobiler.Core.Padding(0F, 5F, 0F, 0F);
            this.lblReson.Size = new System.Drawing.Size(219, 50);
            this.lblReson.TabIndex = 15;
            this.lblReson.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // label13
            // 
            this.label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label13.FontSize = 13F;
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(10, 242);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Padding(0F, 5F, 0F, 0F);
            this.label13.Size = new System.Drawing.Size(55, 50);
            this.label13.TabIndex = 16;
            this.label13.Text = "图片：";
            this.label13.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            // 
            // nodeStateDate
            // 
            this.nodeStateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.nodeStateDate.Border = new Smobiler.Core.Border(0, 1, 0, 0);
            this.nodeStateDate.BorderColor = System.Drawing.Color.LightGray;
            this.nodeStateDate.ItemBackColor = System.Drawing.Color.White;
            this.nodeStateDate.ItemDefaultIcon = "";
            this.nodeStateDate.Location = new System.Drawing.Point(0, 315);
            this.nodeStateDate.Name = "nodeStateDate";
            this.nodeStateDate.Size = new System.Drawing.Size(300, 185);
            this.nodeStateDate.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.FontSize = 13F;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "请假天数：";
            // 
            // lblLDay
            // 
            this.lblLDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLDay.FontSize = 13F;
            this.lblLDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblLDay.Location = new System.Drawing.Point(71, 167);
            this.lblLDay.Name = "lblLDay";
            this.lblLDay.Size = new System.Drawing.Size(219, 25);
            this.lblLDay.TabIndex = 19;
            // 
            // imgL
            // 
            this.imgL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgL.Enlarged = true;
            this.imgL.ID = "";
            this.imgL.Location = new System.Drawing.Point(71, 242);
            this.imgL.Name = "imgL";
            this.imgL.Size = new System.Drawing.Size(40, 50);
            this.imgL.SizeMode = Smobiler.Core.ImageSizeMode.StretchImage;
            this.imgL.TabIndex = 20;
            this.imgL.ZIndex = 13;
            // 
            // frmLeaveDetail
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblUserName,
            this.lblStateNote,
            this.label3,
            this.lblLId,
            this.label5,
            this.lblLType,
            this.label7,
            this.lblStartDate,
            this.label9,
            this.lblEndDate,
            this.label11,
            this.lblReson,
            this.label13,
            this.nodeStateDate,
            this.label1,
            this.lblLDay,
            this.line1,
            this.imgL});
            this.FooterBarLayout = "frmDetailFootbarLayout";
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("!\\ue5c4044044044", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))), Smobiler.Core.HorizontalAlignment.Left);
            this.TitleText = "请假";
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.Select, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.FooterBarLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmLeaveDetail_FooterBarLayoutItemClick);
            this.FooterBarDialogLayoutItemClick += new Smobiler.Core.MobileFormLayoutItemClickEventHandler(this.frmLeaveDetail_FooterBarDialogLayoutItemClick);
            this.Load += new System.EventHandler(this.frmLeaveDef_Load);
            this.TitleImageClick += new System.EventHandler(this.frmLeaveDef_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.frmLeaveDef_KeyDown);
            this.Name = "frmLeaveDetail";

        }
        #endregion

        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Line line1;
        internal Smobiler.Core.Controls.Label lblUserName;
        internal Smobiler.Core.Controls.Label lblStateNote;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label lblLId;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label lblLType;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Label lblStartDate;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label lblEndDate;
        internal Smobiler.Core.Controls.Label label11;
        internal Smobiler.Core.Controls.Label lblReson;
        internal Smobiler.Core.Controls.Label label13;
        private Smobiler.Core.Controls.NodeView nodeStateDate;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblLDay;
        internal Smobiler.Core.Controls.Image imgL;
    }
}