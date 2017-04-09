using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace IpSearchTool
{
    class Device
    {
        private string bMac;
        private string bStatusWord;

        private string bIp;
        private string bGateway;
        private string bSubnetMask;

        private string bDestIp;
        private string bDestPort;
        private string bSrcPort;

        private string bType;
        private string bBaudRate;

        public string getbMac() {
            return bMac;
        }

        public void setbMac(string bMac)
        {
            this.bMac = bMac;
        }

        public string getbStatusWord()
        {
            return bStatusWord;
        }

        public void setbStatusWord(string bStatusWord)
        {
            this.bStatusWord = bStatusWord;
        }

        public string getbIp()
        {
            return bIp;
        }

        public void setbIp(string bIp)
        {
            this.bIp = bIp;
        }

        public string getbGateway()
        {
            return bGateway;
        }

        public void setbGateway(string bGateway)
        {
            this.bGateway = bGateway;
        }

        public string getbSubnetMask()
        {
            return bSubnetMask;
        }

        public void setbSubnetMask(string bSubnetMask)
        {
            this.bSubnetMask = bSubnetMask;
        }

        public string getbDestIp()
        {
            return bDestIp;
        }

        public void setbDestIp(string bDestIp)
        {
            this.bDestIp = bDestIp;
        }

        public string getbDestPort()
        {
            return bDestPort;
        }

        public void setbDestPort(string bDestPort)
        {
            this.bDestPort = bDestPort;
        }

        public string getbSrcPort()
        {
            return bSrcPort;
        }

        public void setbSrcPort(string bSrcPort)
        {
            this.bSrcPort = bSrcPort;
        }

        public string getbType()
        {
            return bType;
        }

        public void setbType(string bType)
        {
            this.bType = bType;
        }

        public string getbBaudRate()
        {
            return bBaudRate;
        }

        public void setbBaudRate(string bBaudRate)
        {
            this.bBaudRate = bBaudRate;
        }


        public Device registerBoard(byte[] dataReceived)
        {
            Device device = new Device();
            if (dataReceived.Length == 35)
            {               
                device.setbMac(string.Empty);
                for (int i = 0; i < 6; i++)
                {
                    if (i != 5)
                    {
                        device.setbMac(device.getbMac() + dataReceived[i].ToString() + ".");
                    }
                    else
                    {
                        device.setbMac(device.getbMac() + dataReceived[i].ToString());
                    }

                }

                device.setbStatusWord(dataReceived[6].ToString());

                device.setbDestIp(string.Empty);
                for (int i = 10; i > 6; i--)
                {
                    if (i != 7)
                    {
                        device.setbDestIp(device.getbDestIp() + dataReceived[i].ToString() + ".");
                    }
                    else
                    {
                        device.setbDestIp(device.getbDestIp() + dataReceived[i].ToString());
                    }

                }

                device.setbDestPort(string.Empty);
                int aux = dataReceived[12] << 8 | dataReceived[11];
                device.setbDestPort(aux.ToString());

                device.setbIp(string.Empty);
                for (int i = 16; i > 12; i--)
                {
                    if (i != 13)
                    {
                        device.setbIp(device.getbIp() + dataReceived[i].ToString() + ".");
                    }
                    else
                    {
                        device.setbIp(device.getbIp() + dataReceived[i].ToString());
                    }
                }

                device.setbSrcPort(string.Empty);
                aux = dataReceived[18] << 8 | dataReceived[17];
                device.setbSrcPort(aux.ToString());

                device.setbGateway(string.Empty);
                for (int i = 22; i > 18; i--)
                {
                    if (i != 19)
                    {
                        device.setbGateway(device.getbGateway() + dataReceived[i].ToString() + ".");
                    }
                    else
                    {
                        device.setbGateway(device.getbGateway() + dataReceived[i].ToString());
                    }
                }

                device.setbType(dataReceived[23].ToString());

                device.setbBaudRate(string.Empty);
                aux = dataReceived[26] << 16 | dataReceived[25] << 8 | dataReceived[24];
                device.setbBaudRate(aux.ToString());

                device.setbSubnetMask(string.Empty);
                for (int i = 34; i > 30; i--)
                {
                    if (i != 31)
                    {
                        device.setbSubnetMask(device.getbSubnetMask() + dataReceived[i].ToString() + ".");
                    }
                    else
                    {
                        device.setbSubnetMask(device.getbSubnetMask() + dataReceived[i].ToString());
                    }
                }
            }
        return device;
        }

        public void mudarConfigRede(Device device)
        {
            byte[] Protocolo = new byte[40];

            byte[] OldPwd = { 0x31, 0x31, 0x30, 0x34, 0x31, 0x35 };
            byte[] Mac = new byte[6];
            byte[] Ip = new byte[4];
            byte[] DestIp = new byte[4];
            byte[] SubnetMask = new byte[4];
            byte[] Gateway = new byte[4];
            byte[] PortaDst = new byte[2];
            byte[] PortaSrc = new byte[2];
            byte[] Type = { 3 };
            byte[] IndependentID = { 0, 0, 0 };
            byte[] SerialParameter = { 3 };
            byte[] BaudRate = { 0x80, 0x25, 0x00 };

            string[] str = new string[6];

            for (int i = 0; i < 6; i++)
            {
                str = device.getbMac().Split('.');
                int a = int.Parse(str[i]);
                Mac[i] = Convert.ToByte(a);
            }

            for (int i = 0; i < 4; i++)
            {
                str = device.getbIp().Split('.');
                int a = int.Parse(str[i]);
                Ip[i] = Convert.ToByte(a);
            }
            Array.Reverse(Ip, 0, Ip.Length);

            for (int i = 0; i < 4; i++)
            {
                str = device.getbGateway().Split('.');
                int a = int.Parse(str[i]);
                Gateway[i] = Convert.ToByte(a);
            }
            Array.Reverse(Gateway, 0, Gateway.Length);

            for (int i = 0; i < 4; i++)
            {
                str = device.getbSubnetMask().Split('.');
                int a = int.Parse(str[i]);
                SubnetMask[i] = Convert.ToByte(a);
            }
            Array.Reverse(SubnetMask, 0, SubnetMask.Length);

            for (int i = 0; i < 4; i++)
            {
                str = device.getbDestIp().Split('.');
                int a = int.Parse(str[i]);
                DestIp[i] = Convert.ToByte(a);
            }
            Array.Reverse(DestIp, 0, DestIp.Length);


            int num = int.Parse(device.getbDestPort().Trim());
            PortaDst[0] = (byte)((num >> 8) & 0xff);
            PortaDst[1] = (byte)(num & 0xff);
            Array.Reverse(PortaDst, 0, PortaDst.Length);

            num = int.Parse(device.getbSrcPort().Trim());
            PortaSrc[0] = (byte)((num >> 8) & 0xff);
            PortaSrc[1] = (byte)(num & 0xff);
            Array.Reverse(PortaSrc, 0, PortaSrc.Length);

            for (int i = 0; i < 6; i++)
            {
                Protocolo[i] = Mac[i];
            }
            for (int i = 0; i < 6; i++)
            {
                Protocolo[i + 6] = OldPwd[i];
            }
            for (int i = 0; i < 4; i++)
            {
                Protocolo[i + 12] = DestIp[i];
            }
            for (int i = 0; i < 2; i++)
            {
                Protocolo[i + 16] = PortaDst[i];
            }
            for (int i = 0; i < 4; i++)
            {
                Protocolo[i + 18] = Ip[i];
            }
            for (int i = 0; i < 2; i++)
            {
                Protocolo[i + 22] = PortaSrc[i];
            }
            for (int i = 0; i < 4; i++)
            {
                Protocolo[i + 24] = Gateway[i];
            }
            Protocolo[28] = Type[0];
            for (int i = 0; i < 3; i++)
            {
                Protocolo[i + 29] = BaudRate[i];
            }
            Protocolo[32] = SerialParameter[0];
            for (int i = 0; i < 3; i++)
            {
                Protocolo[i + 33] = IndependentID[i];
            }
            for (int i = 0; i < 4; i++)
            {
                Protocolo[i + 36] = SubnetMask[i];
            }

            UdpClient udp = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 1500);
            udp.Send(Protocolo, Protocolo.Length, ip);
            udp.Close();
        }

    }
}
