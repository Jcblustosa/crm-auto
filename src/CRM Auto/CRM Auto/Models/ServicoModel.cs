using CRM_Auto.Util;
using System;
using System.Data;

namespace CRM_Auto.Models
{
    public class ServicoModel
    {
        public string Descricao { get; set; }
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

        public string BuscarValor(string descricao)
        {
            string command = "SELECT CUSTO_HORA FROM SERVICO " +
                $"WHERE DESCRICAO = '{descricao}';";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            return dt.Rows[0]["CUSTO_HORA"].ToString();
        }
    }
}
