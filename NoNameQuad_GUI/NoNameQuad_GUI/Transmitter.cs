using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;


namespace NoNameQuad_GUI
{
    class Transmitter
    {
        private SerialPort serialPort;

        public Transmitter(string portName, int baud)
        {
            try
            {
                serialPort = new SerialPort(portName, baud);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void SendByte(byte x)
        {
            if (!serialPort.IsOpen)
            {
                try
                {

                    byte[] buffer = new byte[1];
                    buffer[0] = x;
                    serialPort.Open();
                    serialPort.Write(buffer, 0, 1);
                    serialPort.Close();

                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }

        }
        public void SendArrayByte(byte[] x)
        {
            if (!serialPort.IsOpen)
            {
                try
                {

                    serialPort.Open();
                    serialPort.Write(x, 0, x.Count());
                    serialPort.Close();

                }
                catch
                {
                    MessageBox.Show("Error");


                }
            }
        }
    }
}
