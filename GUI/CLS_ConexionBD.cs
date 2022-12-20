using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GUI
{
    public class CLS_ConexionBD
    {

        public string conection = "";

        public CLS_ConexionBD(string conection)
        {
            this.conection = conection;

        }

        public string[] m_validaringreso(string usuario, string pass)
        {
            string[] arr_usuario = new string[2];
            SqlConnection conection = new SqlConnection(this.conection);
            try
            {
                SqlCommand comando = new SqlCommand("select * from Usuarios where usuario = '" + usuario + "' and password = '" + pass + "'", conection);
                conection.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    arr_usuario[0] = (reader["usuario"].ToString());
                    arr_usuario[1] = (reader["password"].ToString());

                }
            }

            catch (SqlException ex)
            {
                throw ex;

            }
            finally

            {
                conection.Close();
            }


            return arr_usuario;
        }

    }
}
