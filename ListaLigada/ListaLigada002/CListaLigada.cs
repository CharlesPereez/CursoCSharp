using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada002
{
    class CListaLigada
    {
        private CNodo ancla;
        private CNodo trabajo;
        private CNodo trabajo2;

        public CListaLigada()
        {
            ancla = new CNodo();
            ancla.Siguente = null;
        }

        public void Transversa()
        {
            trabajo = ancla;

            while(trabajo.Siguente != null)
            {
                trabajo = trabajo.Siguente;
                int d = trabajo.Dato;
                Console.Write(trabajo.ToString());
            }
            Console.WriteLine();
        }

        public void Adicionar(int pDato)
        {
            trabajo = ancla;

            while(trabajo.Siguente != null)
            {
                trabajo = trabajo.Siguente;
            }

            CNodo temp = new CNodo();

            temp.Dato = pDato;
            temp.Siguente = null;
            trabajo.Siguente = temp;
        }
    }
}
