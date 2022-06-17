using CRM_Auto.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CRM_Auto.Models
{
    public class SucessoModel
    {
        public string IdOrdemServico { get; set; }
        public string NomeCliente { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataOrdem { get; set; }
        public string CelularCliente { get; set; }
        public string PlacaVeiculo { get; set; }

        public List<SucessoModel> BuscarDados(string idOficina)
        {
            List<SucessoModel> listaOs = new List<SucessoModel>();

            string command = "SELECT OS.ID_ORDEM_SERVICO, C.NOME_CLIENTE, OS.DATA_ORDEM, C.CELULAR, V.PLACA_VEICULO " +
                "FROM ORDEM_SERVICO OS " +
                "INNER JOIN CLIENTE C " +
                "ON OS.ID_CLIENTE = C.ID_CLIENTE " +
                "INNER JOIN CLIENTE_VEICULO CV " +
                "ON OS.ID_VEICULO = CV.ID_CLI_VEICULO " +
                "INNER JOIN VEICULO V " +
                "ON CV.ID_VEICULO = V.ID_VEICULO " +
                $"WHERE OS.ID_OFICINA = {idOficina};";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SucessoModel sucesso = new SucessoModel();
                sucesso.IdOrdemServico = dt.Rows[i]["ID_ORDEM_SERVICO"].ToString();
                sucesso.NomeCliente = dt.Rows[i]["NOME_CLIENTE"].ToString();
                sucesso.DataOrdem = DateTime.Parse(dt.Rows[i]["DATA_ORDEM"].ToString());
                sucesso.CelularCliente = dt.Rows[i]["CELULAR"].ToString();
                sucesso.PlacaVeiculo = dt.Rows[i]["PLACA_VEICULO"].ToString();
                listaOs.Add(sucesso);
            }

            return listaOs;
        }
    }
}
