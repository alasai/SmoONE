using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submail.AppConfig
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  Submail的API库,这个是应用配置的接口
    // ******************************************************************
    /// <summary>
    /// 应用配置的接口
    /// </summary>
    public interface IAppConfig
    {
        string AppId { get; set; }

        string AppKey { get; set; }

        SignType SignType { get; set; }
    }

    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  Submail的API库,这个是枚举类型
    // ******************************************************************
    /// <summary>
    /// 枚举类型
    /// </summary>
    public enum SignType
    {
        normal,
        md5,
        sha1
    }
}
