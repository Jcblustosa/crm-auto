using CRM_Auto.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CRM_Auto.Models
{
    public class ServicoModel
    {
        public int IdDetalhamento { get; set; }
        public string Descricao { get; set; }
        public int IdServico { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public TimeSpan TempoPrevisto { get; set; }
        public DateTime InicioServico { get; set; }
        public DateTime FimServico { get; set; }
        public bool ServicoAprovado { get; set; }
        public TimeSpan TempoDeExecucao { get; set; }
        public float CustoHora { get; set; }
        public int IdMecanicoResponsavel { get; set; }
        public string MecanicoResponsavel { get; set; }

        public ServicoModel(int IdServico, string Descricao, TimeSpan TempoDeExecucao, float CustoHora)
        {
            this.IdServico = IdServico;
            this.Descricao = Descricao;
            this.TempoDeExecucao = TempoDeExecucao;
            this.CustoHora = CustoHora;
        }
        public ServicoModel()
        {

        }

        public void CadastrarServico(string idOs)
        {
            this.TempoPrevisto = FimServico - InicioServico;
            string command = "INSERT INTO DETALHE_OS(ID_ORDEM, ID_SERVICO, ID_MEC_RESPONSAVEL, QUANTIDADE, TEMPO_PREVISTO, DATA_INICIO_SERVICO, DATA_FIM_SERVICO, APROVADO, VALOR_UNITARIO) VALUES(" +
                $"{idOs}, " +
                $"{this.IdServico}, " +
                $"{this.IdMecanicoResponsavel}, " +
                $"{this.Quantidade}, " +
                $"'{this.TempoPrevisto}', " +
                $"'{this.InicioServico.ToString("yyyy/MM/dd HH:mm:ss")}', " +
                $"'{this.FimServico.ToString("yyyy/MM/dd HH:mm:ss")}', " +
                $"{this.ServicoAprovado}, " +
                $"{this.CustoHora});";

            CNN cnn = new CNN();
            cnn.InsertData(command);
        }

        public string BuscarValor(string idServico)
        {
            string command = "SELECT CUSTO_HORA FROM SERVICO " +
                $"WHERE ID_SERVICO = '{idServico}';";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            return dt.Rows[0]["CUSTO_HORA"].ToString();
        }
        public List<ServicoModel> BuscarServicos() 
        {
            ArrayListServico<ServicoModel> servicos = new ArrayListServico<ServicoModel>();

            string command = $"SELECT ID_SERVICO, DESCRICAO, TEMPO_EXEC_SERVICO, CUSTO_HORA " +
                $"FROM SERVICO " +
                $"ORDER BY ID_SERVICO ";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ServicoModel servico = new (int.Parse(dt.Rows[i]["ID_SERVICO"].ToString()),
                    dt.Rows[i]["DESCRICAO"].ToString(),
                    TimeSpan.Parse(dt.Rows[i]["TEMPO_EXEC_SERVICO"].ToString()),
                    float.Parse(dt.Rows[i]["CUSTO_HORA"].ToString()));

                servicos.Add(servico);
            }

            return servicos;
        }

        public void InserirNovoServico(ServicoModel servico)
        {

            string command = $"INSERT INTO SERVICO (DESCRICAO, TEMPO_EXEC_SERVICO, CUSTO_HORA) " +
                $"VALUES ('{servico.Descricao}', '{servico.TempoDeExecucao}', '{servico.CustoHora}')";

            CNN cnn1 = new CNN();
            cnn1.InsertData(command);
        }

        public void BuscarDetalhamento(int id)
        {
            string command = "SELECT S.DESCRICAO, F.NOME, S.CUSTO_HORA, D.QUANTIDADE " +
                "FROM DETALHE_OS D " +
                "INNER JOIN SERVICO S " +
                "ON D.ID_SERVICO = S.ID_SERVICO " +
                "INNER JOIN FUNCIONARIO F " +
                "ON D.ID_MEC_RESPONSAVEL = F.ID_FUNCIONARIO " +
                $"WHERE D.ID_ORDEM = {id};";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            Descricao = dt.Rows[0]["DESCRICAO"].ToString();
            MecanicoResponsavel = dt.Rows[0]["NOME"].ToString();
            CustoHora = double.Parse(dt.Rows[0]["CUSTO_HORA"].ToString());
            Quantidade = int.Parse(dt.Rows[0]["QUANTIDADE"].ToString());
        }
    }
}
