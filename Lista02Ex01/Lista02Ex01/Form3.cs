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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        float saldo = 0;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string nome, numero;
            float valor;

            if (cmbTipo.SelectedItem == "depósito")
            {
                saldo = saldo + float.Parse(txtValor.Text);
                lblSaldo.Text = "saldo: R$" + saldo;
            }
            else if (cmbTipo.SelectedItem == "saque")
            {
                saldo = saldo - float.Parse(txtValor.Text);
                lblSaldo.Text = "saldo: R$" + saldo; 
            }
            else
            {
                MessageBox.Show("selecione o tipo de transação");
            }
        }
    }
}
