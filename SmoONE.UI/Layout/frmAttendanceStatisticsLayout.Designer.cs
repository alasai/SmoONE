using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceStatisticsLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatisticsLayout()
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
            this.lblID = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.lbl3 = new Smobiler.Core.Controls.Label();
            this.lblTotal = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblLate = new Smobiler.Core.Controls.Label();
            this.label = new Smobiler.Core.Controls.Label();
            this.lblEarly = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblNo = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblAl = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // lblID
            // 
            this.lblID.DisplayMember = "Name";
            this.lblID.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.lblID.Location = new System.Drawing.Point(0, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Steven";
            this.lblID.ZIndex = 1;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 60);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 5;
            this.line1.ZIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl3.Location = new System.Drawing.Point(60, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(45, 30);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "应签到";
            // 
            // lblTotal
            // 
            this.lblTotal.DisplayMember = "Total";
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTotal.Location = new System.Drawing.Point(105, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblTotal.Size = new System.Drawing.Size(75, 30);
            this.lblTotal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "迟到";
            // 
            // lblLate
            // 
            this.lblLate.DisplayMember = "Late";
            this.lblLate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblLate.Location = new System.Drawing.Point(90, 30);
            this.lblLate.Name = "lblLate";
            this.lblLate.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblLate.Size = new System.Drawing.Size(50, 30);
            this.lblLate.TabIndex = 14;
            // 
            // label
            // 
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label.Location = new System.Drawing.Point(140, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(30, 30);
            this.label.TabIndex = 15;
            this.label.Text = "早退";
            // 
            // lblEarly
            // 
            this.lblEarly.DisplayMember = "Early";
            this.lblEarly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblEarly.Location = new System.Drawing.Point(170, 30);
            this.lblEarly.Name = "lblEarly";
            this.lblEarly.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblEarly.Size = new System.Drawing.Size(50, 30);
            this.lblEarly.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(220, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "未签";
            // 
            // lblNo
            // 
            this.lblNo.DisplayMember = "No";
            this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblNo.Location = new System.Drawing.Point(250, 30);
            this.lblNo.Name = "lblNo";
            this.lblNo.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblNo.Size = new System.Drawing.Size(50, 30);
            this.lblNo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(180, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "准时";
            // 
            // lblAl
            // 
            this.lblAl.DisplayMember = "Al";
            this.lblAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblAl.Location = new System.Drawing.Point(225, 0);
            this.lblAl.Name = "lblAl";
            this.lblAl.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.lblAl.Size = new System.Drawing.Size(75, 30);
            this.lblAl.TabIndex = 22;
            // 
            // image1
            // 
            this.image1.BorderRadius = 10;
            this.image1.DataMember = "ID";
            this.image1.DisplayMember = "Pict";
            this.image1.Location = new System.Drawing.Point(10, 10);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(30, 30);
            this.image1.TabIndex = 28;
            // 
            // frmAttendanceStatisticsLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lbl3,
            this.lblTotal,
            this.label1,
            this.lblLate,
            this.label,
            this.lblEarly,
            this.label3,
            this.lblNo,
            this.label2,
            this.lblAl,
            this.image1,
            this.lblID,
            this.line1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmAttendanceStatisticsLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblID;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Label lbl3;
        private Smobiler.Core.Controls.Label lblTotal;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblLate;
        private Smobiler.Core.Controls.Label label;
        private Smobiler.Core.Controls.Label lblEarly;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblNo;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblAl;
        private Smobiler.Core.Controls.Image image1;
    }
}