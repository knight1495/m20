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
using System.Net.NetworkInformation;

namespace m20
{
    public partial class GestionDispo : Form
    {
        public GestionDispo()
        {
            InitializeComponent();
        }


        private void GestionDispo_Load(object sender, EventArgs e)
        {

            string mac = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }

         
            txtMac.Text = mac;

            txtHost.Text = System.Net.Dns.GetHostName();
        }

        private void GestionDispo_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrincipalAdmins frm = new PrincipalAdmins();
            frm.Show();
        }
    }
}
