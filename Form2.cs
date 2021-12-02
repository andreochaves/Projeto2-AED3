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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int[] numList = new int[] { 3, 4, 9, 2, 5, 8, 2, 1, 7, 4, 6, 2, 9, 8, 5, 1 };
            int len = 16;
            MergeSort_Recursive(numList, 0, len - 1);

            for (int i = 0; i < numList.Length; i++)
            {
                label2.Text += " " + numList[i].ToString();
            }
        }

        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int[] numList = new int[] { 3, 4, 9, 2, 5, 8, 2, 1, 7, 4, 6, 2, 9, 8, 5, 1 };
            int len = 16;
            SortQuick(numList, 0, len - 1);

            for (int i = 0; i < numList.Length; i++)
            {
                label2.Text += " " + numList[i].ToString();
            }
        }

        static public int Partition(int[] numbers, int left, int right)

        {

            int pivot = numbers[left];

            while (true)

            {

                while (numbers[left] < pivot)

                    left++;



                while (numbers[right] > pivot)

                    right--;



                if (left < right)

                {

                    int temp = numbers[right];

                    numbers[right] = numbers[left];

                    numbers[left] = temp;

                }

                else

                {

                    return right;

                }

            }

        }



        static public void SortQuick(int[] arr, int left, int right)

        {

            // For Recusrion  

            if (left < right)

            {

                int pivot = Partition(arr, left, right);



                if (pivot > 1)

                    SortQuick(arr, left, pivot - 1);



                /*if (pivot + 1 < right)

                    SortQuick(arr, pivot + 1, right);
                */
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text;
        }
    }
}
