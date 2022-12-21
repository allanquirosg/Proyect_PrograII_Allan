using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class cls_Usuario
    {

        public cls_datos objeto3 = new cls_datos();
        public void Insertar_Usuario(string id_usuario, string usuario, string password, string  rol)
        {

            objeto3.Insertar_Usuario(Convert.ToInt32(id_usuario), usuario, password, rol);
        } 

    }
}
