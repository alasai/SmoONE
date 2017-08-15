using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.ComponentModel;

namespace SmoONE.UI.Layout
{
    [System.ComponentModel.ToolboxItem(true)]
     public partial class Title : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 标题内容
        /// </summary>
        [Browsable(true),Category("Appearance"),DefaultValue(""),Description("标题")]
        public string TitleText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;

            }
        }
        /// <summary>
        /// 标题字体大小
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("标题字体大小")]
        public float FontSize
        {
            get
            {
                return this.label1.FontSize;
            }
            set
            {
                this.label1.FontSize = value;

            }
        }
        /// <summary>
        /// 标题内容颜色
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("文本颜色")]
        public System.Drawing.Color ForeColr
        {
            get
            {
                return this.label1.ForeColor;
            }
            set
            {
                this.label1.ForeColor = value;

            }
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1_Press(object sender, EventArgs e)
        {
            this.Form.Close();
        }

      
    }
}