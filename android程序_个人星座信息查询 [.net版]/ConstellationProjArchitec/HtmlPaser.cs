using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ConstellationProjArchitec.common;
using HtmlAgilityPack;

namespace ConstellationProjArchitec
{
    /// <summary>
    /// html解析器
    /// </summary>
    public class HtmlPaser : IDisposable
    {
        public HtmlPaser()
        {
            constellationUrl = null;
            iconUrl = null;
            htmlDoc = null;
            icon = null;
        }

        private Uri constellationUrl;
        private Uri iconUrl;

        private HtmlDocument htmlDoc;
        private Bitmap icon;

        /// <summary>
        /// 获取html页面特定内容
        /// </summary>
        /// <param name="xPath"></param>
        /// <returns></returns>
        public string AnalyseStr(string xPath)
        {
            //TODO: 解析库解析
            string result = string.Empty;
            try
            {
                HtmlNodeCollection lst = htmlDoc.DocumentNode.SelectNodes(xPath);
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
        /// 获取html页面特定内容
        /// </summary>
        /// <param name="xPath"></param>
        /// <returns></returns>
        public int AnalyseInt(string xPath)
        {
            //TODO: 解析库解析
            int result = 0;
            try
            {
                HtmlNodeCollection lst = htmlDoc.DocumentNode.SelectNodes(xPath);
                foreach (HtmlNode item in lst)
                {
                    result++;
                }
            }
            catch
            {
                result = -1;
            }

            return result;
        }

        /// <summary>
        /// 获取图标
        /// </summary>
        /// <returns></returns>
        public Bitmap GetIcon()
        {
            if (icon == null && iconUrl != null)
            {
                //TODO: 通过网络url获取图标
                icon = Utils.GetNewWorkBitmap(iconUrl.ToString());
            }

            return icon;
        }

        /// <summary>
        /// 初始化html相关对象
        /// </summary>
        public void InitHtml(Uri constellationUrl, Uri iconUrl)
        {
            this.constellationUrl = constellationUrl;
            this.iconUrl = iconUrl;

            if (constellationUrl != null)
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                htmlDoc = htmlWeb.Load(constellationUrl.ToString());   //使用HtmlAgilityPack库解析，不需要单独设定编码。如utf-8
            }
            InitHtmlObjEnd(null, EventArgs.Empty);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            htmlDoc = null;
            if (icon != null)
            {
                icon.Dispose();
                icon = null;
            }
        }

        /// <summary>
        /// 初始化html解析器完成事件
        /// </summary>
        public event EventHandler InitHtmlObjEndEvent;
        private void InitHtmlObjEnd(object sender, EventArgs e)
        {
            EventHandler handler = this.InitHtmlObjEndEvent;
            if (handler != null)
                handler(sender, e);
        }

    }
}
