using CRM_Auto.Util;
using System;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Models
{
    public class OrdemServico
    {
        public int IdOS { get; set; }
        public int IdCliente { get; set; }
        public string CpfCnpj { get; set; }
        public int IdVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public DateTime DataOrdem { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string IdOficina { get; set; }
        public int IdAgendamento { get; set; }
        public int IdUsuarioCadastrado { get; set; }

        public List<ServicoModel> ListarServicos()
        {
            List<ServicoModel> servicos= new List<ServicoModel>();
            string command = "SELECT ID_SERVICO, DESCRICAO FROM SERVICO;";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ServicoModel servico = new ServicoModel();
                servico.IdServico = int.Parse(dt.Rows[i]["ID_SERVICO"].ToString());
                servico.Descricao = dt.Rows[i]["DESCRICAO"].ToString();
                servicos.Add(servico);
            }

            return servicos;
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

        public string GerarOS(string idCliente, string idAgendamento, string idUsuarioCad, string idCliVeiculo)
        {
            string command = "INSERT INTO ORDEM_SERVICO(ID_CLIENTE, ID_VEICULO, DATA_ORDEM, TELEFONE_CONTATO, EMAIL_CONTATO, ID_OFICINA, ID_AGENDAMENTO, ID_USUARIO_CAD) VALUES(" +
                $"{idCliente}, " +
                $"{idCliVeiculo}, " +
                $"'{this.DataOrdem.ToString("yyyy/MM/dd HH:mm:ss")}', " +
                $"'{this.Telefone}', " +
                $"'{this.Email}', " +
                $"{this.IdOficina}, " +
                $"{idAgendamento}, " +
                $"{idUsuarioCad});";

            CNN cnn = new CNN();
            cnn.InsertData(command);

            command = "SELECT ID_ORDEM_SERVICO FROM ORDEM_SERVICO " +
                $"WHERE DATA_ORDEM = '{this.DataOrdem.ToString("yyyy/MM/dd HH:mm:ss")}';";

            DataTable dt = cnn.GetData(command);
            return dt.Rows[0]["ID_ORDEM_SERVICO"].ToString();
        }

        public OrdemServico BuscarOS(int id)
        {
            OrdemServico os = new OrdemServico();

            string command = "SELECT C.CNPJ_CPF, V.PLACA_VEICULO, O.DATA_ORDEM, O.TELEFONE_CONTATO, O.EMAIL_CONTATO " +
                "FROM ORDEM_SERVICO O " +
                "INNER JOIN CLIENTE C " +
                "ON O.ID_CLIENTE = C.ID_CLIENTE " +
                "INNER JOIN CLIENTE_VEICULO CV " +
                "ON O.ID_VEICULO = CV.ID_CLI_VEICULO " +
                "INNER JOIN VEICULO V " +
                "ON CV.ID_VEICULO = V.ID_VEICULO " +
                $"WHERE O.ID_ORDEM_SERVICO = {id};";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            os.IdOS = id;
            os.CpfCnpj = dt.Rows[0]["CNPJ_CPF"].ToString();
            os.PlacaVeiculo = dt.Rows[0]["PLACA_VEICULO"].ToString();
            os.DataOrdem = DateTime.Parse(dt.Rows[0]["DATA_ORDEM"].ToString());
            os.Telefone = dt.Rows[0]["TELEFONE_CONTATO"].ToString();
            os.Email = dt.Rows[0]["EMAIL_CONTATO"].ToString();
            return os;
        }

        public void ApagarOS()
        {
            string command = "DELETE FROM ORDEM_SERVICO " +
                $"WHERE ID_ORDEM_SERVICO = {this.IdOS};";

            CNN cnn = new CNN();    
            cnn.InsertData(command);
        }
    }

    public class BuscaPlacas
    {
        public string Cnpj_cpf { get; set; }
    }
}
