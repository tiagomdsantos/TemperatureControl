using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;

namespace Supervisório
{
	public partial class Form1 : Form
	{
		//Thread t;
				
		private double tempA = 70;
		private double tempB = 5;
		
        

		private SerialPort temp = new SerialPort();
		private DateTime date;
		private String in_data = "";

        
		string[] ports = SerialPort.GetPortNames();



		public Form1()
		{
			InitializeComponent();
            
            cb_atuador1.Enabled = false;
            cb_atuador2.Enabled = false;

            lb_TempA_value.Text = tempA + " °C";
			lb_TempB_value.Text = tempB + " °C";
			tempChart.Series[0].LegendText = "Set Point Quente";
			tempChart.Series[1].LegendText = "Set Point Frio";
			tempChart.Series[2].LegendText = "Temperatura Quente";
			tempChart.Series[3].LegendText = "Temperatura Fria";
			cb_ports.Items.Clear();

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
			tempA += -1*Convert.ToInt32(txb_Passo1.Text);
			lb_TempA_value.Text = tempA + " °C";
			try
			{
				temp.WriteLine("S1"+tempA*100+"S2"+tempB*100);
			}
			catch(Exception) { }
			}

		private void btn_tempAplus_Click(object sender, EventArgs e)
		{
            tempA += 1 * Convert.ToInt32(txb_Passo1.Text);
            lb_TempA_value.Text = tempA + " °C";
			try
			{
				temp.WriteLine("S1" + (int)tempA * 100 + "S2" + (int)tempB * 100);
			}
			catch (Exception) { }
		}

		private void btn_tempBsub_Click(object sender, EventArgs e)
		{
            tempB += -1 * Convert.ToInt32(txb_Passo2.Text);
            lb_TempB_value.Text = tempB + " °C";
			try
			{
				temp.WriteLine("S1" + tempA * 100 + "S2" + tempB * 100);
			}
			catch (Exception) { }
		}

