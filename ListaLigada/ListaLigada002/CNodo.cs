using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada002
{
    class CNodo
    {
        private int dato;
        private CNodo siguente = null;

        public int Dato { get => dato; set => dato = value; }
        public CNodo Siguente { get => siguente; set => siguente = value;}

        public override string ToString()
        {
            return String.Format("[{0}]", dato);
        }
    }
}
