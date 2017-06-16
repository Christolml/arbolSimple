using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        Arbol arbol = new Arbol();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo agregado = new Nodo(Convert.ToInt32(txtNúmero.Text));

            arbol.agregar(agregado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Nodo encontrado = arbol.buscar(Convert.ToInt32(txtBuscar.Text));
            if (encontrado != null)
            {
                txtResultado.Text = "Dato " + encontrado.ToString() + " encontrado";
            }
            else
                MessageBox.Show("No encontrado", "Error");
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.inOrden(arbol.Raiz);
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.preOrden(arbol.Raiz);
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.postOrden(arbol.Raiz);
        }
    }
}
