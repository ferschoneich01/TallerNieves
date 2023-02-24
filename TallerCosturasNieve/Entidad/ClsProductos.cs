using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    class ClsProductos
    {
        public int idProducto { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public string fechaCreacion { get; set; }
        public float precioUnitario { get; set; }
        public int idBodega { get; set; }
        public int idCategoria { get; set; }
        public int idMoneda { get; set; }


    }
}
