using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLigada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CListaLigada miLista = new CListaLigada();

            miLista.Adicionar(3);
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(13);
            miLista.Adicionar(4);
            miLista.Adicionar(10);

            miLista.Transversa();
        }
    }
}
