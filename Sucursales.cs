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
    public partial class Sucursales : Form
    {
        Funciones c = new Funciones();

        public Sucursales()
        {
            InitializeComponent();
        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            c.mostrarsucursales(dgvsucursalesSU);
        }

        private void btnagregarSU_Click(object sender, EventArgs e)
        {
            
        }

        private void btnactualizarSU_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarSU_Click(object sender, EventArgs e)
        {

        }

        private void dgvsucursalesSU_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmenuSU_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }
    }
}
