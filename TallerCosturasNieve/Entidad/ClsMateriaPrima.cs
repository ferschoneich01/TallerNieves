using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    class ClsMateriaPrima
    {
        public int idMateriaPrima { get; set; }
        public string descripcion { get; set; }
        public string fechaCreacion { get; set; }
        public string ultimaModificacion { get; set; }
        public string unidadMedida { get; set; }
        public int cantidadDisponible { get; set; }
        public int idBodega { get; set; }
        public int idEstadoMateriaPrima { get; set; }


    }
}
