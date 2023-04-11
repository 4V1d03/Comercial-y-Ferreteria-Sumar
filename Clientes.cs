using Comercial_y_Ferreteria_Sumar.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial_y_Ferreteria_Sumar
{
    public partial class Clientes : Form
    {
        Funciones c = new Funciones();
        Validaciones val = new Validaciones();
        int posicion = 0;
        int codigo = 0;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnagregarCL_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizarCL_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarCL_Click(object sender, EventArgs e)
        {

        }
    }
}
