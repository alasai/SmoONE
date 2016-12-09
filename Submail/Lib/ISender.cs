using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submail.Lib
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  Submail的API库,发送数据的接口
    // ******************************************************************
    /// <summary>
    /// 发送数据的接口
    /// </summary>
    public interface ISender
    {
        /**
	     * Send the request data.
	     * @param data {@link HashMap}contains the request data.Such as
	     * <p>
	     * to->xxx@submail.cn
	     * cc->nnn@submail.cn
	     * text->Hello,world!
	     * </p>
	     * @return If send successfully,return true.Error occurs,return false.
	     **/
        bool Send(Dictionary<string, object> data, out string returnMessage);

        bool XSend(Dictionary<string, object> data, out string returnMessage);

        bool MultiXSend(Dictionary<string, object> data, out string returnMessage);

        bool Subscribe(Dictionary<string, object> data, out string returnMessage);

        bool UnSubscribe(Dictionary<string, object> data, out string returnMessage);

        bool VoiceVerify(Dictionary<string, object> data, out string returnMessage);
    }
}
