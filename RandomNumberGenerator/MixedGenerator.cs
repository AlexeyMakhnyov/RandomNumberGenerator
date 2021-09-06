using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class MixedGenerator
    {
        private double y;

        public MixedGenerator(double y)
        {
            this.y = y;
        }

        public double rand()
        {
            double u = 453816693;
            double a = 16070093;
            double m = Math.Pow(2, 63);
            y = (a * y + u) % m;
            return y / m;
        }
    }
}
