using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class cls_negocio
    {

        public cls_datos objeto2 = new cls_datos();
        public void Insertar(string id_producto, string nombre_producto, string precio)
        {

            objeto2.Insertar(Convert.ToInt32(id_producto), nombre_producto, Convert.ToInt32(precio));
        }

        public DataTable MostrarTabla()
        {

            DataTable tabla = new DataTable();
            tabla = objeto2.Mostrar();
            return tabla;
        }

        public void Editar(string id_producto, string nombre_producto, string precio)
        {
            objeto2.Editar(Convert.ToInt32(id_producto), nombre_producto, Convert.ToInt32(precio));
        }



    }
}
