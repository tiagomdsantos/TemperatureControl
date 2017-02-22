namespace Supervisório
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
			System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation7 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.btn_tempAsub = new System.Windows.Forms.Button();
			this.btn_tempAplus = new System.Windows.Forms.Button();
			this.btn_tempBsub = new System.Windows.Forms.Button();
			this.btn_tempBplus = new System.Windows.Forms.Button();
			this.btn_Fechar = new System.Windows.Forms.Button();
			this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_tempAsub
			// 
			this.btn_tempAsub.Location = new System.Drawing.Point(45, 407);
			this.btn_tempAsub.Name = "btn_tempAsub";
			this.btn_tempAsub.Size = new System.Drawing.Size(75, 23);
			this.btn_tempAsub.TabIndex = 0;
			this.btn_tempAsub.Text = "-";
			this.btn_tempAsub.UseVisualStyleBackColor = true;
			this.btn_tempAsub.Click += new System.EventHandler(this.btn_tempAsub_Click);
			// 
			// btn_tempAplus
			// 
			this.btn_tempAplus.Location = new System.Drawing.Point(142, 407);
			this.btn_tempAplus.Name = "btn_tempAplus";
			this.btn_tempAplus.Size = new System.Drawing.Size(75, 23);
			this.btn_tempAplus.TabIndex = 1;
			this.btn_tempAplus.Text = "+";
			this.btn_tempAplus.UseVisualStyleBackColor = true;
			this.btn_tempAplus.Click += new System.EventHandler(this.btn_tempAplus_Click);
			// 
			// btn_tempBsub
			// 
			this.btn_tempBsub.Location = new System.Drawing.Point(313, 407);
			this.btn_tempBsub.Name = "btn_tempBsub";
			this.btn_tempBsub.Size = new System.Drawing.Size(75, 23);
			this.btn_tempBsub.TabIndex = 3;
			this.btn_tempBsub.Text = "-";
			this.btn_tempBsub.UseVisualStyleBackColor = true;
			this.btn_tempBsub.Click += new System.EventHandler(this.btn_tempBsub_Click);
			// 
			// btn_tempBplus
			// 
			this.btn_tempBplus.Location = new System.Drawing.Point(412, 407);
			this.btn_tempBplus.Name = "btn_tempBplus";
			this.btn_tempBplus.Size = new System.Drawing.Size(75, 23);
			this.btn_tempBplus.TabIndex = 2;
			this.btn_tempBplus.Text = "+";
			this.btn_tempBplus.UseVisualStyleBackColor = true;
			this.btn_tempBplus.Click += new System.EventHandler(this.btn_tempBplus_Click);
			// 
			// btn_Fechar
			// 
			this.btn_Fechar.Location = new System.Drawing.Point(448, 479);
			this.btn_Fechar.Name = "btn_Fechar";
			this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
			this.btn_Fechar.TabIndex = 4;
			this.btn_Fechar.Text = "Fechar";
			this.btn_Fechar.UseVisualStyleBackColor = true;
			this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
			// 
			// cpuChart
			// 
			lineAnnotation7.Name = "Series1";
			this.cpuChart.Annotations.Add(lineAnnotation7);
			chartArea7.Name = "ChartArea1";
			this.cpuChart.ChartAreas.Add(chartArea7);
			legend7.Name = "Legend1";
			this.cpuChart.Legends.Add(legend7);
			this.cpuChart.Location = new System.Drawing.Point(45, 24);
			this.cpuChart.Name = "cpuChart";
			this.cpuChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series7.ChartArea = "ChartArea1";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series7.Legend = "Legend1";
			series7.Name = "Series1";
			this.cpuChart.Series.Add(series7);
			this.cpuChart.Size = new System.Drawing.Size(442, 359);
			this.cpuChart.TabIndex = 5;
			this.cpuChart.Text = "chart1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(539, 521);
			this.Controls.Add(this.cpuChart);
			this.Controls.Add(this.btn_Fechar);
			this.Controls.Add(this.btn_tempBsub);
			this.Controls.Add(this.btn_tempBplus);
			this.Controls.Add(this.btn_tempAplus);
			this.Controls.Add(this.btn_tempAsub);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_tempAsub;
		private System.Windows.Forms.Button btn_tempAplus;
		private System.Windows.Forms.Button btn_tempBsub;
		private System.Windows.Forms.Button btn_tempBplus;
		private System.Windows.Forms.Button btn_Fechar;
		private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
	}
}

