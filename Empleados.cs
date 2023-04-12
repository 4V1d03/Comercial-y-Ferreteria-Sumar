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
    public partial class Empleados : Form
    {   
        Funciones fun = new Funciones();

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            fun.abrir();

            fun.mostrarempleados(dgvempleadosEMP);
            fun.mostrarsucursal(cbsucursalEMP);
            fun.mostrarpuestos(cbpuestosEMP);
            fun.mostrarjornada(cbjornadaEMP);

            fun.cerrar();
        }

        private void btnagregarEMP_Click(object sender, EventArgs e)
        {
            fun.abrir();

           // MessageBox.Show(fun.agregarempleado(Convert.ToInt32(cbsucursalEMP.ValueMember), Convert.ToInt32(cbjornadaEMP.ValueMember), Convert.ToInt32(cbpuestosEMP.ValueMember) ,txtnombresEMP.Text, txtapellidosEMP.Text, txtidentidadEMP.Text,
             //   dtpfechanacimientoEMP.Value, txtcorreoEMP.Text, txttelefonoEMP.Text ,txtdireccionEMP.Text, txtusuarioEMP.Text, txtcontraEMP.Text, Convert.ToDouble(txtsalarioEMP.Text)));

            fun.cerrar();
        }

        private void btnActualizarEMP_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarEMP_Click(object sender, EventArgs e)
        {

        }

        private void dgvempleadosEMP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmenuEMP_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }
    }
}
