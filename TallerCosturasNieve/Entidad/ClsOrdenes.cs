using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    class ClsOrdenes
    {
        public int IdUsuario { get; set; }
        public ClsRol oRol { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public byte Estado { get; set; }
    }
}
