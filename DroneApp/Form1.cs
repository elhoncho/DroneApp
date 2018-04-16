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

namespace DroneApp
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        string txt;

        public Form1()
        {
            InitializeComponent();
            GetComPorts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            map.Manager.Mode = GMap.NET.AccessMode.ServerOnly;

            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            double zoom = Convert.ToDouble(txtZoom.Text);

            map.Position = new GMap.NET.PointLatLng(lat, longt);

            map.MinZoom = 1;
            map.MaxZoom = 20;
            map.Zoom = zoom;            
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            //port.Write(txtCommand.Text);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            serialPort = new SerialPort();
            string VER_Command = "ls\r\n";

            if(serialPort is SerialPort)
            {
                serialPort.PortName = "COM4";
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.BaudRate = 9600;
                serialPort.RtsEnable = true;

                try
                {
                    serialPort.Open();
                    serialPort.DiscardOutBuffer();
                    serialPort.DiscardInBuffer();

                    serialPort.DataReceived += new SerialDataReceivedEventHandler(responseHandler);
                    serialPort.Write(VER_Command);
                }
                catch (Exception exc)
                {
                    txtTerminal.Text = exc.ToString();
                }
            }
        }

        private void responseHandler(object sender, SerialDataReceivedEventArgs args)
        {
            txt += serialPort.ReadExisting();
            SetText(txt);
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtTerminal.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtTerminal.Text = text;
            }
        }
        void GetComPorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboPorts.Items.AddRange(ports);
        }
    }
}
