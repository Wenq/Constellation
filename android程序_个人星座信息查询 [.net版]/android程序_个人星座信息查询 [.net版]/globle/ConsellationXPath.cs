/**********************************************************
 *作者：WQ  
 *时间：2013/1/23 2:07:50   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：5f40b3fa-2023-4031-985b-5ab81fa48c81  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace android程序_个人星座信息查询_DotNet版.globle
{
    /// <summary>
    /// sina星座信息解析XPath[依赖于web页面具体html结构][http://vip.astro.sina.com.cn ]
    /// </summary>
    public class ConsellationXPath
    {
        /// <summary>
        /// 星座名称
        /// </summary>
        public static string consNameXPath = @"//span[1]/child::text()";
        /// <summary>
        /// 综合评述
        /// </summary>
        public static string consEvaluationXPath = @"//div[@class='lotconts']";
        /// <summary>
        /// 星座所在日期段
        /// </summary>
        public static string consDateRangeXPath = @"//span[1]/em[1]";
        /// <summary>
        /// 综合运势
        /// </summary>
        public static string consSumLuckXPath = @"//div[@class='tab'][h4='综合运势']/p/img";
        /// <summary>
        /// 工作状况
        /// </summary>
        public static string consWorkLuckXPath = @"//div[@class='tab'][h4='工作状况']/p/img";
        /// <summary>
        /// 健康指数
        /// </summary>
        public static string consHealthCoefficientXPath = @"//div[@class='tab'][h4='健康指数']/p/child::text()";
        /// <summary>
        /// 幸运颜色
        /// </summary>
        public static string consLuckyColorXPath = @"//div[@class='tab'][h4='幸运颜色']/p/child::text()";
        /// <summary>
        /// 速配星座
        /// </summary>
        public static string consSpeedDatingConsXPath = @"//div[@class='tab'][h4='速配星座']/p/child::text()";
        /// <summary>
        /// 爱情运势
        /// </summary>
        public static string consLoveLuckXPath = @"//div[@class='tab'][h4='爱情运势']/p/img";
        /// <summary>
        /// 投资理财
        /// </summary>
        public static string consInvestLuckXPath = @"//div[@class='tab'][h4='理财投资']/p/img";
        /// <summary>
        /// 商谈指数
        /// </summary>
        public static string consConferCoefficientXPath = @"//div[@class='tab'][h4='商谈指数']/p/child::text()";
        /// <summary>
        /// 幸运数字
        /// </summary>
        public static string consLuckNumXPath = @"//div[@class='tab'][h4='幸运数字']/p/child::text()";
    }
}
