using System;

namespace Negocio
{
    public class Cls_CNOrden
    {
        private ClsCD_Usuarios objCD_Usuarios = new ClsCD_Usuarios();

        public List<ClsUsuario> Listar()
        {
            return objCD_Usuarios.Listar();
        }

        public int Registrar(ClsUsuario objUsuario, out string mensaje)
        {
            mensaje = string.Empty;

            if (objUsuario.NombreUsuario == "")
            {
                mensaje += "Es necesario un nombre de usuario";
            }
            else if (objUsuario.Clave == "")
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
