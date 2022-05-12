using CRM_Auto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Auto.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("LoginCliente");
        }
    }
}
