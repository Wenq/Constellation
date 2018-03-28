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

namespace ConstellationProjArchitec.Demo
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
            ConstellationProjArchitec.Model.ConstellationBase ba = new ConstellationProjArchitec.Model.Sagittarius(DateTime.Now);
            this.DataContext = ba;
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            ConstellationProjArchitec.Model.ConstellationBase ba = this.DataContext as ConstellationProjArchitec.Model.ConstellationBase;
            if (ba != null)
                ba.SetShowDate(ba.CurrentShowDate.AddDays(2d));
            //ba.CurrentShowDate = ba.CurrentShowDate.AddDays(2d);
        }
    }
}
