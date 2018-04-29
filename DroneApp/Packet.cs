using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace DroneApp
{
    class Packet
    {
        //          Flag bits
        // 7 | 6 | 5 | 4 | 3  | 2 | 1 | 0
        //Res|Res|Urg|Ack|Push|Rst|Syn|Fin
        private byte flags;
        private ushort sequenceNumber = 0;
        private ushort acknologementNumber = 0;
        private string data;
        private SerialPort serialPort;

        public void Init(SerialPort serialPort)
        {
            this.sequenceNumber = 0;
            this.acknologementNumber = 0;
            this.serialPort = serialPort;
        }
        public void TxPacket(string txData)
        {
            //byte CRC = 0x43;
            //List<byte> txBytes = new List<byte>();
            //txBytes.AddRange(Encoding.ASCII.GetBytes(txData));

            //sequenceNumber = 0x0A0A;
            //acknologementNumber = 0x0D0D;
            //flags = 0b0000_0010;

            //txBytes.InsertRange(0, BitConverter.GetBytes(sequenceNumber));
            //txBytes.InsertRange(2, BitConverter.GetBytes(acknologementNumber));
            //txBytes.Add(CRC);

            //serialPort.Write((Encoding.ASCII.GetString(txBytes.ToArray())));


            txData.Trim();
            //Send Command
            serialPort.Write("TX" + txData.Length.ToString("D3") + "\r\n");
            //Send Data
            serialPort.Write(txData);
            
        }
        public string RxPacket(string rxPacket)
        {
            return rxPacket;
        }
    }
}
