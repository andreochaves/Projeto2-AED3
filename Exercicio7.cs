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
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numList = new int[] { 20,70,30,15,5,40,10};
            label3.Text = "";
            label2.Text = "";
            bubbleSort(numList);
            for (int j = 0; j < numList.Length; j++)
            {
                label2.Text += " " + numList[j].ToString();
            }
            for (int j = numList.Length; j >=1; j--)
            {
                label3.Text += " " + numList[j-1].ToString();
            }
        }

        public static int[] bubbleSort(int[] vetor)
        {
            for (int i = vetor.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            return vetor;
        }
        

    }
}
