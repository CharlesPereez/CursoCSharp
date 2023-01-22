using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada001
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

            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                int d = trabajo.Dato;

                Console.Write(trabajo.ToString());
            }
            Console.WriteLine();

        }

        public void Adicionar(int pDato)
        {
            trabajo = ancla;

            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            CNodo temp = new CNodo();
            temp.Dato = pDato;
            temp.Siguiente = null;
            trabajo.Siguiente = temp;


        }
    }
}
