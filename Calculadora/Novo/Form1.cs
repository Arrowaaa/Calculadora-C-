using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void escolhaoperador(int numero, string operador)
        {
            lbtemp.Text = numero.ToString();
            lbop.Text = operador;
            textBox1.Text = "";
        }
        public double calculos(double num1, double num2, string operador)
        {
            double resultado = 0;

            if (operador == "+")
            {
                resultado = num1 + num2;

            }
            else if (operador == "x")
            {
                resultado = num1 * num2;

            }
            else if (operador == "-")
            {
                resultado = num1 - num2;

            }
            else if (operador == "/")
            {
                resultado = num1 / num2;

            }
            else if (operador == "resto")
            {
                resultado = num1 % num2;
            }

            else if (operador == "%")
            {
                double resul = num1 / 100;
                resultado = resul * num2;
                label1.Text = resul.ToString();

            }
            return resultado;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button botao0 = (Button)sender;
            // MessageBox.Show(botao0.Text);
            textBox1.Text = textBox1.Text + botao0.Text;



        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "Error")
            {



                int numero = int.Parse(textBox1.Text);
                // int numero2 = 0;

                Button botao = (Button)sender;
                string operadorselecionado = botao.Text;

                //int total = calculos(numero,numero2, operadorselecionado);

                //label1.Text = total.ToString();
                escolhaoperador(numero, operadorselecionado);
            }
            else
            {
                textBox1.Text = "Error";
                label1.Text = "";
                lbtemp.Text = "";
                lbop.Text = "";
                textBox1.Text = "";
            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int prim = int.Parse(lbtemp.Text);
            int seg = int.Parse(textBox1.Text);

            string operador = lbop.Text;

            double total = calculos(prim, seg, operador);

            label1.Text = total.ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            lbtemp.Text = "";
            lbop.Text = "";
            textBox1.Text = "";
        }

        private void btnTransformarNegativo_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);

            double numeroNegativo = num * -1;
            textBox1.Text = numeroNegativo.ToString();
        }
    }
}
