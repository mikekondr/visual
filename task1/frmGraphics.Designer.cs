namespace task1
{
    partial class frmGraphics
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.lbl_txtStep = new System.Windows.Forms.Label();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.lbl_txtXmax = new System.Windows.Forms.Label();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.lbl_txtXmin = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFunc4 = new System.Windows.Forms.CheckBox();
            this.chkFunc3 = new System.Windows.Forms.CheckBox();
            this.chkFunc2 = new System.Windows.Forms.CheckBox();
            this.chkFunc1 = new System.Windows.Forms.CheckBox();
            this.chkFunc0 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbFunc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "y = sin(x)";
            series1.Name = "func1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "y = cos(x)";
            series2.Name = "func2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "y = cos(x) + 2x";
            series3.Name = "func3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "y = √x";
            series4.Name = "func4";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "y = x^2 + x + 4";
            series5.Name = "func5";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Size = new System.Drawing.Size(591, 379);
            this.chart.TabIndex = 0;
            this.chart.Text = "Графік";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtStep);
            this.groupBox1.Controls.Add(this.lbl_txtStep);
            this.groupBox1.Controls.Add(this.txtXmax);
            this.groupBox1.Controls.Add(this.lbl_txtXmax);
            this.groupBox1.Controls.Add(this.txtXmin);
            this.groupBox1.Controls.Add(this.lbl_txtXmin);
            this.groupBox1.Location = new System.Drawing.Point(609, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вихідні дані";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(55, 75);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(69, 20);
            this.txtStep.TabIndex = 5;
            // 
            // lbl_txtStep
            // 
            this.lbl_txtStep.AutoSize = true;
            this.lbl_txtStep.Location = new System.Drawing.Point(6, 78);
            this.lbl_txtStep.Name = "lbl_txtStep";
            this.lbl_txtStep.Size = new System.Drawing.Size(35, 13);
            this.lbl_txtStep.TabIndex = 4;
            this.lbl_txtStep.Text = "Крок:";
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(55, 49);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(69, 20);
            this.txtXmax.TabIndex = 3;
            // 
            // lbl_txtXmax
            // 
            this.lbl_txtXmax.AutoSize = true;
            this.lbl_txtXmax.Location = new System.Drawing.Point(6, 52);
            this.lbl_txtXmax.Name = "lbl_txtXmax";
            this.lbl_txtXmax.Size = new System.Drawing.Size(36, 13);
            this.lbl_txtXmax.TabIndex = 2;
            this.lbl_txtXmax.Text = "Xmax:";
            // 
            // txtXmin
            // 
            this.txtXmin.Location = new System.Drawing.Point(55, 23);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(69, 20);
            this.txtXmin.TabIndex = 1;
            // 
            // lbl_txtXmin
            // 
            this.lbl_txtXmin.AutoSize = true;
            this.lbl_txtXmin.Location = new System.Drawing.Point(6, 26);
            this.lbl_txtXmin.Name = "lbl_txtXmin";
            this.lbl_txtXmin.Size = new System.Drawing.Size(33, 13);
            this.lbl_txtXmin.TabIndex = 0;
            this.lbl_txtXmin.Text = "Xmin:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkFunc4);
            this.groupBox2.Controls.Add(this.chkFunc3);
            this.groupBox2.Controls.Add(this.chkFunc2);
            this.groupBox2.Controls.Add(this.chkFunc1);
            this.groupBox2.Controls.Add(this.chkFunc0);
            this.groupBox2.Location = new System.Drawing.Point(609, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Побудова графіка";
            // 
            // chkFunc4
            // 
            this.chkFunc4.AutoSize = true;
            this.chkFunc4.Location = new System.Drawing.Point(9, 111);
            this.chkFunc4.Name = "chkFunc4";
            this.chkFunc4.Size = new System.Drawing.Size(95, 17);
            this.chkFunc4.TabIndex = 4;
            this.chkFunc4.Text = "y = x^2 + x + 4";
            this.chkFunc4.UseVisualStyleBackColor = true;
            // 
            // chkFunc3
            // 
            this.chkFunc3.AutoSize = true;
            this.chkFunc3.Location = new System.Drawing.Point(9, 88);
            this.chkFunc3.Name = "chkFunc3";
            this.chkFunc3.Size = new System.Drawing.Size(54, 17);
            this.chkFunc3.TabIndex = 3;
            this.chkFunc3.Text = "y = √x";
            this.chkFunc3.UseVisualStyleBackColor = true;
            // 
            // chkFunc2
            // 
            this.chkFunc2.AutoSize = true;
            this.chkFunc2.Location = new System.Drawing.Point(9, 65);
            this.chkFunc2.Name = "chkFunc2";
            this.chkFunc2.Size = new System.Drawing.Size(94, 17);
            this.chkFunc2.TabIndex = 2;
            this.chkFunc2.Text = "y = cos(x) + 2x";
            this.chkFunc2.UseVisualStyleBackColor = true;
            // 
            // chkFunc1
            // 
            this.chkFunc1.AutoSize = true;
            this.chkFunc1.Location = new System.Drawing.Point(9, 42);
            this.chkFunc1.Name = "chkFunc1";
            this.chkFunc1.Size = new System.Drawing.Size(71, 17);
            this.chkFunc1.TabIndex = 1;
            this.chkFunc1.Text = "y = cos(x)";
            this.chkFunc1.UseVisualStyleBackColor = true;
            // 
            // chkFunc0
            // 
            this.chkFunc0.AutoSize = true;
            this.chkFunc0.Location = new System.Drawing.Point(9, 19);
            this.chkFunc0.Name = "chkFunc0";
            this.chkFunc0.Size = new System.Drawing.Size(67, 17);
            this.chkFunc0.TabIndex = 0;
            this.chkFunc0.Text = "y = sin(x)";
            this.chkFunc0.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbFunc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Location = new System.Drawing.Point(750, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 379);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Значення графіка";
            // 
            // cbFunc
            // 
            this.cbFunc.FormattingEnabled = true;
            this.cbFunc.Items.AddRange(new object[] {
            "y = sinx(x)",
            "y = cos(x)",
            "y = cos(x) + 2x",
            "y = √x",
            "y = x^2 + x + 4"});
            this.cbFunc.Location = new System.Drawing.Point(6, 58);
            this.cbFunc.Name = "cbFunc";
            this.cbFunc.Size = new System.Drawing.Size(188, 21);
            this.cbFunc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Оберіть функцію для виводу\r\nрозрахунку:";
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtData.Location = new System.Drawing.Point(6, 85);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(188, 288);
            this.txtData.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Location = new System.Drawing.Point(610, 277);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(134, 34);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Розрахувати";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(610, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистити графік";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(610, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.Name = "frmGraphics";
            this.Text = "Графіки функцій";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label lbl_txtStep;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.Label lbl_txtXmax;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.Label lbl_txtXmin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFunc4;
        private System.Windows.Forms.CheckBox chkFunc3;
        private System.Windows.Forms.CheckBox chkFunc2;
        private System.Windows.Forms.CheckBox chkFunc1;
        private System.Windows.Forms.CheckBox chkFunc0;
        private System.Windows.Forms.ComboBox cbFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

