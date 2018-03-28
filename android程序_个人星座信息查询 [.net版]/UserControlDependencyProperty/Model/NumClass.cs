using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace UserControlDependencyProperty.Model
{
    public class NumClass : INotifyPropertyChanged
    {
        public NumClass(int num)
        {
            this.Num = num;
        }

        private int num;
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
                Notify("Num");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Notify(string propertyName)  //这个方法很重要
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
