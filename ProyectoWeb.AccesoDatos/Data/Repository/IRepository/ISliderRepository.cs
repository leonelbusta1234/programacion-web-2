using ProyectoWeb.AccesoDatos.Data.Repository;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Data.Repository.IRepository
{
    public interface ISliderRepository : IRepository<Slider>
    {
        void Update(Slider slider);
    }
}
