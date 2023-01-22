using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada
{
    class CListaLigada
    {
        // Es le ancla o encabezado de la lista
        private CNodo ancla;

        // Esta variable de referencia nos ayuda a trabajar con la lista
        private CNodo trabajo;

        // Esta variable de referencia apoya en ciertas operaciones de la lista
        private CNodo trabajo2;

        public CListaLigada()
        {
            // Instanciamos el ancla
            ancla = new CNodo();

            // Como es una lista vacia su siguiente es null
            ancla.Siguiente = null;
        }

        // Recorreo toda la lista
        public void Transversa()
        {
            // Trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                //avanmos trabajo
                trabajo = trabajo.Siguiente;

                //obtenemos el dato y lo mostramos
                int d = trabajo.Dato;

                Console.Write(trabajo.ToString());
            }
            // Bajamos la linea 
            Console.WriteLine();
        }


        // Adicionar un nuevo elemento
        // La adicion siempre va a al final
        public void Adicionar(int pDato)
        {
            // trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final

            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            // creamos el nuevo nodo
            CNodo temp = new CNodo();

            // Insertamos el dato
            temp.Dato = pDato;

            // Finalizamos correctamente
            //temp.Siguiente = null;

            // Ligamos el ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;

        }
    }
}
