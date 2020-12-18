using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class NodoCola
    {
        private int dato;
        private NodoCola siguiente;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoCola Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoCola()
        {
            dato = 0;
            siguiente = null;
        }

        public NodoCola(int dato, NodoCola siguiente)
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
