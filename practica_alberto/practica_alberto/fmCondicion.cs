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
    public partial class fmCondicion : Form
    {
        public fmCondicion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text=="" && textBox4.Text=="")
                {
                    MessageBox.Show("debe llenar las cajas de texto");
                    textBox3.Focus();
                }
                else
                {
                    int suma;
                    int resta;
                    int multi;
                    int divi;
                    int numero1;
                    int numero2;
                    string codigo = null;

                    numero1 = Convert.ToInt32(textBox3.Text);

                    numero2 = Convert.ToInt32(textBox4.Text);
                    suma = numero1 + numero2; resta = numero1 - numero2;
                    multi = numero1 * numero2; divi = numero1 / numero2;
                    if (numero1 < numero2)
                    {
                        label9.Text = ("el numero 2 es mayor");

                    }
                    if (numero1 > numero2)
                    {
                        label9.Text = ("el numero  1 es mayor");

                    }
                    if (numero1 == numero2)
                    {
                        label9.Text = ("Ambos numeros son iguales");
                    }
                    label10.Text = ("la sumatoria es : " + suma);
                    label12.Text = "la Resta es: " + resta;
                    label13.Text = ("la multiplicacion es: " + multi);
                    label14.Text = ("la division es: " + divi);
                    codigo = "\n"
                            + "if (numero1 < numero2)\n"
                            + "\n"
                            + "{\n"
                            + " label9.Text= (el numero 2 es mayor);\n"
                            + "}"
                            + "if (numero1 > numero2)\n"
                            + "\n"
                            + "{\n"
                            + " label9.Text= (el numero 1 es mayor);\n"
                            + "}"
                            + "if (numero1 == numero2)\n"
                            + "\n"
                            + "{\n"
                            + " label9.Text= (los numeros son iguales);\n"
                            + "}";
                    textBox1.Text = codigo;
                    errorProvider1.SetError(textBox3, "");
                    errorProvider1.SetError(textBox4, "");
                }

            }
            catch (Exception)
            {
                
                errorProvider1.SetError(textBox3, "solo se aceptan numeros ");
                errorProvider1.SetError(textBox4, "solo se aceptan numeros");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int ano;
                string codigo = null;

                ano = Convert.ToInt32(txtano.Text);
                if (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0))
                {
                    label6.Text = ("El año " + ano + " Si es bisiesto ");
                }
                else
                {
                    label6.Text = ("El año " + ano + " No es bisiesto ");
                }
                codigo = "\n"
                    +"/condicion/ if(variable % 4 == 0 && (variable % 100 != 0 || variable % 400 == 0))\n"
                    +"\n"
                    + "{\n"
                    + "label6.text=(El año + ano + Si es bisiesto);\n"
                    + "}"
                    + "else"
                    + "{"
                    +"label6.text=(El año + ano + No es bisiesto);\n"
                    + "}";
                textBox2.Text = codigo;
                errorProvider1.SetError(txtano, "");
                txtano.Clear();
            }
            catch (Exception)
            {
                
                errorProvider1.SetError(txtano, "solo puede ingresar numeros");
                txtano.Clear();
                label6.Text = "";
                 
                    return;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void fmCondicion_Load(object sender, EventArgs e)
        {

        }
    }
}
