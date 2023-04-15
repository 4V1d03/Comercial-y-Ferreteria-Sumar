using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;// Librerias Nuevas
using System.Data.SqlClient;//
using System.Data.Sql;//paquete NuGet
using System.Windows.Forms;

namespace Comercial_y_Ferreteria_Sumar.Clases
{
    public class Conexion
    {
        //MSI\SQLEXPRESS
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public SqlDataReader dr;

        string cadena = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=FerreteriaSumar;Integrated Security=True";

        public SqlConnection cn = new SqlConnection();


        public Conexion() //constructor
        {
            cn.ConnectionString = cadena;
        }

        public void abrir()
        {
            cn.Open();
        }

        public void cerrar()
        {
            cn.Close();
        }
    }
}
