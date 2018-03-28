using System;
using System.Windows;
using System.Windows.Media.Imaging;
using android程序_个人星座信息查询_DotNet版.BLL;
using android程序_个人星座信息查询_DotNet版.Model;
using android程序_个人星座信息查询_DotNet版.globle;
using System.Drawing;
using System.Windows.Documents;
using System.Collections.Generic;

namespace android程序_个人星座信息查询__.net版_
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化12星座对象
        /// </summary>
        private void InitData()
        {
            //使用ConstellationProjArchitec项目Model
            ConstellationProjArchitec.Model.Virgo vir = new ConstellationProjArchitec.Model.Virgo(DateTime.Now);
            ConstellationProjArchitec.Model.Aquarius aqu = new ConstellationProjArchitec.Model.Aquarius(DateTime.Now);
            ConstellationProjArchitec.Model.Aries ari = new ConstellationProjArchitec.Model.Aries(DateTime.Now);
            ConstellationProjArchitec.Model.Cancer can = new ConstellationProjArchitec.Model.Cancer(DateTime.Now);
            ConstellationProjArchitec.Model.Capricorn cap = new ConstellationProjArchitec.Model.Capricorn(DateTime.Now);
            ConstellationProjArchitec.Model.Gemini gem = new ConstellationProjArchitec.Model.Gemini(DateTime.Now);
            ConstellationProjArchitec.Model.Leo leo = new ConstellationProjArchitec.Model.Leo(DateTime.Now);
            ConstellationProjArchitec.Model.Libra lib = new ConstellationProjArchitec.Model.Libra(DateTime.Now);
            ConstellationProjArchitec.Model.Pisces pis = new ConstellationProjArchitec.Model.Pisces(DateTime.Now);
            ConstellationProjArchitec.Model.Sagittarius sag = new ConstellationProjArchitec.Model.Sagittarius(DateTime.Now);
            ConstellationProjArchitec.Model.Scorpio sco = new ConstellationProjArchitec.Model.Scorpio(DateTime.Now);
            ConstellationProjArchitec.Model.Taurus tau = new ConstellationProjArchitec.Model.Taurus(DateTime.Now);

            //Binding星座对象到下来列表
            List<ConstellationProjArchitec.Model.ConstellationBase> lst = new List<ConstellationProjArchitec.Model.ConstellationBase>() { vir, aqu, ari, can, cap, gem, leo, lib, pis, sag, sco, tau };
            comboBox1.ItemsSource = lst;
            comboBox1.SelectedIndex = 0;
        }

        /// <summary>
        /// 显示[绑定]星座信息到UI
        /// </summary>
        /// <param name="cons"></param>
        private void BingData(ConstellationProjArchitec.Model.ConstellationBase cons, DateTime newDate)
        {
            //cons.CurrentShowDate = newDate;
            cons.SetShowDate(newDate);
            this.DataContext = cons;

            ////获取的日期[测试用]
            //lblDate.Content = cons.CurrentShowDate.Date.ToShortDateString();

            //设置Icon
            string fileName = "C://" + Guid.NewGuid().ToString() + ".jpg"; //Icon临时保存路径
            Bitmap img = cons.Icon;
            img.Save(fileName);
            imgCtl.Source = new BitmapImage(new Uri(fileName));  //星座头像
        }

        private void comboBox1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {//绑定星座对象变更
            ConstellationProjArchitec.Model.ConstellationBase cons = comboBox1.SelectedItem as ConstellationProjArchitec.Model.ConstellationBase;
            if (cons != null)
                BingData(cons, datePicker1.SelectedDate.HasValue ? datePicker1.SelectedDate.Value : DateTime.Now);
        }

        private void datePicker1_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {//日期变更，更新星座信息
            ConstellationProjArchitec.Model.ConstellationBase cons = comboBox1.SelectedItem as ConstellationProjArchitec.Model.ConstellationBase;
            if (cons != null)
                cons.SetShowDate(datePicker1.SelectedDate.HasValue ? datePicker1.SelectedDate.Value : DateTime.Now);
            //cons.CurrentShowDate = datePicker1.SelectedDate.HasValue ? datePicker1.SelectedDate.Value : DateTime.Now;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitData();
        }
    }
}
