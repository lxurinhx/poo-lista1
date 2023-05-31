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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);

            if (num1 > num2 && num1 > num3)
            {
                lblMaior.Text = "maior número: " + num1 + " (primeiro)";
            }
            else if (num2 > num1 && num2 > num3)
            {
                lblMaior.Text = "maior número: " + num2 + " (segundo)";
            }
            else if (num3 > num1 && num3 > num2)
            {
                lblMaior.Text = "maior número: " + num3 + " (terceiro)";
            }



        }
    }
}
