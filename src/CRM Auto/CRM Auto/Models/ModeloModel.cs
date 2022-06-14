using CRM_Auto.Util;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Models
{
    public class ModeloModel
    {
        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public string NomeModelo { get; set; }

        private List<ModeloModel> ExecuteQuery(string command)
        {
            List<ModeloModel> modelos = new List<ModeloModel>();

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            foreach (DataRow dr in dt.Rows)
            {
                ModeloModel modelo = new ModeloModel();
                modelo.IdModelo = int.Parse(dr["ID_MODELO"].ToString());
                modelo.IdMarca = int.Parse(dr["ID_MARCA"].ToString());
                modelo.NomeModelo = dr["NOME_MODELO"].ToString();
                modelos.Add(modelo);
            }

            return modelos;
        }

        public List<ModeloModel> Modelos()
        {
            return this.ExecuteQuery("SELECT * FROM MODELO_CARRO;");
        }

        public List<ModeloModel> Modelos(int marcaId)
        {
            return this.ExecuteQuery($"SELECT * FROM MODELO_CARRO WHERE ID_MARCA = {marcaId};");
        }
    }
}
