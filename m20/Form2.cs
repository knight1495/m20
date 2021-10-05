using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


                txtBoxUser.Clear();
                txtBoxPasswrd.Clear();
            }

        }
    }
}
