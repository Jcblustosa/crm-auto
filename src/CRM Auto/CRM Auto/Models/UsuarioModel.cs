using CRM_Auto.Util;
using System.Data;

namespace CRM_Auto.Models
{
    public class UsuarioModel
    {
        public int Id_usuario { get; set; }
        public int Id_funcionario { get; set; }
        public string Login_usuario { get; set; }
        public string Senha_usuario { get; set; }

        public bool ValidarLogin()
        {
            string command = $"SELECT ID_USUARIO, ID_FUNCIONARIO " +
                            $"FROM USUARIO " +
                            $"WHERE LOGIN_USUARIO = '{Login_usuario}' AND " +
                            $"SENHA_USUARIO = '{Senha_usuario}'";

            //DAL dal = new DAL();
            CNN dal = new CNN();
            DataTable dt = dal.GetData(command);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public string[] NomeEId(string login, string senha)
        {
            string command = "SELECT C.ID_CLIENTE, C.NOME_CLIENTE " +
                "FROM CLIENTE C " +
                "INNER JOIN USUARIO U " +
                "ON U.ID_USUARIO = C.ID_USUARIO_CAD " +
                $"WHERE U.LOGIN_USUARIO = '{login}' AND U.SENHA_USUARIO = '{senha}';";

            string[] nomeEId = new string[2];

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            try
            {
                nomeEId[0] = dt.Rows[0]["NOME_CLIENTE"].ToString();
                nomeEId[1] = dt.Rows[0]["ID_CLIENTE"].ToString();
            }
            catch { }

            return nomeEId;
        }
    }
}
