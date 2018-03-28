/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:19:53 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：ca24d986-4ee2-4324-8004-e888ba791112  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 巨蟹座
    /// </summary>
    public class Cancer : ConstellationBase
    {
        public Cancer(DateTime infoDate)
            : base(new Uri(Constants.cancerUrl), new Uri(Constants.cancerIcon), infoDate)
        { }

        public override string ToString()
        {
            return "巨蟹座";
        }
    }
}
