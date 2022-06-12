using CRM_Auto.Util;
using System;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Models
{
    public class OrdemServico
    {
        public int IdCliente { get; set; }
        public string CpfCnpj { get; set; }
        public int IdVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public DateTime DataOrdem { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int IdOficina { get; set; }
        public int IdAgendamento { get; set; }
        public int IdUsuarioCadastrado { get; set; }

        public List<string> ListarServicos()
        {
            List<string> servicos= new List<string>();
            string command = "SELECT DESCRICAO FROM SERVICO;";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                servicos.Add(dt.Rows[i]["DESCRICAO"].ToString());
            }

            return servicos;
        }

        public List<string> ListarMecanicos(string idOficina)
        {
            List<string> mecanicos = new List<string>();
            string command = "SELECT NOME FROM FUNCIONARIO " +
                $"WHERE FUNCAO = 'Mecânico' AND ID_OFICINA = {idOficina}";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                mecanicos.Add(dt.Rows[i]["NOME"].ToString());
            }

            return mecanicos;
        }

        public List<string> BuscarPlacas(string cnpj_cpf)
        {
            List<string> placas = new List<string>();

            string command = "SELECT V.PLACA_VEICULO " +
                "FROM CLIENTE C " +
                "INNER JOIN CLIENTE_VEICULO CV " +
                "ON C.ID_CLIENTE = CV.ID_CLIENTE " +
                "INNER JOIN VEICULO V " +
                "ON CV.ID_VEICULO = V.ID_VEICULO " +
                $"WHERE C.CNPJ_CPF = '{cnpj_cpf}';";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                placas.Add(dt.Rows[i]["PLACA_VEICULO"].ToString());
            }

            return placas;
        }
    }

    public class BuscaPlacas
    {
        public string Cnpj_cpf { get; set; }
    }
}
