using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;




namespace Supervisório
{
	public partial class Form1 : Form
	{
		
		private double tempA = 70;
		private double tempB = 5;
		

		private SerialPort temp = new SerialPort();
		private DateTime date;
		private String in_data = "";

		string[] ports = SerialPort.GetPortNames();



		public Form1()
		{
			InitializeComponent();

			lb_TempA_value.Text = tempA + " °C";
			lb_TempB_value.Text = tempB + " °C";

			foreach (string port in ports)	//checking which usb ports are available
			{
				cb_ports.Items.Add(port);
			}


		}


		
		private void btn_Fechar_Click(object sender, EventArgs e)
		{

			Application.Exit();
		}

		private void btn_tempAsub_Click(object sender, EventArgs e)
		{
			tempA += -1;
			lb_TempA_value.Text = tempA + " °C";
		}

		private void btn_tempAplus_Click(object sender, EventArgs e)
		{
			tempA += 1;
			lb_TempA_value.Text = tempA + " °C";
		}

		private void btn_tempBsub_Click(object sender, EventArgs e)
		{
			tempB += -1;
			lb_TempB_value.Text = tempB + " °C";
		}

		private void btn_tempBplus_Click(object sender, EventArgs e)
		{
			tempB += 1;
			lb_TempB_value.Text = tempB + " °C";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btn_Start_Click(object sender, EventArgs e)
		{


			temp.Close();
			temp.BaudRate = 9600;
			try
			{
				temp.PortName = cb_ports.Items[this.cb_ports.SelectedIndex].ToString();
			}
			catch (Exception)
			{

			}
			temp.Parity = Parity.None;
			temp.DataBits = 8;
			temp.StopBits = StopBits.One;
			temp.DataReceived += temp_dataReceived;
			
			try
			{
				temp.Open();
				data_tb.Text = "";
				temp.WriteLine("on");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");

			}
		}

		private void btn_stop_Click(object sender, EventArgs e)
		{
			try
			{
				temp.WriteLine("off");
				temp.Close();
			}
			catch(Exception ex2)
			{
				MessageBox.Show(ex2.Message, "Error");
			}

		}



		void temp_dataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			

			this.Invoke(new EventHandler(displaydata_event));
			try
			{
				in_data = temp.ReadLine();
			}
			catch(Exception) { }
		}


		int num = 0;
		double time = 0;
		private void displaydata_event(object sender, EventArgs e)
		{
			time += 0.5;
			tempChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			tempChart.ChartAreas[0].RecalculateAxesScale();

			
			tempChart.Series["tempA_SetPoint"].Points.AddXY(time,tempA);
			tempChart.Series["tempB_SetPoint"].Points.AddXY(time,tempB);

			try
			{
				double temp_sensorA;
				double temp_sensorB;

				string controler_read = in_data;
				int dotcomma_position = 0;

				if (controler_read.Contains(";"))
				{
					dotcomma_position = controler_read.IndexOf(";");
					temp_sensorA = Convert.ToDouble(controler_read.Substring(0, dotcomma_position))/100;
					int Length_aux = controler_read.Length - dotcomma_position -1;
					temp_sensorB = Convert.ToDouble(controler_read.Substring(dotcomma_position + 1, Length_aux)) / 100; ;


					tempChart.Series["tempA_usb"].Points.AddXY(time, temp_sensorA);
					tempChart.Series["tempB_usb"].Points.AddXY(time, temp_sensorB);
					num++;
					data_tb.AppendText("Temperatura A: "+temp_sensorA+"\t\t"+"Temperatura B: "+temp_sensorB + "\n");
				}
				else { }
			}
			catch (FormatException) { }

			if (num >= 100)
			{

				tempChart.Series["tempA_SetPoint"].Points.RemoveAt(0);
				tempChart.Series["tempB_SetPoint"].Points.RemoveAt(0);
				tempChart.Series["tempA_usb"].Points.RemoveAt(0);
				tempChart.Series["tempB_usb"].Points.RemoveAt(0);

			}

		}



		private void btn_Save_Click(object sender, EventArgs e)
		{
			try
			{
				date = DateTime.Now;
				string pathfile = @"C:\Users\tiago\Dropbox\PI - Supervisório\PC\dados salvos\";
				string fileName = date.Day.ToString() + "." + date.Month.ToString() + "." + date.Year.ToString()
					+ "-" + date.Hour.ToString() + "." + date.Minute.ToString() + ".txt";
				System.IO.File.WriteAllText(pathfile + fileName, data_tb.Text);
				MessageBox.Show("Data has been saved to " + pathfile, "Save File");
			}
			catch(Exception ex3)
			{
				MessageBox.Show(ex3.Message, "Error");
			}
		}

		private void btn_reset_Click(object sender, EventArgs e)
		{
			try
			{
				tempChart.Series[0].Points.Clear();
				tempChart.Series[1].Points.Clear();
				tempChart.Series[2].Points.Clear();
				tempChart.Series[3].Points.Clear();
				data_tb.Text = "";
			}
			catch (Exception) { }
		}
	}
}
