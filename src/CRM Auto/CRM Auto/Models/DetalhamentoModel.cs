using CRM_Auto.Util;
using System;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Models
{
    public class DetalhamentoModel
    {
        public int IdOrdemServico { get; set; }
        public string DescricaoServico { get; set; }
        public string NomeMecanico { get; set; }
        public TimeSpan TempoPrevisto { get; set; }
        public DateTime DataInicioServico { get; set; }
        public DateTime DataFimServico { get; set; }
        public double ValorUnitario { get; set; }

        public List<DetalhamentoModel> ConsultarDetalhamento(int id)
        {
            string command = "SELECT OS.ID_ORDEM_SERVICO, S.DESCRICAO, F.NOME, D.TEMPO_PREVISTO, D.DATA_INICIO_SERVICO, D.DATA_FIM_SERVICO, D.VALOR_UNITARIO " +
                "FROM ORDEM_SERVICO OS " +
                "INNER JOIN CLIENTE C " +
                "ON OS.ID_CLIENTE = C.ID_CLIENTE " +
                "INNER JOIN DETALHE_OS D " +
                "ON OS.ID_ORDEM_SERVICO = D.ID_ORDEM " +
                "INNER JOIN SERVICO S " +
                "ON D.ID_SERVICO = S.ID_SERVICO " +
                "INNER JOIN FUNCIONARIO F " +
                "ON D.ID_MEC_RESPONSAVEL = F.ID_FUNCIONARIO " +
                $"WHERE C.ID_CLIENTE = {id};";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            List<DetalhamentoModel> servicos = new List<DetalhamentoModel>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DetalhamentoModel servico = new DetalhamentoModel();
                servico.IdOrdemServico = int.Parse(dt.Rows[i]["ID_ORDEM_SERVICO"].ToString());
                servico.DescricaoServico = dt.Rows[i]["DESCRICAO"].ToString();
                servico.NomeMecanico = dt.Rows[i]["NOME"].ToString();
                servico.TempoPrevisto = TimeSpan.Parse(dt.Rows[i]["TEMPO_PREVISTO"].ToString());
                servico.DataInicioServico = DateTime.Parse(dt.Rows[i]["DATA_INICIO_SERVICO"].ToString());
                servico.DataFimServico = DateTime.Parse(dt.Rows[i]["DATA_FIM_SERVICO"].ToString());
                servico.ValorUnitario = double.Parse(dt.Rows[i]["VALOR_UNITARIO"].ToString());

                servicos.Add(servico);
            }
            return servicos;
        }






        //public string Placa { get; set; }
        //public DateTime DataOrdemServico { get; set; }
        //public string MecanicoResponsavel { get; set; }
        //public DateTime PrevisaoEntrega { get; set; }
        //public double ValorTotal { get; set; }
        //public List<ServicoModel> ServicosSolicitados { get; set; } = new List<ServicoModel>();

        //public List<string> RecuperarCabecalho(int idOrdemServico)
        //{
        //    List<string> cabecalho = new List<string>();
        //    double saldo = 0.0;
        //    TimeSpan tempoPrevisto = new TimeSpan(0, 0, 0);
        //    DateTime dataOS = new DateTime();

        //    Pegar valor e tempo total dos serviços
        //    string command = "SELECT (D.QUANTIDADE * S.CUSTO_HORA) AS TOTAL, D.TEMPO_PREVISTO " +
        //        "FROM DETALHE_OS D " +
        //        "INNER JOIN SERVICO S  " +
        //        "ON D.ID_SERVICO = S.ID_SERVICO " +
        //        $"WHERE D.ORDER_ID = {idOrdemServico}";

        //    DAL dal = new DAL();
        //    DataTable dt = dal.GetData(command);

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        saldo += double.Parse(dt.Rows[i]["TOTAL"].ToString());
        //        tempoPrevisto = tempoPrevisto.Add(TimeSpan.Parse(dt.Rows[i]["TEMPO_PREVISTO"].ToString()));
        //    }

        //    Pegar data da OS
        //    command = "SELECT DATA_ORDEM FROM ORDEM_SERVICO " +
        //        $"WHERE ID_ORDEM_SERVICO = {idOrdemServico}";
        //    dt = dal.GetData(command);
        //    dataOS = DateTime.Parse(dt.Rows[0]["DATA_ORDEM"].ToString());

        //    Pegar data de início
        //    command = "SELECT MIN(DATA_INICIO_SERVICO) AS DATA_INICIO " +
        //        "FROM DETALHE_OS " +
        //        $"WHERE ORDER_ID = {idOrdemServico}";
        //    dt = dal.GetData(command);
        //    DateTime dataInicio = DateTime.Parse(dt.Rows[0]["DATA_INICIO"].ToString());

        //    DateTime previsaoEntrega = CalcularTempoPrevisto(dataInicio, tempoPrevisto);

        //    cabecalho.Add(dataOS.ToString());
        //    cabecalho.Add(previsaoEntrega.ToString());
        //    cabecalho.Add(saldo.ToString());
        //    return cabecalho;
        //}

        //public DateTime CalcularTempoPrevisto(DateTime dataInicio, TimeSpan tempoServico)
        //{
        //    TimeSpan horaInicio = dataInicio.TimeOfDay;

        //    DateTime previsao = new DateTime();

        //    TimeSpan fimExpediente = new TimeSpan(17, 0, 0);

        //    if (horaInicio.Add(tempoServico) > fimExpediente || tempoServico.Hours > 8)
        //    {
        //        while (tempoServico.Hours > 8)
        //        {
        //            TimeSpan incremento = new TimeSpan(17 - dataInicio.Hour, 0, 0);
        //            dataInicio = dataInicio.AddHours(incremento.Hours + 15);
        //            tempoServico = tempoServico.Subtract(incremento);
        //        }
        //        while (dataInicio.AddHours(tempoServico.Hours).TimeOfDay >= fimExpediente)
        //        {
        //            TimeSpan incremento = new TimeSpan(17 - dataInicio.Hour, 0, 0);
        //            dataInicio = dataInicio.AddHours(incremento.Hours + 15);
        //            tempoServico = tempoServico.Subtract(incremento);
        //        }
        //        if ((dataInicio.TimeOfDay).Add(new TimeSpan(0, tempoServico.Minutes, 0)) > fimExpediente)
        //        {
        //            dataInicio = dataInicio.AddHours(15);
        //            dataInicio = dataInicio.AddMinutes(60 - tempoServico.Minutes);
        //        }
        //        else
        //        {
        //            dataInicio = dataInicio.AddMinutes(tempoServico.Minutes);
        //        }
        //        tempoServico = tempoServico.Subtract(new TimeSpan(0, tempoServico.Minutes, 0));
        //    }

        //    previsao = dataInicio.AddHours(tempoServico.Hours);
        //    previsao = previsao.AddMinutes(tempoServico.Minutes);

        //    return previsao;
        //}

        //public List<ServicoModel> RecuperarServicos(int idOrdemServico)
        //{
        //    List<ServicoModel> list = new List<ServicoModel>();
        //    string command = "SELECT S.DESCRICAO, D.QUANTIDADE, D.TEMPO_PREVISTO, D.DATA_INICIO_SERVICO, D.DATA_FIM_SERVICO, D.APROVADO, S.CUSTO_HORA " +
        //        "FROM DETALHE_OS D " +
        //        "INNER JOIN SERVICO S " +
        //        "ON D.ID_SERVICO = S.ID_SERVICO " +
        //        $"WHERE D.ORDER_ID = {idOrdemServico}";

        //    DAL dal = new DAL();
        //    DataTable dt = dal.GetData(command);

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        string descricao = dt.Rows[i]["DESCRICAO"].ToString();
        //        int quantidade = int.Parse(dt.Rows[i]["QUANTIDADE"].ToString());
        //        TimeSpan tempoPrevisto = TimeSpan.Parse(dt.Rows[i]["TEMPO_PREVISTO"].ToString());
        //        DateTime inicioServico = DateTime.Parse(dt.Rows[i]["DATA_INICIO_SERVICO"].ToString());
        //        DateTime fimServico = DateTime.Parse(dt.Rows[i]["DATA_FIM_SERVICO"].ToString());
        //        bool servicoAprovado = bool.Parse(dt.Rows[i]["APROVADO"].ToString());
        //        double custoHora = double.Parse(dt.Rows[i]["CUSTO_HORA"].ToString());
        //        ServicoModel servico = new ServicoModel(descricao, quantidade, tempoPrevisto, inicioServico, fimServico, servicoAprovado, custoHora);
        //        list.Add(servico);
        //    }
        //    return list;
        //}
    }
}
