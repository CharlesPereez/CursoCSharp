using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada004
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

        public void Adicionar(int pDato)
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            CNodo temp = new CNodo();

            temp.Dato = pDato;
            temp.Siguiente = null;
            trabajo.Siguiente = temp;
        }

        public void Vaciar()
        {
            ancla.Siguiente = null;
        } 

        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
                return true;
            else 
                return false;
        }

        public CNodo Buscar(int pDato)
        {
            if(ancla.Siguiente == null)
                return null;

            trabajo2 = ancla;

            while(trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;

                if(trabajo2.Dato == pDato)
                    return trabajo2;
            }
            return null;
        }

        public int BuscarIndice(int pDato)
        {
            int n = -1;
            trabajo2 = ancla;

            while(trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;
                n++;

                if (trabajo2.Dato == pDato)
                    return n;
            }
            return -1;
        }

        public CNodo BuscarAnterior(int pDato)
        {
            trabajo2 = ancla;

            while(trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
            
                trabajo2 = trabajo2.Siguiente;
            
            return trabajo2;
        }

        public void Borrar(int pDato)
        {
            if (EstaVacio() == true)
                return;

            CNodo encontrado = Buscar(pDato);
            CNodo anterior = BuscarAnterior(pDato);

            if (encontrado == null)
                return;

            anterior.Siguiente = encontrado.Siguiente;
            encontrado.Siguiente = null;
        }

        public void Insertar(int pDonde, int pValor)
        {
            trabajo = Buscar(pDonde);

            if (trabajo == null)
                return;

            CNodo temp = new CNodo();

            temp.Dato = pValor;
            temp.Siguiente = trabajo.Siguiente;
            trabajo.Siguiente = temp;
        }

        public void InsertarInicio(int pDato)
        {
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            temp.Siguiente = ancla.Siguiente;
            ancla.Siguiente = temp;
        }

        public CNodo ObtenPorIndice(int pIndice)
        {
            CNodo trabajo2 = null;
            int indice = -1;

            trabajo = ancla;

            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == pIndice)
                    trabajo2 = trabajo;
            }
            return trabajo2;
        }
    }
}
