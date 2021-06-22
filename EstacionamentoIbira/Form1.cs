using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstacionamentoIbira
{
    public partial class frmIbira : Form
    {
        public frmIbira()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double hInicio = Convert.ToDouble(txtHoraEntrada.Text);
            double hFim = Convert.ToDouble(txtHoraSaida.Text);
            double totalHora = (hFim - hInicio) * 5;

            txtTotalPagar.Text = totalHora.ToString("N");

        }
    }
}
