using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    class ClsClienteJuridico
    {
        public int idClienteJuridico { get; set; }
        public string RUC { get; set; }
        public int idRepresentante { get; set; }
        public int idPais { get; set; }
        public int idEstadoCliente { get; set; }
    }
}
