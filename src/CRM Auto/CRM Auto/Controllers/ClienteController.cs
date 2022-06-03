using CRM_Auto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            DetalhamentoModel model = new DetalhamentoModel();
            List<DetalhamentoModel> servicos = model.ConsultarDetalhamento(1);
            return View(servicos);
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
