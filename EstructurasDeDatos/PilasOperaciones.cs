using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class PilasOperaciones
    {
        private NodoP top;

        public NodoP Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }

        public int Count
        {
            get
            {
                int c = 0;
                NodoP t = top;
                while (top != null)
                {
                    c++;
                    t = t.Siguiente;
                }
                return c;
            }
        }

        public PilasOperaciones()
        {
            top = null;
        }

        public void Push(NodoP n)
        {
            n.Siguiente = top;
            top = n;
        }

        public NodoP Pop()
        {
            NodoP regreso = null;
            if (top != null)
            {
                top = top.Siguiente;
            }
            return regreso;
        }
        public override string ToString()
        {
            string lista = "";
            NodoP t = top;
            if (t != null)
            {
                lista += t.ToString();
                t = t.Siguiente;
                while (t != null)
                {
                    lista += "," + t.ToString();
                    t = t.Siguiente;
                }
                lista += ".";
                lista = lista.Replace(".", "");
                return lista;

            }
            else
            {
                return "La lista esta vacia";
            }
        }
    }
}
