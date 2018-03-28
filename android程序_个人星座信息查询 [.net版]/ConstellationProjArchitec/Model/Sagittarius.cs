using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec.Model
{
    /// <summary>
    /// 射手座
    /// </summary>
    public class Sagittarius : ConstellationBase
    {
        public Sagittarius(DateTime infoDate)
            : base(new Uri(Constants.SagittariusUrl), new Uri(Constants.SagittariusIcon), infoDate)
        {
        }

        public override string ToString()
        {
            return "射手座";
        }
    }
}
