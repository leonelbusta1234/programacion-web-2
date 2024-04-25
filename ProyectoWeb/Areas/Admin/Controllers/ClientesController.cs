using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Models;

namespace ProyectoWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientesController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public ClientesController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Cliente.GetAll() });
        }
        // se requiere una vista para que registre los datos
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //es el que guarda los datos que llene en el formulario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProyectoWeb.Models.Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //logica para guardar en bd
                _contenedorTrabajo.Cliente.Add(cliente);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));

            }
            return View(cliente);
        }
    }
}
