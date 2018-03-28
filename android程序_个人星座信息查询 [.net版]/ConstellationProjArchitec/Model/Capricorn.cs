/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:20:49 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：d4e2736d-2918-4241-915e-950b7bb683eb  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 摩羯座
    /// </summary>
    public class Capricorn : ConstellationBase
    {
        public Capricorn(DateTime infoDate)
            : base(new Uri(Constants.capricornUrl), new Uri(Constants.capricornIcon), infoDate)
        { }

        public override string ToString()
        {
            return "摩羯座";
        }
    }
}
