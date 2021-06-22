using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double resultado = peso / (altura * altura);

            if (resultado <= 18.5)
            {
                txtResultado.Text = "Procure um nutricionista, você está abaixo do peso!!";
            }
            else if (resultado >= 18.6 && resultado <= 24.9)
            {
                txtResultado.Text = "Você está no peso ideal. Parabéns!";
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                txtResultado.Text = "Sobrepeso tome cuidado! Você está a um passo do peso ruim!";
            }
            else if (resultado >= 30)
            {
                txtResultado.Text = "Você está obeso, cuide da sua saúde, COVID não foi embora ainda!";
            }
        }
    }
}
