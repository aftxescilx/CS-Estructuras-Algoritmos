using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class ListaCircularSimpleOperaciones
    {
        private NodoLCS head;
        public NodoLCS Head
        {
            get { return head; }
            set { head = value; }
        }

        public ListaCircularSimpleOperaciones()
        {
            head = null;
        }
        public ListaCircularSimpleOperaciones(NodoLCS n)
        {
            head = n;
        }
        public bool Agregar(NodoLCS n)
        {
            NodoLCS h = head;

            //lista vacía
            if (head == null)
            {
                n.Siguiente = n;
                head = n;
                return true;
            }
            //nuevo menor que head (insertar al inicio)
            if (n.Dato < head.Dato)
            {
                while (h.Siguiente != head)
                {
                    h = h.Siguiente;
                }
                h.Siguiente = n;
                n.Siguiente = head;
                head = n;
                return true;
            }
            //insertar al final
            while (h.Siguiente != head)
            {
                if (n.Dato < h.Siguiente.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            }

            n.Siguiente = h.Siguiente;
            h.Siguiente = n;

            return true;
        }
        public void Borrar(int dato)
        {
            NodoLCS h = head;
            if (head != null)
            {
                if (head.Dato == dato)
                {
                    while (h.Siguiente != head)
                    {
                        h = h.Siguiente;
                    }

                    head = head.Siguiente;
                    h.Siguiente = head;
                    return;
                }
                else
                {
                    while (h.Siguiente.Dato != dato)
                    {
                        h = h.Siguiente;
                    }
                    h.Siguiente = h.Siguiente.Siguiente;
                }
            }
        }
        public bool BuscarDato(int a)
        {
            NodoLCS h = head;
            if (h != null)

            {
                do
                {
                    if (h.Dato == a)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                } while (h != head);
            }
            return false;
        }
        public int ContarNodos()
        {
            int contador = 0;
            NodoLCS h = head;
            do
            {
                contador++;
                h = h.Siguiente;
            } while (h != head);
            return contador;
        }
        public override string ToString()
        {
            string lista = "";
            NodoLCS h = head;
            if (h != null)
            {
                do
                {
                    lista += h.Dato + ", ";
                    h = h.Siguiente;
                } while (h != head);
                lista += ".";
                lista = lista.Replace(", .", "");
                return lista;
            }
            else
            {
                return "La lista está vacía";
            }
        }
    }
}
