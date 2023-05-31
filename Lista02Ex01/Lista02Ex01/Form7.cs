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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        string[] nome = new string[3];
        int[] matricula = new int[3];
        float[] nota1 = new float[3];
        float[] nota2 = new float[3];
        float[] nota3 = new float[3];
        string[] conceito = new string[3];

        int x = 0, i;

        float notaF;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            nome[x] = txtNome.Text;
            matricula[x] = int.Parse(txtNMatricula.Text);
            nota1[x] = float.Parse(txtNota1.Text);
            nota2[x] = float.Parse(txtNota2.Text);
            nota3[x] = float.Parse(txtNota3.Text);

            x++;

            txtNome.Clear();
            txtNMatricula.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();

            if (x == 3)
            {
                btnRegistrar.Enabled = false;

                for(i = 0; i < nota3.Length; i++)
                {
                    notaF = nota1[i] + nota2[i] + nota3[i];

                    if (notaF >= 9 && notaF <= 10)
                    {
                        conceito[i] = "A";
                    }
                    else if (notaF >= 7 && notaF < 9)
                    {
                        conceito[i] = "B";
                    }
                    else if (notaF >= 5 && notaF < 7)
                    {
                        conceito[i] = "C";
                    }
                    else if (notaF >= 3 && notaF < 5)
                    {
                        conceito[i] = "D";
                    }
                    else if (notaF  < 3)
                    {
                        conceito[i] = "E";
                    }


                    listResult.Items.Add("nome: " + nome[i] + " | número da matrícula: " + matricula[i] + " | nota 1: " + nota1[i] + " | nota 2: " + nota2[i]+ " | nota 3: " + nota3[i] + " | classificação: " + conceito[i]);
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }
    }
}
