using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_AED_3
{
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] vet = new int[] { 36, 52, 51, 5, 33, 17, 33, 53, 42, 8 };
            label3.Text = "";
            par_impar(vet);
            for (int i = 0; i < vet.Length; i++)
            {
                label3.Text += " " + vet[i].ToString();
            }
        }

        void par_impar(int[] M)
        {
            int i, aux, j, z;
            for (z = 0; z < M.Length; z++)
            {
                if ((z % 2) != 0)
                {
                    for (i = 1; i < 100; i = i + 2)
                    {
                        if (M[i] > M[i + 1])
                        {
                            aux = M[i];
                            M[i] = M[i + 1];
                            M[i + 1] = aux;
                        }
                    }
                }
                else
                {
                    for (i = 0; i < 100; i = i + 2)
                    {
                        if (M[i] > M[i + 1])
                        {
                            aux = M[i];
                            M[i] = M[i + 1];
                            M[i + 1] = aux;
                        }
                    }
                }
            }
            for (j = 0; j < 100; j++)
            {
                //printf("%d \n", M[j]);
            }
        }

    }
}
