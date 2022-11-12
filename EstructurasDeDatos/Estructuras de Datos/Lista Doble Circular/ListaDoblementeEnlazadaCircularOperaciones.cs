using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class ListaDoblementeEnlazadaCircularOperaciones
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaDoblementeEnlazadaCircularOperaciones()
        {
            head = null;
        }
        public ListaDoblementeEnlazadaCircularOperaciones(Nodo n)
        {
            head = n;
            n.Anterior = head;
            n.Siguiente = head;
        }
        public bool Agregar(Nodo n)
        {
            Nodo h = head;
            if (head == null) 
            {

                n.Anterior = n;
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
                head.Anterior.Siguiente = n;
                n.Anterior = head.Anterior;
                n.Siguiente = head;
                head.Anterior = n;
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
                h.Siguiente.Anterior = n;
                n.Anterior = h;
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
            }
            else
            {
                n.Siguiente = h;
                n.Anterior = h.Anterior;
                h.Anterior.Siguiente = n;
                h.Anterior = n;
            }
            return true;
        }
        public bool Buscar(int b) 
        {
            Nodo h = head;
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
                Nodo h = head;
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
            Nodo h = head;
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
            Nodo h = head;
            string s = "";
            do
            {
                s += h.Anterior.Dato;
                h = h.Anterior;
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
                Nodo h = head;

                while (h.Siguiente != head) 
                {
                    if (h.Dato == b)
                    {
                        break;
                    }

                    h = h.Siguiente;
                }
                h.Anterior.Siguiente = h.Siguiente;
                h.Siguiente.Anterior = h.Anterior;
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
            Nodo h = head;
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
