using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class ListaDoblementeEnlazadaCircularOperaciones
    {
        private NodoLEDC head;
        public NodoLEDC Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaDoblementeEnlazadaCircularOperaciones()
        {
            head = null;
        }
        public ListaDoblementeEnlazadaCircularOperaciones(NodoLEDC n)
        {
            head = n;
            n.Atras = head;
            n.Siguiente = head;
        }
        public bool Agregar(NodoLEDC n)
        {
            NodoLEDC h = head;
            if (head == null) 
            {

                n.Atras = n;
                n.Siguiente = n;
                head = n;
                return true;
            }
            if (Buscar(n.Dato))  
            {
                return false;
            }

            if (n.Dato < head.Dato)
            {
                head.Atras.Siguiente = n;
                n.Atras = head.Atras;
                n.Siguiente = head;
                head.Atras = n;
                head = n;
                return true;

            }
            do
            {
                if (n.Dato < h.Siguiente.Dato) 
                {
                    break;
                }
                h = h.Siguiente;
            } while (h != head);
            if (n.Dato < h.Siguiente.Dato)
            {
                h.Siguiente.Atras = n;
                n.Atras = h;
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
            }
            else
            {
                n.Siguiente = h;
                n.Atras = h.Atras;
                h.Atras.Siguiente = n;
                h.Atras = n;
            }
            return true;
        }
        public bool Buscar(int b) 
        {
            NodoLEDC h = head;
            if (h != null)
            {
                do
                {
                    if (h.Dato == b)
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
            int cuenta = 0; 
            if (head != null) 
            {
                NodoLEDC h = head;
                do 
                {
                    cuenta++;
                    h = h.Siguiente; 
                } while (h != head); 
            }
            return cuenta; 
        }

        public string MostrarDatos()
        {
            NodoLEDC h = head;
            string s = "";
            do
            {
                s += h.Dato + "-";
                h = h.Siguiente;
            } while (h != head);
            return s;
        }
        public string MostrarDatosAnt()
        {
            NodoLEDC h = head;
            string s = "";
            do
            {
                s += h.Atras.Dato;
                h = h.Atras;
            } while (h != head);
            return s;

        }
        public void Vaciar()
        {
            head = null; 
        }
        public bool Eliminar(int b)
        {
            if (Buscar(b))
            {
                NodoLEDC h = head;

                while (h.Siguiente != head) 
                {
                    if (h.Dato == b)
                    {
                        break;
                    }

                    h = h.Siguiente;
                }
                h.Atras.Siguiente = h.Siguiente;
                h.Siguiente.Atras = h.Atras;
                if (h == head)
                {

                    head = head.Siguiente;


                }

                return true;

            }
            return false;
        }
        public override string ToString()
        {
            string lista = "";
            NodoLEDC h = head;
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
