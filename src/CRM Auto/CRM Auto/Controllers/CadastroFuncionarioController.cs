using CRM_Auto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Auto.Controllers
{
    public class CadastroFuncionarioController : Controller
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
        /*public IActionResult InserirCadastro(FuncionarioModel funcionario)
        {
            funcionario.InserirCadastro(funcionario);
           
        }*/
        
        [HttpGet]
        public IActionResult ValidarInsercaoFuncionario(FuncionarioModel funcionario)
        {
            bool resultadoInsercao = funcionario.ValidarInsercaoFuncionario();
            if (resultadoInsercao)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("ErroInsercaoUsuario");
        }
    }
}
