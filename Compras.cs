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
    public partial class Compras : Form
    {

        Funciones fun = new Funciones();
        Validaciones val = new Validaciones();
        
        public Compras()
        {
            InitializeComponent();
        }


        private void Compras_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fun.mostrarCBempleado(cbempleadoCOM);
            fun.mostrarCBProveedor(cbproveedorCOM);
            fun.mostrarCBproducto(cbproductoCOM);
        }   

        private void btnmenuCOM_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        private void btnagregarCOM_Click(object sender, EventArgs e)
        {           
            DataGridViewRow data = new DataGridViewRow();
            data.CreateCells(dgvcomprasCOM);

            //data.Cells[0].Value = ;
            data.Cells[1].Value = (int)cbproductoCOM.SelectedValue;               
            data.Cells[2].Value = txtpreciocostoCOM.Text;
            data.Cells[3].Value = txtcantidadCOM.Text;

            dgvcomprasCOM.Rows.Add(data);
            
        }

        private void btnactualizarCOM_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarCOM_Click(object sender, EventArgs e)
        {

        }

        private void dgvcomprasCOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtpreciocostoCOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txtpreciocostoCOM, e);
        }

        private void txtpreciocostoCOM_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtpreciocostoCOM, epCOM);
        }

        private void txtcantidadCOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txtcantidadCOM, e);
        }

        private void txtcantidadCOM_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtcantidadCOM, epCOM);
        }

        private void dgvcomprasCOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
