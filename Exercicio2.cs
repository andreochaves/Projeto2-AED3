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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MergeSort merge = new MergeSort();
            label2.Text = "";
            int[] numList = new int[] { 3, 4, 9, 2, 5, 8, 2, 1, 7, 4, 6, 2, 9, 8, 5, 1 };
            int len = 16;
            merge.MergeSort_Recursive(numList, 0, len - 1);

            for (int i = 0; i < numList.Length; i++)
            {
                label2.Text += " " + numList[i].ToString();
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            QuickSort quick = new QuickSort();
            label2.Text = "";
            int[] numList = new int[] { 3, 4, 9, 2, 5, 8, 2, 1, 7, 4, 6, 2, 9, 8, 5, 1 };
            quick.quickSort(numList);

            for (int i = 0; i < numList.Length; i++)
            {
                label2.Text += " " + numList[i].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HeapSort obj = new HeapSort();
            label2.Text = "";
            int[] numList = new int[] { 3, 4, 9, 2, 5, 8, 2, 1, 7, 4, 6, 2, 9, 8, 5, 1 };
            int len = 16;
            obj.heapSort(numList,len);
            for (int i = 0; i < numList.Length; i++)
            {
                label2.Text += " " + numList[i].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text;
        }
    }
}
