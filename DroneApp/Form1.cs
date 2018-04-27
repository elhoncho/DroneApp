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
using System.Text.RegularExpressions;

namespace DroneApp
{
    public partial class Form1 : Form
    {
        Packet packet = new Packet();
        SerialPort serialPort;
        string txt;
        string command;

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
            packet.TxPacket(txtCommand.Text);
            txtCommand.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Make sure that a COM Port and Baud Rate have been selected
            if (comboPorts.SelectedIndex > -1 && comboBaud.SelectedIndex > -1)
            {
                serialPort = new SerialPort();

                if (serialPort is SerialPort)
                {

                    serialPort.PortName = comboPorts.SelectedItem.ToString();
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;
                    serialPort.BaudRate = Convert.ToInt32(comboBaud.SelectedItem.ToString());
                    serialPort.RtsEnable = true;

                    try
                    {
                        serialPort.Open();
                        serialPort.DiscardOutBuffer();
                        serialPort.DiscardInBuffer();

                        serialPort.DataReceived += new SerialDataReceivedEventHandler(responseHandler);
                        comboPorts.Enabled = false;
                        comboBaud.Enabled = false;
                        btnConnect.Enabled = false;
                    }
                    catch (Exception exc)
                    {
                        txtTerminal.Text = exc.ToString();
                    }
                }
                packet.Init(serialPort);
            }
        }

        private void responseHandler(object sender, SerialDataReceivedEventArgs args)
        {
            string inData = serialPort.ReadExisting();
            command = command+packet.RxPacket(inData);
            
            if (command.EndsWith("\r\n"))
            {
                //Check Lat Long
                Regex regex = new Regex(@"lat=(.*?)\,lon=(.*?)\,");
                Match match = regex.Match(command);
                if (match.Success)
                {
                    command += "\r\nLAT: " + match.Groups[1].Value + "\r\nLONG: " + match.Groups[2].Value + "\r\n";

                    map.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
                    map.Manager.Mode = GMap.NET.AccessMode.ServerOnly;

                    SetMap(match.Groups[1].Value, match.Groups[2].Value);
                }

                txt = command + txt;
                command = "";
            }

            SetText(txt);
        }

        delegate void SetTextCallback(string text);
        delegate void SetMapCallback(string lat, string longt);

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

        private void SetMap(string lat, string longt)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtTerminal.InvokeRequired)
            {
                SetMapCallback d = new SetMapCallback(SetMap);
                this.Invoke(d, new object[] { lat, longt });
            }
            else
            {
                this.txtLat.Text = lat;
                this.txtLong.Text = longt;

                map.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
                map.Manager.Mode = GMap.NET.AccessMode.ServerOnly;

                double latNum = Convert.ToDouble(lat);
                double longtNum = Convert.ToDouble(longt);

                map.Position = new GMap.NET.PointLatLng(latNum, longtNum);

                map.MinZoom = 1;
                map.MaxZoom = 20;
                map.Zoom = Convert.ToInt32(txtZoom.Text);
                //map.Zoom = Convert.ToInt32(txtZoom.Text);
            }
        }

        void GetComPorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboPorts.Items.AddRange(ports);
        }

        private void txtLat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTerminal_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetText("");
        }
    }
}
