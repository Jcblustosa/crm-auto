
using CRM_Auto.Util;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CRM_Auto.Models
{
    public class FuncionarioModel
    {
        public int Id_funcionario { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Id_oficina { get; set; }

        public FuncionarioModel(int Id_funcionario, string Nome, string Funcao, string Id_oficina)
        {
            this.Id_funcionario = Id_funcionario;
            this.Nome = Nome;
            this.Funcao = Funcao;
            this.Id_oficina = Id_oficina;
        }

        public FuncionarioModel()
        {

        }

        public void InserirFuncionario(string nome, string funcao, string id_oficina)
        {
            string command = $"INSERT INTO FUNCIONARIO (NOME, FUNCAO, ID_OFICINA) VALUES ('{nome}', '{funcao}', '{id_oficina}')";

           //DAL dal = new DAL();
           //dal.InsertData(command);

            CNN cnn = new CNN();
            cnn.InsertData(command);
        }

        public bool ValidarInsercaoFuncionario()
        {
            string command = $"SELECT NOME, FUNCAO FROM FUNCIONARIO WHERE NOME = '{Nome}' AND FUNCAO = '{Funcao}'";

            //DAL dal = new DAL();
            //DataTable dt = dal.GetData(command);

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public List<FuncionarioModel> BuscarFuncionarios()
        {
            ArrayList<FuncionarioModel> funcionarios = new ArrayList<FuncionarioModel>();

            string command = $"SELECT F.ID_FUNCIONARIO, F.NOME, F.FUNCAO, O.NOME_OFICINA AS ID_OFICINA FROM FUNCIONARIO F INNER JOIN OFICINA O ON F.ID_OFICINA = O.ID_OFICINA";

            //DAL dal = new DAL();
            //DataTable dt = dal.GetData(command);

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                FuncionarioModel funcionario = new FuncionarioModel(int.Parse(dt.Rows[i]["Id_funcionario"].ToString()), dt.Rows[i]["Nome"].ToString(), dt.Rows[i]["Funcao"].ToString(), dt.Rows[i]["Id_oficina"].ToString());
                funcionarios.Add(funcionario);
            }

            return funcionarios;
        }

        public void AlterarFuncionario(string nome, string funcao, string id_oficina)
        {
            string command = $"UPDATE FUNCIONARIO SET NOME = '{nome}', FUNCAO = '{funcao}' , ID_OFICINA = '{id_oficina}' WHERE NOME = '{nome}'";

            //DAL dal = new DAL();
            //dal.InsertData(command);

            CNN cnn = new CNN();
            cnn.InsertData(command);
        }

        public void ExcluirFuncionario(string nome, string funcao, string id_oficina)
        {
            string command = $"DELETE FROM FUNCIONARIO WHERE NOME = '{nome}'";

            //DAL dal = new DAL();
            //dal.InsertData(command);

            CNN cnn = new CNN();
            cnn.InsertData(command);
        }
    }
}
