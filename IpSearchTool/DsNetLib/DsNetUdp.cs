using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DsNetLib
{
    public class DsNetUdp
    {
        private UdpClient client { get; set; }
        private int port { get; set; }
        private string ipAddr { get; set; }

        public DsNetUdp(string ipAddr, int port)
        {
            this.ipAddr = ipAddr;
            this.port = port;
        }

        public void PulseRelay()
        {
            try
            {
                client = new UdpClient(port);
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipAddr), port);
                byte[] bytes = Encoding.ASCII.GetBytes("oie");
                client.Send(bytes, bytes.Length, ip);
                client.Close();
            }
            catch (Exception error)
            {

            }
        }
    }
}
