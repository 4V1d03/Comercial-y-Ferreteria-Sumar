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
    public partial class Puestros : Form
    {
        Funciones c = new Funciones();
        int posicion = 0;
        int codigo = 0;

        public Puestros()
        {
            InitializeComponent();
        }

        private void Puestros_Load(object sender, EventArgs e)
        {
            c.mostrarPuestos(dgvpuestosPUE);
        }

        private void btnagregarCOM_Click(object sender, EventArgs e)
        {
            c.abrir();

            c.agregarpuestos(txtnombrePUE.Text);

            c.cerrar();
            c.mostrarPuestos(dgvpuestosPUE);
        }

        private void btnactualizarCOM_Click(object sender, EventArgs e)
        {
            c.abrir();

            c.actualizarpuestos(txtnombrePUE.Text, codigo);

            c.cerrar();

            c.mostrarPuestos(dgvpuestosPUE);
        }

        private void btneliminarCOM_Click(object sender, EventArgs e)
        {
            c.abrir();

            c.eliminarpuestos(codigo);

            c.cerrar();

            c.mostrarPuestos(dgvpuestosPUE);
        }

        private void dgvpuestosPUE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvpuestosPUE.CurrentRow.Index;

            codigo = Convert.ToInt32(dgvpuestosPUE.Rows[posicion].Cells[0].Value);
            txtnombrePUE.Text = dgvpuestosPUE.Rows[posicion].Cells[1].Value.ToString();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            c.abrir();

            if (txtbuscar.Text == "")
            {
                c.mostrarPuestos(dgvpuestosPUE);
            }
            else
            {
                c.buscarpuestos(dgvpuestosPUE, txtbuscar.Text);
            }

            c.cerrar();
        }

        private void btnmenuPUE_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }
    }
}
