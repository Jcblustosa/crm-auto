
using CRM_Auto.Util;
using System.Data;
using System.Data.SqlClient;

namespace CRM_Auto.Models
{
    public class FuncionarioModel
    {
        public int Id_funcionario { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public int Id_oficina { get; set; }


        public void InserirCadastro(string nome, string funcao, int id_oficina)
        {
            string command = $"INSERT INTO FUNCIONARIO (NOME, FUNCAO, ID_OFICINA) VALUES ('{nome}', '{funcao}', '{id_oficina}')";

            DAL dal = new DAL();
            dal.InsertData(command);
        }

        //public bool ValidarInsercaoFuncionario()
        //{
        //    string command = $"SELECT NOME, FUNCAO FROM FUNCIONARIO WHERE NOME = '{Nome}' AND FUNCAO = '{Funcao}'";

        //    DAL dal = new DAL();
        //    DataTable dt = dal.GetData(command);
        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count == 1)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
