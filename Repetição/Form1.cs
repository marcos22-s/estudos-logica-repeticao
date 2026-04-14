using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 1;
            listBox1.Items.Clear();
            listBox1.Items.Add("Estrutura While");
            while (numero <=30)
            {
                listBox1.Items.Add(numero.ToString());
                numero += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Estrutura For");
            for (int i = 1; i <=400; i ++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valordigitado;
            valordigitado = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + " X " + valordigitado + " = " + (i * valordigitado));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int inicio;
            int final;
            int numero;

            inicio = Convert.ToInt32(textBox2.Text);
            final = Convert.ToInt32(textBox3.Text);
            listBox1.Items.Clear();
            for (numero = inicio; numero <= final; numero++ )
            {
                listBox1.Items.Add(numero.ToString());
            }
        }
    }
}
