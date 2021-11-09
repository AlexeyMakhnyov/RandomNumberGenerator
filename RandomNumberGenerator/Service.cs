using System;

namespace RandomNumberGenerator
{
    class Service
    {
        public static double CaclExpextedValue(double[] mas)
        {
            double sum = 0;
            foreach (double el in mas) sum += el;
            return sum / mas.Length;
        }

        public static double CalcDispersion(double[] mas)
        {
            double sum = 0;
            foreach (double el in mas) sum += el;
            double m = sum / mas.Length;
            sum = 0;
            foreach (double el in mas) sum += Math.Pow(el - m, 2);
            return sum / mas.Length;
        }

        public static double CalcMoment(double[] mas, double m)
        {
            double sum = 0;
            foreach (double el in mas) sum += Math.Pow(el, m);
            return sum / mas.Length;
        }

        public static double CalcFrequency(double[] mas, double lBorder, double rBorder)
        {
            int count = 0;
            for (int i = 0; i < mas.Length; i++)  {
                if (lBorder <= mas[i] && mas[i] < rBorder)
                {
                    count++;
                }
            }
            return (double) count / mas.Length;
        }

        private static double[] CalcHits(double[] mas, byte k)
        {
            double h = (double)3.4 / k;
            double lBorder = 0;
            double rBorder = lBorder + h;
            double[] hits = new double[k];
            for (int i = 0; i < k; i++)
            {
                hits[i] = CalcAmount(mas, lBorder, rBorder);
                lBorder += h;
                rBorder += h;
            }
            return hits;
        }

        private static int CalcAmount(double[] mas, double lBorder, double rBorder)
        {
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (lBorder <= mas[i] && mas[i] < rBorder)
                {
                    count++;
                }
            }
            return count;
        }
        public static double CalcChiSquare(double[] mas, byte k)
        {
            double[] hits = CalcHits(mas, k);
            long n = mas.Length;
            double p = (double) 1 / k;
            double xi = 0;
            for (int i = 0; i < k; i++)
            {
                xi += Math.Pow(hits[i] - n * p, 2) / (n * p);
            }
            return xi;
        }

        public static double CalcLambda(double[] mas)
        {
            int n = mas.Length;
            double dMax = 0;
            double[] sort = mas;
            Array.Sort(sort);
            for (int i = 0; i < n; i++) 
            {
                double dp = Math.Abs((double)(i + 1) / n - CalcFunk(sort[i]));
                double dm = Math.Abs(CalcFunk(sort[i]) - (double)i / n);
                if (dp > dMax)
                    dMax = dp;
                else if (dm > dMax)
                    dMax = dm;
                Console.WriteLine(dMax);
            }
            return dMax * Math.Sqrt(n);
        }

        public static double CalcFunk(double x)
        {
            //if (x <= 0)
            //    return 0;
            //else if (x > 0 && x < 1)
            //    return x;
            //else
            //    return 1;
            if (x < 0)
                return 0;
            else if (x >= 0 && x < 1)
                return 0.15;
            else if (x >= 1 && x < 2)
                return 0.35;
            else if (x >= 2 && x < 2.4)
                return 0.875;
            else if (x >= 2.4 && x < 3.4)
                return 0.14;
            else 
                return 3.4;
        }

        public static double ComputeStreakOfZeros(double[] mas, double p)
        {
            int k = 0;
            int count = 0;
            int n = mas.Length;
            int[] y = new int[n];
            for (int i = 0; i < n; i++)
                if (mas[i] < p)
                {
                    y[i] = 0;
                    count++;
                }
                else
                    y[i] = 1;
            for (int i = 1; i < n; i++)
                if ((y[i - 1] == 0) && (y[i] == 1))
                    k++;
            if (y[n - 1] == 0)
                k++;
            return (double)k / count;
        }
    }
}
