using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double vysledek = 0;
                int soucet = 0;
                int pocet = 0;
                foreach (string cislo in textBox1.Lines)
                {
                    if (int.Parse(cislo) < 0)
                    {
                        checked
                        {
                            soucet += int.Parse(cislo);
                        }
                        pocet++;
                    }
                }
                if (pocet == 0)
                {
                    MessageBox.Show("Textbox neobsahuje žádná záporná čísla.");
                }
                else
                {
                    vysledek = (double)soucet / (double)pocet;
                    MessageBox.Show("Průměr: " + vysledek);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
