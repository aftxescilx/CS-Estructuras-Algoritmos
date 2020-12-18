using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class NodoLDE
    {
        private int dato;
        private NodoLDE siguiente;
        private NodoLDE anterior;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoLDE Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public NodoLDE Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public NodoLDE(int dato, NodoLDE siguiente, NodoLDE anterior)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }

        public NodoLDE()
        {
            dato = 0;
            siguiente = null;
            anterior = null;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
