namespace task2
{
    partial class frmDaig
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvYears = new System.Windows.Forms.DataGridView();
            this.btnGenEmptyYears = new System.Windows.Forms.Button();
            this.txtCountYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRound = new System.Windows.Forms.DataGridView();
            this.btnGenEmptyRound = new System.Windows.Forms.Button();
            this.txtMinRound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountRound = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenGisto = new System.Windows.Forms.Button();
            this.btnGenRound = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYears)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRound)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.PeachPuff;
            this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea1.Name = "ChartArea1";
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea2";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.DockedToChartArea = "ChartArea2";
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend2";
            this.chart.Legends.Add(legend1);
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Кількість учнів";
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend2";
            series2.Name = "Series2";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(408, 382);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            title1.DockedToChartArea = "ChartArea1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Кількість учнів за роками";
            title2.DockedToChartArea = "ChartArea2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "Кількість учнів за віковими групами";
            this.chart.Titles.Add(title1);
            this.chart.Titles.Add(title2);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvYears);
            this.groupBox1.Controls.Add(this.btnGenEmptyYears);
            this.groupBox1.Controls.Add(this.txtCountYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStartYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(426, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дані гістограми - кількість учнів за роками";
            // 
            // dgvYears
            // 
            this.dgvYears.AllowUserToAddRows = false;
            this.dgvYears.AllowUserToDeleteRows = false;
            this.dgvYears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYears.Location = new System.Drawing.Point(6, 79);
            this.dgvYears.Name = "dgvYears";
            this.dgvYears.Size = new System.Drawing.Size(599, 103);
            this.dgvYears.TabIndex = 5;
            // 
            // btnGenEmptyYears
            // 
            this.btnGenEmptyYears.Location = new System.Drawing.Point(428, 25);
            this.btnGenEmptyYears.Name = "btnGenEmptyYears";
            this.btnGenEmptyYears.Size = new System.Drawing.Size(177, 48);
            this.btnGenEmptyYears.TabIndex = 4;
            this.btnGenEmptyYears.Text = "Сгенерувати порожній масив";
            this.btnGenEmptyYears.UseVisualStyleBackColor = true;
            this.btnGenEmptyYears.Click += new System.EventHandler(this.btnGenEmptyYears_Click);
            // 
            // txtCountYear
            // 
            this.txtCountYear.Location = new System.Drawing.Point(174, 53);
            this.txtCountYear.Name = "txtCountYear";
            this.txtCountYear.Size = new System.Drawing.Size(100, 20);
            this.txtCountYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість років:";
            // 
            // txtStartYear
            // 
            this.txtStartYear.Location = new System.Drawing.Point(174, 26);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(100, 20);
            this.txtStartYear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть початковий рік:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvRound);
            this.groupBox2.Controls.Add(this.btnGenEmptyRound);
            this.groupBox2.Controls.Add(this.txtMinRound);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCountRound);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(426, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дані кругової діаграми - кількість учнів за віком";
            // 
            // dgvRound
            // 
            this.dgvRound.AllowUserToAddRows = false;
            this.dgvRound.AllowUserToDeleteRows = false;
            this.dgvRound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRound.Location = new System.Drawing.Point(6, 79);
            this.dgvRound.Name = "dgvRound";
            this.dgvRound.Size = new System.Drawing.Size(599, 103);
            this.dgvRound.TabIndex = 10;
            // 
            // btnGenEmptyRound
            // 
            this.btnGenEmptyRound.Location = new System.Drawing.Point(428, 18);
            this.btnGenEmptyRound.Name = "btnGenEmptyRound";
            this.btnGenEmptyRound.Size = new System.Drawing.Size(177, 48);
            this.btnGenEmptyRound.TabIndex = 9;
            this.btnGenEmptyRound.Text = "Сгенерувати порожній масив";
            this.btnGenEmptyRound.UseVisualStyleBackColor = true;
            this.btnGenEmptyRound.Click += new System.EventHandler(this.btnGenEmptyRound_Click);
            // 
            // txtMinRound
            // 
            this.txtMinRound.Location = new System.Drawing.Point(174, 46);
            this.txtMinRound.Name = "txtMinRound";
            this.txtMinRound.Size = new System.Drawing.Size(100, 20);
            this.txtMinRound.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Мінімальний вік:";
            // 
            // txtCountRound
            // 
            this.txtCountRound.Location = new System.Drawing.Point(174, 19);
            this.txtCountRound.Name = "txtCountRound";
            this.txtCountRound.Size = new System.Drawing.Size(100, 20);
            this.txtCountRound.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кількість вікових категорій:";
            // 
            // btnGenGisto
            // 
            this.btnGenGisto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenGisto.Location = new System.Drawing.Point(12, 400);
            this.btnGenGisto.Name = "btnGenGisto";
            this.btnGenGisto.Size = new System.Drawing.Size(181, 31);
            this.btnGenGisto.TabIndex = 3;
            this.btnGenGisto.Text = "Побудувати гістограму";
            this.btnGenGisto.UseVisualStyleBackColor = true;
            this.btnGenGisto.Click += new System.EventHandler(this.btnGenGisto_Click);
            // 
            // btnGenRound
            // 
            this.btnGenRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenRound.Location = new System.Drawing.Point(239, 400);
            this.btnGenRound.Name = "btnGenRound";
            this.btnGenRound.Size = new System.Drawing.Size(181, 31);
            this.btnGenRound.TabIndex = 4;
            this.btnGenRound.Text = "Побудувати кругову діаграму";
            this.btnGenRound.UseVisualStyleBackColor = true;
            this.btnGenRound.Click += new System.EventHandler(this.btnGenRound_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(888, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDaig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 440);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenRound);
            this.Controls.Add(this.btnGenGisto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.Name = "frmDaig";
            this.Text = "Діаграми";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYears)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCountYear;
        private System.Windows.Forms.DataGridView dgvYears;
        private System.Windows.Forms.Button btnGenEmptyYears;
        private System.Windows.Forms.Button btnGenEmptyRound;
        private System.Windows.Forms.TextBox txtMinRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRound;
        private System.Windows.Forms.Button btnGenGisto;
        private System.Windows.Forms.Button btnGenRound;
        private System.Windows.Forms.Button btnExit;
    }
}

