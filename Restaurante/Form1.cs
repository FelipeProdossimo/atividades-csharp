using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class frmRestaurante : Form
    {
        public frmRestaurante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double despesa = Convert.ToDouble(txtDespesa.Text);
            double totalDaConta = despesa * 1.10;
            txtTotalDaConta.Text = totalDaConta.ToString("N");
        }
    }
}
