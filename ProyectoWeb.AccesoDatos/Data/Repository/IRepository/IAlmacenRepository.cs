using ProyectoWeb.AccesoDatos.Data.Repository;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.AccesoDatos.Data.IRepository.IRepository
{
    public interface IAlmacenRepository : IRepository<Almacen>
    {
        void Update(Almacen almacen);
        IEnumerable<SelectListItem> GetListaAlmacenes();
    }
}

