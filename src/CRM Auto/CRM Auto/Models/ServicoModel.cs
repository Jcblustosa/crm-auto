using CRM_Auto.Util;
using System;
using System.Data;

namespace CRM_Auto.Models
{
    public class ServicoModel
    {
        public int IdDetalhamento { get; set; }
        public string Descricao { get; set; }
        public int IdServico { get; set; }
        public int Quantidade { get; set; }
        public TimeSpan TempoPrevisto { get; set; }
        public DateTime InicioServico { get; set; }
        public DateTime FimServico { get; set; }
        public bool ServicoAprovado { get; set; }
        public TimeSpan TempoDeExecucao { get; set; }
        public double CustoHora { get; set; }
        public int IdMecanicoResponsavel { get; set; }


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

        public ServicoModel BuscarServico(int id)
        {
            ServicoModel servico = new ServicoModel();
            string command = "SELECT S.ID_SERVICO, D.ID_MEC_RESPONSAVEL, D.DATA_INICIO_SERVICO, D.DATA_FIM_SERVICO, D.APROVADO, D.QUANTIDADE " +
                "FROM DETALHE_OS D " +
                "INNER JOIN SERVICO S  " +
                "ON D.ID_SERVICO = S.ID_SERVICO " +
                $"WHERE D.ID_ORDEM = {id};";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            servico.IdDetalhamento = id;
            servico.IdServico = int.Parse(dt.Rows[0]["ID_SERVICO"].ToString());
            servico.IdMecanicoResponsavel = int.Parse(dt.Rows[0]["ID_MEC_RESPONSAVEL"].ToString());
            servico.InicioServico = DateTime.Parse(dt.Rows[0]["DATA_INICIO_SERVICO"].ToString());
            servico.FimServico = DateTime.Parse(dt.Rows[0]["DATA_FIM_SERVICO"].ToString());
            servico.ServicoAprovado = dt.Rows[0]["APROVADO"].ToString() == "1" ? true : false;
            servico.Quantidade = int.Parse(dt.Rows[0]["QUANTIDADE"].ToString());

            return servico;
        }

        public void ApagarDetalhamento(int id)
        {
            string command = "DELETE FROM DETALHE_OS " +
                $"WHERE ID_ORDEM = {id};";

            CNN cNN = new CNN();
            cNN.InsertData(command);
        }
    }
}
