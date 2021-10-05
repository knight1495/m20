using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace m20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList numeros = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(i);

            }

            Random rng = new Random();
            Queue<int> cola = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                int num = rng.Next(9 - i);
                int numero = (int)numeros[num];
                cola.Enqueue(numero);
                numeros.RemoveAt(num);
            }

            while (cola.Count > 0)
            {
                int valor = cola.Dequeue();
                MessageBox.Show(valor.ToString());
            }
            tablaNumeros.
        }
    }
}
