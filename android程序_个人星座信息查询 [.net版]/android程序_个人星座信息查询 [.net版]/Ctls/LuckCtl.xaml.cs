using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.ComponentModel;

namespace android程序_个人星座信息查询_DotNet版.Ctls
{
    /// <summary>
    /// 自定义控件：绘制五角星评分效果
    /// </summary>
    public partial class LuckCtl : UserControl
    {
        public LuckCtl()
        {
            InitializeComponent();

            sumStarsCount = 5;
            this.NumUpdated += new RoutedPropertyChangedEventHandler<int>(ShowNumCtl_NumUpdated);
        }

        void ShowNumCtl_NumUpdated(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            int value = e.NewValue;
            if (value < 0)
                luck = 0;
            else if (value > sumStarsCount)
                luck = sumStarsCount;
            else
                luck = value;
            InvalidateVisual();
        }

        //自定义依赖属性
        public static readonly DependencyProperty LuckProperty = DependencyProperty.Register("Luck",
            typeof(int),
            typeof(LuckCtl),
            new FrameworkPropertyMetadata(0, new PropertyChangedCallback(LuckPropertyChangedCallback)));

        /// <summary>
        /// 自定义依赖属性回调: 更新时执行的逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private static void LuckPropertyChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs arg)
        {
            if (sender != null && sender is LuckCtl)
            {
                LuckCtl ctl = sender as LuckCtl;
                ctl.OnLuckUpdated((int)arg.OldValue, (int)arg.NewValue);  //回调里通知
            }
        }

        //自定义订阅事件
        public static readonly RoutedEvent LuckUpdatedEvent = EventManager.RegisterRoutedEvent("NumUpdated",
             RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<int>), typeof(LuckCtl));

        [Description("Luck被更新后发生")]
        public event RoutedPropertyChangedEventHandler<int> NumUpdated
        {
            add
            {
                this.AddHandler(LuckUpdatedEvent, value);
            }
            remove
            {
                this.RemoveHandler(LuckUpdatedEvent, value);
            }
        }

        protected virtual void OnLuckUpdated(int oldValue, int newValue)
        {
            RoutedPropertyChangedEventArgs<int> arg = new RoutedPropertyChangedEventArgs<int>(oldValue, newValue, LuckUpdatedEvent);
            this.RaiseEvent(arg); //触发事件
        }

        //自定义命令支持
        //TODO:

        ///// <summary>
        ///// 自定义依赖属性：包装成一般属性
        ///// </summary>
        //public string Num
        //{
        //    get
        //    {
        //        return (string)this.GetValue(NumProperty);
        //    }
        //    set
        //    {
        //        this.SetValue(NumProperty, value);
        //    }
        //}

        private int sumStarsCount;  //绘制星星总数
        private int luck;

        ///// <summary>
        ///// 幸运指数[0<= num <=Luck]
        ///// </summary>
        //public int Luck
        //{
        //    get
        //    {
        //        return luck;
        //    }
        //    set
        //    {
        //        if (value != luck)
        //        {
        //            if (value < 0)
        //                luck = 0;
        //            else if (value > sumStarsCount)
        //                luck = sumStarsCount;
        //            else
        //                luck = value;
        //            //InvalidateArrange();
        //            //UpdateLayout();
        //            InvalidateVisual();
        //        }
        //    }
        //}

        /// <summary>
        /// 幸运指数[0<= num <=Luck][自定义依赖属性：包装成一般属性]
        /// </summary>
        public int Luck
        {
            get
            {
                return (int)this.GetValue(LuckProperty);
            }
            set
            {
                if (value != luck)
                {
                    luck = value;
                    this.SetValue(LuckProperty, value);
                }
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            Canvas mycanvas = new Canvas();
            Content = mycanvas;
            double startLeft = 15.0; //初始左间距
            double space = 30.0;

            //红色五角星
            for (int i = 1; i <= luck; i++)
            {
                DrawPentagram(mycanvas, Brushes.Red, 15.0, startLeft + space * (i - 1));
            }
            //灰色五角星
            for (int i = luck + 1; i <= sumStarsCount; i++)
            {
                DrawPentagram(mycanvas, Brushes.LightGray, 15.0, startLeft + space * (i - 1));
            }
        }

        /// <summary>
        /// 在指定位置绘制单个五角星(Canvas对象传进来之前要预先指定"Content":显示的面板)
        /// </summary>
        /// <param name="mycanvas"></param>
        /// <param name="locationTop"></param>
        /// <param name="locationLeft"></param>
        private void DrawPentagram(Canvas mycanvas, Brush fillColor, double locationTop, double locationLeft)
        {
            Polygon ply = new Polygon();

            mycanvas.Children.Add(ply);

            ply.SetValue(Canvas.TopProperty, locationTop);  //五角星坐标
            ply.SetValue(Canvas.LeftProperty, locationLeft);

            ply.Fill = fillColor;  //填充色
            //ply.Stroke = Brushes.Black; //border颜色
            ply.StrokeThickness = 1;
            ply.Points = new PointCollection();

            Point pt;
            double angle;
            for (int i = 0; i < 5; i++)  //五角星五个点
            {
                angle = i * 4 * Math.PI / 5;
                pt = new Point(15 * Math.Sin(angle), -15 * Math.Cos(angle));
                ply.Points.Add(pt);
            }
        }
    }
}
