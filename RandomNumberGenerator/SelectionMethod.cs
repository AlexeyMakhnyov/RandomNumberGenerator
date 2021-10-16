using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class SelectionMethod
    {
        public static double Random(Random random)
        {
            double a = 0, b = 3.4, c = 1;
            double x = 0, r1, r2, z1, z2;
            bool hit = false;
            do
            {
                r1 = random.NextDouble();
                r2 = random.NextDouble();
                z1 = a + r1 * (b - a);
                z2 = c * r2;
                if ((z2 < 0.15 * z1) ||
                    (z2 < 0.35 * z1 - 0.2) ||
                    (z2 < 0.875 * z1 - 1.25) ||
                    (z2 < 0.15 * z1 + 0.49))
                {
                    x = z1;
                    hit = true;
                }
            }
            while (!hit);
            return x;
        }
    }
}
