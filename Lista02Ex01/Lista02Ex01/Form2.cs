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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] nome = new string[3];
        int[] quant = new int[3];
        float[] preco = new float[3];
        float[] desc = new float[3];

        int x = 0, i;
        float total, totalPagar, totalDesconto;

        private void button1_Click(object sender, EventArgs e)
        { 
            nome[x] = txtNome.Text;
            quant[x] = int.Parse(txtQuant.Text);
            preco[x] = float.Parse(txtPreco.Text);
            desc[x] = float.Parse(txtDesc.Text);

            x++;

            txtNome.Clear();
            txtQuant.Clear();
            txtPreco.Clear();
            txtDesc.Clear();

            if (x == 3)
            {
                btnCadastrar.Enabled = false;

                for(i=0; i<desc.Length; i++)
                {
                    totalPagar = (quant[i] * preco[i]);
                    totalDesconto = ((desc[i] * totalPagar) / 100);
                    total = totalPagar - totalDesconto;

                    listResult.Items.Add( "produto: " + nome[i] + " | quantidade: " + quant[i] + " | preço: R$" + preco[i] + " | desconto: " + desc[i] + "%" + " | total a pagar: R$" + totalPagar);

                }
            }
        }
    }
}
