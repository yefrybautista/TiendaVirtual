using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
}
