﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int num = 100;
        int x = 0, i;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[6];
            
            vetor[0] = num;

            lstResult.Items.Add(vetor[0]);

            for(int i = 1; i <vetor.Length; i++)
            {
                vetor[i] = vetor[i - 1] * 2;
                lstResult.Items.Add(vetor[i]);
            }
        }
    }
}
