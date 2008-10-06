using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace SerialHandlerLib
{
    public class Serial
    {
        SerialPort actualSerial;

        public Serial(int comPort)
        {
            actualSerial = new SerialPort("COM" + comPort);
        }

        public void Close()
        {
            try
            {
                actualSerial.Close();
            }
            catch { }
        }

        public void Send(byte[] data)
        {
            try
            {
                if (!actualSerial.IsOpen)
                {
                    actualSerial.Open();
                }

                actualSerial.Write(data, 0, data.Length);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
