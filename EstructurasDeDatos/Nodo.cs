using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;
        private Nodo anterior;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public int V { get; }

        public Nodo(int dato, Nodo siguiente, Nodo anterior)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }

        public Nodo()
        {
            dato = 0;
            siguiente = null;
            anterior = null;
        }

        public Nodo(int v)
        {
            V = v;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
