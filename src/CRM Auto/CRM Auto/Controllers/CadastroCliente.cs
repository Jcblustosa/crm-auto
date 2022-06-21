using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM_Auto.Models;
using CRM_Auto.ViewModels;

namespace CRM_Auto.Controllers
{
    public class CadastroCliente : Controller
    {
        // GET: CadastroCliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: CadastroCliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastroCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroCliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroCliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadastroCliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroCliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadastroCliente/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        [HttpPost]
        public IActionResult ExcluirCliente(ClienteModel cliente)
        {
            cliente.ExcluirCliente(cliente);

            TempData["msg"] = "Exclusão realizada com sucesso!";
            TempData["msgDetalhes"] = "A exclusão do funcionário foi finalizada e você já pode consultar as informações atualizadas no sistema da sua oficina.";

            return View("CadastroRealizadoComSucesso");

        }
    }
}
