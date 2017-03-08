using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmATStatisticsDayLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmATStatisticsDayLayout()
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
            this.lblUser = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.proAl = new Smobiler.Core.Controls.Progress();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.proLate = new Smobiler.Core.Controls.Progress();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.proEarly = new Smobiler.Core.Controls.Progress();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.proNo = new Smobiler.Core.Controls.Progress();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.lblAbsenteeism = new Smobiler.Core.Controls.Label();
            // 
            // lblUser
            // 
            this.lblUser.AutoVisibleInLayout = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblUser.DataMember = "U_ID";
            this.lblUser.DisplayMember = "Total";
            this.lblUser.FontSize = 12F;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblUser.Size = new System.Drawing.Size(200, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.ZIndex = 3;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(0, 20);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(66, 30);
            this.label9.TabIndex = 3;
            this.label9.Text = "准时";
            this.label9.ZIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoVisibleInLayout = true;
            this.label1.DataMember = "Al";
            this.label1.DisplayMember = "Al";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "0次";
            this.label1.ZIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoVisibleInLayout = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(270, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(30, 145);
            this.label2.TabIndex = 5;
            this.label2.Text = ">";
            this.label2.ZIndex = 3;
            // 
            // proAl
            // 
            this.proAl.DataMember = "ProAl";
            this.proAl.DisplayMember = "ProAl";
            this.proAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(187)))), ((int)(((byte)(91)))));
            this.proAl.Location = new System.Drawing.Point(10, 50);
            this.proAl.Name = "proAl";
            this.proAl.Size = new System.Drawing.Size(260, 5);
            this.proAl.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoVisibleInLayout = true;
            this.label4.DataMember = "Late";
            this.label4.DisplayMember = "Late";
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(66, 55);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.label4.Size = new System.Drawing.Size(204, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "0次";
            this.label4.ZIndex = 3;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, 55);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "迟到";
            this.label5.ZIndex = 1;
            // 
            // proLate
            // 
            this.proLate.DataMember = "ProLate";
            this.proLate.DisplayMember = "ProLate";
            this.proLate.ForeColor = System.Drawing.Color.Yellow;
            this.proLate.Location = new System.Drawing.Point(10, 85);
            this.proLate.Name = "proLate";
            this.proLate.Size = new System.Drawing.Size(260, 5);
            this.proLate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(0, 90);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(66, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "早退";
            this.label7.ZIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoVisibleInLayout = true;
            this.label8.DataMember = "Early";
            this.label8.DisplayMember = "Early";
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label8.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label8.Location = new System.Drawing.Point(66, 90);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.label8.Size = new System.Drawing.Size(204, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "0次";
            this.label8.ZIndex = 3;
            // 
            // proEarly
            // 
            this.proEarly.DataMember = "ProEarly";
            this.proEarly.DisplayMember = "ProEarly";
            this.proEarly.ForeColor = System.Drawing.Color.Orange;
            this.proEarly.Location = new System.Drawing.Point(10, 120);
            this.proEarly.Name = "proEarly";
            this.proEarly.Size = new System.Drawing.Size(260, 5);
            this.proEarly.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label10.Location = new System.Drawing.Point(0, 125);
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.label10.Size = new System.Drawing.Size(66, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "未签";
            this.label10.ZIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoVisibleInLayout = true;
            this.label11.DataMember = "No";
            this.label11.DisplayMember = "No";
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label11.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.label11.Location = new System.Drawing.Point(66, 125);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.label11.Size = new System.Drawing.Size(204, 30);
            this.label11.TabIndex = 16;
            this.label11.Text = "0次";
            this.label11.ZIndex = 3;
            // 
            // proNo
            // 
            this.proNo.DataMember = "ProNo";
            this.proNo.DisplayMember = "ProNo";
            this.proNo.ForeColor = System.Drawing.Color.Red;
            this.proNo.Location = new System.Drawing.Point(10, 155);
            this.proNo.Name = "proNo";
            this.proNo.Size = new System.Drawing.Size(260, 5);
            this.proNo.TabIndex = 18;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 165);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 19;
            // 
            // lblAbsenteeism
            // 
            this.lblAbsenteeism.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblAbsenteeism.DataMember = "ISAbsenteeism";
            this.lblAbsenteeism.DisplayMember = "Absenteeism";
            this.lblAbsenteeism.FontSize = 12F;
            this.lblAbsenteeism.ForeColor = System.Drawing.Color.Red;
            this.lblAbsenteeism.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblAbsenteeism.Location = new System.Drawing.Point(200, 0);
            this.lblAbsenteeism.Name = "lblAbsenteeism";
            this.lblAbsenteeism.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.lblAbsenteeism.Size = new System.Drawing.Size(100, 20);
            this.lblAbsenteeism.TabIndex = 20;
            this.lblAbsenteeism.ZIndex = 3;
            // 
            // frmATStatisticsDayLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.proAl,
            this.proLate,
            this.proEarly,
            this.proNo,
            this.line1,
            this.label9,
            this.label5,
            this.label7,
            this.label10,
            this.lblUser,
            this.label1,
            this.label2,
            this.label4,
            this.label8,
            this.label11,
            this.lblAbsenteeism});
            this.Size = new System.Drawing.Size(300, 165);
            this.Name = "frmATStatisticsDayLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblUser;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Progress proAl;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Progress proLate;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Progress proEarly;
        internal Smobiler.Core.Controls.Label label10;
        internal Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.Progress proNo;
        private Smobiler.Core.Controls.Line line1;
        internal Smobiler.Core.Controls.Label lblAbsenteeism;
    }
}