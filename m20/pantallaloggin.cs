using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Configuration;


namespace m20
{

    
    public partial class pantallaloggin : Form

    {
        bool showpass = true;
        sdsBBDD.Selects bd = new sdsBBDD.Selects();
        public pantallaloggin()
        {
            
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


       

        private void bttEnter_Click(object sender, EventArgs e)

        {
            int device, user;
            int contador = 0;
            String contra;

            contra = HashejarContra();
            string mac = pillarMac();

            DataSet dtsMAC = bd.PortarPerConsulta("Select * from TrustedDevices where MAC = '" + mac + "'");

            DataSet dtsUsers = bd.PortarPerConsulta("select * from dbo.Users where codeUser= '" + txtBoxUser.Text + "' and password= '" + contra + "'");

              if (dtsMAC.Tables[0].Rows.Count == 1)
            {
                device = int.Parse(dtsMAC.Tables[0].Rows[0]["IdDevice"].ToString());
                if (dtsUsers.Tables[0].Rows.Count == 1)
                {
                    user = int.Parse(dtsUsers.Tables[0].Rows[0]["IdUser"].ToString());
                    if (comprobarMessiUser(device, user))
                    {
                        if (comprobarApp())
                        {
                            this.Hide();
                            MainUser Main = new MainUser();
                            Main.ShowDialog();
                        }

                    }


                }
                else
                {
                    contador++;
                    txtBoxPasswrd.Clear();

                }
                if (contador >= 3)
                {
                    FileStream fitxer = new FileStream("C:\\Temp\\log_error.log",
                    FileMode.Append, FileAccess.Write);
                    StreamWriter error = new StreamWriter(fitxer);
                    error.WriteLine("Date: " + DateTime.Now + " User: " + txtBoxUser.Text);

                    error.Close();

                    MessageBox.Show("Usuario incorrecto, iniciando protocolo de autodestrucción...");
                    Application.Exit();

                }
            }
            else
            {
                MessageBox.Show("Dispositiu no registrat a la base de dades, accés denegat");
            }
            

            
        }

        private void Showpasswordicon_Click(object sender, EventArgs e)
            
        {
            if (showpass == false)
            {
                Showpasswordicon.Image = Image.FromFile("Img\\Show password off.png");
                showpass = true;
                txtBoxPasswrd.UseSystemPasswordChar = true;
            }
            else
            {
                Showpasswordicon.Image = Image.FromFile("Img\\Show password on.png");
                showpass = false;
                txtBoxPasswrd.UseSystemPasswordChar = false;

            }
        }

        private string HashejarContra()
        {
            String contra;
            using (SHA256 hash = SHA256.Create())
            {
                
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(txtBoxPasswrd.Text));

                StringBuilder strBuilder = new StringBuilder();

                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    strBuilder.Append(hashedBytes[i].ToString("X2"));
                }


                contra = strBuilder.ToString().ToLower();

            }
            return contra;
        }

        private string pillarMac()
        {
            string mac;
            mac = "";
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
            return mac;
        }

        private bool comprobarMessiUser(int device, int user)
        {
            bool check;
            DataSet dtsMessiUser = bd.PortarPerConsulta("Select * From MessiUsers Where idDevice = '" + device + "' AND idUser = '" + user + "'");
            if (dtsMessiUser.Tables[0].Rows.Count !=0)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        private bool comprobarApp()
        {
            bool check;

            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings["TrustedUser"] ?? "Not Found";

            if (result.ToUpper() == txtBoxUser.Text.ToUpper())
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }


        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}