using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MinMax
{
    public partial class Form1 : Form
    {
        int INDEX = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            int start = Convert.ToInt32(low.Text);
            int end = Convert.ToInt32(high.Text);
            if (start >= end)
            {
                MessageBox.Show("Please Entre correct Boundry!");
                return;
            }


            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = start - 1;
            objChart.AxisX.Maximum = end +1;
            objChart.AxisX.Interval = 1;
            chart1.Series.Clear();
            // add first line
            chart1.Series.Add("graph");
            chart1.Series["graph"].BorderWidth = 2;
            chart1.Series["graph"].Color = Color.Blue;
            chart1.Series["graph"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //adding data of first line
            for (double i = start; i <= end; i += 0.1)
                chart1.Series["graph"].Points.AddXY(i, functionList(i));
            
        }


        private double FX1(double x)
        {
            double f = (Math.Pow(x, 2)) - (Math.Pow(x, 4)) * Math.Sin(x);
            return f;
        }

        private double FX2(double x)
        {
            double f = Math.Pow(x, 2);
            return f;
        }

        private double FX3(double x)
        {
            double f = 12 * Math.Sin(x) - 0.1 * Math.Pow(x, 2);
            return f;
        }

        private double FX4(double x)
        {
            double f = 0.3 * Math.Pow(x,3) - 4 * x;
            return f;
        }

        private double FX5(double x)
        {
            double f = (Math.Sin(x)) * (Math.Sin(x)) - Math.Cos(x);
            return f;
        }

        private void fx1_CheckedChanged(object sender, EventArgs e)
        {
            INDEX = 1;
            low.Text = "0";
            high.Text = "10";
            lowRang.Text = "0";
            highRang.Text = "10";
            button2.Enabled = false;
        }

        private void fx2_CheckedChanged(object sender, EventArgs e)
        {
            INDEX = 2;
            low.Text = "-4";
            high.Text = "4";
            lowRang.Text = "-4";
            highRang.Text = "4";
            button2.Enabled = false;
        }

        private void fx3_CheckedChanged(object sender, EventArgs e)
        {
            INDEX = 3;
            low.Text = "0";
            high.Text = "10";
            lowRang.Text = "0";
            highRang.Text = "10";
            button2.Enabled = false;
        }

        private void fx4_CheckedChanged(object sender, EventArgs e)
        {
            INDEX = 4;
            low.Text = "-5";
            high.Text = "5";
            lowRang.Text = "-5";
            highRang.Text = "5";
            button2.Enabled = false;
        }

        private void fx5_CheckedChanged(object sender, EventArgs e)
        {
            INDEX = 5;
            low.Text = "-5";
            high.Text = "5";
            lowRang.Text = "-5";
            highRang.Text = "5";
            button2.Enabled = false;
        }

        private double functionList(double x)
        {
            switch (INDEX)
            {
                case 1: return FX1(x);
                case 2: return FX2(x);
                case 3: return FX3(x);
                case 4: return FX4(x);
                case 5: return FX5(x);
                default: return FX1(x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool minimumPrblem;
            if(min.Checked)
                minimumPrblem = true;
            else minimumPrblem = false;
            int start = Convert.ToInt32(lowRang.Text);
            int stop = Convert.ToInt32(highRang.Text);
            int begin = Convert.ToInt32(low.Text);
            int end = Convert.ToInt32(high.Text);
            if (start >= stop)
            {
                MessageBox.Show("Please Entre correct Boundry!");
                return;
            }
            if ((start < begin) || (stop > end))
            {
                MessageBox.Show("Please, the Boundry of local value must be less than Boundry of Function");
                return;
            }

            // search about local value

            Bee bee = new Bee(start, stop, minimumPrblem,functionList);
            bee.Search();
            double[] result = bee.getBestsol();
            // -------------------------
            // draw special part for search inside it
            int idx = chart1.Series.IndexOf("subgraph");
            if (idx >= 0)
                chart1.Series.RemoveAt(idx);
            chart1.Series.Add("subgraph");
            chart1.Series["subgraph"].BorderWidth = 2;
            chart1.Series["subgraph"].Color = Color.Red;
            chart1.Series["subgraph"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //adding data of first line
            for (double i = start; i <= stop; i += 0.1)
                chart1.Series["subgraph"].Points.AddXY(i, functionList(i));

            // draw boundry of rang
            int bound = chart1.Series.IndexOf("boundry");
            if (bound >= 0)
                chart1.Series.RemoveAt(bound);
            chart1.Series.Add("boundry");
            chart1.Series["boundry"].BorderWidth = 2;
            chart1.Series["boundry"].Color = Color.Red;
            chart1.Series["boundry"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            //adding data of first line
            chart1.Series["boundry"].Points.AddXY(start, functionList(start));
            chart1.Series["boundry"].Points.AddXY(stop, functionList(stop));

            // draw local Value
            int local = chart1.Series.IndexOf("local");
            if (local >= 0)
                chart1.Series.RemoveAt(local);
            chart1.Series.Add("local");
            chart1.Series["local"].BorderWidth = 8;
            chart1.Series["local"].Label = $"X = {Math.Round(result[0],2)}";
            chart1.Series["local"].Color = Color.Black;
            chart1.Series["local"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            //adding data of first line
            chart1.Series["local"].Points.AddXY(result[0], result[result.Length - 1]);
            
            //  show on form
            localValue.Text = $"X = {Math.Round(result[0],2)}";
            scoreOfLocal.Text = $"F(X) = {Math.Round(result[result.Length - 1],2)}";
            
        }



    }
}
