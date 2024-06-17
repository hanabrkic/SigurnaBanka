using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double euro, dolar, funta;

            if (double.TryParse(textBox1.Text, out euro) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text))
            {
                dolar = euro * 1.07;
                textBox2.Text = dolar.ToString("F2");

                funta = euro * 0.84;
                textBox3.Text = funta.ToString("F2");
            }
            else if (double.TryParse(textBox2.Text, out dolar) && string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox3.Text))
            {
                euro = dolar / 1.07;
                textBox1.Text = euro.ToString("F2");

                funta = dolar * 0.79;
                textBox3.Text = funta.ToString("F2");
            }
            else if (double.TryParse(textBox3.Text, out funta) && string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                euro = funta / 0.84;
                textBox1.Text = euro.ToString("F2");

                dolar = funta / 0.79;
                textBox2.Text = dolar.ToString("F2");
            }
            else
            {
                MessageBox.Show("Unesite samo jedan iznos za pretvorbu.");
            }
        }

    }
}
