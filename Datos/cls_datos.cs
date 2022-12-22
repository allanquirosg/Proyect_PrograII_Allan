using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_datos
    {

        // prueba

        public CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar(int id_producto, string nombre_producto, int precio)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INGRESA_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_PRODUCTO", id_producto);
            comando.Parameters.AddWithValue("@NOMBRE_PRODUCTO", nombre_producto);
            comando.Parameters.AddWithValue("@PRECIO", precio);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(int id_producto, string nombre_producto, int precio)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Editar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_PRODUCTO", id_producto);
            comando.Parameters.AddWithValue("@NOMBRE_PRODUCTO", nombre_producto);
            comando.Parameters.AddWithValue("@PRECIO", precio);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Insertar_Usuario(int id_usuario, string usuario, string password, string rol)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INGRESA_USUARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_usuario", id_usuario);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@rol", rol);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }


        public void Insertar_Empresa(int ced_juridica, string nombre_empresa, string razon_social )
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INGRESA_Empresa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ced_juridica", ced_juridica);
            comando.Parameters.AddWithValue("@nombre_empresa", nombre_empresa);
            comando.Parameters.AddWithValue("@razon_social", razon_social);
            


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Insertar_Venta(int ID_PRODUCTO, int ID_Cliente, int Cantidad, string Razon)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Ingresa_Registro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_PRODUCTO", ID_PRODUCTO);
            comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Razon", Razon);




            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public DataTable Mostrar1()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar1";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable Mostrar2()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar2";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}
