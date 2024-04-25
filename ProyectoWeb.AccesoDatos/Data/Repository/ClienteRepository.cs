using ProyectoWeb.AccesoDatos.Data.IRepository.IRepository;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Data;
using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.AccesoDatos.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly ApplicationDbContext _db;
        public ClienteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Cliente cliente)
        {
            var objDesdeDb = _db.Cliente.FirstOrDefault(s => s.Id == cliente.Id);
            objDesdeDb.Nombre = cliente.Nombre;
            objDesdeDb.Paterno = cliente.Paterno;
            objDesdeDb.Materno = cliente.Materno;
            objDesdeDb.Celular = cliente.Celular;   
            objDesdeDb.CarnetIdentidad = cliente.CarnetIdentidad;
        }
    }
}
