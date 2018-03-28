using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 双鱼座
    /// </summary>
    public class Pisces : ConstellationBase
    {
        public Pisces(DateTime infoDate)
            : base(new Uri(Constants.piscesUrl), new Uri(Constants.piscesIcon), infoDate)
        { }

        public override string ToString()
        {
            return "双鱼座";
        }
    }
}
