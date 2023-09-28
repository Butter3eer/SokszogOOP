using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Paralelogramma : Sokszog
    {
        private double alfa;
        private double b;
        private static Random rnd = new Random();

        public Paralelogramma(double a, double alfa, double b) : base(a)
        {
            this.alfa = alfa;
            this.b = b;
        }

        public Paralelogramma() : base(VeletlenOldalhossz())
        {
            this.alfa = VeletlenSzog();
        }

        public double Alfa { get => alfa; set => alfa = value; }

        private static int VeletlenOldalhossz()
        {
            return rnd.Next(1, 10);
        }

        private static int VeletlenSzog()
        {
            return rnd.Next(1, 180);
        }

        public override double GetKerulet()
        {
            return 2 * (base.A + this.b);
        }

        public override double GetTerulet()
        {
            return Math.Round(base.A * this.b * Math.Sin(this.alfa * Math.PI / 180), 2);
        }

        public override string ToString()
        {
            return $"a: {this.A} - b: {this.b} - {base.ToString()}";
        }
    }
}
