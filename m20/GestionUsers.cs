using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace m20
{
    public partial class GestionUsers : Form
    {
        public GestionUsers()
        {
            InitializeComponent();
        }

        sdsBBDD.Selects bd = new sdsBBDD.Selects();
        

        private void Form5_Load(object sender, EventArgs e)
        {
            DataSet dts;
            dts = bd.PortarPerConsulta("Select * from Users");
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

            cmbUsers.DataSource = dts.Tables[0];
            cmbUsers.DisplayMember = "DescUser";
            cmbUsers.ValueMember = "idUser";
        }

        private void GestionUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrincipalAdmins frm = new PrincipalAdmins();
            frm.Show();
        }
    }
}
