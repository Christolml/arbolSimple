using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    class Arbol
    {

        public Nodo Raiz { get; set; }

        //Nodo Raiz;

        public void agregar(Nodo nuevo)
        {
            if (Raiz == null)
                Raiz = nuevo;
            else
                agregar(nuevo, Raiz);
        }

        private void agregar(Nodo nuevo, Nodo padre)
        {
            if (nuevo.Dato == padre.Dato)
                MessageBox.Show("Número ya introducido", "Error");
            else if (nuevo.Dato < padre.Dato)
            {
                if (padre.hijoI == null)
                    padre.hijoI = nuevo;
                else
                    agregar(nuevo, padre.hijoI);
            }

            else if (padre.hijoD == null)
                padre.hijoD = nuevo;
            else
                agregar(nuevo, padre.hijoD);
        }

        public Nodo buscar(int entrada)
        {
            if (entrada == Raiz.Dato)
                return Raiz;
            else
                return buscar(entrada, Raiz);
        }

        private Nodo buscar(int entrada, Nodo padre)
        {
            if(entrada < padre.Dato)
            {
                if (entrada != padre.Dato)
                    buscar(entrada, padre.hijoI);
                else
                    return padre;
            }
            else
            {
                if (entrada != padre.Dato)
                    buscar(entrada, padre.hijoD);
                else
                    return padre;
            }
            return padre;
        }

        public string inOrden(Nodo r)
        {
            string mostrar = "";
            if (r.hijoI != null)
                mostrar += inOrden(r.hijoI);
            mostrar += r.ToString() +",";
            if (r.hijoD != null)
                mostrar += inOrden(r.hijoD);
            return mostrar;
        }

        public string preOrden(Nodo r)
        {
            string mostrar = "";
            mostrar += r.ToString() + ",";
            if (r.hijoI != null)
                mostrar += preOrden(r.hijoI);
            if (r.hijoD != null)
                mostrar += preOrden(r.hijoD);
            return mostrar;
        }

        public string postOrden(Nodo r)
        {
            string mostrar = "";
            if (r.hijoI != null)
                mostrar += postOrden(r.hijoI);
            if (r.hijoD != null)
                mostrar += postOrden(r.hijoD);
            mostrar += r.ToString() + ",";
            return mostrar;
        }


    }
}
