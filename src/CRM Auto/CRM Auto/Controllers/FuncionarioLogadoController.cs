using Microsoft.AspNetCore.Mvc;
using CRM_Auto.Models;

namespace CRM_Auto.Views.Oficina
{
    public class FuncionarioLogadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastroDeFuncionario()
        {
            return View();
        }

        public IActionResult CadastrarFuncionario()
        {
            return View("CadastroDeFuncionario");
        }
    }
}
