
namespace RandomNumberGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.initialValue = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.expectedValue = new System.Windows.Forms.Label();
            this.dispersionValue = new System.Windows.Forms.Label();
            this.secondMoment = new System.Windows.Forms.Label();
            this.thirdMoment = new System.Windows.Forms.Label();
            this.histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.functionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chiSquareValue = new System.Windows.Forms.Label();
            this.lambdaValue = new System.Windows.Forms.Label();
            this.streakOfZeroValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // initialValue
            // 
            this.initialValue.Location = new System.Drawing.Point(12, 45);
            this.initialValue.Name = "initialValue";
            this.initialValue.Size = new System.Drawing.Size(100, 20);
            this.initialValue.TabIndex = 0;
            this.initialValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InitialValue_KeyPress);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(12, 71);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(100, 23);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // expectedValue
            // 
            this.expectedValue.AutoSize = true;
            this.expectedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expectedValue.Location = new System.Drawing.Point(12, 97);
            this.expectedValue.Name = "expectedValue";
            this.expectedValue.Size = new System.Drawing.Size(160, 30);
            this.expectedValue.TabIndex = 2;
            this.expectedValue.Text = "Оценка математического \r\nожидания: ";
            // 
            // dispersionValue
            // 
            this.dispersionValue.AutoSize = true;
            this.dispersionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dispersionValue.Location = new System.Drawing.Point(12, 136);
            this.dispersionValue.Name = "dispersionValue";
            this.dispersionValue.Size = new System.Drawing.Size(120, 15);
            this.dispersionValue.TabIndex = 3;
            this.dispersionValue.Text = "Оценка дисперсии: ";
            // 
            // secondMoment
            // 
            this.secondMoment.AutoSize = true;
            this.secondMoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondMoment.Location = new System.Drawing.Point(12, 161);
            this.secondMoment.Name = "secondMoment";
            this.secondMoment.Size = new System.Drawing.Size(141, 15);
            this.secondMoment.TabIndex = 4;
            this.secondMoment.Text = "Оценка 2-го момента:  ";
            // 
            // thirdMoment
            // 
            this.thirdMoment.AutoSize = true;
            this.thirdMoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdMoment.Location = new System.Drawing.Point(12, 186);
            this.thirdMoment.Name = "thirdMoment";
            this.thirdMoment.Size = new System.Drawing.Size(141, 15);
            this.thirdMoment.TabIndex = 5;
            this.thirdMoment.Text = "Оценка 3-го момента:  ";
            // 
            // histogram
            // 
            chartArea1.Name = "ChartArea1";
            this.histogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogram.Legends.Add(legend1);
            this.histogram.Location = new System.Drawing.Point(6, 30);
            this.histogram.Name = "histogram";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "frequency";
            this.histogram.Series.Add(series1);
            this.histogram.Size = new System.Drawing.Size(550, 300);
            this.histogram.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(204, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 370);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.histogram);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Гистограмма частот";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.functionChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистическая функция распределения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // functionChart
            // 
            chartArea2.Name = "ChartArea1";
            this.functionChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.functionChart.Legends.Add(legend2);
            this.functionChart.Location = new System.Drawing.Point(6, 38);
            this.functionChart.Name = "functionChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "function";
            series2.YValuesPerPoint = 3;
            this.functionChart.Series.Add(series2);
            this.functionChart.Size = new System.Drawing.Size(550, 300);
            this.functionChart.TabIndex = 0;
            this.functionChart.Text = "functionChart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите начальное \r\nзначение Y:";
            // 
            // chiSquareValue
            // 
            this.chiSquareValue.AutoSize = true;
            this.chiSquareValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiSquareValue.Location = new System.Drawing.Point(12, 211);
            this.chiSquareValue.Name = "chiSquareValue";
            this.chiSquareValue.Size = new System.Drawing.Size(126, 15);
            this.chiSquareValue.TabIndex = 9;
            this.chiSquareValue.Text = "Критерий Пирсона:  ";
            // 
            // lambdaValue
            // 
            this.lambdaValue.AutoSize = true;
            this.lambdaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lambdaValue.Location = new System.Drawing.Point(12, 236);
            this.lambdaValue.Name = "lambdaValue";
            this.lambdaValue.Size = new System.Drawing.Size(154, 15);
            this.lambdaValue.TabIndex = 10;
            this.lambdaValue.Text = "Критерий Колмогорова:  ";
            // 
            // streakOfZeroValue
            // 
            this.streakOfZeroValue.AutoSize = true;
            this.streakOfZeroValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streakOfZeroValue.Location = new System.Drawing.Point(12, 261);
            this.streakOfZeroValue.Name = "streakOfZeroValue";
            this.streakOfZeroValue.Size = new System.Drawing.Size(151, 15);
            this.streakOfZeroValue.TabIndex = 11;
            this.streakOfZeroValue.Text = "Критерий серий(нулей):  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 439);
            this.Controls.Add(this.streakOfZeroValue);
            this.Controls.Add(this.lambdaValue);
            this.Controls.Add(this.chiSquareValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.thirdMoment);
            this.Controls.Add(this.secondMoment);
            this.Controls.Add(this.dispersionValue);
            this.Controls.Add(this.expectedValue);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.initialValue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смешанный генератор псевдослучайных чисел";
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox initialValue;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label expectedValue;
        private System.Windows.Forms.Label dispersionValue;
        private System.Windows.Forms.Label secondMoment;
        private System.Windows.Forms.Label thirdMoment;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogram;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart functionChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chiSquareValue;
        private System.Windows.Forms.Label lambdaValue;
        private System.Windows.Forms.Label streakOfZeroValue;
    }
}

