/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:22:00 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：a27f6d39-0d3d-44dc-9ec5-158fd379ac42  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 狮子座
    /// </summary>
    public class Leo : ConstellationBase
    {
        public Leo(DateTime infoDate)
            : base(new Uri(Constants.leoUrl), new Uri(Constants.leoIcon), infoDate)
        { }

        public override string ToString()
        {
            return "狮子座";
        }
    }
}
