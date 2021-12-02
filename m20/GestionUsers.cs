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

        DataSet dtsMac;
        DataSet dtsUsr;
        DataSet dtsMessi;
        int device;
        string query;

        private void Form5_Load(object sender, EventArgs e)
        {
            
            dtsUsr = bd.PortarPerConsulta("Select * from Users");
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

            cmbUsers.DataSource = dtsUsr.Tables[0];
            cmbUsers.DisplayMember = "CodeUser";
            cmbUsers.ValueMember = "idUser";

            

            dtsUsr = bd.PortarPerConsulta("Select * from Users");

            dtsMac = bd.PortarPerConsulta("select * from dbo.TrustedDevices where MAC= '" + txtMac.Text + "'");

            if (dtsMac.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Dispositiu no registrat");
                Application.Exit();
            }else
            {
                device = int.Parse(dtsMac.Tables[0].Rows[0]["IdDevice"].ToString());
            }




            btnDel.Enabled = false;
            btnRegis.Enabled = false;




        }

        private void GestionUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrincipalAdmins frm = new PrincipalAdmins();
            frm.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            query = "Select * From MessiUsers where IdDevice = " + device + " AND IdUser = " + cmbUsers.SelectedValue;
            dtsMessi = bd.PortarPerConsulta(query);
            if (dtsMessi.Tables[0].Rows.Count !=0)
            {
                MessageBox.Show("Device "+ dtsMac.Tables[0].Rows[0]["MAC"].ToString() + " alredy  linked with User: " + cmbUsers.Text);
                btnDel.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Device " + dtsMac.Tables[0].Rows[0]["MAC"].ToString() + " not linked with User: " + cmbUsers.Text);
                btnRegis.Enabled = true;
                cmbUsers.Enabled = false;

            }
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            
            
            

            DataRow dr = dtsMessi.Tables[0].NewRow();
            dr["IdDevice"] = device;
            dr["IdUser"] = cmbUsers.SelectedValue;
            dtsMessi.Tables[0].Rows.Add(dr);
            bd.Actualitzar(query, dtsMessi.Tables[0].TableName, dtsMessi);
            MessageBox.Show("User and device registered correctly");
            this.Close();
        }
    }
}
