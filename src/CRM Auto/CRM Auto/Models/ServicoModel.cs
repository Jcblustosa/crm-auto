using System;

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

        public ServicoModel()
        {

        }

        public ServicoModel(string descricao, int quantidade, TimeSpan tempoPrevisto, DateTime inicioServico, DateTime fimServico, bool servicoAprovado, double custoHora)
        {
            Descricao = descricao;
            Quantidade = quantidade;
            TempoPrevisto = tempoPrevisto;
            InicioServico = inicioServico;
            FimServico = fimServico;
            ServicoAprovado = servicoAprovado;
            CustoHora = custoHora;
        }
    }
}
