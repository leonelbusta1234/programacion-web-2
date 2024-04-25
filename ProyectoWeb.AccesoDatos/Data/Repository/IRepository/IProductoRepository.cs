using ProyectoWeb.AccesoDatos.Data.Repository;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.AccesoDatos.Data.Repository.IRepository
{
    public interface IProductoRepository : IRepository<Producto>
    {
        void Update(Producto producto);
    }
}
