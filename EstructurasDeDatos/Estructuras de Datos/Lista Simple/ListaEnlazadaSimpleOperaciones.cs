using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EstructurasDeDatos
{
    class ListaEnlazadaSimpleOperaciones
    {
        private NodoLES head;

        public NodoLES Head
        {
            get { return head; }
            set { head = value; }
        }

        public ListaEnlazadaSimpleOperaciones()
        {
            head = null;
        }
        public ListaEnlazadaSimpleOperaciones(NodoLES n)
        {
            head = n;
        }
        public void Borrar(int dato)
        {
            if (head != null)
            {
                if (head.Dato == dato)
                {
                    head = head.Siguiente;
                    return;
                }
                NodoLES h = head;
                while (h.Siguiente != null)
                {
                    if (h.Siguiente.Dato == dato)
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                        return;
                    }
                    h = h.Siguiente;
                }
            }
        }
        public void Agregar(NodoLES n)
        {

            if (head == null)
            {
                head = n;
                return;
            }
            if (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                head = n;
                return;
            }
            NodoLES h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato > n.Dato)
                {
                    break;
                }
                h = h.Siguiente; 
            }

            if (h.Siguiente != null)
            {
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
                return;
            }
            h.Siguiente = n;
        }


        public override string ToString()
        {
            string lista = "";
            NodoLES h = head;
            if (h != null)
            {
                lista += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    lista += "," + h.ToString();
                    h = h.Siguiente;
                }
                return lista;
            }
            else
            {
                return "La lista esta vacia";
            }
        }
        public bool BuscarDato(int a)
        {
            NodoLES h = head;
            if (h != null)
            {
                while (h != null)
                {
                    if (h.Dato == a)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                }
            }
            return false;
        }
        public int ContarNodos()
        {
            int contador = 0;
            NodoLES h = head;
            while (h != null)
            {
                contador++;
                h = h.Siguiente;
            }
            return contador;
        }
        public void Guardar(string Ruta, string Datos)
        {
            if (File.Exists(Ruta))
            {
                File.Delete(Ruta);
            }
            using (StreamWriter sw = File.CreateText(Ruta))
            {
                sw.WriteLine(Datos);
            }
        }
    }
}
