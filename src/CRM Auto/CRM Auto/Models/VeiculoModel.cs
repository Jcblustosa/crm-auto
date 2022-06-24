using CRM_Auto.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CRM_Auto.Models
{
    public class VeiculoModel
    {

        public int IdVeiculo { get; set; }
        [Display(Name = "Modelo")]
        public int IdModelo { get; set; }
        public string Placa { get; set; }
        public string Motorizacao { get; set; }
        public string AnoFabricacao{ get; set; }
        public string AnoModelo { get; set; }
        public string Renavan { get; set; }
        public Cor Cor { get; set; }


        public void CadastroVeiculo()
        {
            string command = $"INSERT INTO VEICULO (ID_MODELO, PLACA_VEICULO, MOTORIZACAO, ANO_FABRICACAO, ANO_MODELO, RENAVAN, COR) VALUES({IdModelo}, '{Placa}', '{Motorizacao}', '{AnoFabricacao}', '{AnoModelo}', '{Renavan}', '{(Cor)Cor}');";

            CNN dal = new CNN();
            dal.InsertData(command);
        }       
    }

    public enum Cor
    {
        AMARELO,
        AZUL,
        BEGE,
        BRANCA,
        CINZA,
        DOURADA,
        GRENA,
        LARANJA,
        MARROM,
        PRATA,
        PRETA,
        ROSA,
        ROXA,
        VERDE,
        VERMELHA,
        FANTASIA,
    }
}
