using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.AccesoDatos.Data.Repository;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;

namespace ProyectoWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductosController : Controller
    {
        private readonly IContenedorTrabajo _context;
        public ProductosController(IContenedorTrabajo context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _context.Producto.GetAll() });
        }
    }
}
