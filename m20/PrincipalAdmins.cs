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
    public partial class PrincipalAdmins : Form
    {
        public PrincipalAdmins()
        {
            InitializeComponent();
        }

        private void btnCoordenadas_Click(object sender, EventArgs e)
        {
            TablaCoord frmCoordenades = new TablaCoord();
            frmCoordenades.Show();
            this.Hide();
        }

        private void btnDispositius_Click(object sender, EventArgs e)
        {
            GestionDispo frmDispo = new GestionDispo();
            frmDispo.Show();
            this.Hide();
        }

        private void btnUsuaris_Click(object sender, EventArgs e)
        {
            GestionUsers frmUsers = new GestionUsers();
            frmUsers.Show();
            this.Hide();
        }
    }
}
