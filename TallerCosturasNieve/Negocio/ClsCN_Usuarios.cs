using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cls_CNUsuarios
    {
        private Cls_CDUsuarios objCD_Usuarios = new Cls_CDUsuarios();

        public List<ClsUsuarios> Listar()
        {
            return objCD_Usuarios.Listar();
        }

        public int Registrar(ClsUsuarios objUsuario, out string mensaje)
        {
            mensaje = string.Empty;

            if (objUsuario.nombreUsuario == "")
            {
                mensaje += "Es necesario un nombre de usuario";
            }
            else if (objUsuario.claveUsuario == "")
            {
                mensaje += "Es necesaria una contraseña";
            }


            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objCD_Usuarios.Registrar(objUsuario, out mensaje);
            }
        }

        public void Eliminar(int IdUsuario)
        {
            objCD_Usuarios.Eliminar(IdUsuario);

        }
    }
}
