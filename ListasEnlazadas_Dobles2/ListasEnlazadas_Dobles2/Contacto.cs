using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas_Dobles2
{
    class Contacto
    {
        /// <summary>
        /// Agenda con listas simples
        /// </summary>
        private string _nombre; // { get; set; }
        private int _telefono; // { get; set; }
        private string _email; // { get; set; }
        private int _edad; // { get; set; }
        public Contacto siguiente { get; set; }
        public Contacto anterior { get; set; }

        /// <summary>
        /// Propiedad de nombre del contacto
        /// </summary>
        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        /// <summary>
        /// Propiedad de la edad del contacto
        /// </summary>
        public int Edad
        {
            get
            {
                return _edad;
            }

            set
            {
                _edad = value;
            }
        }

        /// <summary>
        // Propiedad del correo del contacto
        // </summary>
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }


        /// <summary>
        /// Propiedad de teléfono del contacto 
        /// </summary>
        public int Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public Contacto(string nombre, int edad, string email, int telefono)
        {
            this._nombre = nombre;
            this._edad = edad;
            this._email = email;
            this._telefono = telefono;
        }

        public override string ToString()
        {
            string Contacto = "Nombre: " + _nombre.ToString() + Environment.NewLine +
                              "Edad: " + _edad.ToString() + Environment.NewLine +
                              "Correo: " + _email.ToString() + Environment.NewLine +
                              "Teléfono: " + _telefono.ToString() + Environment.NewLine;

            return Contacto;
        }
    }
}
