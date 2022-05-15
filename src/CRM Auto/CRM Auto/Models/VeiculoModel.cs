using CRM_Auto.Util;

namespace CRM_Auto.Models
{
    public class VeiculoModel
    {

        // Tabela Modelo_Carro

        public string Nome_Modelo{ get; set; }

        // Tabela Veiculo

        public int Id_Veiculo_Cliente { get; set; }
        public int Id_Modelo { get; set; }
        public string Motorizacao { get; set; }
        public string Ano_Fabricacao { get; set; }
        public string Ano_Modelo { get; set; }

        public void CadastroVeiculo()
        {
            string command = $"INSERT INTO VEICULO VALUES ('{Id_Modelo}', '{Motorizacao}', '{Ano_Fabricacao}', '{Ano_Modelo}')";

            DAL dal = new DAL();
            dal.InsertData(command);
        }
    }
}
