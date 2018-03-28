using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace UserControlDependencyProperty.Ctls
{
    /// <summary>
    /// Interaction logic for ShowNumCtl.xaml
    /// </summary>
    public partial class ShowNumCtl : UserControl
    {
        public ShowNumCtl()
        {
            InitializeComponent();

            this.NumUpdated += new RoutedPropertyChangedEventHandler<string>(ShowNumCtl_NumUpdated);
        }

        void ShowNumCtl_NumUpdated(object sender, RoutedPropertyChangedEventArgs<string> e)
        {
            this.txtNum.Text = (string)e.NewValue;
        }

        //自定义依赖属性
        public static readonly DependencyProperty NumProperty = DependencyProperty.Register("Num",
            typeof(string),
            typeof(ShowNumCtl),
            new FrameworkPropertyMetadata("默认值", new PropertyChangedCallback(NumPropertyChangedCallback)));

        /// <summary>
        /// 自定义依赖属性回调: 更新时执行的逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private static void NumPropertyChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs arg)
        {
            if (sender != null && sender is ShowNumCtl)
            {
                ShowNumCtl ctl = sender as ShowNumCtl;
                ctl.OnNumUpdated((string)arg.OldValue, (string)arg.NewValue);  //回调里通知
            }
        }

        //自定义订阅事件
        public static readonly RoutedEvent NumUpdatedEvent = EventManager.RegisterRoutedEvent("NumUpdated",
             RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<string>), typeof(ShowNumCtl));

        [Description("Num被更新后发生")]
        public event RoutedPropertyChangedEventHandler<string> NumUpdated
        {
            add
            {
                this.AddHandler(NumUpdatedEvent, value);
            }
            remove
            {
                this.RemoveHandler(NumUpdatedEvent, value);
            }
        }

        protected virtual void OnNumUpdated(string oldValue, string newValue)
        {
            RoutedPropertyChangedEventArgs<string> arg = new RoutedPropertyChangedEventArgs<string>(oldValue, newValue, NumUpdatedEvent);
            this.RaiseEvent(arg); //触发事件
        }

        //自定义命令支持
        //TODO:

        /// <summary>
        /// 自定义依赖属性：包装成一般属性
        /// </summary>
        public string Num
        {
            get
            {
                return (string)this.GetValue(NumProperty);
            }
            set
            {
                this.SetValue(NumProperty, value);
            }
        }
    }
}
