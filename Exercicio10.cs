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
        }
        void par_impar(int[] M)
        {
            int trocado = 1, i, aux, j, z = 1;
            while ((z < 100) || z==trocado)
            {
                trocado = 0;
                if ((z % 2) != 0)
                {
                    for (i = 1; i < 100; i = i + 2)
                    {
                        if (M[i] > M[i + 1])
                        {
                            aux = M[i];
                            M[i] = M[i + 1];
                            M[i + 1] = aux;
                            trocado = 1;
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
                            trocado = 1;
                        }
                    }
                }
                z++;
            }
            for (j = 0; j < 100; j++)
            {
                //printf("%d \n", M[j]);
            }
        }
    }
}
