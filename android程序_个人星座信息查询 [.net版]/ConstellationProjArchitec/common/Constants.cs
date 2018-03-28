using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstellationProjArchitec.common
{
    public class Constants
    {
        #region 各星座url

        /// <summary>
        /// 射手座头像url
        /// </summary>
        public static readonly string SagittariusIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/sagittarius_b.gif";

        /// <summary>
        /// 射手座链接url
        /// </summary>
        public static readonly string SagittariusUrl = "http://vip.astro.sina.com.cn/astro/view/sagittarius/day/";


        /// <summary>
        /// 白羊座头像url
        /// </summary>
        public static readonly string ariesIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/aries_b.gif";

        /// <summary>
        /// 白羊座链接url
        /// </summary>
        public static readonly string ariesUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/aries/day/";

        /// <summary>
        /// 金牛座头像url
        /// </summary>
        public static readonly string taurusIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/taurus_b.gif";

        /// <summary>
        /// 金牛座链接url
        /// </summary>
        public static readonly string taurusUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/taurus/day/";


        /// <summary>
        /// 双子座头像url
        /// </summary>
        public static readonly string geminiIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/gemini_b.gif";

        /// <summary>
        /// 双子座链接url
        /// </summary>
        public static readonly string geminiUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/gemini/day/";

        /// <summary>
        /// 巨蟹座头像url
        /// </summary>
        public static readonly string cancerIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/cancer_b.gif";

        /// <summary>
        /// 巨蟹座链接url
        /// </summary>
        public static readonly string cancerUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/cancer/day/";


        /// 狮子座头像url
        /// </summary>
        public static readonly string leoIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/leo_b.gif";

        /// <summary>
        /// 狮子座链接url
        /// </summary>
        public static readonly string leoUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/leo/day/";


        /// 处女座头像url
        /// </summary>
        public static readonly string virgoIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/virgo_b.gif";

        /// <summary>
        /// 处女座链接url
        /// </summary>
        public static readonly string virgoUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/virgo/day/";


        /// 天秤座头像url
        /// </summary>
        public static readonly string libraIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/libra_b.gif";

        /// <summary>
        /// 天秤座链接url
        /// </summary>
        public static readonly string libraUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/libra/day/";

        /// 天蝎座头像url
        /// </summary>
        public static readonly string scorpioIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/scorpio_b.gif";

        /// <summary>
        /// 天蝎座链接url
        /// </summary>
        public static readonly string scorpioUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/scorpio/day/";


        /// 魔羯座头像url
        /// </summary>
        public static readonly string capricornIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/capricorn_b.gif";

        /// <summary>
        /// 魔羯座链接url
        /// </summary>
        public static readonly string capricornUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/capricorn/day/";

        /// 水瓶座头像url
        /// </summary>
        public static readonly string aquariusIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/aquarius_b.gif";

        /// <summary>
        /// 水瓶座链接url
        /// </summary>
        public static readonly string aquariusUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/aquarius/day/";

        /// 双鱼座头像url
        /// </summary>
        public static readonly string piscesIcon = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/pisces_b.gif";

        /// <summary>
        /// 双鱼座链接url
        /// </summary>
        public static readonly string piscesUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/pisces/day/";


        /*  //sina 12星座链接
        "http://vip.astro.sina.com.cn/iframe/astro/view/aries/day/"; //白羊座
        "http://vip.astro.sina.com.cn/iframe/astro/view/taurus/day/"; //金牛座
        "http://vip.astro.sina.com.cn/iframe/astro/view/gemini/day/"; //双子座
        "http://vip.astro.sina.com.cn/iframe/astro/view/cancer/day/"; //巨蟹座
        "http://vip.astro.sina.com.cn/iframe/astro/view/leo/day/"; //狮子座
        "http://vip.astro.sina.com.cn/iframe/astro/view/virgo/day/"; //处女座
        "http://vip.astro.sina.com.cn/iframe/astro/view/libra/day/"; //天秤座
        "http://vip.astro.sina.com.cn/iframe/astro/view/scorpio/day/"; //天蝎座
        "http://vip.astro.sina.com.cn/iframe/astro/view/sagittarius/day/"; //射手座
        "http://vip.astro.sina.com.cn/iframe/astro/view/capricorn/day/"; //魔羯座
        "http://vip.astro.sina.com.cn/iframe/astro/view/aquarius/day/"; //水瓶座
        "http://vip.astro.sina.com.cn/iframe/astro/view/pisces/day/"; //双鱼座
         */

        #endregion

        #region 各项xpath:sina星座信息解析XPath[依赖于web页面具体html结构][http://vip.astro.sina.com.cn ]

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

        #endregion
    }
}
