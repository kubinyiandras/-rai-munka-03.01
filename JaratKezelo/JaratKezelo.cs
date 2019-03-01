using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JaratKezelo
{
    public class JaratKezelo
    {
        

        class Jarat
        {
            public string jaratSzam;
            private string repterHonnan;
            private string repterHova;
            private DateTime Indulas;
            public int Kesik;

            

            public Jarat(string jaratSzam2, string repterHonnan2, string repterHova2, DateTime indulas2, int kesik2)
            {
                jaratSzam = jaratSzam2;
                repterHonnan = repterHonnan2;
                repterHova = repterHova2;
                Indulas = indulas2;
                Kesik = kesik2;

            }
            
        }
        List<Jarat> jarat = new List<Jarat>();

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas, int Kesik)
        {
            var jar = new Jarat(jaratSzam, repterHonnan, repterHova, indulas, Kesik);
            jarat.Add(jar);

        }


    public void Keses(string jaratSzam, int Kesik, DateTime Indulas)
        {
            foreach (var jar in jarat)
            {
                if (jar.jaratSzam.Equals(jaratSzam))
                {
                    jar.Kesik += Kesik;
                }
            }
            throw new NegativKesesException(jaratSzam, Kesik);
        }
    }
}
