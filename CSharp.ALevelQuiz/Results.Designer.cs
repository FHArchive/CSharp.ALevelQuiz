namespace ALevelQuiz
{
    partial class Results
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ResultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResults = new System.Windows.Forms.Label();
            this.LblResultsHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea";
            this.ResultsChart.ChartAreas.Add(chartArea1);
            this.ResultsChart.Location = new System.Drawing.Point(0, 155);
            this.ResultsChart.Name = "ResultsChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.ResultsChart.Series.Add(series1);
            this.ResultsChart.Size = new System.Drawing.Size(200, 200);
            this.ResultsChart.TabIndex = 0;
            this.ResultsChart.Text = "chart1";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 39);
            this.Title.TabIndex = 30;
            this.Title.Text = "Results";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "Past Results";
            // 
            // LblResults
            // 
            this.LblResults.AutoSize = true;
            this.LblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResults.Location = new System.Drawing.Point(0, 39);
            this.LblResults.MaximumSize = new System.Drawing.Size(200, 1000);
            this.LblResults.MinimumSize = new System.Drawing.Size(200, 0);
            this.LblResults.Name = "LblResults";
            this.LblResults.Size = new System.Drawing.Size(200, 16);
            this.LblResults.TabIndex = 32;
            // 
            // LblResultsHistory
            // 
            this.LblResultsHistory.AutoSize = true;
            this.LblResultsHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultsHistory.Location = new System.Drawing.Point(0, 120);
            this.LblResultsHistory.MaximumSize = new System.Drawing.Size(200, 1000);
            this.LblResultsHistory.MinimumSize = new System.Drawing.Size(200, 0);
            this.LblResultsHistory.Name = "LblResultsHistory";
            this.LblResultsHistory.Size = new System.Drawing.Size(200, 32);
            this.LblResultsHistory.TabIndex = 33;
            this.LblResultsHistory.Text = "The Graph Below shows your previous 10 results.";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 565);
            this.Controls.Add(this.LblResultsHistory);
            this.Controls.Add(this.LblResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ResultsChart);
            this.MaximizeBox = false;
            this.Name = "Results";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ResultsChart;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResults;
        private System.Windows.Forms.Label LblResultsHistory;

    }
}