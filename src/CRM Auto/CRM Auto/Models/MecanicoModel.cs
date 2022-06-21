using CRM_Auto.Util;
using System.Collections.Generic;
using System.Data;

namespace CRM_Auto.Models
{
    public class MecanicoModel
    {
        public int IdMecanico { get; set; }
        public string Nome { get; set; }

        public List<MecanicoModel> ListarMecanicos(string idOficina)
        {
            List<MecanicoModel> mecanicos = new List<MecanicoModel>();
            string command = "SELECT ID_FUNCIONARIO, NOME FROM FUNCIONARIO " +
                            $"WHERE FUNCAO = 'Mecânico' AND ID_OFICINA = '{idOficina}'";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MecanicoModel mecanico = new MecanicoModel();
                mecanico.IdMecanico = int.Parse(dt.Rows[i]["ID_FUNCIONARIO"].ToString());
                mecanico.Nome = dt.Rows[i]["NOME"].ToString();
                mecanicos.Add(mecanico);
            }

            return mecanicos;
        }
    }
}
