using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.ComponentModel;
using System.Drawing;

namespace SmoONE.UI.UserControl
{
    [ToolboxItem(true), DefaultEvent("Press")]
    partial class ImageButton : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 图像资源名称
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("图像资源名称")]
        public string ResourceID
        {
            get
            {
                return this.imageEx1.ResourceID;
            }
            set
            {
                this.imageEx1.ResourceID = value;
            }
        }
        /// <summary>
        /// 图片宽高
        /// </summary>
        [Browsable(true), Category("布局"), DefaultValue(""), Description("设置图片的宽度和高度")]
        public Size iamgeSize
        {
            get
            {
                return this.imageEx1.Size;
            }
            set
            {
                this.panel1.Size = value;
                this.imageEx1.Size = value;
            }
        }
        /// <summary>
        /// 图像类型
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("图像类型")]
        public ImageEx.ImageStyle ImageType
        {
            get
            {
                return this.imageEx1.ImageType;
            }
            set
            {
                this.imageEx1.ImageType = value;
            }
        }
    }
}