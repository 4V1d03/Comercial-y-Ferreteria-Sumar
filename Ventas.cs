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
    public partial class Ventas : Form
    {
        Funciones fun = new Funciones();
        Validaciones val = new Validaciones();
        Variables variables = new Variables();

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
        }

        private void btnmenuVT_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        private void btnagregarVT_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizarVT_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarVT_Click(object sender, EventArgs e)
        {

        }

        private void dgvventasVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void addproducto_Click(object sender, EventArgs e)
        {
            variables.selectProducto = 2;
            Productos productos = new Productos();
            productos.Show();
            this.Hide();

        }
    }

}
