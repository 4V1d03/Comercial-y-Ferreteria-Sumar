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
    public partial class Proveedores : Form
    {   
        Funciones c = new Funciones();
        Validaciones val = new Validaciones();
        int posicion = 0;
        int codigo = 0;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnagregarPROV_Click(object sender, EventArgs e)
        {
            c.abrir();
          
               
            MessageBox.Show(c.agregarproveedor(txtnombrePROV.Text, txtrtnPROV.Text, txtdireccionPROV.Text,
                    txttelefonoPROV.Text, txtcorreoPROV.Text));
            
            c.cerrar();

            c.mostrarproveedores(dgvproveedoresPROV);

        }

        private void btnactualizarPROV_Click(object sender, EventArgs e)
        {
            c.abrir();

            MessageBox.Show(c.actualizarproveedor(txtnombrePROV.Text, txtrtnPROV.Text, txtdireccionPROV.Text,
                txttelefonoPROV.Text, txtcorreoPROV.Text, codigo));

            c.cerrar();

            c.mostrarproveedores(dgvproveedoresPROV);

        }

        private void btneliminarPROV_Click(object sender, EventArgs e)
        {
            c.abrir();
            MessageBox.Show(c.eliminarproveedor(codigo));

            c.cerrar();
            c.mostrarproveedores(dgvproveedoresPROV);
        }   

        private void dgvproveedoresPROV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvproveedoresPROV.CurrentRow.Index;

            codigo = Convert.ToInt32(dgvproveedoresPROV.Rows[posicion].Cells[0].Value);
            txtnombrePROV.Text = dgvproveedoresPROV.Rows[posicion].Cells[1].Value.ToString();
            txtrtnPROV.Text = dgvproveedoresPROV.Rows[posicion].Cells[2].Value.ToString();
            txtdireccionPROV.Text = dgvproveedoresPROV.Rows[posicion].Cells[3].Value.ToString();
            txttelefonoPROV.Text = dgvproveedoresPROV.Rows[posicion].Cells[4].Value.ToString();
            txtcorreoPROV.Text = dgvproveedoresPROV.Rows[posicion].Cells[5].Value.ToString();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            c.mostrarproveedores(dgvproveedoresPROV);

            /**
            if (txtnombrePROV.Text != "" && txtrtnPROV.Text != "" && txtdireccionPROV.Text != "" && txttelefonoPROV.Text != "" && txtcorreoPROV.Text != "")
            {
                btnagregarPROV.Enabled = true;              
            }
            else
            {
                btnagregarPROV.Enabled = false;
                
            }
            **/
        }

        private void txtnombrePROV_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sololetras(txtnombrePROV, e);
        }

        private void txtrtnPROV_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txttelefonoPROV, e);
        }

        private void txttelefonoPROV_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txttelefonoPROV, e);
        }

        private void txtnombrePROV_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            val.validarvacios(txtnombrePROV, epPROV);
        }

        private void txtdireccionPROV_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            val.validarvacios(txtdireccionPROV, epPROV);
        }

        private void txtcorreoPROV_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            val.validarvacios(txtcorreoPROV, epPROV);
        }

        private void txtrtnPROV_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            val.validarvacios(txtrtnPROV, epPROV);
        }

        private void txttelefonoPROV_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            val.validarvacios(txttelefonoPROV, epPROV);
        }

        private void btnmenuPROV_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }
    }
}
