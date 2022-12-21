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
    }
}
