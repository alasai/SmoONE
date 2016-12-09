using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Utility
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  Submail的API库,帮助类
    // ******************************************************************
    /// <summary>
    /// 帮助类
    /// </summary>
    public class SignatureHelper
    {
        private IAppConfig _appConfig;
        public SignatureHelper(IAppConfig appConfig)
        {
            this._appConfig = appConfig;
        }

        /// <summary>
        /// Get signature based on sign type
        /// </summary>
        /// <param name="data">eg : key1=value1&key2=value2</param>
        /// <returns></returns>
        public string GetSignature(string data)
        {
            switch (_appConfig.SignType)
            {
                case SignType.normal:
                    {
                        return _appConfig.AppKey;
                    }
                case SignType.md5:
                    {
                        return GetMD5Signature(data);
                    }
                case SignType.sha1:
                    {
                        return GetSHA1Signature(data);
                    }
                default : 
                    return null;
            }
        }

        private string GetMD5Signature(string data)
        {
            string signStr = string.Format("{0}{1}{2}{3}{4}", _appConfig.AppId, _appConfig.AppKey, data, _appConfig.AppId, _appConfig.AppKey);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.GetEncoding("utf-8").GetBytes(signStr);
            byte[] targetData = md5.ComputeHash(fromData);
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < targetData.Length; i++)
            {
                sBuilder.Append(targetData[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private string GetSHA1Signature(string data)
        {
            string signStr = string.Format("{0}{1}{2}{3}{4}", _appConfig.AppId, _appConfig.AppKey, data, _appConfig.AppId, _appConfig.AppKey);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] fromData = Encoding.GetEncoding("utf-8").GetBytes(signStr);
            byte[] targetData = sha1.ComputeHash(fromData);
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < targetData.Length; i++)
            {
                sBuilder.Append(targetData[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
