/**********************************************************
 *作者：WQ  
 *时间：2/28/2013 12:14:37 AM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：c678befe-6020-44f8-af25-48a470771a2d  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFBinding.Demo.Model
{
    public class EmployeeOne : EmployeeBase
    {
        public EmployeeOne()
        { }

        public EmployeeOne(string name, string id, string sex, int age, string address)
            : base(name, id, sex, age, address)
        { }
    }
}
