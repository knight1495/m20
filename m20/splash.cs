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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();

        }

        private void tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Form2 main = new Form2();
                main.ShowDialog();
            }
        }

        private void splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && (e.Alt))
            {
                timer1.Stop();
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
        }
    }
}
