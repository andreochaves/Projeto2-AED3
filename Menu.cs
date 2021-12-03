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
            exercicio7ToolStripMenuItem.Click += Exercicio7ToolStripMenuItem_Click;
            exercicio8ToolStripMenuItem.Click += Exercicio8ToolStripMenuItem_Click;
            exercicio9ToolStripMenuItem.Click += Exercicio9ToolStripMenuItem_Click;
        }

        private void Exercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio9 form = new Exercicio9();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void Exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio2 form = new Exercicio2();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void Exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio7 form = new Exercicio7();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void Exercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio8 form = new Exercicio8();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
