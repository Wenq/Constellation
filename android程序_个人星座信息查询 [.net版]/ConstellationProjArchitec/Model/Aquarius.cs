/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:21:01 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：25725347-4c7a-4b1b-9fd0-4f4209d969f8  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    public class Aquarius : ConstellationBase
    {
        /// <summary>
        /// 水瓶座
        /// </summary>
        public Aquarius(DateTime infoDate)
            : base(new Uri(Constants.aquariusUrl), new Uri(Constants.aquariusIcon), infoDate)
        { }

        public override string ToString()
        {
            return "水瓶座";
        }
    }
}
