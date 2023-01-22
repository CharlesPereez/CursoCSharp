using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada005
{
    class CNodo
    {
        private int dato;
        private CNodo siguiente = null;

        public int Dato { get => dato; set => dato = value; }
        public CNodo Siguiente { get => siguiente; set => siguiente = value;}

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
