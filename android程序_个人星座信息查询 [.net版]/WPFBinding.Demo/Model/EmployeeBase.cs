/**********************************************************
 *作者：WQ  
 *时间：2/27/2013 11:22:31 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：08cbae11-68f2-4b7f-8cce-9a0710d9dcf2  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WPFBinding.Demo.Model
{
    public class EmployeeBase : INotifyPropertyChanged
    {
        public EmployeeBase()
        { }

        public EmployeeBase(string name, string id, string sex, int age, string address)
        {
            this.name = name;
            this.id = id;
            this.sex = sex;
            this.age = age;
            this.address = address;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged("Id");
            }
        }

        private string sex;
        public string Sex
        {
            get { return sex; }
            set
            {
                sex = value;
                NotifyPropertyChanged("Sex");
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                NotifyPropertyChanged("Age");
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                NotifyPropertyChanged("Address");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion


        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
