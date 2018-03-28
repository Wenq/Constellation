/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:19:25 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：2a821117-27d0-4a90-84e5-421ffbb0d6dd  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 金牛座
    /// </summary>
    public class Taurus : ConstellationBase
    {
        public Taurus(DateTime infoDate)
            : base(new Uri(Constants.taurusUrl), new Uri(Constants.taurusIcon), infoDate)
        { }

        public override string ToString()
        {
            return "金牛座";
        }
    }
}
