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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Dictionary<String, int> posicion = new Dictionary<string, int>();

            for (int i = 0; i < 4; i++)
            {
                String key;

                key = abcd[i];
                for (int j = 1; i < 5; j++)
                {
                 
                    key += j;
                    Random aleatorio = new Random();
                    numerosaleatorios = aleatorio.Next(9999);
                    foreach (String llave in posicion.Keys)
                    {
                        int result;
                        if (!repetido)
                        {
                            posicion.TryGetValue(llave, out result);
                            if(numerosaleatorios == result)
                            {
                                repetido = true;
                            }
                        }
                    }
                    if (!repetido)
                    {
                        posicion.Add(key, numerosaleatorios);
                    }
                    else
                    {
                        j--;
                    }
                }
            }
            
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
