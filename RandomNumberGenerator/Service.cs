using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Service
    {
        public static double expextedValue(double[] mas)
        {
            double sum = 0;
            foreach (double el in mas) sum += el;
            return sum / mas.Length;
        }

        public static double dispersion(double[] mas)
        {
            double sum = 0;
            foreach (double el in mas) sum += el;
            double m = sum / mas.Length;
            sum = 0;
            foreach (double el in mas) sum += Math.Pow(el - m, 2);
            return sum / mas.Length;
        }

        public static double moment(double[] mas, double m)
        {
            double sum = 0;
            foreach (double el in mas) sum += Math.Pow(el, m);
            return sum / mas.Length;
        }

        public static double frequency(double[] mas, double lBorder, double rBorder)
        {
            Console.WriteLine("rBorder: " + rBorder);
            Console.WriteLine("lBorder: " + lBorder);
            int count = 0;
            for (int i = 0; i < mas.Length; i++)  {
                if (lBorder <= mas[i] && mas[i] < rBorder)
                {
                    count++;
                }
            }
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Freq: " + (double) count / mas.Length);
            return (double) count / mas.Length;
        }
    }
}
