/**********************************************************
 *作者：WQ  
 *时间：2/28/2013 12:16:11 AM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：5138be43-5626-437b-a871-b9f37686c370  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFBinding.Demo.Model
{
    public class EmployeeTwo : EmployeeBase
    {
        public EmployeeTwo()
        { }

        public EmployeeTwo(string name, string id, string sex, int age, string address)
            : base(name, id, sex, age, address)
        { }
    }
}
