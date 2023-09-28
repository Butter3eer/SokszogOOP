using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Rombusz : Sokszog
    {
        private double m;

        public Rombusz(double a, double m) : base(a)
        {
            this.m = m;
        }

        public double M { get => m; set => m = value; }

        public override double GetKerulet()
        {
            return 4 * base.A;
        }

        public override double GetTerulet()
        {
            return Math.Round(this.m * base.A, 2);
        }

        public override string ToString()
        {
            return $"a: {this.A} - m: {this.m} - {base.ToString()}";
        }
    }
}
