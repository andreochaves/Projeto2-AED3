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
    public partial class Exercicio8 : Form
    {
        public Exercicio8()
        {
            InitializeComponent();
        }

        private void countSort(int[] array, int size)
        {
            int[] output= new int[10];
            int[] count = new int[10];
            int max = array[0];

            for (int i = 1; i < size; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            for (int i = 0; i <= max; ++i)
            {
                count[i] = 0;
            }

            for (int i = 0; i < size; i++)
            {
                count[array[i]]++;
            }

            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = size - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;
            }

            for (int i = 0; i < size; i++)
            {
                array[i] = output[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = new int[] { 4, 2, 2, 8, 3, 3, 1 };
            int n = array.Length;
            countSort(array, n);
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i].ToString());
            }
        }

        
    }
}
