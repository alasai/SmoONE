using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Core.Controls.Native;

namespace SmoONE.UI.Attendance
{
    partial class frmATGPSEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        //经度
        public float Longitude;
        //纬度
        public float Latitude;
        public string addressInfo;
         #endregion

        /// <summary>
        /// 地点微调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mapView1_TagClick(object sender, MapViewTagClickEventArgs e)
        {
            if ((!e.Tag.Longitude.Equals(Longitude)) & (!e.Tag.Latitude.Equals(Latitude)))
            {
                MessageBox.Show("是否确定更改地点？", "地点微调", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == Smobiler.Core.Controls.ShowResult.Yes)
                    {
                        Longitude = e.Tag.Longitude;
                        Latitude = e.Tag.Latitude;
                        addressInfo = e.Tag.Description;
                        ShowResult = ShowResult.Yes;
                        
                    }
                });
            }
        }
        /// <summary>
        /// 界面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSignGPSEdit_Load(object sender, EventArgs e)
        {
            mapTrimView1.Longitude = Longitude;
            mapTrimView1.Latitude = Latitude;
            mapTrimView1.Description = addressInfo;
        }
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSignGPSEdit_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
    }
}