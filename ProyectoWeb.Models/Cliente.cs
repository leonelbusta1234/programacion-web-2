using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
     public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public int Celular { get; set; }
        public int CarnetIdentidad { get; set; }
    }
}
