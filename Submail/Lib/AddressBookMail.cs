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
    // 主要内容：  Submail的API库,邮件的地址簿类
    // ******************************************************************
    /// <summary>
    /// 邮件的地址薄类
    /// </summary>
    public class AddressBookMail : SendBase
    {
        private const string ADDRESS = "address";
        private const string TARGET = "target";

        public AddressBookMail(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Mail(_appConfig);
        }

        public void SetAddress(string address, string name)
        {
            _dataPair.Add(ADDRESS, string.Format("{0}<{1}>", name, address));
        }

        public void SetAddressBook(string target)
        {
            _dataPair.Add(TARGET, target);
        }

        public bool Subscribe(out string returnMessage)
        {
            return GetSender().Subscribe(_dataPair, out returnMessage);
        }

        public bool UnSubscribe(out string returnMessage)
        {
            return GetSender().UnSubscribe(_dataPair, out returnMessage);
        }
    }
}
