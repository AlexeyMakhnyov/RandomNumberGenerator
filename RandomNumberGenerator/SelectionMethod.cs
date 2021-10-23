using System;

namespace RandomNumberGenerator
{
    class SelectionMethod
    {
        public static double Random(Random random)
        {
            double a = 0, b = 3.4, c = 0.875;
            double x = 0, r1, r2, z1, z2;
            bool hit = false;
            do
            {
                r1 = random.NextDouble();
                r2 = random.NextDouble();
                z1 = a + r1 * (b - a);
                z2 = c * r2;
                if ((z1 >= 0 && z1 < 1 && z2 < 0.15) ||
                    (z1 >= 1 && z1 < 2 && z2 < 0.35) ||
                    (z1 >= 2 && z1 < 2.4 && z2 < 0.875) ||
                    (z1 >= 2.4 && z1 < 3.4 && z2 < 0.15))
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
