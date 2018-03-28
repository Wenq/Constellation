using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Drawing;

namespace android程序_个人星座信息查询_DotNet版.Model
{
    /// <summary>
    /// 星座实体
    /// </summary>
    public class Constellation
    {
        public Constellation()
        {
            currentDate = DateTime.Now.Date;
        }

        public Constellation(Bitmap consImg, string consName, string consDescription)
            : this()
        {
            this.consIcon = consImg;
            this.consName = consName;
            this.consEvaluation = consDescription;
        }

        public Constellation(Bitmap consImg, string consName, int consSumLuck, int consWorkLuck, string consHealthCoefficient, string consLuckyColor, string consSpeedDatingCons, int consLoveLuck, int consInvestLuck, string consConferCoefficient, string consLuckNum, string consEvaluation, DateTime startDate, DateTime endDate, DateTime currentDate, string consDateRange)
            : this()
        {
            this.consIcon = consImg;
            this.consName = consName;
            this.consSumLuck = consSumLuck;
            this.consWorkLuck = consWorkLuck;
            this.consHealthCoefficient = consHealthCoefficient;
            this.consLuckyColor = consLuckyColor;
            this.consSpeedDatingCons = consSpeedDatingCons;
            this.consLoveLuck = consLoveLuck;
            this.consInvestLuck = consInvestLuck;
            this.consConferCoefficient = consConferCoefficient;
            this.consLuckNum = consLuckNum;
            this.consEvaluation = consEvaluation;
            this.startDate = startDate;
            this.endDate = endDate;
            this.currentDate = currentDate;
            this.consDateRage = consDateRange;
        }

        private Bitmap consIcon; //星座图标 
        private string consName; //星座名称
        private int consSumLuck; //综合运势
        private int consWorkLuck; //工作状况
        private string consHealthCoefficient; //健康指数
        private string consLuckyColor; //幸运颜色
        private string consSpeedDatingCons; //速配星座
        private int consLoveLuck; //爱情运势
        private int consInvestLuck; //投资运势
        private string consConferCoefficient; //商谈指数
        private string consLuckNum; //幸运数字
        private string consEvaluation; //星座综合评述
        private DateTime startDate;
        private DateTime endDate;
        private DateTime currentDate; //当前日期
        private string consDateRage; //星座所在时间段

        /// <summary>
        /// 综合运势
        /// </summary>
        public int ConsSumLuck
        {
            get { return consSumLuck; }
            set { consSumLuck = value; }
        }

        /// <summary>
        /// 工作状况
        /// </summary>
        public int ConsWorkLuck
        {
            get { return consWorkLuck; }
            set { consWorkLuck = value; }
        }

        /// <summary>
        /// 健康指数
        /// </summary>
        public string ConsHealthCoefficient
        {
            get { return consHealthCoefficient; }
            set { consHealthCoefficient = value; }
        }

        /// <summary>
        /// 幸运颜色
        /// </summary>
        public string ConsLuckyColor
        {
            get { return consLuckyColor; }
            set { consLuckyColor = value; }
        }

        /// <summary>
        /// 速配星座
        /// </summary>
        public string ConsSpeedDatingCons
        {
            get { return consSpeedDatingCons; }
            set { consSpeedDatingCons = value; }
        }

        /// <summary>
        /// 爱情运势
        /// </summary>
        public int ConsLoveLuck
        {
            get { return consLoveLuck; }
            set { consLoveLuck = value; }
        }

        /// <summary>
        /// 投资运势
        /// </summary>
        public int ConsInvestLuck
        {
            get { return consInvestLuck; }
            set { consInvestLuck = value; }
        }

        /// <summary>
        /// 商谈指数
        /// </summary>
        public string ConsConferCoefficient
        {
            get { return consConferCoefficient; }
            set { consConferCoefficient = value; }
        }

        /// <summary>
        /// 幸运数字
        /// </summary>
        public string ConsLuckNum
        {
            get { return consLuckNum; }
            set { consLuckNum = value; }
        }

        /// <summary>
        /// 星座综合评述
        /// </summary>
        public string ConsEvaluation
        {
            get { return consEvaluation; }
            set { consEvaluation = value; }
        }

        /// <summary>
        /// 星座计算开始日期
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        /// <summary>
        /// 星座计算结束日期
        /// </summary>
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        /// <summary>
        /// 当前日期
        /// </summary>
        public DateTime CurrentDate
        {
            get { return currentDate; }
            private set { currentDate = value; }
        }

        /// <summary>
        /// 星座缩略图
        /// </summary>
        public Bitmap ConsIcon
        {
            get { return consIcon; }
            set { consIcon = value; }
        }

        /// <summary>
        /// 星座名称
        /// </summary>
        public string ConsName
        {
            get { return consName; }
            set { consName = value; }
        }

        /// <summary>
        /// 星座所在时间段
        /// </summary>
        public string ConsDateRage
        {
            get { return consDateRage; }
            set { consDateRage = value; }
        }

        public override string ToString()
        {
            return string.Format("constellation name: {0}, constellation description: {1}", consName, consEvaluation);
        }
    }
}
