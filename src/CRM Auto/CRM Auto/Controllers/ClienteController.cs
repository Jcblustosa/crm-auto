using Microsoft.AspNetCore.Mvc;
using CRM_Auto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRM_Auto.ViewModels;

namespace CRM_Auto.Controllers
{
    public class ClienteController : Controller
    {
        private IHttpContextAccessor HttpContextAccessor;
        public ClienteController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginCliente()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ConsultarDetalhamento(int id)
        {
            DetalhamentoModel model = new DetalhamentoModel();
            List<DetalhamentoModel> servicos = model.ConsultarDetalhamento(id);
            return View(servicos);
        }

        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                string[] nomeEId = usuario.NomeEId(usuario.Login_usuario, usuario.Senha_usuario);
                HttpContext.Session.SetString("NomeUsuario", nomeEId[0]);
                HttpContext.Session.SetString("IdUsuario", nomeEId[1]);
                TempData["NomeUsuario"] = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuario");
                TempData["IdUsuario"] = HttpContextAccessor.HttpContext.Session.GetString("IdUsuario");
                return RedirectToAction("BemVindoCliente");
            }
            return RedirectToAction("LoginCliente");
        }
        public IActionResult BemVindoCliente()
        {
            return View("bemVindoCliente");
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

