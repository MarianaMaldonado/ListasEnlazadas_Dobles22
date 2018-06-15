using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas_Dobles2
{
    class Agenda
    {
        Contacto inicio, ultimo, temporal, anterior, buscado;

        public Agenda()
        {
            inicio = null;
        }

        public void Agregar(Contacto nuevo)
        {
             temporal = inicio;

            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
            }
            else
            {
                if (inicio.siguiente == null)
                    if (inicio.Telefono > nuevo.Telefono)
                    {
                        nuevo.siguiente = inicio;
                        ultimo = inicio;
                        inicio = nuevo;
                        inicio.siguiente = ultimo;
                        ultimo.anterior = inicio;
                    }
                    else
                    {
                        inicio.siguiente = nuevo;
                        ultimo = nuevo;
                        ultimo.anterior = inicio;
                    }
                else
                {
                    if (inicio.Telefono > nuevo.Telefono)
                    {
                        nuevo.siguiente = inicio;
                        inicio.anterior = nuevo;
                        inicio = nuevo;
                    }
                    else if (ultimo.Telefono < nuevo.Telefono)
                    {
                        ultimo.siguiente = nuevo;
                        nuevo.anterior = ultimo;
                        ultimo = nuevo;
                    }

                    else
                    {
                        temporal = inicio;

                        while (temporal.siguiente.Telefono < nuevo.Telefono && temporal.siguiente != ultimo)
                        {
                            temporal = temporal.siguiente;
                        }

                        nuevo.siguiente = temporal.siguiente;
                        temporal.siguiente.anterior = nuevo;
                        temporal.siguiente = nuevo;
                        nuevo.anterior = temporal;
                    }
                }
            }
        }

        public bool Eliminar(int telefono)
        {
            Contacto buscado = Buscar(telefono);
            if (buscado != null)
            {
                if (buscado == inicio)
                {
                    inicio = inicio.siguiente;
                }

                else
                    anterior.siguiente = buscado.siguiente;

                return true;

            }
            return false;

        }

        public bool EliminarPrimero()
        {
            if (inicio == null)
            {
                return false;
            }
            else

            if (inicio != null)
            {
                inicio = inicio.siguiente;
            }

            return true;
        }

        public bool EliminarUltimo()
        {
            if (ultimo == null)
            {
                return false;
            }
            else
            {
                ultimo = ultimo.anterior;
                ultimo.siguiente = null;

                return true;
            }
        }

        public Contacto Buscar(int telefono)
        {
            temporal = inicio;
            buscado = null;

            while (buscado == null && temporal != null)
            {
                if (telefono == temporal.Telefono)
                {
                    buscado = temporal;
                    //return temporal.ToString();
                }
                else
                    anterior = temporal;
                temporal = temporal.siguiente;
            }

            return buscado;
        }

        public string Listar()
        {
            string Contacto = "";
            temporal = inicio;

            while(temporal != null)
            {
                Contacto += temporal.ToString() + Environment.NewLine;
                temporal = temporal.siguiente;
            }

            return Contacto;
        }
    }
}
