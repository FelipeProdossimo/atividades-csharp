using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntrocar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = txtvalor2.Text;
            txtvalor2.Text = txtvalor1.Text;
            txtvalor1.Text = auxiliar;

            MessageBox.Show("Troca de valores concluída.",
            "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
