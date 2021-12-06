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
    public partial class Exercicio9 : Form
    {
        public Exercicio9()
        {
            InitializeComponent();
        }

        public static List<int> BucketSort1(params int[] x)
        {
            List<int> result = new List<int>();
            int numOfBuckets = 10;
            List<int>[] buckets = new List<int>[numOfBuckets];
            
            for (int i = 0; i < numOfBuckets; i++)
                buckets[i] = new List<int>();
            
            for (int i = 0; i < x.Length; i++)
            {
                int buckitChoice = (x[i] / numOfBuckets);
                buckets[buckitChoice].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                int[] temp = BubbleSortList(buckets[i]);
                result.AddRange(temp);
            }
            return result;
        }

        public static int[] BubbleSortList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i] < input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int[] x = new int[] { 99, 95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 45, 40, 35, 30, 25, 20, 15, 10, 5, 1 };
            List<int> sorted = BucketSort1(x);
            foreach (int i in sorted)
            {
                label1.Text += " " + i.ToString();
            }
        }
    }
}
