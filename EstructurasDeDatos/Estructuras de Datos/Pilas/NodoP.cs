using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.Estructuras_de_Datos.Pilas
{
    class NodoP
    {
        private int dato;

        public int Dato
        {
            get
            {
                return dato;
            }
            set
            {
                dato = value;
            }
        }

        private NodoP siguiente;

        public NodoP Siguiente
        {
            get
            {
                return siguiente;
            }
            set
            {
                siguiente = value;
            }
        }

        public NodoP()
        {
            dato = 0;
            siguiente = null;
        }

        public NodoP(int d)
        {
            dato = d;
            siguiente = null;
        }

        public NodoP(int d, NodoP s)
        {
            dato = d;
            siguiente = s;
        }

        public NodoP(NodoP n)
        {
            dato = n.dato;
            siguiente = n.siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
