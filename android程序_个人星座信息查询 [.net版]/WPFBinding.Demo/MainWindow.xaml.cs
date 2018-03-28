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
using WPFBinding.Demo.Model;

namespace WPFBinding.Demo
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

        private EmployeeBase emp;
        private EmployeeOne empOne;
        private EmployeeTwo empTwo;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            empOne = new EmployeeOne("Alan", "asdf-23rqwr-wqerqwer-aasdf", "男", 21, "深圳");
            empTwo = new EmployeeTwo("qq", "asdf-sdf-aasdfa-sd-fasd-f", "女", 17, "重庆");
            emp = empOne;

            this.DataContext = emp;
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            Binding(empOne);
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            Binding(empTwo);
        }

        /// <summary>
        /// 更换对象：必须重新binding
        /// </summary>
        /// <param name="emp"></param>
        private void Binding(EmployeeBase emp)
        {
            this.DataContext = emp;
        }

        private void btnNameChange_Click(object sender, RoutedEventArgs e)
        {
            EmployeeBase ba = this.DataContext as EmployeeBase;
            if (ba != null)
                ba.Name = Guid.NewGuid().ToString();
        }
    }
}
