using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.AppConfig
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  Submail的API库,语音应用的配置类
    // ******************************************************************
    /// <summary>
    /// 语音应用的配置类
    /// </summary>
    public class VoiceAppConfig :IAppConfig
    {
        public VoiceAppConfig(string appId, string appKey, SignType signType = SignType.normal)
        {
            this._appId = appId;
            this._appKey = appKey;
            this._signType = signType;
        }

        private string _appId;
        public string AppId
        {
            get
            {
                return _appId;
            }
            set
            {
                _appId = value;
            }
        }

        private string _appKey;
        public string AppKey
        {
            get
            {
                return _appKey;
            }
            set
            {
                _appKey = value;
            }
        }

        private SignType _signType;
        public SignType SignType
        {
            get
            {
                return _signType;
            }
            set
            {
                _signType = value;
            }
        }
    }
}
