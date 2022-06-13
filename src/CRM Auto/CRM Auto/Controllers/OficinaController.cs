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

        [HttpPost]
        public IActionResult InserirOficina(OficinaModel oficina)
        {
            int Id_oficina = oficina.Id_oficina;
            string Cnpj = oficina.Cnpj;
            string Nome_oficina = oficina.Nome_oficina;
            string Apelido = oficina.Apelido;
            string Insc_estadual = oficina.Insc_estadual;
            string Insc_municipal = oficina.Insc_municipal;
            string Cep = oficina.Cep;
            string Logradouro = oficina.Logradouro;
            string Numero = oficina.Numero;
            string Complemento = oficina.Complemento;
            string Bairro = oficina.Bairro;
            string Cidade = oficina.Cidade;
            string Telefone1 = oficina.Telefone1;
            string Telefone2 = oficina.Telefone2;
            string Email = oficina.Email;
            string Email_Nf = oficina.Email_Nf;
            string Opcao_cadastro = oficina.Opcao_cadastro;

            oficina.InserirOficina(Id_oficina, Cnpj, Nome_oficina,  Apelido,
                 Insc_estadual,  Insc_municipal,  Cep,  Logradouro,
                 Numero,  Complemento,  Bairro,  Cidade,  Telefone1,
                 Telefone2,  Email,  Email_Nf,  Opcao_cadastro);

            return View("CadastroRealizadoComSucesso");
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

        public IActionResult BuscarOficinas()
        {
            try
            {
                OficinaModel oficina = new OficinaModel();
                ViewBag.BuscarOficinas = oficina.BuscarOficinas();
                return View("CadastroDeOficina");
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
        public IActionResult AlterarOficina(OficinaModel oficina)
        {
            int Id_oficina = oficina.Id_oficina;
            string Cnpj = oficina.Cnpj;
            string Nome_oficina = oficina.Nome_oficina;
            string Apelido = oficina.Apelido;
            string Insc_estadual = oficina.Insc_estadual;
            string Insc_municipal = oficina.Insc_municipal;
            string Cep = oficina.Cep;
            string Logradouro = oficina.Logradouro;
            string Numero = oficina.Numero;
            string Complemento = oficina.Complemento;
            string Bairro = oficina.Bairro;
            string Cidade = oficina.Cidade;
            string Telefone1 = oficina.Telefone1;
            string Telefone2 = oficina.Telefone2;
            string Email = oficina.Email;
            string Email_Nf = oficina.Email_Nf;
            string Opcao_cadastro = oficina.Opcao_cadastro;

            oficina.AlterarOficina(Id_oficina, Cnpj, Nome_oficina, Apelido,
                 Insc_estadual, Insc_municipal, Cep, Logradouro,
                 Numero, Complemento, Bairro, Cidade, Telefone1,
                 Telefone2, Email, Email_Nf, Opcao_cadastro);

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
    
    }
}
