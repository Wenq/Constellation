/**********************************************************
 *作者：WQ  
 *时间：2013/1/14 23:18:15   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：adc24e44-ccd0-49e3-9eeb-931157a36eb5  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace android程序_个人星座信息查询_DotNet版.Common
{
    /// <summary>
    /// 通用工具类
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// 获取html页面编码方式通过Html文档
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string GetHtmlEncoding(string html)
        {
            string encod = Encoding.UTF8.ToString();


            return encod;
        }

        /// <summary>
        /// 获取html页面编码方式通过网络uri
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string GetHtmlEncoding(Uri uri)
        {
            string encod = Encoding.UTF8.ToString();


            return encod;
        }
    }
}
