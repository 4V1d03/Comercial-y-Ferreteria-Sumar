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
        public Compras()
        {
            InitializeComponent();
        }


        private void Compras_Load(object sender, EventArgs e)
        {

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


    }
}