		private void btn_tempBplus_Click(object sender, EventArgs e)
        {
            tempB += 1 * Convert.ToInt32(txb_Passo2.Text);
            lb_TempB_value.Text = tempB + " °C";
			try
			{
				temp.WriteLine("S1" + tempA * 100 + "S2" + tempB * 100);
			}
			catch (Exception) { }
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btn_Start_Click(object sender, EventArgs e)
		{

            //temp.WriteLine("on");
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
				//temp.WriteLine("on");
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
				//temp.WriteLine("off");
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
        List<string> auxiliar2 = new List<string>();

        List<string> auxiliar_excel_tempo = new List<string>();
        List<string> auxiliar_excel_tempA = new List<string>();
        List<string> auxiliar_excel_tempB = new List<string>();

        private void displaydata_event(object sender, EventArgs e)
		{
			time += 1;
			tempChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
			tempChart.ChartAreas[0].RecalculateAxesScale();

			
			tempChart.Series["tempA_SetPoint"].Points.AddXY(time,tempA);
			tempChart.Series["tempB_SetPoint"].Points.AddXY(time,tempB);
			

			try
			{
				double temp_sensorA;
				double temp_sensorB;
				string controler_read = in_data;
                
                int indexQ = controler_read.IndexOf("Q");
                if (controler_read.Contains("F") && controler_read.Contains("Q"))
				{
                    temp_sensorB = Convert.ToDouble(controler_read.Substring(1, indexQ-1)) / 100;      //receive temperature B(cold) from string
					temp_sensorA = Convert.ToDouble(controler_read.Substring(indexQ+1)) / 100;         //receive temperature A(hot) from string
					tempChart.Series["tempA_usb"].Points.AddXY(time, temp_sensorA);
					tempChart.Series["tempB_usb"].Points.AddXY(time, temp_sensorB);

                    //data_tb.AppendText("Temperatura A: " + temp_sensorA + "\t\t" + "Temperatura B: " + temp_sensorB + "\n");

                    data_tb.AppendText("Temperatura A: " + temp_sensorA + "\t\t" + "Temperatura B: " + temp_sensorB + "\n");
                    num +=1;	//counting how many samples has already been colected
                    auxiliar2.Add("Temperatura A: " + temp_sensorA + "\t\t" + "Temperatura B: " + temp_sensorB);
                    auxiliar_excel_tempo.Add(Convert.ToString(time));
                    auxiliar_excel_tempA.Add(Convert.ToString(temp_sensorA));
                    auxiliar_excel_tempB.Add(Convert.ToString(temp_sensorB));
                    
                }
				else {
				}
				
			}
			catch (Exception) { }

			/*if (num >= 100)
			{
				//clean the chart array at inicial position
				tempChart.Series["tempA_SetPoint"].Points.RemoveAt(0);
				tempChart.Series["tempB_SetPoint"].Points.RemoveAt(0);
				tempChart.Series["tempA_usb"].Points.RemoveAt(0);
				tempChart.Series["tempB_usb"].Points.RemoveAt(0);

			}*/

		}

        private void btn_Save_Click(object sender, EventArgs e)
		{
			//saves the collected samples into a txt archive
			try
			{

				date = DateTime.Now;

				string fileName = date.Day.ToString() + "." + date.Month.ToString() + "." + date.Year.ToString()
					+ "-" + date.Hour.ToString() + "." + date.Minute.ToString() + ".txt";
 
                SaveFileDialog save_data_dialog = new SaveFileDialog();

                //config data file name and type
                save_data_dialog.FileName = fileName;
                save_data_dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                save_data_dialog.FilterIndex = 1;
                save_data_dialog.RestoreDirectory = true;

                
                if (save_data_dialog.ShowDialog() == DialogResult.OK)
                {

                    using (Stream save_data_stream = File.Open(save_data_dialog.FileName, FileMode.CreateNew)) 
                    using (StreamWriter sw = new StreamWriter(save_data_stream))
                    {
                       foreach (String s in auxiliar2)
                        sw.WriteLine(s);
                    }

                }



			}
			catch(Exception ex3)
			{
				MessageBox.Show(ex3.Message, "Error");
			}
		}

		private void btn_reset_Click(object sender, EventArgs e)
		{
			//resets samples
			try
			{
				tempChart.Series[0].Points.Clear();
				tempChart.Series[1].Points.Clear();
				tempChart.Series[2].Points.Clear();
				tempChart.Series[3].Points.Clear();
                auxiliar2.Clear();
                auxiliar_excel_tempo.Clear();
                auxiliar_excel_tempA.Clear();
                auxiliar_excel_tempB.Clear();

                data_tb.Text = "";
			}
			catch (Exception) { }
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			//check if new USB port is available
			try
			{

				ports = SerialPort.GetPortNames();

				cb_ports.Items.Clear();

				foreach (string port in ports)  //checking which usb ports are available
				{
					cb_ports.Items.Add(port);
				}
			}
			catch (Exception) { }
		}



        private void btn_atuador1_click(object sender, EventArgs e)
        {
            if (btn_atuador1.Text == "Ligar")
            {
                try
                {
                    temp.WriteLine("L1");
                    cb_atuador1.Checked = true;
                    btn_atuador1.Text = "Desligar";
                }
                catch (Exception) { }
            }
            else if (btn_atuador1.Text == "Desligar")
            {
                try
                {
                    temp.WriteLine("D1");
                    cb_atuador1.Checked = false;
                    btn_atuador1.Text = "Ligar";
                }
                catch (Exception) { }
            }

        }

        private void btn_atuador2_Click(object sender, EventArgs e)
        {
            if (btn_atuador2.Text == "Ligar")
            {
                try
                {
                    temp.WriteLine("L2");
                    cb_atuador2.Checked = true;
                    btn_atuador2.Text = "Desligar";
                }
                catch (Exception) { }
            }
            else if (btn_atuador2.Text == "Desligar")
            {
                try
                {
                    temp.WriteLine("D2");
                    cb_atuador2.Checked = false;
                    btn_atuador2.Text = "Ligar";
                }
                catch (Exception) { }
            }

            }

        private void txb_Passo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txb_Passo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {

                date = DateTime.Now;

                string fileName = date.Day.ToString() + "." + date.Month.ToString() + "." + date.Year.ToString()
                    + "-" + date.Hour.ToString() + "." + date.Minute.ToString() + ".xls";

                SaveFileDialog save_data_dialog = new SaveFileDialog();

                //config data file name and type
                save_data_dialog.FileName = fileName;
                save_data_dialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
                save_data_dialog.FilterIndex = 1;
                save_data_dialog.RestoreDirectory = true;


                if (save_data_dialog.ShowDialog() == DialogResult.OK)
                {
                    string file = save_data_dialog.FileName;
                    Workbook wb = new Workbook();
                    Worksheet ws = new Worksheet(fileName);

                    ws.Cells[1, 1] = new Cell("Tempo(s)");
                    ws.Cells[1, 2] = new Cell("Temperatura Quente(ºC)");
                    ws.Cells[1, 3] = new Cell("Temperatura Fria(ºC)");

                    for (int i = 0;i< auxiliar_excel_tempo.Count(); i++)
                    {
                        ws.Cells[i + 2, 1] = new Cell(auxiliar_excel_tempo[i]);
                        ws.Cells[i + 2, 2] = new Cell(auxiliar_excel_tempA[i]);
                        ws.Cells[i + 2, 3] = new Cell(auxiliar_excel_tempB[i]);
                    }

                    wb.Worksheets.Add(ws);
                    wb.Save(file);
                }



            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message, "Error");
            }
        }
    }
  }

