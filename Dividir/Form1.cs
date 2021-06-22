using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dividir
{
    public partial class FrmRestoDeDivisao : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            int resto = dividendo % divisor;
            /*txtResto.Text = Convert.ToString(resto);*/
            txtResto.Text = resto.ToString();
        }
    }
}
