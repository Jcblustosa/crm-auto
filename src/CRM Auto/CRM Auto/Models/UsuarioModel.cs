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

            DAL dal = new DAL();
            //CNN dal = new CNN();
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
    }
}
