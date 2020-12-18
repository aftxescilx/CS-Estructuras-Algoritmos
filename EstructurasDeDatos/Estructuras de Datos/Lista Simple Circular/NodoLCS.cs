using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class NodoLCS
    {
        private int dato;
        private NodoLCS siguiente;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoLCS Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public NodoLCS()
        {
            dato = 0;
            siguiente = null;
        }

        public NodoLCS(int dato, NodoLCS siguiente)
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
