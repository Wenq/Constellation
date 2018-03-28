using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using android程序_个人星座信息查询_DotNet版.globle;
using System.Net;
using System.IO;

namespace HtmlAgilityPack.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Encoding PageEncoding = Encoding.GetEncoding("gb2312");

            ////download html
            //WebClient client = new WebClient();
            //client.Encoding = PageEncoding;
            //byte[] imgs = client.DownloadData(ConsellationConstant.SagittariusUrl);
            //MemoryStream ms = new MemoryStream(imgs.Length);
            //ms.Write(imgs, 0, imgs.Length);

            //if (ms != null)
            //{
            //    //analysis html
            //    HtmlDocument doc = new HtmlDocument();
            //    doc.Load(ms, PageEncoding);

            //    richTextBox1.Text = doc.DocumentNode.Name;
            //}
            //else
            //    MessageBox.Show("Exception: GetRequestStream");



            //*************************************************测试解析库*******************************************

            //HtmlWeb htmlWeb = new HtmlWeb();
            //HtmlDocument htmlDoc = htmlWeb.Load(@"http://www.cnblogs.com/");
            //HtmlNodeCollection anchors = htmlDoc.DocumentNode.SelectNodes(@"//a[@class='titlelnk']");  //获取cnblog主页推荐帖子标题
            //foreach (HtmlNode anchor in anchors)
            //    richTextBox1.Text = richTextBox1.Text + "/r/n" + anchor.InnerHtml;

            //*************************************************星座信息url******************************************

            string consNameXPath = @"//span[1]/child::text()";
            string consDescriptionXPath = @"//div[@class='lotconts']";
            string consDateRangeXPath = @"//span[1]/em[1]";
            string consEvaluateXPath = @"//div[@class='tab'][h4='综合运势']/p/img";
            string consWorkLuckXPath = @"//div[@class='tab'][h4='工作状况']/p/img";
            string consHealthCoefficientXPath = @"//div[@class='tab'][h4='健康指数']/p/child::text()";  // @"//div[@class='tab']/p[1]/child::text()";
            string consLuckyColorXPath = @"//div[@class='tab'][h4='幸运颜色']/p/child::text()";
            string consSpeedDatingConsXPath = @"//div[@class='tab'][h4='速配星座']/p/child::text()";
            string consLoveLuckXPath = @"//div[@class='tab'][h4='爱情运势']/p/img";
            string consInvestLuckXPath = @"//div[@class='tab'][h4='理财投资']/p/img";
            string consConferCoefficientXPath = @"//div[@class='tab'][h4='商谈指数']/p/child::text()";
            string consLuckNumXPath = @"//div[@class='tab'][h4='幸运数字']/p/child::text()";


            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDoc = htmlWeb.Load(ConsellationConstant.SagittariusUrl);

            ShowDataStr(htmlDoc, consNameXPath, "星座名称:");

            ShowDataStr(htmlDoc, consDescriptionXPath, "综合评述:");

            ShowDataStr(htmlDoc, consDateRangeXPath, "星座所在日期段:");

            ShowDataCount(htmlDoc, consEvaluateXPath, "综合运势:");

            ShowDataCount(htmlDoc, consWorkLuckXPath, "工作状况:");

            ShowDataStr(htmlDoc, consHealthCoefficientXPath, "健康指数:");

            ShowDataStr(htmlDoc, consLuckyColorXPath, "幸运颜色:");

            ShowDataStr(htmlDoc, consSpeedDatingConsXPath, "速配星座:");

            ShowDataCount(htmlDoc, consLoveLuckXPath, "爱情运势:");

            ShowDataCount(htmlDoc, consInvestLuckXPath, "投资理财:");

            ShowDataStr(htmlDoc, consConferCoefficientXPath, "商谈指数:");

            ShowDataStr(htmlDoc, consLuckNumXPath, "幸运数字:");



        }

        /// <summary>
        /// 结果文本方式显示
        /// </summary>
        /// <param name="htmlDoc"></param>
        /// <param name="xpath"></param>
        /// <param name="propertyName"></param>
        private void ShowDataStr(HtmlDocument htmlDoc, string xpath, string propertyName)
        {
            try
            {
                HtmlNodeCollection lst = htmlDoc.DocumentNode.SelectNodes(xpath);
                foreach (HtmlNode item in lst)
                {
                    listBox1.Items.Add("/*******/ " + propertyName + " " + item.InnerText);
                }
                listBox1.Items.Add("/*******/ ");
            }
            catch (Exception e)
            {
                listBox1.Items.Add("error: " + e.Message);
            }
        }

        /// <summary>
        /// 结果数量统计方式显示
        /// </summary>
        /// <param name="htmlDoc"></param>
        /// <param name="xpath"></param>
        /// <param name="propertyName"></param>
        private void ShowDataCount(HtmlDocument htmlDoc, string xpath, string propertyName)
        {
            try
            {
                int i = 0;
                HtmlNodeCollection lst = htmlDoc.DocumentNode.SelectNodes(xpath);
                foreach (HtmlNode item in lst)
                {
                    i++;
                }
                listBox1.Items.Add("/*******/ " + propertyName + " " + i.ToString());
                listBox1.Items.Add("/*******/ ");
            }
            catch (Exception e)
            {
                listBox1.Items.Add("error: " + e.Message);
            }
        }
    }
}
