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
    public partial class programa1 : Form
    {
        public programa1()
        {
            InitializeComponent();
        }
        List<Agenda> lista = new List<Agenda>();
        public void guardarpersona()
        {

            Agenda persona1 = new Agenda(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtTelefono.Text, txtCorreo.Text);

            // Agregar datos a la lista
            lista.Add(persona1);

            dGVDdatos.DataSource = null;
            dGVDdatos.DataSource = lista;
        }

        // Modificar datos de la lista
        public void modificar(string nombre)
        {
            foreach (var persona in lista)
            {
                if (persona.Nombre == nombre)
                {
                    persona.Nombre = txtNombre.Text;
                    persona.Apellido = txtApellido.Text;
                    persona.Edad = Convert.ToInt32(txtEdad.Text);
                    persona.Telefono = txtTelefono.Text;
                    persona.Correo = txtCorreo.Text;
                }
            }
        }

        // Eliminar datos de la lista
        public void eliminar(string nombre)
        {
            foreach (var item in lista)
            {
                if (item.Nombre == nombre)
                {
                    lista.Remove(item);
                    break;
                }
            }
        }

        private void programa1_Load(object sender, EventArgs e)
        {
            if (txtNomaModificar.Text=="")
            {
                btnModificar.Enabled = true;
            }

            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtNombre.Text + txtApellido.Text + txtEdad.Text + txtTelefono.Text + txtCorreo.Text))
                    MessageBox.Show("Debe rellenar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                guardarpersona();
                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();
                txtTelefono.Clear(); txtCorreo.Clear();
                txtNombre.Focus();
                return;
                {
                   
                }
                
            }
            catch (Exception)
            {

                txtNombre.Focus();
            }

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtNomaModificar.Text))
                    errorProvider1.SetError(txtNomaModificar, "Debe rellenar el campo nombre M ");

                modificar(txtNomaModificar.Text);
                dGVDdatos.DataSource = null;
                dGVDdatos.DataSource = lista;
                return;

                {

                }



            }
            catch (Exception)
            {
                errorProvider1.SetError(txtNomaModificar, "");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            eliminar(txtNomaModificar.Text);
            dGVDdatos.DataSource = null;
            dGVDdatos.DataSource = lista;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
