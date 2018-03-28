using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using android程序_个人星座信息查询_DotNet版.Model;
using System.Net;
using System.IO;
using System.Drawing;

namespace android程序_个人星座信息查询_DotNet版.BLL
{
    /// <summary>
    /// Constellation管理器
    /// </summary>
    public class ConstellationMgr
    {
        public ConstellationMgr()
        { }

        /// <summary>
        /// 使用webclient获取Constellation资料[方法一]
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Constellation GetConstellationByWebClient(string url)
        {
            string html = string.Empty;
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;      //webclient下载 中文会乱码 必须预先设定utf-8编码
            html = client.DownloadString(url);

            return new ConstellationParser().Analysis(html);
        }

        /// <summary>
        /// 使用WebRequest获取Constellation资料[方式二]
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Constellation GetConstellationByWebRequest(string url)
        {
            string html = string.Empty;
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            html = reader.ReadToEnd();
            reader.Close();
            responseStream.Close();

            return new ConstellationParser().Analysis(html);
        }

        /// <summary>
        /// 使用webclient获取星座头像
        /// </summary>
        /// <param name="imgUrl"></param>
        /// <returns></returns>
        public Bitmap GetConstellationImgByWebClient(string imgUrl)
        {
            Bitmap img;

            /* webclient 方法一*/
            WebClient client = new WebClient();
            byte[] imgs = client.DownloadData(imgUrl);
            MemoryStream ms = new MemoryStream(imgs.Length);
            ms.Write(imgs, 0, imgs.Length);
            img = new Bitmap(ms);

            return img;
        }

        /// <summary>
        /// 使用HtmlAgilityPack库获取Constellation资料[方式三]
        /// </summary>
        /// <param name="htmlUrl"></param>
        /// <returns></returns>
        public Constellation GetConstellationByHtmlAgilityPack(string htmlUrl)
        {
            return new ConstellationParser().Analysis(new Uri(htmlUrl));
        }

    }
}
