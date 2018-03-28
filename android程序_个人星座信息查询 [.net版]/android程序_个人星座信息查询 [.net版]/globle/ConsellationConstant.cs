/**********************************************************
 *作者：WQ  
 *时间：2012/12/27 1:04:35   
 *版权：2012-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：5a38f5c0-5a97-4ca9-b6e9-e0ae2b9a5c70  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace android程序_个人星座信息查询_DotNet版.globle
{
    /// <summary>
    /// 12星座URL信息
    /// </summary>
    public class ConsellationConstant
    {
        /// <summary>
        /// 射手座头像url
        /// </summary>
        public static readonly string SagittariusImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/sagittarius_b.gif";

        /// <summary>
        /// 射手座链接url
        /// </summary>
        public static readonly string SagittariusUrl = "http://vip.astro.sina.com.cn/astro/view/sagittarius/day/20121226";


        /// <summary>
        /// 白羊座头像url
        /// </summary>
        public static readonly string ariesImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/aries_b.gif";

        /// <summary>
        /// 白羊座链接url
        /// </summary>
        public static readonly string ariesUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/aries/day/";

        /// <summary>
        /// 金牛座头像url
        /// </summary>
        public static readonly string taurusImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/taurus_b.gif";

        /// <summary>
        /// 金牛座链接url
        /// </summary>
        public static readonly string taurusUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/taurus/day/";


        /// <summary>
        /// 双子座头像url
        /// </summary>
        public static readonly string geminiImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/gemini_b.gif";

        /// <summary>
        /// 双子座链接url
        /// </summary>
        public static readonly string geminiUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/gemini/day/";

        /// <summary>
        /// 巨蟹座头像url
        /// </summary>
        public static readonly string cancerImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/cancer_b.gif";

        /// <summary>
        /// 巨蟹座链接url
        /// </summary>
        public static readonly string cancerUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/cancer/day/";


        /// 狮子座头像url
        /// </summary>
        public static readonly string leoImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/leo_b.gif";

        /// <summary>
        /// 狮子座链接url
        /// </summary>
        public static readonly string leoUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/leo/day/";


        /// 处女座头像url
        /// </summary>
        public static readonly string virgoImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/virgo_b.gif";

        /// <summary>
        /// 处女座链接url
        /// </summary>
        public static readonly string virgoUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/virgo/day/";


        /// 天秤座头像url
        /// </summary>
        public static readonly string libraImg = "";

        /// <summary>
        /// 天秤座链接url
        /// </summary>
        public static readonly string libraUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/libra/day/";

        /// 天蝎座头像url
        /// </summary>
        public static readonly string scorpioImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/scorpio_b.gif";

        /// <summary>
        /// 天蝎座链接url
        /// </summary>
        public static readonly string scorpioUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/scorpio/day/";


        /// 魔羯座头像url
        /// </summary>
        public static readonly string capricornImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/capricorn_b.gif";

        /// <summary>
        /// 魔羯座链接url
        /// </summary>
        public static readonly string capricornUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/capricorn/day/";

        /// 水瓶座头像url
        /// </summary>
        public static readonly string aquariusImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/aquarius_b.gif";

        /// <summary>
        /// 水瓶座链接url
        /// </summary>
        public static readonly string aquariusUrl = "http://vip.astro.sina.com.cn/iframe/astro/view/aquarius/day/";

        /// 双鱼座头像url
        /// </summary>
        public static readonly string piscesImg = "http://image2.sina.com.cn/ast/2007index/tmp/star_php/pisces_b.gif";

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

    }
}
