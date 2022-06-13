using CRM_Auto.Util;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Models
{
    public class ClienteVeiculo
    {
        public int Id_Cliente_Veiculo { get; set; }
        public string Placa_modelo { get; set; }
        public string Modelo_carro { get; set; }
        public string Ano_modelo { get; set; }
        public string Cor { get; set; }

        public List<ClienteVeiculo> ListarVeiculoCliente(string idCnpj)
        {
            List<ClienteVeiculo> veiculos = new List<ClienteVeiculo>();
            string command = $"SELECT V.PLACA_VEICULO, MC.NOME_MODELO, V.ANO_MODELO, V.COR " +
                                    $"FROM CLIENTE_VEICULO CV INNER JOIN VEICULO V ON CV.ID_VEICULO = V.ID_VEICULO " +
                                        $"INNER JOIN CLIENTE C ON CV.ID_CLIENTE = C.ID_CLIENTE " +
                                        $"INNER JOIN MODELO_CARRO MC ON V.ID_MODELO = MC.ID_MODELO " +
                                    $"WHERE C.CNPJ_CPF = '{idCnpj};";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClienteVeiculo veiculo = new ClienteVeiculo();
                veiculo.Placa_modelo = dt.Rows[i]["PLACA_VEICULO"].ToString();
                veiculo.Modelo_carro = dt.Rows[i]["NOME_MODELO"].ToString();
                veiculo.Ano_modelo = dt.Rows[i]["ANO_MODELO"].ToString();
                veiculo.Cor = dt.Rows[i]["COR"].ToString();
            }

            return veiculos;
        }
    }
}
