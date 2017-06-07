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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_tempAsub = new System.Windows.Forms.Button();
            this.btn_tempAplus = new System.Windows.Forms.Button();
            this.btn_tempBsub = new System.Windows.Forms.Button();
            this.btn_tempBplus = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_ports = new System.Windows.Forms.ComboBox();
            this.data_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lb_TempA_sp = new System.Windows.Forms.Label();
            this.lb_TempA_value = new System.Windows.Forms.Label();
            this.lb_TempB_sp = new System.Windows.Forms.Label();
            this.lb_TempB_value = new System.Windows.Forms.Label();
            this.lb_tempA_control = new System.Windows.Forms.Label();
            this.lb_tempB_control = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_atuador1 = new System.Windows.Forms.Button();
            this.btn_atuador2 = new System.Windows.Forms.Button();
            this.cb_atuador2 = new System.Windows.Forms.CheckBox();
            this.cb_atuador1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Passo1 = new System.Windows.Forms.TextBox();
            this.txb_Passo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
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
            this.btn_Fechar.Location = new System.Drawing.Point(715, 561);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 4;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // tempChart
            // 
            lineAnnotation1.Name = "Series1";
            this.tempChart.Annotations.Add(lineAnnotation1);
            chartArea1.Name = "ChartArea1";
            this.tempChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tempChart.Legends.Add(legend1);
            this.tempChart.Location = new System.Drawing.Point(12, 12);
            this.tempChart.Name = "tempChart";
            this.tempChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.IndianRed;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "tempA_SetPoint";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Aqua;
            series2.Legend = "Legend1";
            series2.Name = "tempB_SetPoint";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "tempA_usb";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.Legend = "Legend1";
            series4.Name = "tempB_usb";
            this.tempChart.Series.Add(series1);
            this.tempChart.Series.Add(series2);
            this.tempChart.Series.Add(series3);
            this.tempChart.Series.Add(series4);
            this.tempChart.Size = new System.Drawing.Size(778, 354);
            this.tempChart.TabIndex = 5;
            this.tempChart.Text = "chart1";
            title1.Name = "Controle de temperatura";
            this.tempChart.Titles.Add(title1);
            // 
            // cb_ports
            // 
            this.cb_ports.FormattingEnabled = true;
            this.cb_ports.Location = new System.Drawing.Point(585, 422);
            this.cb_ports.Name = "cb_ports";
            this.cb_ports.Size = new System.Drawing.Size(121, 21);
            this.cb_ports.TabIndex = 6;
            this.cb_ports.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(45, 461);
            this.data_tb.Multiline = true;
            this.data_tb.Name = "data_tb";
            this.data_tb.Size = new System.Drawing.Size(442, 124);
            this.data_tb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Porta:";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(715, 449);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(715, 478);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(715, 508);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lb_TempA_sp
            // 
            this.lb_TempA_sp.AutoSize = true;
            this.lb_TempA_sp.Location = new System.Drawing.Point(631, 129);
            this.lb_TempA_sp.Name = "lb_TempA_sp";
            this.lb_TempA_sp.Size = new System.Drawing.Size(60, 13);
            this.lb_TempA_sp.TabIndex = 12;
            this.lb_TempA_sp.Text = "Set Point A";
            // 
            // lb_TempA_value
            // 
            this.lb_TempA_value.AutoSize = true;
            this.lb_TempA_value.Location = new System.Drawing.Point(697, 129);
            this.lb_TempA_value.Name = "lb_TempA_value";
            this.lb_TempA_value.Size = new System.Drawing.Size(35, 13);
            this.lb_TempA_value.TabIndex = 13;
            this.lb_TempA_value.Text = "label2";
            // 
            // lb_TempB_sp
            // 
            this.lb_TempB_sp.AutoSize = true;
            this.lb_TempB_sp.Location = new System.Drawing.Point(631, 158);
            this.lb_TempB_sp.Name = "lb_TempB_sp";
            this.lb_TempB_sp.Size = new System.Drawing.Size(60, 13);
            this.lb_TempB_sp.TabIndex = 14;
            this.lb_TempB_sp.Text = "Set Point B";
            // 
            // lb_TempB_value
            // 
            this.lb_TempB_value.AutoSize = true;
            this.lb_TempB_value.Location = new System.Drawing.Point(697, 158);
            this.lb_TempB_value.Name = "lb_TempB_value";
            this.lb_TempB_value.Size = new System.Drawing.Size(35, 13);
            this.lb_TempB_value.TabIndex = 15;
            this.lb_TempB_value.Text = "label3";
            // 
            // lb_tempA_control
            // 
            this.lb_tempA_control.AutoSize = true;
            this.lb_tempA_control.Location = new System.Drawing.Point(74, 391);
            this.lb_tempA_control.Name = "lb_tempA_control";
            this.lb_tempA_control.Size = new System.Drawing.Size(117, 13);
            this.lb_tempA_control.TabIndex = 16;
            this.lb_tempA_control.Text = "Controle do Set Point A";
            // 
            // lb_tempB_control
            // 
            this.lb_tempB_control.AutoSize = true;
            this.lb_tempB_control.Location = new System.Drawing.Point(344, 391);
            this.lb_tempB_control.Name = "lb_tempB_control";
            this.lb_tempB_control.Size = new System.Drawing.Size(117, 13);
            this.lb_tempB_control.TabIndex = 17;
            this.lb_tempB_control.Text = "Controle do Set Point B";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(631, 449);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(715, 422);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_atuador1
            // 
            this.btn_atuador1.Location = new System.Drawing.Point(45, 365);
            this.btn_atuador1.Name = "btn_atuador1";
            this.btn_atuador1.Size = new System.Drawing.Size(75, 23);
            this.btn_atuador1.TabIndex = 20;
            this.btn_atuador1.Text = "Ligar";
            this.btn_atuador1.UseVisualStyleBackColor = true;
            this.btn_atuador1.Click += new System.EventHandler(this.btn_atuador1_click);
            // 
            // btn_atuador2
            // 
            this.btn_atuador2.Location = new System.Drawing.Point(313, 365);
            this.btn_atuador2.Name = "btn_atuador2";
            this.btn_atuador2.Size = new System.Drawing.Size(75, 23);
            this.btn_atuador2.TabIndex = 21;
            this.btn_atuador2.Text = "Ligar";
            this.btn_atuador2.UseVisualStyleBackColor = true;
            this.btn_atuador2.Click += new System.EventHandler(this.btn_atuador2_Click);
            // 
            // cb_atuador2
            // 
            this.cb_atuador2.AutoSize = true;
            this.cb_atuador2.Enabled = false;
            this.cb_atuador2.Location = new System.Drawing.Point(412, 365);
            this.cb_atuador2.Name = "cb_atuador2";
            this.cb_atuador2.Size = new System.Drawing.Size(58, 17);
            this.cb_atuador2.TabIndex = 22;
            this.cb_atuador2.Text = "Ligado";
            this.cb_atuador2.UseVisualStyleBackColor = true;
            // 
            // cb_atuador1
            // 
            this.cb_atuador1.AutoSize = true;
            this.cb_atuador1.Enabled = false;
            this.cb_atuador1.Location = new System.Drawing.Point(142, 365);
            this.cb_atuador1.Name = "cb_atuador1";
            this.cb_atuador1.Size = new System.Drawing.Size(58, 17);
            this.cb_atuador1.TabIndex = 23;
            this.cb_atuador1.Text = "Ligado";
            this.cb_atuador1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Passo Set Point A:";
            // 
            // txb_Passo1
            // 
            this.txb_Passo1.Location = new System.Drawing.Point(117, 439);
            this.txb_Passo1.Name = "txb_Passo1";
            this.txb_Passo1.Size = new System.Drawing.Size(100, 20);
            this.txb_Passo1.TabIndex = 25;
            this.txb_Passo1.Text = "1";
            this.txb_Passo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Passo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Passo1_KeyPress);
            // 
            // txb_Passo2
            // 
            this.txb_Passo2.Location = new System.Drawing.Point(387, 436);
            this.txb_Passo2.Name = "txb_Passo2";
            this.txb_Passo2.Size = new System.Drawing.Size(100, 20);
            this.txb_Passo2.TabIndex = 27;
            this.txb_Passo2.Text = "1";
            this.txb_Passo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Passo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Passo2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Passo Set Point B";
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(634, 508);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 29;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 601);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.txb_Passo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Passo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_atuador1);
            this.Controls.Add(this.cb_atuador2);
            this.Controls.Add(this.btn_atuador2);
            this.Controls.Add(this.btn_atuador1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lb_tempB_control);
            this.Controls.Add(this.lb_tempA_control);
            this.Controls.Add(this.lb_TempB_value);
            this.Controls.Add(this.lb_TempB_sp);
            this.Controls.Add(this.lb_TempA_value);
            this.Controls.Add(this.lb_TempA_sp);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_tb);
            this.Controls.Add(this.cb_ports);
            this.Controls.Add(this.tempChart);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_tempBsub);
            this.Controls.Add(this.btn_tempBplus);
            this.Controls.Add(this.btn_tempAplus);
            this.Controls.Add(this.btn_tempAsub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refeitório";
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_tempAsub;
		private System.Windows.Forms.Button btn_tempAplus;
		private System.Windows.Forms.Button btn_tempBsub;
		private System.Windows.Forms.Button btn_tempBplus;
		private System.Windows.Forms.Button btn_Fechar;
		private System.Windows.Forms.DataVisualization.Charting.Chart tempChart;
		private System.Windows.Forms.ComboBox cb_ports;
		private System.Windows.Forms.TextBox data_tb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Label lb_TempA_sp;
		private System.Windows.Forms.Label lb_TempA_value;
		private System.Windows.Forms.Label lb_TempB_sp;
		private System.Windows.Forms.Label lb_TempB_value;
		private System.Windows.Forms.Label lb_tempA_control;
		private System.Windows.Forms.Label lb_tempB_control;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_atuador1;
        private System.Windows.Forms.Button btn_atuador2;
        private System.Windows.Forms.CheckBox cb_atuador2;
        private System.Windows.Forms.CheckBox cb_atuador1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Passo1;
        private System.Windows.Forms.TextBox txb_Passo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Export;
    }
}

