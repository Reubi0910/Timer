﻿using System;
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
            Serial_Port.DataReceived += SerialPortDataReceived;
            Serial_Port.Open();
            updateLabelPosition(Lbl_timer, this);
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Resize(object sender, EventArgs e)
        {
            updateLabelPosition(Lbl_timer, this);
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;

            string receivedData = serialPort.ReadExisting();

            updateLabel(formatReceivedData(receivedData));

            Console.WriteLine("Received data: " + receivedData);
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

        private void updateLabelPosition(Control label, Form form)
        {
            label.Font = new Font(label.Font.FontFamily, form.Height / 5, label.Font.Style);
            Console.WriteLine(label.Location);
            Console.WriteLine(label.Size);
            label.Location = new Point(form.Size.Width / 2 - (label.Width / 2),form.Size.Height / 2 - (label.Height / 2) - 30);
        }

    }
}