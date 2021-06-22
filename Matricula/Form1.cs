using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matricula
{
    public partial class frmMatricula : Form
    {
        public frmMatricula()
        {
            InitializeComponent();
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            int anoNascimento = Convert.ToInt32( txtAnoNascimento.Text );
            int anoUltimoAniversario = Convert.ToInt32( txtAnoUltimoAniversario.Text );
            int idade = anoUltimoAniversario - anoNascimento;

            if (idade >= 5 && idade <= 7)
            {
                txtCategoria.Text = "Infantil A";
            }
            else if (idade >= 8 && idade <= 10)
            {
                txtCategoria.Text = "Infantil B";
            }
            else if (idade >= 11 && idade <= 13)
            {
                txtCategoria.Text = "Juvenil A";
            }
            else if (idade >= 14 && idade <= 17)
            {
                txtCategoria.Text = "Juvenil B";
            }
            else if (idade >= 18)
            {
                txtCategoria.Text = "Adulto";
            }
        }
    }
}
