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
    public partial class fmSeleccion : Form
    {
        public fmSeleccion()
        {
            InitializeComponent();
        }

        private void cboColorFondo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboColorFondo.SelectedIndex)
            {
                case 0: this.BackColor = System.Drawing.Color.Yellow;
                    break;
                case 1: this.BackColor = System.Drawing.Color.Blue;
                    break;
                case 2: this.BackColor = System.Drawing.Color.Red;
                    break;
                case 3: this.BackColor = System.Drawing.Color.Green;
                    break;
                default: this.BackColor = SystemColors.Control;
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboColorFondo.SelectedItem = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
