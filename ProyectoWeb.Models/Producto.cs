using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadMinima { get; set; }
        public int PrecioVenta { get; set; }

    }
}
