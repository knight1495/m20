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
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
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
            int contador = 0;
            while (cola.Count > 0)
            {
                Button boton = new Button();
                boton.Name = "btn" + contador;
                boton.Width = 118;
                boton.Height = 92;

                boton.Font = new Font("Microsoft Sans Serif", 20f);


                boton.Font = new Font("Microsoft Sans Serif", 13.8f);

                boton.Click += new System.EventHandler(this.TeclesNum_Click);
                contador++;

                int valor = cola.Dequeue();

                boton.Text = valor.ToString();
                tablaNumeros.Controls.Add(boton);

            }


            string[] opcion = {"A", "B", "C", "D"};

            string[] opcionNum = { "1", "2", "3", "4", "5" };
            
        }

        private void TeclesNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;

            textBox1.Text += num;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123")
            {
                this.Hide();
                TablaCoord form = new TablaCoord();
                form.Show();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
         Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();

        }
    }
}
