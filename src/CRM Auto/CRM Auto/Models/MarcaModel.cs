using CRM_Auto.Util;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Models
{
    public class MarcaModel
    {
        public int IdMarca { get; set; }
        public string MarcaNome { get; set; }

        private List<MarcaModel> ExecuteQuery(string command)
        {
            List<MarcaModel> marcas = new List<MarcaModel>();

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            foreach (DataRow dr in dt.Rows)
            {
                MarcaModel marca = new MarcaModel();
                marca.IdMarca = int.Parse(dr["ID_MARCA"].ToString());
                marca.MarcaNome = dr["NOME_MARCA"].ToString();
                marcas.Add(marca);
            }

            return marcas;
        }

        public List<MarcaModel> Marcas()
        {
            return this.ExecuteQuery("SELECT * FROM MARCA_CARRO;");
        }
    }
}
