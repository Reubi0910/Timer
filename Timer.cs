using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Timer
{
    public partial class Timer : Form
    {
        SerialPort Serial_Port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        public Timer()
        {
            InitializeComponent();
            updateDisposition();
            updateComList();
            updatePortName();
            Serial_Port.DataReceived += SerialPortDataReceived;
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Resize(object sender, EventArgs e)
        {
            updateDisposition();
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            if (serialPort.BytesToRead >= 14)
            {
                string receivedData = serialPort.ReadExisting();

                serialPort.DiscardInBuffer();

                updateLabel(formatReceivedData(receivedData));

                Console.WriteLine("Received data: " + receivedData);
            }            
        }

        public string formatReceivedData(string data)
        {
            string text = "";
            for (int index = 2; index < 9; index++)
            {
                if (char.IsDigit(data[index]))
                {
                    if (index == 6)
                    {
                        text += ",";
                    }
                    
                    text += data[index];

                    if (index == 3)
                    {
                        text += ":";
                    }
                }
            }
            text = text == "0" ? "Timer" : text;
            return text;
        }

        private void updateLabel(string time)
        {
            if (Lbl_timer.InvokeRequired)
            {
                Lbl_timer.Invoke(new Action(() => Lbl_timer.Text = time));
                Lbl_timer.Invoke(new Action(() => updateLabelPosition(Lbl_timer, this)));
            } 
            else
            {
                Lbl_timer.Text = time;
                updateLabelPosition(Lbl_timer, this);
            }
            
        }
        private void updateDisposition()
        {
            updateLabelPosition(Lbl_timer, this);
            updatePortSelectionPosition();
        }

        private void updateLabelPosition(Control label, Form form)
        {
            label.Font = new Font(label.Font.FontFamily, form.Height / 5, label.Font.Style);
            label.Location = new Point(form.Size.Width / 2 - (label.Width / 2),form.Size.Height / 2 - (label.Height / 2) - 30);
        }

        private void updatePortSelectionPosition()
        {
            Lbl_Port.Location = new Point(7, this.Height - 85);
            Cbo_PortList.Location = new Point(9, this.Height - 70);
        }

        private void updateComList()
        {
            string[] portNames = SerialPort.GetPortNames();
            foreach (string portName in portNames)
            {
                Cbo_PortList.Items.Add(portName);
            }
            if (Cbo_PortList.Items.Count > 0)
            {
                Cbo_PortList.SelectedIndex = 0;
            }
        }

        private void Cbo_PortList_SelectedItemChange(object sender, EventArgs e)
        {
            updatePortName();
        }

        private void updatePortName()
        {
            Serial_Port.Close();
            if (Cbo_PortList.SelectedIndex >= 0)
            {
                Serial_Port.PortName = Cbo_PortList.SelectedItem.ToString();
                Serial_Port.Open();
            }
        }
    }
}
