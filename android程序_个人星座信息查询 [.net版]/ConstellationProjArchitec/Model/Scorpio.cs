/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:20:35 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：9b6f57d7-e724-4a86-ad91-2efdbe248597  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 天蝎座
    /// </summary>
    public class Scorpio : ConstellationBase
    {
        public Scorpio(DateTime infoDate)
            : base(new Uri(Constants.scorpioUrl), new Uri(Constants.scorpioIcon), infoDate)
        { }

        public override string ToString()
        {
            return "天蝎座";
        }
    }
}
