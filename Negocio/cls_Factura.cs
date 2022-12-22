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
    public class cls_Factura
    {

        public cls_datos objeto3 = new cls_datos();
        public DataTable MostrarTabla()
        {

            DataTable tabla = new DataTable();
            tabla = objeto3.Mostrar1();
            return tabla;
        }


        public cls_datos objeto7 = new cls_datos();
        public void Insertar_Venta(string ID_PRODUCTO, string ID_Cliente, string Cantidad, string Razon)
        {
            //
            objeto7.Insertar_Venta(Convert.ToInt32(ID_PRODUCTO), Convert.ToInt32(ID_Cliente), Convert.ToInt32(Cantidad), Razon);

        }

      
    }
}
