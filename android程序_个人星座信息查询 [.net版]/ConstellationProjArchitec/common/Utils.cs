using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Net;
using System.IO;

namespace ConstellationProjArchitec.common
{
    /// <summary>
    /// 通用工具集合
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// 获取网络Bitmap
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetNewWorkBitmap(string imgUrl)
        {
            Bitmap img;

            WebClient client = new WebClient();
            byte[] imgs = client.DownloadData(imgUrl);
            MemoryStream ms = new MemoryStream(imgs.Length);
            ms.Write(imgs, 0, imgs.Length);
            img = new Bitmap(ms);

            return img;
        }

        /// <summary>
        /// 获取网络url的html页面[注意页面编码方式，防止乱码]
        /// </summary>
        /// <returns></returns>
        public static string GetHtml(string htmlUrl)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取DateTime的日期并格式化为特定string
        /// </summary>
        /// <returns></returns>
        public static string GetDate(DateTime date)
        {
            return date.Year.ToString() + (date.Month < 10 ? "0" + date.Month.ToString() : date.Month.ToString()) + (date.Day < 10 ? "0" + date.Day.ToString() : date.Day.ToString());
        }

    }
}
