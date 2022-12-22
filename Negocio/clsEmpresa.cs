using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class clsEmpresa
    {


        public cls_datos objeto6 = new cls_datos();
        public void Insertar_Empresa(string ced_juridica, string nombre_empresa, string razon_social)
        {
            //
            objeto6.Insertar_Empresa(Convert.ToInt32(ced_juridica), nombre_empresa, razon_social);
        }

        public DataTable MostrarTabla()
        {

            DataTable tabla = new DataTable();
            tabla = objeto6.Mostrar2();
            return tabla;
        }
    }
}
