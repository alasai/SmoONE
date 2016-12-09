using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  Submail的API库,语音验证类
    // ******************************************************************
    /// <summary>
    /// 语音验证类
    /// </summary>
    public class VoiceVerify : SendBase
    {
        public const string TO = "to";
        public const string CODE = "code";

        public VoiceVerify(IAppConfig appConfig) : base(appConfig)
        {
        }

        public void AddTo(string address)
        {
            this._dataPair.Add(TO, address);
        }

        public void SetCode(string code)
        {
            this._dataPair.Add(CODE, code);
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public bool Verify (out string returnMessage)
        {
            return this.GetSender().VoiceVerify(_dataPair, out returnMessage);
        }
    }
}
