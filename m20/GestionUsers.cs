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
using System.Xml;
using System.Configuration;

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
                MessageBox.Show("Device "+ dtsMac.Tables[0].Rows[0]["MAC"].ToString() + " alredy  binded with User: " + cmbUsers.Text);
                btnDel.Enabled = true;
                btnRegis.Enabled = false;

            }
            else
            {
                MessageBox.Show("Device " + dtsMac.Tables[0].Rows[0]["MAC"].ToString() + " not binded with User: " + cmbUsers.Text);
                btnRegis.Enabled = true;
                btnDel.Enabled = false;
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

            MessageBox.Show("User and device binded properly");
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dtsMessi.Tables[0].Rows[0].Delete();
            bd.Actualitzar(query, dtsMessi.Tables[0].TableName, dtsMessi);
            MessageBox.Show("User and device unbinded properly ");
            this.Close();
        }

        private void añadirUsuariosArchivo()
        {
            ReadAllSettings();
            ReadSetting("TrustedUSer");
            ReadSetting("NotValid");
            AddUpdateAppSettings("NewSetting", "May 7, 2014");
            AddUpdateAppSettings("TrustedUser", cmbUsers.Text);
            ReadAllSettings();

        }
        static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
