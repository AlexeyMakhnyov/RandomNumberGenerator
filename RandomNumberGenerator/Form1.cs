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
            ClearValue();
            double initVal;
            if (initialValue.Text == "")
                initVal = 0;
            else
                initVal = Convert.ToDouble(initialValue.Text);
            double[] mas = GenerateMas(initVal, 4000);
            CalcExpectedValue(mas);
            CalcDispersion(mas);
            CalcSecondMoment(mas);
            CalcThirdMoment(mas);
            CalcChiSquare(mas);
            CalcStreakOfZero(mas);
            CalcLambda(mas);
            BuildHistogram(mas);
            BuildFunctionChart(mas);
        }

        private double[] GenerateMas(double initlVal, int n)
        {
            double[] mas = new double[n];
            //MixedGenerator mGen = new MixedGenerator(initlVal);
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                //mas[i] = mGen.Rand();
                mas[i] = SelectionMethod.Random(random);
                Console.WriteLine(mas[i]);
            }
            return mas;
        }

        private void CalcExpectedValue(double[] mas)
        {
            expectedValue.Text += Math.Round(Service.CaclExpextedValue(mas) * 1000) / 1000;
        }

        private void CalcDispersion(double[] mas)
        {
            dispersionValue.Text += Math.Round(Service.CalcDispersion(mas) * 1000) / 1000;
        }

        private void CalcSecondMoment(double[] mas)
        {
            secondMoment.Text += Math.Round(Service.CalcMoment(mas, 2) *1000) / 1000;
        }

        private void CalcThirdMoment(double[] mas)
        {
            thirdMoment.Text += Math.Round(Service.CalcMoment(mas, 3) * 1000) / 1000;
        }

        private void CalcChiSquare(double[] mas)
        {
            byte numOfIntervals = 40;
            chiSquareValue.Text += Math.Round(Service.CalcChiSquare(mas, numOfIntervals) * 1000) / 1000;
        }
        private void CalcLambda(double[] mas)
        {
            lambdaValue.Text += Math.Round(Service.CalcLambda(mas) * 1000) / 1000;
        }

        private void CalcStreakOfZero(double[] mas)
        {
            double p = 0.5;
            streakOfZeroValue.Text += Math.Round(Service.ComputeStreakOfZeros(mas, p) * 1000) / 1000;
        }

        private void BuildHistogram(double[] mas)
        {
            histogram.Series["frequency"].Points.Clear();
            double h = (double)3.4 / 25; //3.4 / 25
            double lBorder = 0;
            double rBorder = h;
            double[] p = new double[25]; //25
            double sum = 0;
            histogram.Series["frequency"].BorderWidth = 2;
            for (int i = 0; i < 25; i++) //25
            {
                p[i] = Service.CalcFrequency(mas, lBorder, rBorder);
                sum += p[i];
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
                    //Console.WriteLine(j);
                }
                lBorder += h;
                rBorder += h;
            }
            histogram.Series["frequency"].Points.AddXY(3.4, p[p.Length - 1]); //3.4
            histogram.Series["frequency"].Points.AddXY(3.4, 0); //3.4
            Console.WriteLine("Sum = " + sum);
        }

        private void BuildFunctionChart(double[] mas)
        {
            functionChart.Series["function"].Points.Clear();
            double h = (double) 3.4 / 25; //3.4 / 25
            double lBorder = 0;
            double rBorder = lBorder + h;
            double sum = 0;
            double[] f = new double[25]; //25
            for (int i = 1; i < 25; i++) //25
            {
                sum += Service.CalcFrequency(mas, lBorder, rBorder);
                f[i] = sum;
                for (double j = lBorder; j < rBorder; j += 0.0025)
                {
                    functionChart.Series["function"].Points.AddXY(j, f[i]);
                }
                lBorder += h;
                rBorder += h;
            }
        }

        private void ClearValue()
        {
            expectedValue.Text = "Оценка математического \n ожидания: ";
            dispersionValue.Text = "Оценка дисперсии: ";
            secondMoment.Text = "Оценка 2-го момента: ";
            thirdMoment.Text = "Оценка 3-го момента: ";
            //secondMoment.Visible = false;
            //thirdMoment.Visible = false;
            chiSquareValue.Text = "Критерий Пирсона: ";
            lambdaValue.Text = "Критерий Колмогорова: ";
            streakOfZeroValue.Text = "Критерий серий(нулей): ";
            //streakOfZeroValue.Visible = false;
        }

        private void InitialValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
