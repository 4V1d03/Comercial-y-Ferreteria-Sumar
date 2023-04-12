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
            this.CenterToScreen();
            c.mostrarclientes(dgvclientesCL);

        }

        private void btnagregarCL_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show(c.agregarcliente(txtnombresCL.Text, txtapellidosCL.Text, txttelefonoCL.Text, txtcorreoCL.Text));

            c.cerrar();

            c.mostrarclientes(dgvclientesCL);
        }

        private void btnactualizarCL_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show( c.actualizarcliente(txtnombresCL.Text, txtapellidosCL.Text, txttelefonoCL.Text, txtcorreoCL.Text, codigo));

            c.cerrar();

            c.mostrarclientes(dgvclientesCL);
        }

        private void btneliminarCL_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show(c.eliminarcliente(codigo));

            c.cerrar();

            c.mostrarclientes(dgvclientesCL);

        }

        private void dgvclientesCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvclientesCL.CurrentRow.Index;

            codigo = Convert.ToInt32(dgvclientesCL.Rows[posicion].Cells[0].Value);
            txtnombresCL.Text = dgvclientesCL.Rows[posicion].Cells[1].Value.ToString();
            txtapellidosCL.Text = dgvclientesCL.Rows[posicion].Cells[2].Value.ToString();
            txttelefonoCL.Text = dgvclientesCL.Rows[posicion].Cells[3].Value.ToString();
            txtcorreoCL.Text = dgvclientesCL.Rows[posicion].Cells[4].Value.ToString();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            c.abrir();

            if (txtbuscar.Text == "")
            {
                c.mostrarclientes(dgvclientesCL);
            }
            else
            {
                c.buscaecliente(dgvclientesCL, txtbuscar.Text);
            }

            c.cerrar();
        }

        private void btnmenuCL_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }
    }
}
