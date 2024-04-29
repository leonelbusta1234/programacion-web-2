using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;

namespace ProyectoWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuariosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        public UsuariosController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_contenedorTrabajo.Usuario.GetAll());
        }
        [HttpGet]
        public IActionResult Bloquear(string id)
        {
            if(id== null)
            {
                return NotFound();
            }
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var usuarioActual=claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            _contenedorTrabajo.Usuario.BloquearUsuario(id);
            return View("Index",_contenedorTrabajo.Usuario.GetAll());
        }
        [HttpGet]
        public IActionResult Desbloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var usuarioActual = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            _contenedorTrabajo.Usuario.DesbloquearUsuario(id);
            return View("Index", _contenedorTrabajo.Usuario.GetAll());
        }
    }
}
