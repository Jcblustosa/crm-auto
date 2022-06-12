using CRM_Auto.Util;
using System;
using System.Data;

namespace CRM_Auto.Models
{
    public class ServicoModel
    {
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
                $"'{this.InicioServico}', " +
                $"'{this.FimServico}', " +
                $"{this.ServicoAprovado}, " +
                $"{this.CustoHora});";
        }

        public string BuscarValor(string idServico)
        {
            string command = "SELECT CUSTO_HORA FROM SERVICO " +
                $"WHERE ID_SERVICO = '{idServico}';";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            return dt.Rows[0]["CUSTO_HORA"].ToString();
        }
    }
}
