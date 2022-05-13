using Microsoft.AspNetCore.Mvc;
using CRM_Auto.Models;

namespace CRM_Auto.Controllers
{
    public class OficinaController : Controller
    {

        public IActionResult LoginColaborador()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerificacaoLogin(UsuarioModel usuario)
        {
            bool verificacao = usuario.ValidarLogin();
            if (verificacao)
            {
                return RedirectToAction("Sucesso");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Sucesso()
        {
            return View();
        }
    }
}
