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

        //Sends 1 command and reads 3 different values
        public double[] GPS_Information()
        {
            String str = "GPS"+'\r'+ '\n';
            double[] returner = new double[3];
            
            // Initialize stream
            Stream stm = tcpclnt.GetStream();
            //Encode
            ASCIIEncoding asen = new ASCIIEncoding();
            //Turn the string into bytes
            byte[] ba = asen.GetBytes(str);
    

            //Write the command to the server
            stm.Write(ba, 0, ba.Length);

            //Byte to receive tthe info from the server
            //Receive Latitude
            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            Auxiliary GPS = new Auxiliary();
            returner=GPS.GPS_Calculus(bb, k);


            //Console.WriteLine(" Latitude: " + returner[0].ToString() + "\n Longitude: " + returner[1].ToString() + "\n Speed: " + returner[2].ToString());

            return returner;
        }

    }
}
