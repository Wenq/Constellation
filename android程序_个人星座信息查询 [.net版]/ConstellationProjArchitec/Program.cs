using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstellationProjArchitec.Model;
using ConstellationProjArchitec.common;

namespace ConstellationProjArchitec
{
    class Program
    {
        static void Main(string[] args)
        {
            Sagittarius st = new Sagittarius(DateTime.Now);
            Pisces ps = new Pisces(DateTime.Now);

            string name = st.ConsName;
            string eva = st.ConsEvaluation;

            string name2 = ps.ConsName;
            string eva2 = ps.ConsEvaluation;

            Console.Read();
        }
    }
}
