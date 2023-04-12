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
                cmd = new SqlCommand("update Clientes set Nombres = '" + nombres + "', Apellidos = '" + apellidos + "', Telefono = '" + telefono + "', Correo = '" + correo + "' where CodigoCliente = '" + codigo + "'  ", cn);
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
                cmd = new SqlCommand("delete from Clientes where CodigoCliente = '" + codigo + "' ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se elimino!!";
            }
            catch (Exception ex)
            {

                respuesta = "Error no se Elimino!! " + ex.ToString();
            }

            return respuesta;
        }

        public void buscaecliente(DataGridView data, string nombres)
        {
            try
            {
                string consulta = "select * from Clientes where Nombres= '"+nombres+"'";

                da = new SqlDataAdapter(consulta, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception)
            {
                
            }
            
        }


        //Formulario Empleados
        public void mostrarempleados(DataGridView data)
        {
            string consulta = "Select * From Empleado";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }

        public void mostrarsucursal(ComboBox cb)
        {
            string consulta = "Select * From Sucursales";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DataSource = dt;

            cb.DisplayMember = "Nombre";
            cb.ValueMember = "CodigoSucursal";
        }

        public void mostrarpuestos(ComboBox cbp)
        {
            string consulta = "select * from Puestos";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbp.DataSource = dt;

            cbp.DisplayMember = "Nombre";
            cbp.ValueMember = "CodigoPuesto";
        }
        public void mostrarjornada(ComboBox cbp)
        {
            string consulta = "select * from Jornada";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbp.DataSource = dt;

            cbp.DisplayMember = "Descripcion";
            cbp.ValueMember = "CodigoJornada";
        }

        public string agregarempleado(int codigosuc, int codigojor, int codigopue, string nombre, string apellido,
        string rtn, DateTime nacimiento, string correo, string telefono, string direccion, string usuario, string contra,
        double salario)
        {
            string respuesta = "";
            try
            {
                cmd = new SqlCommand("insert into Empleado(CodigoSucursal, CodigoJornada, CodigoPuesto, Nombres, Apellidos, Identidad, FechaNacimiento, Correo, Telefono, Direcion, Usuario, Contraseña, Salario) values( '" + codigosuc + "','" + codigojor + "','" + codigopue + "','" + nombre + "', '" + apellido + "','" + rtn + "','" + nacimiento + "','" + correo + "','" + telefono + "','" + direccion + "','" + usuario + "','" + contra + "','" + salario + "' )", cn);
                cmd.ExecuteNonQuery();

                respuesta = "el registro fue insertado";
            }
            catch (Exception ex)
            {
                respuesta = "el registro no fue insertado " + ex.ToString();
            }

            return respuesta;
        }


        //Formulario Categorias
        public void mostrarcategorias(DataGridView data)
        {
            string consulta = "Select * From Categoria";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }

        public string agregarcategoria(string nombre)
        {
            string respuesta = "";
            try
            {
                cmd = new SqlCommand("insert into Categoria(Nombre) values('" + nombre + "')", cn);
                cmd.ExecuteNonQuery();

                respuesta = "el registro fue insertado";
            }
            catch (Exception ex)
            {
                respuesta = "el registro no fue insertado " + ex.ToString();
            }

            return respuesta;
        }

        public string actualizarcategoria(string nombres, int codigo)
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("update Clientes set Nombre = '" + nombres + "' where = '" + codigo + "'  ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se actualizo!";

            }
            catch (Exception ex)
            {

                respuesta = "Error no se actualizo el registro!" + ex.ToString();

            }

            return respuesta;
        }


        public string eliminarcategoria(int codigo)
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("delete from Categoria where CodigoCategoria = '" + codigo + "' ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se elimino!!";
            }
            catch (Exception ex)
            {

                respuesta = "Error no se Elimino!! " + ex.ToString();
            }

            return respuesta;
        }

        public void buscarcategoria(DataGridView data, string nombre)
        {
            try
            {
                string consulta = "select * from Categoria where Nombre= '" + nombre + "'";

                da = new SqlDataAdapter(consulta, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception)
            {


            }
        }


        //Formulario Sucursales
        public void mostrarsucursales(DataGridView data)
        {
            string consulta = "Select * From Sucursales";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }



        //Fomulario Productos

        public void mostrarProductos(DataGridView data)
        {
            
            string consulta = "Select * From Productos";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }

        public void mostrarCBcategoria(ComboBox cb)
        {
            string consulta = "select * from Categoria";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DataSource = dt;

            cb.DisplayMember= "Nombre";
            cb.ValueMember= "CodigoCategoria";
        }

        public void mostrarCBproveedor(ComboBox proveedor)
        {
            string consulta = "select * from Proveedores";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            proveedor.DataSource = dt;

            proveedor.DisplayMember = "Nombre";
            proveedor.ValueMember = "CodigoProveedor";
        }


        public string agregarProductos(int codigocategoria, int codigoproveedor, double precio, string nombre, string descripcion, int existencia)
        {
            string respuesta = "";
            try
            {                                                                                                                       
                cmd = new SqlCommand("insert into Productos(CodigoCategoria, CodigoProveedor, Pecio, Nombre, Descripcion, Existencia) values('" + codigocategoria + "', '"+codigoproveedor+"', '"+precio+"', '"+nombre+"', '"+descripcion+"', '"+existencia+"')", cn);
                cmd.ExecuteNonQuery();

                respuesta = "el registro fue insertado";
            }
            catch (Exception ex)
            {
                respuesta = "el registro no fue insertado " + ex.ToString();
            }

            return respuesta;
        }

        public string actualizarProductos(int codigocategoria, int codigoproveedor, double precio, string nombre, string descripcion, int existencia, int codigo)
        {
            string respuesta = "";

            try
            {
                //cmd = new SqlCommand("update Clientes set Nombres = '" + nombres + "', Apellidos = '" + apellidos + "', Telefono = '" + telefono + "', Correo = '" + correo + "' where CodigoCliente = '" + codigo + "'  ", cn);
                cmd = new SqlCommand("update Productos set CodigoCategoria = '" + codigocategoria + "', CodigoProveedor = '" + codigoproveedor + "', Precio = '" + precio + "', Nombre = '" + nombre + "', Descripcion = '"+descripcion+"', Existencia = '"+existencia+"' where CodigoProducto = '" + codigo + "'  ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se actualizo!";

            }
            catch (Exception ex)
            {

                respuesta = "Error no se actualizo el registro!" + ex.ToString();

            }

            return respuesta;
        }


        public string eliminarProductos(int codigo)
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("delete from Productos where CodigoProducto = '" + codigo + "' ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se elimino!!";
            }
            catch (Exception ex)
            {

                respuesta = "Error no se Elimino!! " + ex.ToString();
            }

            return respuesta;
        }

        public void buscarproductos(DataGridView data, string nombre)
        {
            try
            {
                string consulta = "select * from Productos where Nombre= '" + nombre + "'";

                da = new SqlDataAdapter(consulta, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception)
            {


            }
        }


        //Formulario Puestos
        public void mostrarPuestos(DataGridView data)
        {
            string consulta = "Select * From Puestos";
            da = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }

        public string agregarpuestos(string nombre)
        {
            string respuesta = "";
            try
            {
                cmd = new SqlCommand("insert into Puestos(NombrePuestos) values('" + nombre + "')", cn);
                cmd.ExecuteNonQuery();

                respuesta = "el registro fue insertado";
            }
            catch (Exception ex)
            {
                respuesta = "el registro no fue insertado " + ex.ToString();
            }

            return respuesta;
        }

        public string actualizarpuestos(string nombre, int codigo)
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("update Puestos set NombrePuestos = '" + nombre + "' where = '" + codigo + "'  ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se actualizo!";

            }
            catch (Exception ex)
            {

                respuesta = "Error no se actualizo el registro!" + ex.ToString();

            }

            return respuesta;
        }


        public string eliminarpuestos(int codigo)
        {
            string respuesta = "";

            try
            {
                cmd = new SqlCommand("delete from Puestos where CodigoPuesto = '" + codigo + "' ", cn);
                cmd.ExecuteNonQuery();

                respuesta = "El registro se elimino!!";
            }
            catch (Exception ex)
            {

                respuesta = "Error no se Elimino!! " + ex.ToString();
            }

            return respuesta;
        }

        public void buscarpuestos(DataGridView data, string nombre)
        {
            try
            {
                string consulta = "select * from Puestos where Nombre= '" + nombre + "'";

                da = new SqlDataAdapter(consulta, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
            }
            catch (Exception)
            {


            }
        }







































    }
}
