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
    public partial class pantallasplash : Form
    {
        int contador = 0;
        public pantallasplash()
        {
            InitializeComponent();

        }

        private void tick(object sender, EventArgs e)
        {
            contador++;
            label1.Text = contador.ToString() + "%";
            if (contador == 100)
            {
                timer1.Stop();
                this.Hide();
                pantallaloggin main = new pantallaloggin();
                main.ShowDialog();
            }
        }

        private void splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && (e.Alt))
            {
                timer1.Stop();
                this.Hide();
                PanelAdmin form = new PanelAdmin();
                form.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
