using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        SerialPort arduinoPort = null;
        List<double> data;
        public MainForm()
        {
            InitializeComponent();
            data = new List<double>();
        }

        private void RefleshPortsButton_Click(object sender, EventArgs e)
        {
            PortsComboBox.DataSource = SerialPort.GetPortNames();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PortsComboBox.SelectedIndex >= 0)
                {
                    arduinoPort = new SerialPort(PortsComboBox.Text, 9600);
                    arduinoPort.ReadBufferSize = 1000000;
                    arduinoPort.RtsEnable = true;
                    arduinoPort.DtrEnable = true;
                    arduinoPort.NewLine = "\r\n";
                    arduinoPort.Open();
                    arduinoPort.ReadExisting();
                    DisConnectButton.Enabled = true;
                    ConnectButton.Enabled = false;
                    timer.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DisConnectButton_Click(object sender, EventArgs e)
        {
            arduinoPort.RtsEnable = false;
            arduinoPort.DtrEnable = false;
            arduinoPort.Close();
            arduinoPort = null;
            DisConnectButton.Enabled = false;
            ConnectButton.Enabled = true;
            timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            while (arduinoPort.BytesToRead > 0)
            {
                bool end = false;
                string s = arduinoPort.ReadLine();
                if (s.Equals("R"))
                {
                    end = true;
                    data.Reverse();
                }
                else if (s.Equals("L"))
                {
                    end = true;
                }
                else
                {
                    data.Add(Double.Parse(s));
                }

                if (end)
                {
                    chart.Series["m"].Points.Clear();
                    for (int i = 0; i < data.Count; i++)
                    {
                        chart.Series["m"].Points.AddXY(360.0 * i / data.Count, data[i]);
                    }
                    data.Clear();
                    
                }
            }
        }
    }
}
