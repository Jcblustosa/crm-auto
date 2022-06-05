using Microsoft.AspNetCore.Mvc;
using CRM_Auto.Models;
using System;

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

        public IActionResult CadastroVeiculo()
        {
            return View("CadastroVeiculo");
        }

        public IActionResult OperacaoCadastroVeiculo(VeiculoModel veiculo)
        {
            veiculo.CadastroVeiculo();
            return RedirectToAction("CadastroVeiculo");
        }

        public IActionResult CadastrarFuncionario()
        {
            return View("CadastroDeFuncionario");
        }

        [HttpPost]
        public IActionResult InserirFuncionario(FuncionarioModel funcionario)
        {
            string nome = funcionario.Nome;
            string funcao = funcionario.Funcao;
            string nome_oficina = funcionario.Nome_oficina;

            funcionario.InserirFuncionario(nome, funcao, nome_oficina);

            bool resultadoInsercao = funcionario.ValidarInsercaoFuncionario();
            if (resultadoInsercao)
            {
                TempData["msg"] = "Inclusão realizada com sucesso!";
                TempData["msgDetalhes"] = "O cadastro do funcionário foi finalizado e você já pode consultá-lo no sistema da sua oficina.";

                return View("CadastroRealizadoComSucesso");
            }
            return RedirectToAction("Sucesso");
        }

        public IActionResult BuscarFuncionarios()
        {
            try
            {
                FuncionarioModel funcionario = new FuncionarioModel();
                ViewBag.BuscarFuncionarios = funcionario.BuscarFuncionarios();
                return View("CadastroDeFuncionario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AlterarFuncionario(FuncionarioModel funcionario)
        {
            string nome = funcionario.Nome;
            string funcao = funcionario.Funcao;
            string nome_oficina = funcionario.Nome_oficina;

            funcionario.AlterarFuncionario(nome, funcao, nome_oficina);

            TempData["msg"] = "Alteração realizada com sucesso!";
            TempData["msgDetalhes"] = "A alteração do funcionário foi finalizada e você já pode consultar as informações atualizadas no sistema da sua oficina.";

            return View("CadastroRealizadoComSucesso");

        }

        [HttpPost]
        public IActionResult ExcluirFuncionario(FuncionarioModel funcionario)
        {
            string nome = funcionario.Nome;
            string funcao = funcionario.Funcao;

            funcionario.ExcluirFuncionario(nome, funcao);

            TempData["msg"] = "Exclusão realizada com sucesso!";
            TempData["msgDetalhes"] = "A exclusão do funcionário foi finalizada e você já pode consultar as informações atualizadas no sistema da sua oficina.";

            return View("CadastroRealizadoComSucesso");

        }
        public IActionResult BuscarOficinas()
        {
            try
            {
                FuncionarioOficinaModel oficina = new FuncionarioOficinaModel();
                ViewBag.BuscarOficinas = oficina.oficinaModel.BuscarOficinas();
                return View("CadastroDeFuncionario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
