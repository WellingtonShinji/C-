using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calc.Wellington
{
    public partial class CalcEto : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public CalcEto()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            tela.Text +="0";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            tela.Text += "1";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            tela.Text += "2";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            tela.Text += "3";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            tela.Text += "4";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            tela.Text += "5";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            tela.Text += "6";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            tela.Text += "7";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            tela.Text += "8";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            tela.Text += "9";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            tela.Text += ".";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(tela.Text != "")
            {
                valor1 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
                tela.Text = "";
                operacao = "SOMA";
                tela2.Text = "+";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {   
            if(tela.Text != "")
            {
                valor1 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
                tela.Text = "";
                operacao = "SUB";
                tela2.Text = "-";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tela.Text != "")
            {
                valor1 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
                tela.Text = "";
                operacao = "MULT";
                tela2.Text = "*";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(tela.Text != "")
            {
                valor1 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
                tela.Text = "";
                operacao = "DIV";
                tela2.Text = "/";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tela.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                tela.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                tela.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                tela.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                tela.Text = Convert.ToString(valor1 / valor2);
            }
        }
    }
}
