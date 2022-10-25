namespace MinMax
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.scoreOfLocal = new System.Windows.Forms.Label();
            this.localValue = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lowRang = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.RadioButton();
            this.highRang = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.low = new System.Windows.Forms.TextBox();
            this.high = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fx5 = new System.Windows.Forms.RadioButton();
            this.fx4 = new System.Windows.Forms.RadioButton();
            this.fx3 = new System.Windows.Forms.RadioButton();
            this.fx2 = new System.Windows.Forms.RadioButton();
            this.fx1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tool Box";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.scoreOfLocal);
            this.groupBox4.Controls.Add(this.localValue);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.lowRang);
            this.groupBox4.Controls.Add(this.max);
            this.groupBox4.Controls.Add(this.highRang);
            this.groupBox4.Controls.Add(this.min);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 237);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mini Max";
            // 
            // scoreOfLocal
            // 
            this.scoreOfLocal.AutoSize = true;
            this.scoreOfLocal.Location = new System.Drawing.Point(9, 206);
            this.scoreOfLocal.Name = "scoreOfLocal";
            this.scoreOfLocal.Size = new System.Drawing.Size(38, 13);
            this.scoreOfLocal.TabIndex = 10;
            this.scoreOfLocal.Text = "F(X) = ";
            // 
            // localValue
            // 
            this.localValue.AutoSize = true;
            this.localValue.Location = new System.Drawing.Point(11, 181);
            this.localValue.Name = "localValue";
            this.localValue.Size = new System.Drawing.Size(26, 13);
            this.localValue.TabIndex = 10;
            this.localValue.Text = "X = ";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(14, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Find Local Value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lowRang
            // 
            this.lowRang.Location = new System.Drawing.Point(87, 84);
            this.lowRang.Name = "lowRang";
            this.lowRang.Size = new System.Drawing.Size(28, 20);
            this.lowRang.TabIndex = 8;
            this.lowRang.Text = "0";
            this.lowRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(80, 45);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(69, 17);
            this.max.TabIndex = 1;
            this.max.Text = "Maximum";
            this.max.UseVisualStyleBackColor = true;
            // 
            // highRang
            // 
            this.highRang.Location = new System.Drawing.Point(133, 84);
            this.highRang.Name = "highRang";
            this.highRang.Size = new System.Drawing.Size(28, 20);
            this.highRang.TabIndex = 8;
            this.highRang.Text = "10";
            this.highRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Checked = true;
            this.min.Location = new System.Drawing.Point(80, 26);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(66, 17);
            this.min.TabIndex = 0;
            this.min.TabStop = true;
            this.min.Text = "Minimum";
            this.min.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = ",";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Range";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(160, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 29);
            this.label12.TabIndex = 7;
            this.label12.Text = "]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "[";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox3.Controls.Add(this.low);
            this.groupBox3.Controls.Add(this.high);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.fx5);
            this.groupBox3.Controls.Add(this.fx4);
            this.groupBox3.Controls.Add(this.fx3);
            this.groupBox3.Controls.Add(this.fx2);
            this.groupBox3.Controls.Add(this.fx1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(6, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 234);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // low
            // 
            this.low.Location = new System.Drawing.Point(65, 155);
            this.low.Name = "low";
            this.low.Size = new System.Drawing.Size(28, 20);
            this.low.TabIndex = 8;
            this.low.Text = "0";
            this.low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // high
            // 
            this.high.Location = new System.Drawing.Point(111, 155);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(28, 20);
            this.high.TabIndex = 8;
            this.high.Text = "10";
            this.high.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = ",";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "[";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "( -5 --> 5 )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "( -5 --> 5 )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "( 0 --> 10 )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "( -4 --> 4 )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "( 0 --> 10 )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Range";
            // 
            // fx5
            // 
            this.fx5.AutoSize = true;
            this.fx5.Location = new System.Drawing.Point(13, 112);
            this.fx5.Name = "fx5";
            this.fx5.Size = new System.Drawing.Size(148, 17);
            this.fx5.TabIndex = 5;
            this.fx5.Text = "f(x) =Sin(x) * Sin(x) - Cos(x)";
            this.fx5.UseVisualStyleBackColor = true;
            this.fx5.CheckedChanged += new System.EventHandler(this.fx5_CheckedChanged);
            // 
            // fx4
            // 
            this.fx4.AutoSize = true;
            this.fx4.Location = new System.Drawing.Point(13, 90);
            this.fx4.Name = "fx4";
            this.fx4.Size = new System.Drawing.Size(127, 17);
            this.fx4.TabIndex = 4;
            this.fx4.Text = "f(x) =0.3 * X ^3 - 4 * X";
            this.fx4.UseVisualStyleBackColor = true;
            this.fx4.CheckedChanged += new System.EventHandler(this.fx4_CheckedChanged);
            // 
            // fx3
            // 
            this.fx3.AutoSize = true;
            this.fx3.Location = new System.Drawing.Point(13, 68);
            this.fx3.Name = "fx3";
            this.fx3.Size = new System.Drawing.Size(140, 17);
            this.fx3.TabIndex = 3;
            this.fx3.Text = "f(x) =12* Sin(x) - 0.1*X^2";
            this.fx3.UseVisualStyleBackColor = true;
            this.fx3.CheckedChanged += new System.EventHandler(this.fx3_CheckedChanged);
            // 
            // fx2
            // 
            this.fx2.AutoSize = true;
            this.fx2.Location = new System.Drawing.Point(13, 46);
            this.fx2.Name = "fx2";
            this.fx2.Size = new System.Drawing.Size(68, 17);
            this.fx2.TabIndex = 2;
            this.fx2.Text = "f(x) = x^2";
            this.fx2.UseVisualStyleBackColor = true;
            this.fx2.CheckedChanged += new System.EventHandler(this.fx2_CheckedChanged);
            // 
            // fx1
            // 
            this.fx1.AutoSize = true;
            this.fx1.Checked = true;
            this.fx1.Location = new System.Drawing.Point(13, 24);
            this.fx1.Name = "fx1";
            this.fx1.Size = new System.Drawing.Size(128, 17);
            this.fx1.TabIndex = 1;
            this.fx1.TabStop = true;
            this.fx1.Text = "f(x) = x^2 - x^4 * sin(x)";
            this.fx1.UseVisualStyleBackColor = true;
            this.fx1.CheckedChanged += new System.EventHandler(this.fx1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(246, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 514);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph";
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(14, 19);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.CustomProperties = "LineTension=0.2";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(565, 483);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox low;
        private System.Windows.Forms.TextBox high;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fx5;
        private System.Windows.Forms.RadioButton fx4;
        private System.Windows.Forms.RadioButton fx3;
        private System.Windows.Forms.RadioButton fx2;
        private System.Windows.Forms.RadioButton fx1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scoreOfLocal;
        private System.Windows.Forms.Label localValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lowRang;
        private System.Windows.Forms.RadioButton max;
        private System.Windows.Forms.TextBox highRang;
        private System.Windows.Forms.RadioButton min;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

