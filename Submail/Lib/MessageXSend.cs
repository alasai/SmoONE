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
    // 主要内容：  Submail的API库,短信消息的发送
    // ******************************************************************
    /// <summary>
    /// 短信消息的发送
    /// </summary>
    public class MessageXSend : SendBase
    {
        public const string ADDRESSBOOK = "addressbook";
        public const string TO = "to";
        public const string PROJECT = "project";
        public const string VARS = "vars";
	    public const string LINKS = "links";

        /// <summary>
        /// 短信消息的发送
        /// </summary>
        public MessageXSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        /// <summary>
        /// 把号码(address)加入进来
        /// </summary>
        public void AddTo(string address)
        {
            this.AddWithComma(TO, address);
        }

        public void AddAddressBook(string addressbook)
        {
            this.AddWithComma(ADDRESSBOOK, addressbook);
        }

        /// <summary>
        /// 设置要使用的短信模板(project)
        /// </summary>
        public void SetProject(string project)
        {
            this._dataPair.Add(PROJECT, project);
        }

        /// <summary>
        /// 设置短信模板中对应key的对应值val
        /// </summary>
        public void AddVar(string key, string val)
        {
            this.AddWithJson(VARS, key, val);
        }

        public bool XSend(out string returnMessage)
        {
           return this.GetSender().XSend(_dataPair, out returnMessage);
        }
    }
}
