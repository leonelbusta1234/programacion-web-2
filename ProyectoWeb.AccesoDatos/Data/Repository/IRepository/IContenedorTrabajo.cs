using ProyectoWeb.AccesoDatos.Data.IRepository.IRepository;
using ProyectoWeb.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        IAlmacenRepository Almacen { get; }
        IClienteRepository Cliente { get; }

        IProductoRepository Producto { get; }
        ISliderRepository Slider { get; }

        IOficinaRepository Oficina { get; }

        IUsuarioRepository Usuario { get; }
        void Save();
    }

}
