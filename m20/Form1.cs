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
            int contador = 0;
            while (cola.Count > 0)
            {
                Button boton = new Button();
                boton.Name = "btn" + contador;
                boton.Width = 118;
                boton.Height = 92;
                boton.Font = new Font("Microsoft Sans Serif", 13.8f);
                boton.Click += new System.EventHandler(this.TeclesNum_Click);
                contador++;

                int valor = cola.Dequeue();

                boton.Text = valor.ToString();
                tablaNumeros.Controls.Add(boton);
                
            }
            
        }

        private void TeclesNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;
            textBox1.Text += btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = "";
            }
        }
    }
}
