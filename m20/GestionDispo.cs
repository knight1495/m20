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

        sdsBBDD.Selects bd = new sdsBBDD.Selects();
        DataSet dtsMac;
        string query;


        private void GestionDispo_Load(object sender, EventArgs e)
        {
            
            txtHost.Enabled = false;
            txtMac.Enabled = false;

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


            query = "select * from TrustedDevices where MAC = '" + txtMac.Text + "'";
            dtsMac = bd.PortarPerConsulta(query);

            if (dtsMac.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Device not logged");
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Device logged");
                btnSave.Enabled = false;
            }
            

            
        }

        private void GestionDispo_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrincipalAdmins frm = new PrincipalAdmins();
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow dr = dtsMac.Tables[0].NewRow();
            dr["MAC"] = txtMac.Text;
            dr["HostName"] = txtHost.Text;
            dtsMac.Tables[0].Rows.Add(dr);
            bd.Actualitzar(query, dtsMac.Tables[0].TableName, dtsMac);
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dtsMac.Tables[0].Rows[0].Delete();
            bd.Actualitzar(query, dtsMac.Tables[0].TableName, dtsMac);
        }
    }
}
