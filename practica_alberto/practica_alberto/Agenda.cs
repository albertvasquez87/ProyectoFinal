using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_alberto
{
    class Agenda
    {
         private string nombre;
        private string apellido;
        private int edad;
        private string telefono;
        private string correo;


        // Construcor sin parametros:
        public Agenda()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            edad = 0;
            telefono = string.Empty;
            correo = string.Empty;            
        }
        // Constructor con parametros:
        public Agenda(string nom, string ap, int ed,string tel, string corr)
        {
            nombre = nom;
            apellido = ap;
            edad = ed;
            telefono = tel;
            correo = corr;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
          get { return edad; }
          set { edad = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}
