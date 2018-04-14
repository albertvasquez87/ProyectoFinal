using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_alberto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            programa1 p1 = new programa1();
            p1.Show();
            p1.MdiParent = this;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            grupo gr = new grupo();
            gr.Show();
            gr.MdiParent = this;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            programa2 p2 = new programa2();
            p2.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            programa3 p3 = new programa3();
            p3.Show();
            p3.MdiParent = this;
        }
    }
}
