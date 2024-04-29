
using ProyectoWeb.AccesoDatos.Data.IRepository.IRepository;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Data;
using ProyectoWeb.Data.Repository;
using ProyectoWeb.Data.Repository.IRepository;
using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _context;
        public ContenedorTrabajo(ApplicationDbContext context)
        {
            _context = context;
            //se agregan cada uno de los repositorios para que queden encapsulados
            Almacen = new AlmacenRepository(_context);

            Cliente = new ClienteRepository(_context);

            Producto = new ProductoRepository(_context);
            
            Slider = new SliderRepository(_context);

            Oficina = new OficinaRepository(_context);

            Usuario = new UsuarioRepository(_context);


        }

        public IAlmacenRepository Almacen { get; private set; }
        public IClienteRepository Cliente { get; private set; }

        public IProductoRepository Producto { get; private set; }

        public ISliderRepository Slider { get; private set; }

        public IOficinaRepository Oficina { get; private set; }

        public IUsuarioRepository Usuario { get; private set; }


        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
