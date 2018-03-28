using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ConstellationProjArchitec.common;
using System.ComponentModel;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 星座基类
    /// </summary>
    public abstract class ConstellationBase : INotifyPropertyChanged //支持数据绑定
    {
        public ConstellationBase(Uri constellationUrl, Uri iconUrl, DateTime infoDate)
        {
            this.constellationUrl = constellationUrl; //加上特定获取信息所属的Date
            this.iconUrl = iconUrl;
            this.currentShowDate = infoDate;

            htmlPaser = new HtmlPaser();
            htmlPaser.InitHtmlObjEndEvent += new EventHandler(htmlPaser_InitHtmlObjEndEvent);
            htmlPaser.InitHtml(new Uri(this.constellationUrl.ToString() + "/" + Utils.GetDate(currentShowDate)), this.iconUrl);

            this.DateChanged += new EventHandler(ConstellationBase_DateChanged);
        }

        void ConstellationBase_DateChanged(object sender, EventArgs e)
        {
            htmlPaser.InitHtml(new Uri(this.constellationUrl.ToString() + "/" + Utils.GetDate(currentShowDate)), this.iconUrl); //日期更改，重新查询
        }

        /// <summary>
        /// html变更,触发绑定目标数据同步更新。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void htmlPaser_InitHtmlObjEndEvent(object sender, EventArgs e)
        {
            Icon = htmlPaser.GetIcon();
            ConsName = htmlPaser.AnalyseStr(Constants.consNameXPath);
            ConsEvaluation = htmlPaser.AnalyseStr(Constants.consEvaluationXPath);
            ConsSumLuck = htmlPaser.AnalyseInt(Constants.consSumLuckXPath);
            ConsWorkLuck = htmlPaser.AnalyseInt(Constants.consWorkLuckXPath);
            ConsHealthCoefficient = htmlPaser.AnalyseStr(Constants.consHealthCoefficientXPath);
            ConsLuckyColor = htmlPaser.AnalyseStr(Constants.consLuckyColorXPath);
            ConsSpeedDatingCons = htmlPaser.AnalyseStr(Constants.consSpeedDatingConsXPath);
            ConsLoveLuck = htmlPaser.AnalyseInt(Constants.consLoveLuckXPath);
            ConsInvestLuck = htmlPaser.AnalyseInt(Constants.consInvestLuckXPath);
            ConsConferCoefficient = htmlPaser.AnalyseStr(Constants.consConferCoefficientXPath);
            ConsLuckNum = htmlPaser.AnalyseStr(Constants.consLuckNumXPath);
            ConsDateRage = htmlPaser.AnalyseStr(Constants.consDateRangeXPath);
            CurrentShowDate = setShowDate;

        }

        private Uri constellationUrl;
        private Uri iconUrl;
        private HtmlPaser htmlPaser; //html解析对象
        private DateTime currentShowDate;

        private Bitmap icon;
        private string consName;
        private string consEvaluation;
        private int consSumLuck;
        private int consWorkLuck;
        private string consHealthCoefficient;
        private string consLuckyColor;
        private string consSpeedDatingCons;
        private int consLoveLuck;
        private int consInvestLuck;
        private string consConferCoefficient;
        private string consLuckNum;
        private string consDateRage;

        private DateTime setShowDate; //保存当前获取的星座对象所属的日期.

        /// <summary>
        /// 星座信息所在网络页面的url
        /// </summary>
        public Uri ConstellationUrl
        {
            get { return constellationUrl; }
        }

        /// <summary>
        /// Icon的url
        /// </summary>
        public Uri IconUrl
        {
            get { return iconUrl; }
        }

        /// <summary>
        /// Ico
        /// </summary>
        public Bitmap Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                Notify("Icon");
            }
        }

        /// <summary>
        /// 星座名称
        /// </summary>
        public virtual string ConsName
        {
            get
            {
                return consName;
            }
            set
            {
                if (value != consName)
                {
                    consName = value;
                    Notify("ConsName");
                }
            }
        }

        /// <summary>
        /// 综合评述
        /// </summary>
        public virtual string ConsEvaluation
        {
            get
            {
                return consEvaluation;
            }
            set
            {
                if (value != consEvaluation)
                {
                    consEvaluation = value;
                    Notify("ConsEvaluation");
                }
            }
        }

        /// <summary>
        /// 综合运势
        /// </summary>
        public virtual int ConsSumLuck
        {
            get
            {
                return consSumLuck;
            }
            set
            {
                if (value != consSumLuck)
                {
                    consSumLuck = value;
                    Notify("ConsSumLuck");
                }
            }
        }

        /// <summary>
        /// 工作状况
        /// </summary>
        public virtual int ConsWorkLuck
        {
            get
            {
                return consWorkLuck;
            }
            set
            {
                if (value != consWorkLuck)
                {
                    consWorkLuck = value;
                    Notify("ConsWorkLuck");
                }
            }
        }

        /// <summary>
        /// 健康指数
        /// </summary>
        public virtual string ConsHealthCoefficient
        {
            get
            {
                return consHealthCoefficient;
            }
            set
            {
                if (value != consHealthCoefficient)
                {
                    consHealthCoefficient = value;
                    Notify("ConsHealthCoefficient");
                }
            }
        }

        /// <summary>
        /// 幸运颜色
        /// </summary>
        public virtual string ConsLuckyColor
        {
            get
            {
                return consLuckyColor;
            }
            set
            {
                if (value != consLuckyColor)
                {
                    consLuckyColor = value;
                    Notify("ConsLuckyColor");
                }
            }
        }

        /// <summary>
        /// 速配星座
        /// </summary>
        public virtual string ConsSpeedDatingCons
        {
            get
            {
                return consSpeedDatingCons;
            }
            set
            {
                if (value != consSpeedDatingCons)
                {
                    consSpeedDatingCons = value;
                    Notify("ConsSpeedDatingCons");
                }
            }
        }

        /// <summary>
        /// 爱情运势
        /// </summary>
        public virtual int ConsLoveLuck
        {
            get
            {
                return consLoveLuck;
            }
            set
            {
                if (value != consLoveLuck)
                {
                    consLoveLuck = value;
                    Notify("ConsLoveLuck");
                }
            }
        }

        /// <summary>
        /// 投资运势
        /// </summary>
        public virtual int ConsInvestLuck
        {
            get
            {
                return consInvestLuck;
            }
            set
            {
                if (value != consInvestLuck)
                {
                    consInvestLuck = value;
                    Notify("ConsInvestLuck");
                }
            }
        }

        /// <summary>
        /// 商谈指数
        /// </summary>
        public virtual string ConsConferCoefficient
        {
            get
            {
                return consConferCoefficient;
            }
            set
            {
                if (value != consConferCoefficient)
                {
                    consConferCoefficient = value;
                    Notify("ConsConferCoefficient");
                }
            }
        }

        /// <summary>
        /// 幸运数字
        /// </summary>
        public virtual string ConsLuckNum
        {
            get
            {
                return consLuckNum;
            }
            set
            {
                if (value != consLuckNum)
                {
                    consLuckNum = value;
                    Notify("ConsLuckNum");
                }
            }
        }

        /// <summary>
        /// 星座所在时间段
        /// </summary>
        public virtual string ConsDateRage
        {
            get
            {
                return consDateRage;
            }
            set
            {
                if (value != consDateRage)
                {
                    consDateRage = value;
                    Notify("ConsDateRage");
                }
            }
        }

        /// <summary>
        /// [星座信息所属日期更改入口,不绑定.]当前信息所属日期
        /// </summary>
        public DateTime CurrentShowDate
        {
            get
            {
                return currentShowDate;
            }
            private set
            {
                if (currentShowDate.Date != value.Date)
                {
                    currentShowDate = value;
                    Notify("CurrentShowDate");
                    //DateChangedHandler(null, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// 设置星座对象所属日期的入口
        /// </summary>
        /// <param name="date"></param>
        public void SetShowDate(DateTime date)
        {
            if (setShowDate.Date != date.Date)
            {
                setShowDate = date.Date;
                DateChangedHandler(null, EventArgs.Empty);
            }
        }

        ///// <summary>
        ///// 获取自定义xpath内容
        ///// </summary>
        ///// <param name="xPath"></param>
        ///// <returns></returns>
        //public string AnalyseStr(string xPath)
        //{
        //    return htmlPaser.AnalyseStr(xPath);
        //}

        ///// <summary>
        ///// 获取自定义xpath内容
        ///// </summary>
        ///// <param name="xPath"></param>
        ///// <returns></returns>
        //public int AnalyseInt(string xPath)
        //{
        //    return htmlPaser.AnalyseInt(xPath);
        //}

        /// <summary>
        /// 查询日期更改事件
        /// </summary>
        public event EventHandler DateChanged;
        public void DateChangedHandler(object sender, EventArgs e)
        {
            EventHandler handler = this.DateChanged;
            if (handler != null)
                handler(sender, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Notify(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
