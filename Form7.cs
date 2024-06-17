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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                try
                {
                    double glavnica = double.Parse(textBox1.Text);
                    double godisnjaKamatnaStopa = 4.49;
                    int brojRata = int.Parse(textBox2.Text);

                    double mjesecnaKamatnaStopa = godisnjaKamatnaStopa / 100 / 12;

                    double mjesecnaRata = glavnica * (mjesecnaKamatnaStopa * Math.Pow(1 + mjesecnaKamatnaStopa, brojRata)) / (Math.Pow(1 + mjesecnaKamatnaStopa, brojRata) - 1);

                    double ukupanIznosKamate = (mjesecnaRata * brojRata) - glavnica;

                    double ukupanIznosZaOtplatu = mjesecnaRata * brojRata;

                    MessageBox.Show("STAMBENI KREDITI\n" + "Iznos anuiteta: " + mjesecnaRata.ToString("F2") + "EUR\n" + "Fiksna kamatna stopa: " + godisnjaKamatnaStopa + "%\n" + "Ukupan iznos kamate: " + ukupanIznosKamate + "EUR\n" + "Ukupan iznos za otplatu: " + ukupanIznosZaOtplatu + "EUR");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do pogreške: " + ex.Message);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double glavnica2 = double.Parse(textBox4.Text);
                double godisnjaKamatnaStopa2 = 6.69;
                int brojRata2 = int.Parse(textBox3.Text);

                double mjesecnaKamatnaStopa2 = godisnjaKamatnaStopa2 / 100 / 12;

                double mjesecnaRata2 = glavnica2 * (mjesecnaKamatnaStopa2 * Math.Pow(1 + mjesecnaKamatnaStopa2, brojRata2)) / (Math.Pow(1 + mjesecnaKamatnaStopa2, brojRata2) - 1);

                double ukupanIznosKamate2 = (mjesecnaRata2 * brojRata2) - glavnica2;

                double ukupanIznosZaOtplatu2 = mjesecnaRata2 * brojRata2;

                MessageBox.Show("GOTOVINSKI KREDITI\n" + "Iznos anuiteta: " + mjesecnaRata2.ToString("F2") + "EUR\n" + "Fiksna kamatna stopa: " + godisnjaKamatnaStopa2 + "%\n" + "Ukupan iznos kamate: " + ukupanIznosKamate2 + "EUR\n" + "Ukupan iznos za otplatu: " + ukupanIznosZaOtplatu2 + "EUR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške: " + ex.Message);
            }
        }
        
    }

}
