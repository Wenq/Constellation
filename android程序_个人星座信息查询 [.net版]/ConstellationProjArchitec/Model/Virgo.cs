/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:20:07 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：0eef289d-d48c-4c0c-b218-ebec1f29f892  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 处女座
    /// </summary>
    public class Virgo : ConstellationBase
    {
        public Virgo(DateTime infoDate)
            : base(new Uri(Constants.virgoUrl), new Uri(Constants.virgoIcon), infoDate)
        { }

        public override string ToString()
        {
            return "处女座";
        }
    }
}
