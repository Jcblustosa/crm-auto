
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
        public string Login_usuario { get; set; }
        public string Nome_oficina { get; set; }

        public FuncionarioModel(int Id_funcionario, string Nome, string Funcao, string Id_oficina, string Login_usuario)
        {
            this.Id_funcionario = Id_funcionario;
            this.Nome = Nome;
            this.Funcao = Funcao;
            this.Id_oficina = Id_oficina;
            this.Login_usuario = Login_usuario;
        }

        public FuncionarioModel()
        {

        }

        public void InserirFuncionario(string nome, string funcao, string nome_oficina)
        {

            CNN cnn = new CNN();
            DataTable Id_oficina = cnn.GetData($"SELECT ID_OFICINA FROM OFICINA WHERE NOME_OFICINA = '{nome_oficina}'");

            string command = $"INSERT INTO FUNCIONARIO (NOME, FUNCAO, ID_OFICINA) " +
                $"VALUES ('{nome}', '{funcao}', '{Id_oficina.Rows[0]["Id_oficina"]}')";

           //DAL dal = new DAL();
           //dal.InsertData(command);

            CNN cnn1= new CNN();
            cnn1.InsertData(command);
        }

        public bool ValidarInsercaoFuncionario()
        {
            string command = $"SELECT NOME, FUNCAO " +
                $"FROM FUNCIONARIO " +
                $"WHERE NOME = '{Nome}' AND FUNCAO = '{Funcao}'";

            //DAL dal = new DAL();
            //DataTable dt = dal.GetData(command);

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    //Cria um usuario para o funcionário inserido no método anterior
                    CNN cnn1 = new CNN();
                    DataTable Id_funcionario = cnn1.GetData($"SELECT ID_FUNCIONARIO FROM FUNCIONARIO WHERE NOME = '{Nome}' AND FUNCAO = '{Funcao}'");

                    string command2 = $"INSERT INTO USUARIO (ID_FUNCIONARIO, LOGIN_USUARIO, SENHA_USUARIO, CLIENTE_OU_FUNCIONARIO)" +
                    $"VALUES ('{Id_funcionario.Rows[0]["Id_funcionario"]}','{Nome.Replace(" ", string.Empty).ToLower()}@oficina.com.br', 'ad123', 'F')";

                    //DAL dal = new DAL();
                    //dal.InsertData(command);

                    CNN cnn2 = new CNN();
                    cnn.InsertData(command2);

                    return true;
                }
            }
            return false;
        }

        public List<FuncionarioModel> BuscarFuncionarios()
        {
            ArrayList<FuncionarioModel> funcionarios = new ArrayList<FuncionarioModel>();

            string command = $"SELECT F.ID_FUNCIONARIO, F.NOME, F.FUNCAO, O.NOME_OFICINA AS ID_OFICINA, U.LOGIN_USUARIO " +
                $"FROM FUNCIONARIO F " +
                $"INNER JOIN OFICINA O ON F.ID_OFICINA = O.ID_OFICINA " +
                $"INNER JOIN USUARIO U ON F.ID_FUNCIONARIO = U.ID_FUNCIONARIO " +
                $"ORDER BY F.NOME";

            //DAL dal = new DAL();
            //DataTable dt = dal.GetData(command);

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                FuncionarioModel funcionario = new FuncionarioModel(int.Parse(dt.Rows[i]["Id_funcionario"].ToString()), 
                    dt.Rows[i]["Nome"].ToString(), 
                    dt.Rows[i]["Funcao"].ToString(), 
                    dt.Rows[i]["Id_oficina"].ToString(), 
                    dt.Rows[i]["Login_usuario"].ToString());

                funcionarios.Add(funcionario);
            }

            return funcionarios;
        }

        public void AlterarFuncionario(string nome, string funcao, string id_oficina)
        {
            string command = $"UPDATE FUNCIONARIO " +
                $"SET NOME = '{nome}', FUNCAO = '{funcao}' , ID_OFICINA = '{id_oficina}' " +
                $"WHERE NOME = '{nome}'";

            //DAL dal = new DAL();
            //dal.InsertData(command);

            CNN cnn = new CNN();
            cnn.InsertData(command);
        }

        public void ExcluirFuncionario(string nome, string funcao)
        {

            //Exclui o usuário (necessário excluir antes porque o id_funcionario é chave estrangeira na tabela Usuario)
            string command = $"DELETE FROM USUARIO " +
                $"WHERE ID_FUNCIONARIO IN (SELECT ID_FUNCIONARIO FROM FUNCIONARIO WHERE NOME = '{nome}')";

            //Exclui o funcionário
            string command2 = $"DELETE FROM FUNCIONARIO " +
                $"WHERE NOME = '{nome}'";


            //DAL dal = new DAL();
            //dal.InsertData(command);

            CNN cnn = new CNN();
            cnn.InsertData(command);

            CNN cnn2 = new CNN();
            cnn2.InsertData(command2);
        }
    }
}
