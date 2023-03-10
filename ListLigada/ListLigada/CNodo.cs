using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLigada
{
    class CNodo
    {
        // Aqui colocamos el datos o datos que guarda el nodo
        private int dato;

        // esta variable de referencia es usada para apuntar al nodo siguiente
        private CNodo siguiente = null;

        // Propiedades que usaremos
        public int Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
