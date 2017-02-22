﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;
namespace Supervisório
{
	public partial class Form1 : Form
	{

		private Thread cpuThread;
		private double[] cpuArray = new double[60];

		public Form1()
		{
			InitializeComponent();

			cpuThread = new Thread(new ThreadStart(this.getperfomancecounters));
			cpuThread.IsBackground = true;

			cpuThread.Start();

		}

		private void getperfomancecounters()
		{
			var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

			while (true)
			{
				cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(),0);
				Array.Copy(cpuArray,1,cpuArray, 0, cpuArray.Length - 1);
				if (cpuChart.IsHandleCreated)
				{
					this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
				}
				else
				{
					//.....
				}
				Thread.Sleep(200);
			}
		}

		private void UpdateCpuChart()
		{
			cpuChart.Series["Series1"].Points.Clear();
			for(int i = 0; i < cpuArray.Length - 1; ++i)
			{
				cpuChart.Series["Series1"].Points.AddY(cpuArray[i]);
			}
		}




		private void btn_Fechar_Click(object sender, EventArgs e)
		{

			
		}

		private void btn_tempAsub_Click(object sender, EventArgs e)
		{

		}

		private void btn_tempAplus_Click(object sender, EventArgs e)
		{

		}

		private void btn_tempBsub_Click(object sender, EventArgs e)
		{

		}

		private void btn_tempBplus_Click(object sender, EventArgs e)
		{

		}
	}
}
