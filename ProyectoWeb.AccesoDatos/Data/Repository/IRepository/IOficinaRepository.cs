using ProyectoWeb.AccesoDatos.Data.IRepository.IRepository;
using ProyectoWeb.Data.Repository.IRepository;
using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.AccesoDatos.Data.Repository.IRepository
{
    public interface IOficinaRepository : IRepository<Oficina>
    {
        void Update(Oficina oficina);

        
    }
}
