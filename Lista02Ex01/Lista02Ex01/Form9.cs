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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        char[] doisOuUm1 = new char[4];
        char[] doisOuUm2 = new char[4];
        char[] doisOuUm3 = new char[4];

        int x = 0, i;

        private void btnJogar_Click(object sender, EventArgs e)
        {
            doisOuUm1[x] = char.Parse(txtNum1.Text);
            doisOuUm2[x] = char.Parse(txtNum2.Text);
            doisOuUm3[x] = char.Parse(txtNum3.Text);

            x++;
            txtNum1.Clear();
            txtNum2.Clear();   
            txtNum3.Clear();

            if (x == 4)
            {
                btnJogar.Enabled = false;

                for (i = 0; i < doisOuUm3.Length; i++)
                {
                    if (doisOuUm1[i] != doisOuUm2[i] && doisOuUm1[i] != doisOuUm3[i])
                    {
                        lstResult.Items.Add( (i + 1) + "º vencedor: número 1");
                    }
                    else if (doisOuUm2[i] != doisOuUm1[i] && doisOuUm2[i] != doisOuUm3[i])
                    {
                        lstResult.Items.Add( (i + 1) + "º vencedor: número 2");
                    }
                    else if (doisOuUm3[i] != doisOuUm1[i] && doisOuUm3[i] != doisOuUm2[i])
                    {
                        lstResult.Items.Add( (i + 1) + "º vencedor: número 3");
                    }
                    else if (doisOuUm1[i] == doisOuUm2[i] && doisOuUm1[i] == doisOuUm3[i])
                    {
                        lstResult.Items.Add("empate");
                    }
                }
            }
        }
    }
}
