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
    public partial class FrmAdmin : Form
    {
        int numerosaleatorios;
        String[]  abcd = { "a", "b", "c", "d" };
        Boolean repetido = false;
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            


        }

        private void natejabutons()
        {

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(i, j));
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            natejabutons();

            Dictionary<String, String> posicion = new Dictionary<String, String>();
            HashSet<int> numeros = new HashSet<int>();

            Random aleatorio = new Random();
            while (numeros.Count < 20)
            {
                numeros.Add(aleatorio.Next(9999));
            }


            String key;
            String numero;
            int contador1 = 0;
            int contador2 = 1;


            foreach (var num in numeros)
            {

                numero = num.ToString();
                key = abcd[contador1] + contador2.ToString();
                while (numero.Length < 4)
                {
                    numero = "0" + numero;
                }
                posicion.Add(key, numero);
                if (contador2 == 5 && contador1 < 4)
                {
                    contador1++;
                    contador2 = 0;
                }
                contador2++;

            }

            foreach (var item in posicion)
            {
                Label lbl = new Label();
                lbl.Text = item.Value;
                tableLayoutPanel1.Controls.Add(lbl);
                lbl.Font = new Font("Microsoft Sans Serif", 18f);
            }

            tableLayoutPanel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionDispo frm = new GestionDispo();

            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }
    }
}
