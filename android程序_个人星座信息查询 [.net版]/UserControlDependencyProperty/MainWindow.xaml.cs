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
using UserControlDependencyProperty.Model;

namespace UserControlDependencyProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NumClass num = new NumClass(7);
            showNumCtl1.DataContext = num;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NumClass num = showNumCtl1.DataContext as NumClass;
            if (num != null)
                num.Num = new Random().Next(3, 138);
        }
    }
}
