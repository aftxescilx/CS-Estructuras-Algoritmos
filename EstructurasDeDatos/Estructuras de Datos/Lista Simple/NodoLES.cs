using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class NodoLES
    {
        private int dato;
        private NodoLES siguiente;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoLES Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoLES()
        {
            dato = 0;
            siguiente = null;
        }

        public NodoLES(int dato, NodoLES siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
