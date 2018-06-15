using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas_Dobles2
{
    public partial class Form1 : Form
    {
        Agenda contactos = new Agenda();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            int Edad = Convert.ToInt32(txtEdad.Text);
            string Correo = txtCorreo.Text;
            Int32 Telefono = Convert.ToInt32(txtTelefono.Text);

            contactos.Agregar(new Contacto(Nombre, Edad, Correo, Telefono));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = contactos.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = contactos.Buscar(Convert.ToInt32(txtTelefono.Text)).ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contactos.Eliminar(Convert.ToInt32(txtTelefono.Text)))
            {
                txtDatos.Text = contactos.Listar();
            }
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            if (contactos.EliminarPrimero())
            {
                txtDatos.Text = contactos.Listar();
            }
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            if(contactos.EliminarUltimo())
            {
                txtDatos.Text = contactos.Listar();
            }
        }
    }
}
