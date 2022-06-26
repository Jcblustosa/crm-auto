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
    public class OficinaController : Controller
    {
        private IHttpContextAccessor HttpContextAccessor;
        public OficinaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
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
                string[] nomeEIdFuncionario = usuario.NomeEIdFuncionario(usuario.Login_usuario, usuario.Senha_usuario);
                HttpContext.Session.SetString("Nome", nomeEIdFuncionario[0]);
                HttpContext.Session.SetString("IdFuncionario", nomeEIdFuncionario[1]);
                HttpContext.Session.SetString("IdOficina", nomeEIdFuncionario[2]);
                HttpContext.Session.SetString("IdUsuario", nomeEIdFuncionario[3]);
                TempData["Nome"] = HttpContextAccessor.HttpContext.Session.GetString("Nome");
                TempData["IdFuncionario"] = HttpContextAccessor.HttpContext.Session.GetString("IdFuncionario");
                return RedirectToAction("Sucesso");
            }
            return RedirectToAction("LoginColaborador");
        }

        public IActionResult Sucesso()
        {
            SucessoModel sucesso = new SucessoModel();
            TempData["Nome"] = HttpContextAccessor.HttpContext.Session.GetString("Nome");
            ViewBag.ListaOS = sucesso.BuscarDados(HttpContextAccessor.HttpContext.Session.GetString("IdOficina"));
            return View("Sucesso");
        }

        public IActionResult CadastroVeiculo()
        {
            MarcaModel marcas = new MarcaModel();
            ViewBag.Marcas = marcas.Marcas();
            return View();
        }

        [HttpPost]
        public List<ModeloModel> SelecionaModelosMarca(MarcaModel marca)
        {
            ModeloModel modelo = new ModeloModel();
            return modelo.Modelos(marca.IdMarca);
        }

        [HttpPost]
        public IActionResult OperacaoCadastroVeiculo(VeiculoModel veiculo)
        {
            veiculo.CadastroVeiculo();
            TempData["veiculoCadastrado"] = "Veículo cadastrado com sucesso!";
            return RedirectToAction("CadastroVeiculo");
        }

        public IActionResult CadastrarFuncionario()
        {
            return View("CadastroDeFuncionario");
        }

        [HttpPost]
        public IActionResult InserirFuncionario(FuncionarioModel funcionario)
        {
            
            funcionario.InserirFuncionario(funcionario);

            bool resultadoInsercao = funcionario.ValidarInsercaoFuncionario(funcionario);
            if (resultadoInsercao)
            {
                TempData["msg"] = "Inclusão realizada com sucesso!";
                TempData["msgDetalhes"] = "O cadastro do funcionário foi finalizado e você já pode consultá-lo no sistema da sua oficina.";

                return View("CadastroRealizadoComSucesso");
            }
            return RedirectToAction("Sucesso");
        }

        public IActionResult BuscarFuncionariosEOficinas()
        {
            try
            {
                FuncionarioModel funcionario = new FuncionarioModel();
                ViewBag.BuscarFuncionarios = funcionario.BuscarFuncionarios();

                OficinaModel oficina = new OficinaModel();
                List<OficinaModel> lista = oficina.BuscarOficinas();
                ViewBag.BuscarOficinas = lista.Select(o => new { o.Id_oficina, o.Nome_oficina });

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
                List<OficinaModel> lista = oficina.BuscarOficinas();
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
            funcionario.AlterarFuncionario(funcionario);

            TempData["msg"] = "Alteração realizada com sucesso!";
            TempData["msgDetalhes"] = "A alteração do funcionário foi finalizada e você já pode consultar as informações atualizadas no sistema da sua oficina.";

            return View("CadastroRealizadoComSucesso");

        }

        [HttpPost]
        public IActionResult AlterarOficina(OficinaModel oficina)
        {
            oficina.AlterarOficina(oficina);

            TempData["msg"] = "Alteração realizada com sucesso!";
            TempData["msgDetalhes"] = "A alteração da oficina foi finalizada e você já pode consultar as informações atualizadas no sistema da sua oficina.";


            return View("CadastroRealizadoComSucesso");

        }

        public IActionResult InserirOficina(OficinaModel oficina)
        {
            oficina.InserirOficina(oficina);

            TempData["msg"] = "Inserção realizada com sucesso!";
            TempData["msgDetalhes"] = "A inserção da oficina foi finalizada e você já pode consultar as informações atualizadas no sistema da sua oficina.";


            return View("CadastroRealizadoComSucesso");

        }

        [HttpPost]
        public IActionResult ExcluirFuncionario(FuncionarioModel funcionario)
        {
 
            funcionario.ExcluirFuncionario(funcionario);

            TempData["msg"] = "Exclusão realizada com sucesso!";
            TempData["msgDetalhes"] = "A exclusão do funcionário foi finalizada e você já pode consultar as informações atualizadas no sistema da sua oficina.";

            return View("CadastroRealizadoComSucesso");

        }

        [HttpGet]
        public IActionResult OrdemServico()
        {
            OrdemServico os = new OrdemServico();
            ViewBag.ListaServicos = os.ListarServicos();
            string idOficina = HttpContextAccessor.HttpContext.Session.GetString("IdOficina");
            MecanicoModel mecanico = new MecanicoModel();
            ViewBag.ListaMecanicos = mecanico.ListarMecanicos(idOficina);
            return View();
        }

        [HttpPost]
        public List<string> BuscarPlacas(BuscaPlacas buscaPlacas)
        {
            OrdemServico os = new OrdemServico();
            return os.BuscarPlacas(buscaPlacas.Cnpj_cpf);
        }

        [HttpPost]
        public string BuscarPreco(ServicoModel servico)
        {
            return servico.BuscarValor(servico.Descricao);
        }

        [HttpPost]
        public IActionResult GerarOS(OficinaOrdemServicoViewModel oficinaOS)
        {
            AgendamentoServicoModel agendamento = new AgendamentoServicoModel();
            agendamento.DataAgendamento = oficinaOS.OrdemServico.DataOrdem;
            string idCliente = agendamento.BuscarIdCliente(oficinaOS.OrdemServico.CpfCnpj);
            string idCliVeiculo = agendamento.BuscarIdClienteVeiculo(oficinaOS.OrdemServico.PlacaVeiculo, idCliente);
            string idAgendamento = agendamento.GerarAgendamento(idCliente, idCliVeiculo);
            string idUsuarioCad = HttpContextAccessor.HttpContext.Session.GetString("IdUsuario");
            oficinaOS.OrdemServico.IdOficina = HttpContextAccessor.HttpContext.Session.GetString("IdOficina");
            string idOS = oficinaOS.OrdemServico.GerarOS(idCliente, idAgendamento, idUsuarioCad, idCliVeiculo);
            oficinaOS.Servico.CadastrarServico(idOS);
            TempData["ordemCadastrada"] = "Ordem de Serviço cadastrada com sucesso!";
            return RedirectToAction("OrdemServico");
        }
   
    }
}
