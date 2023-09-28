using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Sokszogek
    {
        private List<Sokszog> sokszogek = new List<Sokszog>();
        private static Random rnd = new Random();

        public Sokszogek()
        {
            for (int i = 0; i < rnd.Next(10, 100); i++)
            {
                int kategoria = rnd.Next(0, 4);

                switch (kategoria)
                {
                    case 0:
                        sokszogek.Add(new Teglalap(rnd.Next(1, 10), rnd.Next(1, 10)));
                        break;
                    case 1:
                        sokszogek.Add(new Haromszog());
                        break;
                    case 2:
                        sokszogek.Add(new Paralelogramma());
                        break;
                    case 3:
                        sokszogek.Add(new Rombusz(rnd.Next(1, 10), rnd.Next(1, 10)));
                        break;
                }
            }
        }

        public override string ToString()
        {
            string eredmeny = "";
            for (int i = 0; i < sokszogek.Count; i++)
            {
                eredmeny += $"{sokszogek[i]}\n";
            }
            return eredmeny;
        }

        public double osszKerulet()
        {
            double eredmeny = 0;

            for (int i = 0; i < sokszogek.Count; i++)
            {
                eredmeny += sokszogek[i].GetKerulet();
            }

            return Math.Round(eredmeny, 2);
        }

        public double osszTerulet()
        {
            double eredmeny = 0;

            for (int i = 0; i < sokszogek.Count; i++)
            {
                eredmeny += sokszogek[i].GetTerulet();
            }

            return Math.Round(eredmeny, 2);
        }

        public double maxTerulet()
        {
            Sokszog eredmenySokszog = sokszogek.Find(x => x.GetTerulet() == sokszogek.Max(y => y.GetTerulet()));

            return eredmenySokszog.GetTerulet();
        }
    }
}
