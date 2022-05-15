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
            return RedirectToAction("LoginColaborador");
        }

        public IActionResult Sucesso()
        {
            return View("Sucesso");
        }

        public IActionResult CadastrarFuncionario()
        {
            return View("CadastroDeFuncionario");
        }

       [HttpPost]
        public IActionResult InserirCadastro(FuncionarioModel funcionario)
        {
            string nome = funcionario.Nome;
            string funcao = funcionario.Funcao;
            int id_oficina = funcionario.Id_oficina;
            
            funcionario.InserirCadastro(nome, funcao, id_oficina);

            bool resultadoInsercao = funcionario.ValidarInsercaoFuncionario();
            if (resultadoInsercao)
            {
                return View("CadastroRealizadoComSucesso");
            }
            return RedirectToAction("Sucesso");
        }


        public IActionResult CadastroVeiculo()
        {
            return View("CadastroVeiculo");
        }

        public IActionResult OperacaoCadastroVeiculo(VeiculoModel veiculo)
        {
            veiculo.CadastroVeiculo();
            return RedirectToAction("CadastroVeiculo");
        }
    }
}
