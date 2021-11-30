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
            int contador = 0;
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

            DataSet dts = bd.PortarPerConsulta("select * from dbo.Users where codeUser= '" + txtBoxUser.Text + "' and password= '" + contra + "'");

            if (dts.Tables[0].Rows.Count == 1)
            {

                this.Hide();
                MainUser Main = new MainUser();
                Main.ShowDialog();

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


    }

}