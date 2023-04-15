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
    public partial class Categorias : Form
    {
        Funciones c = new Funciones();
        Validaciones val = new Validaciones();
        int posicion = 0;
        int codigo = 0;

        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            c.mostrarcategorias(dgvCategoriasCAT);

        }

        private void btnagregarCAT_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show(c.agregarcategoria(txtnombreCAT.Text));

            c.cerrar();

            c.mostrarcategorias(dgvCategoriasCAT);
        }

        private void btnactualizarCAT_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show(c.actualizarcategoria(txtnombreCAT.Text, codigo));

            c.cerrar();

            c.mostrarcategorias(dgvCategoriasCAT);
        }

        private void btneliminarCAT_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show( c.eliminarcategoria(codigo));

            c.cerrar();

            c.mostrarcategorias(dgvCategoriasCAT);

        }

        private void dgvCategoriasCAT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvCategoriasCAT.CurrentRow.Index;

            codigo = Convert.ToInt32(dgvCategoriasCAT.Rows[posicion].Cells[0].Value);
            txtnombreCAT.Text = dgvCategoriasCAT.Rows[posicion].Cells[1].Value.ToString();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            c.abrir();

            if (txtbuscar.Text == "")
            {
                c.mostrarcategorias(dgvCategoriasCAT);
            }
            else
            {
                c.buscarcategoria(dgvCategoriasCAT, txtbuscar.Text);
            }

            c.cerrar();
        }

        private void btnmenuCAT_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        private void txtnombreCAT_KeyPress(object sender, KeyPressEventArgs e)
        {
             val.sololetras(txtnombreCAT, e);
        }

        private void txtnombreCAT_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtnombreCAT, epCAT);
        }
    }
}
