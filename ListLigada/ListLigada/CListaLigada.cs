using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLigada
{
    class CListaLigada
    {
        private CNodo ancla;
        private CNodo trabajo;
        private CNodo trabajo2;

        public CListaLigada()
        {
            ancla = new CNodo();
            ancla.Siguiente = null;
        }

        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                
                trabajo = trabajo.Siguiente;            
                int d = trabajo.Dato;
                Console.Write(trabajo.ToString());
            }
            Console.WriteLine();
        }


        // Adicionar un nuevo elemento
        // La adicion siempre va a al final
        public void Adicionar(int pDato)
        {
            
            trabajo = ancla;

            // Recorremos hasta encontrar el final

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            // creamos el nuevo nodo
            CNodo temp = new CNodo();
            temp.Dato = pDato;
            temp.Siguiente = null;
            trabajo.Siguiente = temp;

        }
    }
}

