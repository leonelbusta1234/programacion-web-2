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
    public class AlmacenRepository : Repository<Almacen>, IAlmacenRepository
    {
        private readonly ApplicationDbContext _db;

        public AlmacenRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaAlmacenes()
        {
            throw new NotImplementedException();
        }

        public void Update(Almacen almacen)
        {
            var objDesdeDb = _db.Almacen.FirstOrDefault(s => s.Id == almacen.Id);
            objDesdeDb.NombreAlmacen = almacen.NombreAlmacen;
            objDesdeDb.Direccion = almacen.Direccion;
            objDesdeDb.UrlImagen = almacen.UrlImagen;
            objDesdeDb.Orden = almacen.Orden;

            //_db.SaveChanges();
        }
    }

}

