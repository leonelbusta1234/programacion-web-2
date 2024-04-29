using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace ProyectoWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OficinasController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public OficinasController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }
        //metodo para ir a la vista index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //metodo para ir a la vista create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //metodo para guardar los datos del nuevo oficina
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Oficina oficina)
        {
            if (ModelState.IsValid)
            {
                //logica para guardar en bd
                _contenedorTrabajo.Oficina.Add(oficina);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));

            }
            return View(oficina);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Oficina oficina = new Oficina();
            oficina = _contenedorTrabajo.Oficina.Get(id);
            if (oficina == null)
            {
                return NotFound();

            }
            return View(oficina);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Oficina oficina)
        {

            if (ModelState.IsValid)
            {
                _contenedorTrabajo.Oficina.Update(oficina);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(oficina);
        }
        #region llamadas a la api
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Oficina.GetAll() });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _contenedorTrabajo.Oficina.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error borrando oficina" });
            }
            _contenedorTrabajo.Oficina.Remove(objFromDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Se borro la oficina" });
        }
        #endregion
    }
}
