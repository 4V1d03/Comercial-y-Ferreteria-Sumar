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
    public class Funciones : Conexion
    {
        //Formulario Log in
        public int iniciarsesion(string usuario, string contraseña)
        {
            int respuesta = 0;

            try
            {
                cmd = new SqlCommand("Select count(*) from Empleado where Usuario = '" + usuario + "' and Contraseña  = '" + contraseña + "' ", cn);
             
                respuesta = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                respuesta = 0;
            }

            return respuesta;
        }


        //Formulario Proveedores
        public void mostrarproveedores(DataGridView data)
        {
            string consulta = "Select  * From Proveedores";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }

        public string agregarproveedor(string nombre, string rtn, string direccion,
             string telefono, string correo)
        {
            string respuesta = "";
            try
            {
                cmd = new SqlCommand("insert into Proveedores(Nombre, RTN, Direccion, Telefono, Correo) values('" + nombre + "', '" + rtn + "', '" + direccion + "', '" + telefono + "', '"+correo+"')", cn);
                cmd.ExecuteNonQuery();

                respuesta = "el registro fue insertado";
            }
            catch (Exception ex)
            {
                respuesta = "el registro no fue insertado " + ex.ToString();
            }

            return respuesta;
        }

        public string actualizarproveedor(string nombre, string rtn, string direccion,
             string telefono, string correo, int codigo)    
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("UPDATE Proveedores set Nombre = '" + nombre + "', RTN = '" + rtn + "', Direccion = '" + direccion + "', Telefono = '" + telefono + "', Correo = '"+correo+"' where CodigoProveedor = '" + codigo + "' ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "el registro se actualizo correctamente";
            }
            catch (Exception ex)
            {

                respuesta = "error, no se actualizo " + ex.ToString();
            }


            return respuesta;
        }

        public string eliminarproveedor(int codigo)
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("delete from Proveedores where CodigoProveedor = '" + codigo + "' ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se elimino!!";
            }
            catch (Exception ex)
            {

                respuesta = "Error no se Elimino!! " + ex.ToString();
            }          

            return respuesta;
        }


        //Fomrulario Clientes


        public void mostrarclientes(DataGridView data)
        {
            string consulta = "Select * From Clientes";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }

        public string agregarcliente(string nombres, string apellidos, string telefono, string correo)
        {
            string respuesta = "";
            try
            {
                cmd = new SqlCommand("insert into Clientes(Nombres, Apellidos, Telefono, Correo) values('" + nombres + "', '" + apellidos + "', '" + telefono + "', '" + correo + "')", cn);
                cmd.ExecuteNonQuery();

                respuesta = "el registro fue insertado";
            }
            catch (Exception ex)
            {
                respuesta = "el registro no fue insertado " + ex.ToString();
            }

            return respuesta;
        }

        public string actualizarcliente(string nombres, string apellidos, string telefono, string correo, int codigo)
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("update Clientes set Nombres = '" + nombres + "', Apellidos = '" + apellidos + "', Telefono = '" + telefono + "', Correo = '" + correo + "' where CodigoClientes = '" + codigo + "'  ", cn);

                cmd.ExecuteNonQuery();

                respuesta = "El registro se actualizo!";

            }
            catch (Exception ex)
            {

                respuesta = "Error no se actualizo el registro!" + ex.ToString();

            }

            return respuesta;
        }

        
        public string eliminarcliente(int codigo)
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("delete from Clientes where CodigoClientes = '" + codigo + "' ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se elimino!!";
            }
            catch (Exception ex)
            {

                respuesta = "Error no se Elimino!! " + ex.ToString();
            }

            return respuesta;
        }
        























































    }
}
