using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;


namespace Rasp_UI
{
    class TCP_connection
    {
        TcpClient tcpclnt = new TcpClient();

        public void Connect_TCP()
        {

            try
            {
                this.tcpclnt.Connect("192.168.1.83", 8001);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error connecting to server");

            }

        }

        public void Disconnect_TCP()
        {
            this.tcpclnt.Close();
        }

        public double[3] GPS_Information()
        {
            String str = "GPS"+'\r'+ '\n';

            Stream stm = tcpclnt.GetStream();

            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);
 
            byte[] bc = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                bc[i] = Convert.ToByte(str[i]);
            }

            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            for (int i = 0; i < k; i++)
                Console.Write(Convert.ToChar(bb[i]));

            stm.Write(ba, 0, ba.Length);

            double[] returner = new double[3];

            return returner;
        }

    }
}
