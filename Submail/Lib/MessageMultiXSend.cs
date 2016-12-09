using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    // 主要内容：  Submail的API库,消息多发的类
    // ******************************************************************
    /// <summary>
    /// 消息多发的类
    /// </summary>
    public class MessageMultiXSend : SendBase
    {
        public const string PROJECT = "project";
        public const string MULTI = "multi";
      
        public MessageMultiXSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void SetProject(string project)
        {
            this._dataPair.Add(PROJECT, project);
        }

        public void SetMulti(List<MultiMessageItem> multiItems)
        {
            this._dataPair.Add(MULTI, JsonConvert.SerializeObject(multiItems));
        }

        public bool MultiXSend(out string returnMessage)
        {
            return this.GetSender().MultiXSend(_dataPair, out returnMessage);
        }
    }

    public class MultiMessageItem
    {
        public MultiMessageItem()
        {
            vars = new Dictionary<string, string>();
        }

        public string to { get; set; }

        public Dictionary<string, string> vars { get; set; }
    }
}
