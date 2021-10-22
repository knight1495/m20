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

    
    public partial class Form2 : Form
    {
        sdsBBDD.Selects bd = new sdsBBDD.Selects();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int contador = 0;
        private void bttEnter_Click(object sender, EventArgs e)

        {
            String contra;
            using (SHA256 hash = SHA256.Create())

            {

                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(txtBoxPasswrd.Text));

                string strHash = BitConverter.ToString(hashedBytes);

                contra = strHash;

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

                MessageBox.Show("Vamos a ver, payaso, sal de aquí o tendrás problemas!");
                Application.Exit();

            }
        }
    }

}

        

   


