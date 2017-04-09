using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using DsNetLib;

namespace IpSearchTool
{
    public partial class IpSearch : Form
    {
        public IpSearch()
        {
            InitializeComponent();
        }

        private readonly UdpClient udp = new UdpClient(1500);
        private List<Device> lista = new List<Device>();
        private int contador = 0;


        public void Send(string mensagem)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 1500);
            byte[] bytes = Encoding.ASCII.GetBytes(mensagem);
            udp.Send(bytes, bytes.Length, ip);
        }
        private void StartListening()
        {
            this.udp.BeginReceive(Receive, new object());
        }

        private void Receive(IAsyncResult ar)
        {
           IPEndPoint ip = new IPEndPoint(IPAddress.Any, 1500);
            byte[] bytes = udp.EndReceive(ar, ref ip);

            if(bytes.Length == 35)
            {
                bool deviceExiste = false;
                Device device = new Device();
                device = device.registerBoard(bytes);
                for (int i=0; i<lista.Count; i++)
                {
                    if (device.getbMac() == lista[i].getbMac())
                    {
                        deviceExiste = true;
                        break;
                    }
                }
                if (!deviceExiste)
                {
                    lista.Add(device);
                }
                
            }
        StartListening();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            Send("1234567890123456789012345678901234567890");
            StartListening();
            tmrBuscar.Enabled = true;
        }

        private void grdDevices_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
            txtMac.Text = lista[grdDevices.CurrentRow.Index].getbMac();
            txtVersao.Text = lista[grdDevices.CurrentRow.Index].getbStatusWord();
            txtDestIp.Text = lista[grdDevices.CurrentRow.Index].getbDestIp();
            txtPortaDst.Text = lista[grdDevices.CurrentRow.Index].getbDestPort();
            txtIp.Text = lista[grdDevices.CurrentRow.Index].getbIp();
            txtPortaSrc.Text = lista[grdDevices.CurrentRow.Index].getbSrcPort();
            txtGateway.Text = lista[grdDevices.CurrentRow.Index].getbGateway();
            txtBaudRate.Text = lista[grdDevices.CurrentRow.Index].getbBaudRate();
            txtSubNetMask.Text = lista[grdDevices.CurrentRow.Index].getbSubnetMask();
            cmbTipo.SelectedIndex = int.Parse(lista[grdDevices.CurrentRow.Index].getbType());
            lblQtd.Text = lista.Count.ToString();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void tmrBuscar_Tick(object sender, EventArgs e)
        {
            if (contador == 5)
            {
                tmrBuscar.Enabled = false;
                contador = 0;
                grdDevices.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    grdDevices.Rows.Add(lista[i].getbIp(), lista[i].getbMac());
                }
                pgrBuscar.Value = 0;
            }
            else
            {
                pgrBuscar.PerformStep();
                contador++;
            }
        }

        private void btnSetIp_Click(object sender, EventArgs e)
        {
            Device device = new Device();
            device.setbMac(txtMac.Text.Trim());
            device.setbIp(txtIp.Text.Trim());
            device.setbSrcPort(txtPortaSrc.Text.Trim());
            device.setbDestIp(txtDestIp.Text.Trim());
            device.setbDestPort(txtPortaDst.Text.Trim());
            device.setbGateway(txtGateway.Text.Trim());
            device.setbSubnetMask(txtSubNetMask.Text.Trim());
            device.mudarConfigRede(device);
            MessageBox.Show("Configuração Enviada!");
            btnBuscar_Click(sender, e);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            DsNetUdp udp = new DsNetUdp(txtIpTcp.Text.Trim(), int.Parse(txtPortaTcp.Text.Trim()));
            udp.PulseRelay();
        }
    }
}

