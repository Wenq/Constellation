/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:20:23 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：777c8f3d-7fad-4720-942a-fdf13d99dc93  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 天枰座
    /// </summary>
    public class Libra : ConstellationBase
    {
        public Libra(DateTime infoDate)
            : base(new Uri(Constants.libraUrl), new Uri(Constants.libraIcon), infoDate)
        { }

        public override string ToString()
        {
            return "天枰座";
        }
    }
}
