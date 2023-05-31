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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 10 == 0)
                {
                    soma += i; 
                }
            }

            lblResult.Text = "soma: " + soma.ToString();
        }
    }
}
