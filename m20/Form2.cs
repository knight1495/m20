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


namespace m20
{
    public partial class Form2 : Form
    {
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
            if (txtBoxUser.Text == "user" && txtBoxPasswrd.Text == "admin")
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
                FileStream fitxer = new FileStream("C:\\Temp",
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

        

   


