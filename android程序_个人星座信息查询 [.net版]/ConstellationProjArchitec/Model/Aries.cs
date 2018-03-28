/**********************************************************
 *作者：WQ  
 *时间：2/25/2013 9:19:08 PM   
 *版权：2013-2013  
 *CLR版本：4.0.30319.296  
 *唯一标识：194be8c1-e303-43de-9c9b-6b5901ec34c3  
 *********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 白羊座
    /// </summary>
    public class Aries : ConstellationBase
    {
        public Aries(DateTime infoDate)
            : base(new Uri(Constants.ariesUrl), new Uri(Constants.ariesIcon), infoDate)
        { }

        public override string ToString()
        {
            return "白羊座";
        }
    }
}
