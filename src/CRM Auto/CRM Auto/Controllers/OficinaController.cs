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
            string id_oficina = funcionario.Id_oficina;

            funcionario.AlterarFuncionario(nome, funcao, id_oficina);

            return View("CadastroRealizadoComSucesso");

        }

        [HttpPost]
        public IActionResult ExcluirFuncionario(FuncionarioModel funcionario)
        {
            string nome = funcionario.Nome;
            string funcao = funcionario.Funcao;

            funcionario.ExcluirFuncionario(nome, funcao);

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
