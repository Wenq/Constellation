using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using android程序_个人星座信息查询_DotNet版.Model;
using System.IO;
using HtmlAgilityPack;
using android程序_个人星座信息查询_DotNet版.globle;

namespace android程序_个人星座信息查询_DotNet版.BLL
{
    /// <summary>
    /// sina星座html文本解析器
    /// </summary>
    public class ConstellationParser
    {
        /// <summary>
        /// 通过html文档进行解析
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public Constellation Analysis(string html)
        {
            //HtmlWeb htmlWeb = new HtmlWeb();
            //HtmlDocument htmlDoc = htmlWeb.Load(ConsellationConstant.SagittariusUrl);
            //HtmlDocument htmlDoc = new HtmlDocument();

            //return Analysis(htmlDoc);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 通过网络Uri进行解析
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Constellation Analysis(Uri url)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDoc = htmlWeb.Load(url.ToString());   //使用HtmlAgilityPack库解析，不需要单独设定编码。如utf-8

            return Analysis(htmlDoc);
        }

        private Constellation Analysis(HtmlDocument htmlDoc)
        {
            //解析星座名称
            string consName = GetXPathStr(htmlDoc, ConsellationXPath.consNameXPath);
            //星座所在日期段
            string consDateRange = GetXPathStr(htmlDoc, ConsellationXPath.consDateRangeXPath);
            //解析星座综合运势
            int consSumLuck = GetXPathCount(htmlDoc, ConsellationXPath.consSumLuckXPath);
            //解析星座工作状况
            int consWorkLuck = GetXPathCount(htmlDoc, ConsellationXPath.consWorkLuckXPath);
            //解析星座健康指数
            string consHealthCoefficient = GetXPathStr(htmlDoc, ConsellationXPath.consHealthCoefficientXPath);
            //解析星座幸运颜色
            string consLuckyColor = GetXPathStr(htmlDoc, ConsellationXPath.consLuckyColorXPath);
            //解析星座速配星座
            string consSpeedDatingCons = GetXPathStr(htmlDoc, ConsellationXPath.consSpeedDatingConsXPath);
            //解析星座爱情运势
            int consLoveLuck = GetXPathCount(htmlDoc, ConsellationXPath.consLoveLuckXPath);
            //解析星座理财投资
            int consInvestLuck = GetXPathCount(htmlDoc, ConsellationXPath.consInvestLuckXPath); ;
            //解析星座商谈指数
            string consConferCoefficient = GetXPathStr(htmlDoc, ConsellationXPath.consConferCoefficientXPath);
            //解析星座幸运数字
            string consLuckNum = GetXPathStr(htmlDoc, ConsellationXPath.consLuckNumXPath);
            //综合评述
            string consEvaluation = GetXPathStr(htmlDoc, ConsellationXPath.consEvaluationXPath);

            Constellation cons = new Constellation();
            cons.ConsConferCoefficient = consConferCoefficient;
            cons.ConsDateRage = consDateRange;
            cons.ConsEvaluation = consEvaluation;
            cons.ConsHealthCoefficient = consHealthCoefficient;
            cons.ConsInvestLuck = consInvestLuck;
            cons.ConsLoveLuck = consLoveLuck;
            cons.ConsLuckNum = consLuckNum;
            cons.ConsLuckyColor = consLuckyColor;
            cons.ConsName = consName;
            cons.ConsSpeedDatingCons = consSpeedDatingCons;
            cons.ConsWorkLuck = consWorkLuck;
            cons.ConsSumLuck = consSumLuck;

            return cons;
        }

        /// <summary>
        /// 结果文本方式
        /// </summary>
        /// <param name="htmlDoc"></param>
        /// <param name="xpath"></param>
        /// <returns></returns>
        private string GetXPathStr(HtmlDocument htmlDoc, string xpath)
        {
            string result = string.Empty;
            try
            {
                HtmlNodeCollection lst = htmlDoc.DocumentNode.SelectNodes(xpath);
                foreach (HtmlNode item in lst)
                {
                    result += item.InnerText + " "; //可能有多个并列结果
                }
            }
            catch
            {
                result = "error";
            }

            return result;
        }

        /// <summary>
        /// 结果数量统计方式
        /// </summary>
        /// <param name="htmlDoc"></param>
        /// <param name="xpath"></param>
        /// <returns></returns>
        private int GetXPathCount(HtmlDocument htmlDoc, string xpath)
        {
            int i = 0;
            try
            {
                HtmlNodeCollection lst = htmlDoc.DocumentNode.SelectNodes(xpath);
                foreach (HtmlNode item in lst)
                {
                    i++;
                }
            }
            catch
            {
                i = -1;
            }

            return i;
        }

    }
}
