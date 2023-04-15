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
    public partial class Productos : Form
    {
        Funciones c = new Funciones();
        int posicion = 0;
        int codigo = 0;
        Variables variables = new Variables();

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            c.abrir();

            c.mostrarproductosPROD(dgvproductosPROD);
            c.mostrarCBcategoria(cbcategoriaPROD);
            c.mostrarCBproveedor(cbproveedorPROD);


            c.cerrar();
        }

        private void btnagregarPROD_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show(c.agregarProductos((int)cbcategoriaPROD.SelectedValue, (int)cbproveedorPROD.SelectedValue, Convert.ToDouble(txtprecioPROD.Text), txtnombrePROD.Text, txtdescripcionPROD.Text, Convert.ToInt32(txtExistenciaPROD.Text)));

            c.cerrar();

            c.mostrarproductosPROD(dgvproductosPROD);
        }

        private void btnactualizarProd_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show(c.actualizarProductos((int)cbcategoriaPROD.SelectedValue, (int)cbproveedorPROD.SelectedValue, Convert.ToDouble(txtprecioPROD.Text), txtnombrePROD.Text, txtdescripcionPROD.Text, Convert.ToInt32(txtExistenciaPROD.Text), codigo));

            c.cerrar();

            c.mostrarproductosPROD(dgvproductosPROD);
        }

        private void btneliminarProd_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show(c.eliminarProductos(codigo));

            c.cerrar();

            c.mostrarproductosPROD(dgvproductosPROD);
        }

        private void dgvproductosPROD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            c.abrir();

            if (txtbuscar.Text == "")
            {
                c.mostrarproductosPROD(dgvproductosPROD);
            }
            else
            {
                c.buscarproductos(dgvproductosPROD, txtbuscar.Text);
            }

            c.cerrar();
        }

        private void btnmenuPROD_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        private void txtprecioPROD_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtnombrePROD_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtdescripcionPROD_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtExistenciaPROD_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtprecioPROD_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtnombrePROD_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtdescripcionPROD_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtExistenciaPROD_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dgvproductosPROD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvproductosPROD.CurrentRow.Index;
            if (variables.selectProducto == 2)
            {
                Ventas ventas = new Ventas();
                ventas.TxtIdProducto.Text = (string)dgvproductosPROD.Rows[posicion].Cells[0].Value;
                ventas.txtpreciounitarioVT.Text = dgvproductosPROD.Rows[posicion].Cells[3].Value.ToString();
                ventas.txtproducto.Text = (string)dgvproductosPROD.Rows[posicion].Cells[4].Value;
                ventas.TxtExistencia.Text = dgvproductosPROD.Rows[posicion].Cells[6].Value.ToString();
                ventas.Show();
                this.Close();
            }else if (variables.selectProducto == 1)
            {
                codigo = Convert.ToInt32(dgvproductosPROD.Rows[posicion].Cells[0].Value);
                cbcategoriaPROD.DisplayMember = dgvproductosPROD.Rows[posicion].Cells[1].Value.ToString();
                cbproveedorPROD.SelectedItem = dgvproductosPROD.Rows[posicion].Cells[2].Value.ToString();
                txtprecioPROD.Text = dgvproductosPROD.Rows[posicion].Cells[3].Value.ToString();
                txtnombrePROD.Text = dgvproductosPROD.Rows[posicion].Cells[4].Value.ToString();
                txtdescripcionPROD.Text = dgvproductosPROD.Rows[posicion].Cells[5].Value.ToString();
                txtExistenciaPROD.Text = dgvproductosPROD.Rows[posicion].Cells[6].Value.ToString();
            }
            
        }
    }
}
