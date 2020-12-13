using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class ColaOperaciones
    {
        private NodoCola head;
        public NodoCola Head
        {
            get { return head; }
            set { head = value; }
        }
        private NodoCola tail;

        public NodoCola Tail
        {
            get { return head; }
            set { head = value; }
        }
        public ColaOperaciones()
        {
            head = null;
            tail = null;
        }
        public void Encolar(NodoCola n)
        {
            if (head == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.Siguiente = n;
                tail = n;
            }
        }
        public void Desencolar()
        {
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
            head = head.Siguiente;
        }
        public int Front()
        {
            return head.Dato;
        }
        public override string ToString()
        {
            string stringCola = "";
            NodoCola h = head;
            if (h != null)
            {
                stringCola += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    stringCola += "," + h.ToString();
                    h = h.Siguiente;
                }
                return stringCola;
            }
            else
            {
                return "La cola está vacía";
            }
        }
    }
}