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
    public partial class fmRepeticion : Form
    {
        public fmRepeticion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
             int num = Convert.ToInt32(nudTablaNum.Value);
            int omite = Convert.ToInt32(nudContinue.Value);
            int detiene = Convert.ToInt32(nudBreak.Value);
            string item = null;
            string codigo = null;
            listTabla.Items.Clear();
            txtCodigo.Clear();
            if (rbFor.Checked)
            {
                for (int i = 0; i <= 12; i++)
                {
                    if (ckbContinue.Checked && i == omite) continue;
                    item = num + " \u00D7 " + i + " = " + i * num;
                    listTabla.Items.Add(item);
                    if (ckbBreak.Checked && i == detiene) break;
                }

                codigo = "for (int i = 0; i < length; i++)\n"
                    + "{\n"
                    + "\t if(i = <valor>) continue; \n"
                    + "\t <instrucciones> \n"
                    + "\t if(i = <valor>) break; \n"
                    + "}";
                txtCodigo.Text = codigo;
            }
            else if (rbWhile.Checked)
            {
                int i = 0;
                while (i <= 12)
                {
                    if (ckbContinue.Checked && i == omite)
                    {
                        i++;
                        continue;
                    }
                    item = num + " \u00D7 " + i + " = " + i * num;
                    listTabla.Items.Add(item);
                    if (ckbBreak.Checked && i == detiene) break;
                    i++;
                }
                codigo = "int i = 0 //contador\n"
                    + "while (i <= length)\n"
                    + "{\n"
                    + "\t if(i = <valor>)\n"
                    + "\t {\n"
                    + "\t\t i++;\n"
                    + "\t\t continue;\n"
                    + "\t }\n"
                    + "\t <instrucciones>\n"
                    + "\t if (i = <valor>) break; \n"
                    + "\t i++;\n"
                    +"}";
                txtCodigo.Text = codigo;
            }
            else if (rbDoWhile.Checked)
            {
            int i = 0;
                do
                {
                    if (ckbContinue.Checked && i == omite)
                    {
                    i++;
                    continue;
                    }
                    item = num + " \u00D7 " + i + " = " + i * num;
                    listTabla.Items.Add(item);
                    if (ckbBreak.Checked && i == detiene) break;
                    i++;
                }
                while (i <= 12);
                codigo = "int i = 0 //contador\n"
                    + "do\n"
                    + "{\n"
                    + "\t if (i = <valor>)\n"
                    + "\t {\n"
                    + "\t\t i++;\n"
                    + "\t\t continue;\n"
                    + "\t }\n"
                    + "\t <instrucciones>\n"
                    + "\t if(i = <valor>) break;\n"
                    + "\t i++;\n"
                    + "}\n"
                    + "while (i <= length)";
                txtCodigo.Text = codigo;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
