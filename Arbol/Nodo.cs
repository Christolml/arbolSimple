using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class Nodo
    {
        public Nodo hijoI { get; set; }
        public Nodo hijoD { get; set; }

        public int Dato { get; set; }

        public Nodo(int dato)
        {
            this.Dato = dato;
        }


        public override string ToString()
        {
            return Dato.ToString();
        }








    }
}
