﻿using System;
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
            //int i = numList.Length - 1;
            //int temp = 0;
            label3.Text = "";
            //while (i >= 1)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (numList[j] > numList[j+1])
            //        {
            //            temp = numList[j];
            //            numList[j] = numList[j + 1];
            //            numList[j + 1] = temp;
            //        }
            //    }
            //    i--;

            //}
            bubbleSort(numList);
            for (int j = 0; j < numList.Length; j++)
            {
                label3.Text += " " + numList[j].ToString();
            }
        }

        public static int[] bubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;
            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }
            return vetor;
        }
        

    }
}