using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Somar_Dois_Numeros
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Somar_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            resultado = num1 + num2;

            label4.Text = resultado.ToString();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            valor1 = 0;
            valor2 = 0;
            label4.Text = "0";  
        }
    }
}
