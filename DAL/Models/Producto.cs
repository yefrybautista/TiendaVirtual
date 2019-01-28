using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public int ProductoPrecio { get; set; }
    }
}
