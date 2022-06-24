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
        public string Origem_usuario { get; set; }

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

        public string[] NomeEIdFuncionario(string login, string senha)
        {
            //string command = "SELECT F.NOME, F.ID_FUNCIONARIO, F.ID_OFICINA, U.ID_USUARIO, U.CLIENTE_OU_FUNCIONARIO " +
            //                    "FROM FUNCIONARIO F INNER JOIN USUARIO U ON F.ID_FUNCIONARIO = U.ID_FUNCIONARIO " +
            //                    $"WHERE U.LOGIN_USUARIO = '{login}' AND U.SENHA_USUARIO = '{senha}';";

            string command = "SELECT F.NOME, F.ID_FUNCIONARIO, F.ID_OFICINA, U.ID_USUARIO, " +
                                    "U.CLIENTE_OU_FUNCIONARIO, C.NOME_CLIENTE " +
                                "FROM FUNCIONARIO F RIGHT JOIN USUARIO U ON F.ID_FUNCIONARIO = U.ID_FUNCIONARIO " +
                                    "RIGHT JOIN CLIENTE C ON C.ID_CLIENTE = U.ID_CLIENTE " +
                                $"WHERE U.LOGIN_USUARIO = '{login}' AND U.SENHA_USUARIO = '{senha}';";

            string[] nomeEIdFuncionario = new string[6];

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            try
            {
                nomeEIdFuncionario[0] = dt.Rows[0]["NOME"].ToString();
                nomeEIdFuncionario[1] = dt.Rows[0]["ID_FUNCIONARIO"].ToString();
                nomeEIdFuncionario[2] = dt.Rows[0]["ID_OFICINA"].ToString();
                nomeEIdFuncionario[3] = dt.Rows[0]["ID_USUARIO"].ToString();
                nomeEIdFuncionario[4] = dt.Rows[0]["CLIENTE_OU_FUNCIONARIO"].ToString();
                nomeEIdFuncionario[5] = dt.Rows[0]["NOME_CLIENTE"].ToString();
            }
            catch { }

            return nomeEIdFuncionario;
        }
    }
}
