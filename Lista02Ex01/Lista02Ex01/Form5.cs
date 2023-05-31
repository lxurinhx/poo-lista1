using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista02Ex01
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicit_Click(object sender, EventArgs e)
        {
            float valor = 0, valorParcelas, salario = 0, porcentagem;
            int numParcelas = 0;

            numParcelas = int.Parse(txtNumParc.Text);
            salario = float.Parse(txtSalario.Text);
            valor = float.Parse(txtValor.Text);


            valorParcelas = valor / numParcelas;
            porcentagem = salario / 100 * 30;

            if (valorParcelas <= porcentagem)
            {
                lblResult.Text = "situação: aprovado";
            }
            else
            {
                lblResult.Text = "situação: negado";
            }



        }
    }
}
