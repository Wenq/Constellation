/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:19:39 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：e2aed393-05b6-45ac-bbbf-48789f330840  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 双子座
    /// </summary>
    public class Gemini : ConstellationBase
    {
        public Gemini(DateTime infoDate)
            : base(new Uri(Constants.geminiUrl), new Uri(Constants.geminiIcon), infoDate)
        { }

        public override string ToString()
        {
            return "双子座";
        }
    }
}
