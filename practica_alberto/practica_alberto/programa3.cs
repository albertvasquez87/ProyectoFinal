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
    public partial class programa3 : Form
    {   //Juan Alberto Vasquez   14-EISN-1-200 
        //Las variables se ponen en esta parte para que sea accesible a todos los miembros o partes del programa y son del tipo enteras
        int w=0;
        int a=0;
        public programa3()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {//Juan Alberto Vasquez   14-EISN-1-200 
            //en esta parte se ponen 4 variables enteras que se le asociaran avarias cajas de texto
            int primernumero;
            int segundonumero;
            int tercernumero;
            int cuartonumero;
            int resultado;
            /*Juan Alberto Vasquez   14-EISN-1-200 
             * el try catch es un acaparador de errores  o exclusiones para evitar que el programa explote
              el try seguira ejecuando  todo el bloque o sentencia de codigo dentro de las llaves del mismo*/
            try
           {
                /*aqui se asocia  las variables a las cajas de texto y lo que se hace es que lo que la variables
                 se conveirta a  loque se escriba en las cajas de texto*/
                primernumero = int.Parse(textBox4.Text);
                segundonumero = int.Parse(textBox5.Text);
                tercernumero = int.Parse(textBox6.Text);
                cuartonumero = int.Parse(textBox7.Text);
                /*Juan Alberto Vasquez   14-EISN-1-200 
                 * aqui se dara la primera  condicion que siempre para poder continuar siempre debe ser verdadera*/
                if (comboBox1.Text == "")
                {
                    errorProvider1.SetError(comboBox1,"Debe seleccionar al menos una materia");
                    return;
                }
                /*aqui entra lo que es el primer bucle  que mientras se cumpla el requisito seguira de lo contrario no dejara 
                 continuar*/
                while (primernumero >= 11)
                {
                    errorProvider1.SetError(textBox4, "La asistenca debe tener una puntuacion menor que 10");
                 
                    return;
                }
                while (segundonumero >= 21)
                {
                    errorProvider1.SetError(textBox4, "La practica debe tener una puntuacion menor que 20");

                    return;
                }
                while (tercernumero >= 21)
                {
                    errorProvider1.SetError(textBox4, "El examen parcial debe tener una puntuacion menor que 20");

                    return;
                }
                while (cuartonumero >= 51)
                {
                    errorProvider1.SetError(textBox4, "El examen final debe tener una puntuacion menor que 50");

                    return;
                }
                //Richards Lugo   07-EIST-1-082
                /*esta condicion  lo que hace una comparacion con la primera  varible que es accesible para todas las partes
                 del codigo  , lo que hace es verificar si  el ancho de la caja es igual a  887 */
                if (button1.Text == "Calcular nota")
                {

                    w = this.Width;
                    /*el for hara dicha comparacion y si no se cumple agregara anchura al formulario o caja hasta  lo especificado*/
                    for (int i = this.Width; i < w + 887; i++)
                    {
                        this.Width = i;
                        this.Height = 1;
                        a = i;
                    }
                }

                    button1.Text = "Calcular nota";

                // aqui se hace una suma  entre las 4 variables enteras  ya mencionadas
                resultado = primernumero + segundonumero + tercernumero + cuartonumero;
                //aqui se llamaran con el .show las etiquetas ocultas por .hide
                label26.Show(); label27.Show(); label28.Show();
                textBox9.Text = resultado.ToString();
                /*en esta parte  lo que hace es  que se agrega un objeto de tipo objeto  llaamado errorprovider el cual
                 sustituye a los messagebox en este caso con la idea de eviar el molesto cuadro de dialogo*/
                errorProvider1.SetError(textBox4, ""); errorProvider1.SetError(textBox5, ""); errorProvider1.SetError(textBox6, "");
                errorProvider1.SetError(textBox7, ""); errorProvider1.SetError(comboBox1, "");

                {
                    //Richards Lugo   07-EIST-1-082
                    //esta  otra deciscion lo que hace es comparar  la suma en la variable resultado
                    if (resultado >= 90)
                    {
                        textBox8.Text = "A";
                        label20.Text = "FELICIDADES HAS TENIDO UNA NOTA EXCELENTE \n  APROVASTE";
                        label11.Text ="NOMBRE : "+ textBox1.Text;
                        label15.Text = "MATERIA: " + comboBox1.SelectedItem;
                        label13.Text = "MATRICULA DEL ESTUDIANTE: " + textBox2.Text;
                        label14.Text = "SECCION EN LA QUE ESTA EL ESTUDIANTE: " + textBox3.Text;
                        label22.Text = textBox4.Text;
                        label23.Text = textBox5.Text;
                        label24.Text = textBox6.Text;
                        label25.Text = textBox7.Text;
                    }
                      //si la primera deciscion es falsa pasa a comprar si el resultado obtenido es igual a este sino seguira  
                    else if ((resultado >= 80 & resultado <= 89))
                    {
                        textBox8.Text = "B";
                        label20.Text = "FELICIDADES HAS TENIDO UNA MUY BUENA NOTA \n  SIGUE ASI!!!";
                        label11.Text = "NOMBRE : " + textBox1.Text;
                        label15.Text = "MATERIA: " + comboBox1.SelectedItem;
                        label13.Text = "MATRICULA DEL ESTUDIANTE: " + textBox2.Text;
                        label14.Text = "SECCION EN LA QUE ESTA EL ESTUDIANTE: " + textBox3.Text;
                        label22.Text = textBox4.Text;
                        label23.Text = textBox5.Text;
                        label24.Text = textBox6.Text;
                        label25.Text = textBox7.Text;
                    }
                        
                    else if ((resultado >= 75 & resultado <= 79))
                    {
                         textBox8.Text = "c";
                         label20.Text = "FELICIDADES HAS TENIDO UNA NOTA REGULAR";
                        label11.Text ="NOMBRE : "+ textBox1.Text;
                        label15.Text = "MATERIA: " + comboBox1.SelectedItem;
                        label13.Text = "MATRICULA DEL ESTUDIANTE: " + textBox2.Text;
                        label14.Text = "SECCION EN LA QUE ESTA EL ESTUDIANTE: " + textBox3.Text;
                        label22.Text = textBox4.Text;
                        label23.Text = textBox5.Text;
                        label24.Text = textBox6.Text;
                        label25.Text = textBox7.Text;
                    }
                       
                    else if ((resultado >= 70 & resultado <= 74))
                    {
                        textBox8.Text = "D";
                        label20.Text = "FELICIDADES APROVASTE \n  PERO DEBERIAS ESTUDIAR UN POCO MAS";
                        label11.Text = "NOMBRE : " + textBox1.Text;
                        label15.Text = "MATERIA: " + comboBox1.SelectedItem;
                        label13.Text = "MATRICULA DEL ESTUDIANTE: " + textBox2.Text;
                        label14.Text = "SECCION EN LA QUE ESTA EL ESTUDIANTE: " + textBox3.Text;
                        label22.Text = textBox4.Text;
                        label23.Text = textBox5.Text;
                        label24.Text = textBox6.Text;
                        label25.Text = textBox7.Text;
                    }
                        
                    else if ((resultado >= 60 & resultado <= 69))
                    {
                         textBox8.Text = "FE";
                        label20.Text="NO HAS APROVADO PERO TIENES DERECHO A UN EXAMEN \n COMPLETIVO \n A VER SI CONSIGUES APROVAR ";
                        label11.Text ="NOMBRE : "+ textBox1.Text;
                        label15.Text = "MATERIA: " + comboBox1.SelectedItem;
                        label13.Text = "MATRICULA DEL ESTUDIANTE: " + textBox2.Text;
                        label14.Text = "SECCION EN LA QUE ESTA EL ESTUDIANTE: " + textBox3.Text;
                        label22.Text = textBox4.Text;
                        label23.Text = textBox5.Text;
                        label24.Text = textBox6.Text;
                        label25.Text = textBox7.Text;
                    }
                       
                    else if ((resultado >= 50 & resultado <= 59))
                    {
                        textBox8.Text = "FI";
                        label20.Text = "NO HAS APROVADO PERO TIENES DERECHO A UN EXAMEN \n ESPECIAL \n A VER SI CONSIGUES APROVAR";
                        label11.Text ="NOMBRE : "+ textBox1.Text;
                        label15.Text = "MATERIA: " + comboBox1.SelectedItem;
                        label13.Text = "MATRICULA DEL ESTUDIANTE: " + textBox2.Text;
                        label14.Text = "SECCION EN LA QUE ESTA EL ESTUDIANTE: " + textBox3.Text;
                        label22.Text = textBox4.Text;
                        label23.Text = textBox5.Text;
                        label24.Text = textBox6.Text;
                        label25.Text = textBox7.Text;
                    }
                        
                    else if ((resultado <= 49))
                    {
                        textBox8.Text = "F";
                    label20.Text="HAS REPROBADO LA MATERIA \n ESTUDIA Y PON MAS EMPEÑO PARA LA PROXIMA";
                        label11.Text ="NOMBRE : "+ textBox1.Text;
                        label15.Text = "MATERIA: " + comboBox1.SelectedItem;
                        label13.Text = "MATRICULA DEL ESTUDIANTE: " + textBox2.Text;
                        label14.Text = "SECCION EN LA QUE ESTA EL ESTUDIANTE: " + textBox3.Text;
                        label22.Text = textBox4.Text;
                        label23.Text = textBox5.Text;
                        label24.Text = textBox6.Text;
                        label25.Text = textBox7.Text;
                    }
                        

                }
            }
                /*aqui esta el catch que sive para capturar el error y en vez de explotar  el programa
                 lo que hara sera mostrar un mensaje al usuario ya sea personalizado o mostrando el porque se produjo 
                 dicho error , sin finalizar el programa*/
            catch (FormatException)
            {
                MessageBox.Show("Debe terminar de  rellenar los campos faltantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //esta decicion lo que evitara que las cajas de textos esten vacias o solamente contengan espacios
            if (String.IsNullOrWhiteSpace(textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text + comboBox1.Text))
                MessageBox.Show("Debe rellenar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Focus();
            return;
            {
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {/*Leopoldo Evangelista   10-EISN-1-183
          * el for de esta seccion lo que hara sera verificar si el formulario esta anchado , en dado caso que este anchado 
          lo que hara sera reducir el ancho del formulario hasta el establecido en el mismo formulario */
           
                for (int s = a; s > w; s--)
                {
                    this.Width = s;
                    this.Height = s;
                }
                //Leopoldo Evangelista   10-EISN-1-183
            //si todas las condiciones y bucles se cumplen se procedera a lo que es la limpieza de las cajas de textos y las etiquetas
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear(); textBox9.Clear(); comboBox1.Text="";
            label26.Hide(); label27.Hide(); label28.Hide();
            label20.Text="";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {/*Leopoldo Evangelista   10-EISN-1-183
          * este pedazo o linea de codigo lo que hace es una comparacion en las teclas intrucidas por teclado
          solo permitiendo los numeros  */
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void programa3_Load(object sender, EventArgs e)
        {
            // aqui se oculataran automaticamente estas etiquetas al iniciar el programa y solo se moestraran cuando sean llamadas o invoca
            label26.Hide(); label27.Hide(); label28.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
