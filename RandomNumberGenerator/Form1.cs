using System;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            clearValue();
            double initVal = Convert.ToDouble(initialValue.Text);
            double[] mas = generateMas(initVal, 4000);
            calcExpectedValue(mas);
            calcDispersion(mas);
            calcSecondMoment(mas);
            calcThirdMoment(mas);
            buildHistogram(mas);
            buildFunctionChart(mas);
        }

        private double[] generateMas(double initlVal, int n)
        {
            double[] mas = new double[n];
            MixedGenerator mGen = new MixedGenerator(initlVal);
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = mGen.rand();
                Console.WriteLine(mas[i]);
            }
            return mas;
        }

        private void calcExpectedValue(double[] mas)
        {
            expectedValue.Text += Math.Round(Service.expextedValue(mas) * 1000) / 1000;
        }

        private void calcDispersion(double[] mas)
        {
            dispersionValue.Text += Math.Round(Service.dispersion(mas) * 1000) / 1000;
        }

        private void calcSecondMoment(double[] mas)
        {
            secondMoment.Text += Math.Round(Service.moment(mas, 2) *1000) / 1000;
        }

        private void calcThirdMoment(double[] mas)
        {
            thirdMoment.Text += Math.Round(Service.moment(mas, 3) * 1000) / 1000;
        }

        private void buildHistogram(double[] mas)
        {
            histogram.Series["frequency"].Points.Clear();
            double h = 0.0625;
            double lBorder = 0;
            double rBorder = h;
            double[] p = new double[16];
            histogram.Series["frequency"].BorderWidth = 2;
            for (int i = 0; i < 16; i++)
            {
                p[i] = Service.frequency(mas, lBorder, rBorder);
                for (double j = lBorder; j <= rBorder; j += 0.0025)
                {
                    if (j == lBorder || j == rBorder)
                    {
                        histogram.Series["frequency"].Points.AddXY(j, 0);
                        histogram.Series["frequency"].Points.AddXY(j, p[i]);
                    }
                    else
                    {
                        histogram.Series["frequency"].Points.AddXY(j, p[i]);
                    }
                    Console.WriteLine(j);
                }
                lBorder += h;
                rBorder += h;
            }
            Console.WriteLine(rBorder);
            histogram.Series["frequency"].Points.AddXY(1, p[p.Length - 1]);
            histogram.Series["frequency"].Points.AddXY(1, 0);
        }

        private void buildFunctionChart(double[] mas)
        {
            functionChart.Series["function"].Points.Clear();
            double h = (double) 1 / 16;
            double lBorder = 0;
            double rBorder = lBorder + h;
            double sum = 0;
            double[] f = new double[17];
            f[0] = 0;
            for (int i = 1; i <= 16; i++)
            {
                sum += Service.frequency(mas, lBorder, rBorder);
                Console.WriteLine(sum);
                f[i] = sum;
                for (double j = lBorder; j < rBorder; j += 0.0025)
                {
                    functionChart.Series["function"].Points.AddXY(j, f[i]);
                }
                lBorder += h;
                rBorder += h;
            }
        }

        private void clearValue()
        {
            expectedValue.Text = "Оценка математического \n ожидания: ";
            dispersionValue.Text = "Оценка дисперсии: ";
            secondMoment.Text = "Оценка 2-го момента: ";
            thirdMoment.Text = "Оценка 3-го момента: ";
        }

        private void initialValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
