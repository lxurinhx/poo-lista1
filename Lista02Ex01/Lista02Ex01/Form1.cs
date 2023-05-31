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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;

            if (senha == "1234")
            {
                lblResult.Text = "acesso permitido";
            }
            else if (senha == "")
            {
                lblResult.Text = "por favor, preencha uma senha";
            }
            else
            {
                lblResult.Text = "acesso negado";
            }
        }
    }
}
