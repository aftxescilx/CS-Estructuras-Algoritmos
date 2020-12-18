using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class NodoLEDC
    {
        private int dato;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        //tiene un apuntador al siguiente nodo
        private NodoLEDC siguiente;
        public NodoLEDC Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        // y tiene un apuntador al nodo anterior
        private NodoLEDC atras;

        public NodoLEDC Atras
        {
            get { return atras; }
            set { atras = value; }
        }

        public NodoLEDC()
        {
            dato = 0;
            siguiente = null;


        }
        public NodoLEDC(int dato, NodoLEDC siguiente)
        {
            this.Dato = dato;
            this.Siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
