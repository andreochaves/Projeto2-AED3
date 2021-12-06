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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] vetor = new int[30];
            label1.Text = "";
            label2.Text = "";
            for (int i = 0; i < 30; i++)
            {
                vetor[i] = rand.Next(1, 12);
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                label1.Text += " " + vetor[i].ToString(); 
            }
            VerificarRepeticao(vetor);
        }

        void VerificarRepeticao(int[] M)
        {
            int chave=0, count = 0;
            for (int i = 0; i < M.Length; i++)
            {
                chave = M[i];
                count = 0;

                for (int j = 0; j < M.Length; j++)
                {
                    if (chave == M[j])
                    {
                        count++;
                    }
                    
                }
                if (count >= 3)
                {
                    count = chave;
                    label2.Text += " " + Repetidos(count).ToString();
                }
            }
        }

        int Repetidos(int c)
        {
            return c;
        }
    }
}
