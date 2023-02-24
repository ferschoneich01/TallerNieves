using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class ClsUsuarios
    {
        public int idUsuario{ get; set; }
        public string nombreUsuario { get; set; }
        public string claveUsuario { get; set; }
        public int idPersona { get; set; }
        public int idRol { get; set; }
        public int idEstadoUsuario { get; set; }
    }
}
