using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    class ClsFacturas
    {
        public int idFactura { get; set; }
        public string codigoFactura { get; set; }
        public string nombreEmpresa { get; set; }
        public string RUC { get; set; }
        public int idEstadoFactura { get; set; }
        public int idDireccion { get; set; }
        public int idOrden { get; set; }
    }
}
