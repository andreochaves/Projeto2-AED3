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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            exercicio2ToolStripMenuItem.Click += Exercicio2ToolStripMenuItem_Click;
            exercicio3ToolStripMenuItem.Click += Exercicio3ToolStripMenuItem_Click;
        }

        private void Exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BubbleSort form = new BubbleSort();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void Exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
