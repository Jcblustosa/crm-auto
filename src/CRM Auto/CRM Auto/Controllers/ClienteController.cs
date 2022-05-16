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

        public IActionResult ConsultarDetalhamento()
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

        public IActionResult CadastroCliente()
        {
            return View("CadastroCliente");
        }

        public IActionResult OperacaoCadastroCliente(ClienteModel cliente)
        {
            cliente.CadastroCliente();
            return RedirectToAction("CadastroCliente");
        }

    }
}
