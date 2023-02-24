using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class ClsPersonas
    {
        public int idPersona { get; set; }
        public int idPersonaIdentificacion { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public int idPais { get; set; }
        public int idCiudad { get; set; }
        public int idDireccion { get; set; }
        public string telefono { get; set; }
    }
}
