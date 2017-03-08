using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceManagerLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceManagerLayout()
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
            this.lblId = new Smobiler.Core.Controls.Label();
            this.lblATWorking = new Smobiler.Core.Controls.Label();
            this.lblWorkDate = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.lblAT = new Smobiler.Core.Controls.Label();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.lblWorkDate1 = new Smobiler.Core.Controls.Label();
            this.lblATEffective = new Smobiler.Core.Controls.Label();
            // 
            // lblId
            // 
            this.lblId.DataMember = "AT_ID";
            this.lblId.DisplayMember = "AT_Name";
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblId.Location = new System.Drawing.Point(0, 10);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new Smobiler.Core.Padding(10F, 0F, 0F, 0F);
            this.lblId.Size = new System.Drawing.Size(257, 40);
            this.lblId.TabIndex = 2;
            this.lblId.ZIndex = 1;
            // 
            // lblATWorking
            // 
            this.lblATWorking.DataMember = "AT_CommutingType";
            this.lblATWorking.DisplayMember = "AT_WeeklyWorkingDay";
            this.lblATWorking.FontSize = 12F;
            this.lblATWorking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblATWorking.Location = new System.Drawing.Point(0, 50);
            this.lblATWorking.Name = "lblATWorking";
            this.lblATWorking.Padding = new Smobiler.Core.Padding(10F, 0F, 10F, 0F);
            this.lblATWorking.Size = new System.Drawing.Size(300, 20);
            this.lblATWorking.TabIndex = 3;
            this.lblATWorking.ZIndex = 3;
            // 
            // lblWorkDate
            // 
            this.lblWorkDate.DataMember = "WorkDate";
            this.lblWorkDate.DisplayMember = "WorkDate";
            this.lblWorkDate.FontSize = 12F;
            this.lblWorkDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblWorkDate.Location = new System.Drawing.Point(0, 70);
            this.lblWorkDate.Name = "lblWorkDate";
            this.lblWorkDate.Padding = new Smobiler.Core.Padding(10F, 0F, 10F, 0F);
            this.lblWorkDate.Size = new System.Drawing.Size(300, 20);
            this.lblWorkDate.TabIndex = 4;
            this.lblWorkDate.ZIndex = 3;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightGray;
            this.line1.Location = new System.Drawing.Point(0, 140);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 5;
            this.line1.ZIndex = 3;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightGray;
            this.line2.Location = new System.Drawing.Point(0, 10);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 6;
            this.line2.ZIndex = 3;
            // 
            // lblAT
            // 
            this.lblAT.FontSize = 20F;
            this.lblAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblAT.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblAT.Location = new System.Drawing.Point(257, 10);
            this.lblAT.Name = "lblAT";
            this.lblAT.Padding = new Smobiler.Core.Padding(0F, 0F, 10F, 0F);
            this.lblAT.Size = new System.Drawing.Size(43, 40);
            this.lblAT.TabIndex = 7;
            this.lblAT.Text = ">";
            this.lblAT.ZIndex = 1;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightGray;
            this.line3.Location = new System.Drawing.Point(10, 50);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(290, 1);
            this.line3.TabIndex = 8;
            this.line3.ZIndex = 3;
            // 
            // lblWorkDate1
            // 
            this.lblWorkDate1.AutoVisibleInLayout = true;
            this.lblWorkDate1.DataMember = "WorkDate1";
            this.lblWorkDate1.DisplayMember = "WorkDate1";
            this.lblWorkDate1.FontSize = 12F;
            this.lblWorkDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblWorkDate1.Location = new System.Drawing.Point(0, 90);
            this.lblWorkDate1.Name = "lblWorkDate1";
            this.lblWorkDate1.Padding = new Smobiler.Core.Padding(10F, 0F, 10F, 0F);
            this.lblWorkDate1.Size = new System.Drawing.Size(300, 20);
            this.lblWorkDate1.TabIndex = 9;
            this.lblWorkDate1.ZIndex = 3;
            // 
            // lblATEffective
            // 
            this.lblATEffective.AutoVisibleInLayout = true;
            this.lblATEffective.BorderColor = System.Drawing.Color.LightGray;
            this.lblATEffective.DataMember = "AT_EffectiveDate";
            this.lblATEffective.DisplayMember = "AT_EffectiveDesc";
            this.lblATEffective.ForeColor = System.Drawing.Color.Orange;
            this.lblATEffective.Location = new System.Drawing.Point(0, 110);
            this.lblATEffective.Name = "lblATEffective";
            this.lblATEffective.Padding = new Smobiler.Core.Padding(10F, 0F, 10F, 0F);
            this.lblATEffective.Size = new System.Drawing.Size(300, 30);
            this.lblATEffective.TabIndex = 10;
            this.lblATEffective.ZIndex = 1;
            // 
            // frmAttendanceManagerLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblId,
            this.lblAT,
            this.lblATWorking,
            this.lblWorkDate,
            this.line1,
            this.line2,
            this.line3,
            this.lblWorkDate1,
            this.lblATEffective});
            this.Size = new System.Drawing.Size(300, 140);
            this.Name = "frmAttendanceManagerLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblId;
        internal Smobiler.Core.Controls.Label lblATWorking;
        internal Smobiler.Core.Controls.Label lblWorkDate;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        internal Smobiler.Core.Controls.Label lblAT;
        private Smobiler.Core.Controls.Line line3;
        internal Smobiler.Core.Controls.Label lblWorkDate1;
        internal Smobiler.Core.Controls.Label lblATEffective;
    }
}