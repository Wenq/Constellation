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

namespace Pentagram.Demo
{
    /// <summary>
    /// 绘制五角星：Demo
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Canvas mycanvas = new Canvas();
            Content = mycanvas;
            DrawPentagram(mycanvas, 200.0, 200.0);
        }

        /// <summary>
        /// 在指定位置绘制单个五角星(Canvas对象传进来之前要预先指定"Content":显示的面板)
        /// </summary>
        /// <param name="mycanvas"></param>
        /// <param name="locationTop"></param>
        /// <param name="locationLeft"></param>
        private void DrawPentagram(Canvas mycanvas, double locationTop, double locationLeft)
        {
            Polygon ply = new Polygon();

            mycanvas.Children.Add(ply);

            ply.SetValue(Canvas.TopProperty, locationTop);  //五角星坐标
            ply.SetValue(Canvas.LeftProperty, locationLeft);

            ply.Fill = Brushes.Red;  //填充色
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
