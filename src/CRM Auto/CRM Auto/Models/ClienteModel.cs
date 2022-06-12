using System;
using System.Data;
using CRM_Auto.Util;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CRM_Auto.Models
{
    public class ClienteModel
    {
        public bool Tipo_fisica { get; set; }
        public bool Tipo_juridica { get; set; }
        
        public List<string> Tipo_pessoa;
        public string Cnpj_cpf { get; set; }
        public string Nome_cliente { get; set; }
        public char Cnpj_ou_cpf { get; set; }
        public string Apelido { get; set; }
        public DateTime Data_nascimento { get; set; }
        public DateTime Data_cadastro { get; set; }
        public int Id_usuario_cad { get; set; }
        public string Email_nf { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        // public ClienteModel(bool Tipo_fisica, bool Tipo_juridica, string Cnpj_cpf, string Nome_cliente, char Cnpj_ou_cpf, string Apelido,
        //                     DateTime Data_nascimento, DateTime Data_cadastro, int Id_usuario_cad, string Email_nf, string Cep,
        //                     string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, string Estado,
        //                     string Telefone, string Celular)
        // {
        //     this.Tipo_fisica = Tipo_fisica;
        //     this.Tipo_juridica = Tipo_juridica;
        //     this.Cnpj_cpf = Cnpj_cpf;
        //     this.Nome_cliente = Nome_cliente;
        //     this.Cnpj_ou_cpf = Cnpj_ou_cpf;
        //     this.Apelido = Apelido;
        //     this.Data_nascimento = Data_nascimento;
        //     this.Data_cadastro = Data_cadastro;
        //     this.Id_usuario_cad = Id_usuario_cad;
        //     this.Email_nf = Email_nf;
        //     this.Cep = Cep;
        //     this.Logradouro = Logradouro;
        //     this.Numero = Numero;
        //     this.Complemento = Complemento;
        //     this.Bairro = Bairro;
        //     this.Cidade = Cidade;
        //     this.Estado = Estado;
        //     this.Telefone = Telefone;
        //     this.Celular = Celular;
        // }

        // public ClienteModel{

        // }

        public void CadastroCliente()
        {
            Id_usuario_cad = 1;

            List<string> TipoPessoa = new List<string>();

            TipoPessoa = Tipo_pessoa;

            foreach(var tp in TipoPessoa){
                if (tp != null){
                    Cnpj_ou_cpf = Convert.ToChar(tp);
                }
            }

            int length = Cnpj_cpf.Length;

            if (length == 11)
            {
                Cnpj_ou_cpf = 'F';
            }
            else if (length == 14)
            {
                Cnpj_ou_cpf = 'J';
            }

            Data_cadastro = DateTime.Now;

            string command = $"INSERT INTO [dbo].[CLIENTE] " +
                                     $"([CNPJ_CPF] " +
                                     $",[NOME_CLIENTE] " +
                                     $",[CNPJ_OU_CPF] " +
                                     $",[APELIDO] " +
                                     $",[DATA_NASCIMENTO] " +
                                     $",[DATA_CADASTRO] " +
                                     $",[ID_USUARIO_CAD] " +
                                     $",[EMAIL_NF] " +
                                     $",[CEP] " +
                                     $",[LOGRADOURO] " +
                                     $",[NUMERO] " +
                                     $",[COMPLEMENTO] " +
                                     $",[BAIRRO] " +
                                     $",[CIDADE] " +
                                     $",[ESTADO] " +
                                     $",[TELEFONE] " +
                                     $",[CELULAR]) " +
                                $"VALUES ('{Cnpj_cpf}', " +
                                    $"'{Nome_cliente}', " +
                                    $"'{Cnpj_ou_cpf}', " +
                                    $"'{Apelido}', " +
                                    $"'{Data_nascimento}', " +
                                    $"'{Data_cadastro}', " +
                                    $"'{Id_usuario_cad}', " +
                                    $"'{Email_nf}', " +
                                    $"'{Cep}', " +
                                    $"'{Logradouro}', " +
                                    $"'{Numero}', " +
                                    $"'{Complemento}', " +
                                    $"'{Bairro}', " +
                                    $"'{Cidade}', " +
                                    $"'{Estado}', " +
                                    $"'{Telefone}', " +
                                    $"'{Celular}')";

            DAL dal = new DAL();
            dal.InsertData(command);
        }

        // public bool ValidarInsercaoCliente()
        // {
        //     string command = $"SELECT NOME, FUNCAO " +
        //                         $"FROM FUNCIONARIO " +
        //                         $"WHERE NOME = '{Nome}' AND FUNCAO = '{Funcao}'";

        //     //DAL dal = new DAL();
        //     //DataTable dt = dal.GetData(command);

        //     CNN cnn = new CNN();
        //     DataTable dt = cnn.GetData(command);

        //     if (dt != null)
        //     {
        //         if (dt.Rows.Count >= 1)
        //         {
        //             //Cria um usuario para o funcionário inserido no método anterior
        //             CNN cnn1 = new CNN();
        //             DataTable Id_funcionario = cnn1.GetData($"SELECT ID_FUNCIONARIO FROM FUNCIONARIO WHERE NOME = '{Nome}' AND FUNCAO = '{Funcao}'");

        //             string command2 = $"INSERT INTO USUARIO (ID_FUNCIONARIO, LOGIN_USUARIO, SENHA_USUARIO, CLIENTE_OU_FUNCIONARIO)" +
        //             $"VALUES ('{Id_funcionario.Rows[0]["Id_funcionario"]}','{Nome.Replace(" ", string.Empty).ToLower()}@oficina.com.br', 'ad123', 'F')";

        //             //DAL dal = new DAL();
        //             //dal.InsertData(command);

        //             CNN cnn2 = new CNN();
        //             cnn.InsertData(command2);

        //             return true;
        //         }
        //     }
        //     return false;
        // }

        // public List<ClienteModel> BuscarVeiculoCliente()
        // {
        //     ArrayList<FuncionarioModel> funcionarios = new ArrayList<FuncionarioModel>();

        //     string command = $"SELECT F.ID_FUNCIONARIO, F.NOME, F.FUNCAO, O.NOME_OFICINA AS ID_OFICINA, U.LOGIN_USUARIO " +
        //         $"FROM FUNCIONARIO F " +
        //         $"INNER JOIN OFICINA O ON F.ID_OFICINA = O.ID_OFICINA " +
        //         $"INNER JOIN USUARIO U ON F.ID_FUNCIONARIO = U.ID_FUNCIONARIO " +
        //         $"ORDER BY F.NOME";

        //     //DAL dal = new DAL();
        //     //DataTable dt = dal.GetData(command);

        //     CNN cnn = new CNN();
        //     DataTable dt = cnn.GetData(command);

        //     for (int i = 0; i < dt.Rows.Count; i++)
        //     {
        //         FuncionarioModel funcionario = new FuncionarioModel(int.Parse(dt.Rows[i]["Id_funcionario"].ToString()), 
        //             dt.Rows[i]["Nome"].ToString(), 
        //             dt.Rows[i]["Funcao"].ToString(), 
        //             dt.Rows[i]["Id_oficina"].ToString(), 
        //             dt.Rows[i]["Login_usuario"].ToString());

        //         funcionarios.Add(funcionario);
        //     }

        //     return funcionarios;
        // }

        // public void AlterarCliente(string nome, string funcao, string nome_oficina)
        // {
        //     CNN cnn = new CNN();
        //     DataTable Id_oficina = cnn.GetData($"SELECT ID_OFICINA FROM OFICINA WHERE NOME_OFICINA = '{nome_oficina}'");

        //     string command = $"UPDATE FUNCIONARIO " +
        //         $"SET NOME = '{nome}', FUNCAO = '{funcao}' , ID_OFICINA = '{Id_oficina.Rows[0]["Id_oficina"]}' " +
        //         $"WHERE NOME = '{nome}'";

        //     //DAL dal = new DAL();
        //     //dal.InsertData(command);

        //     CNN cnn1 = new CNN();
        //     cnn1.InsertData(command);
        // }

        // public void ExcluirCliente(string nome, string funcao)
        // {

        //     //Exclui o usuário (necessário excluir antes porque o id_funcionario é chave estrangeira na tabela Usuario)
        //     string command = $"DELETE FROM USUARIO " +
        //         $"WHERE ID_FUNCIONARIO IN (SELECT ID_FUNCIONARIO FROM FUNCIONARIO WHERE NOME = '{nome}')";

        //     //Exclui o funcionário
        //     string command2 = $"DELETE FROM FUNCIONARIO " +
        //         $"WHERE NOME = '{nome}' AND FUNCAO = '{funcao}'";


        //     //DAL dal = new DAL();
        //     //dal.InsertData(command);

        //     CNN cnn = new CNN();
        //     cnn.InsertData(command);

        //     CNN cnn2 = new CNN();
        //     cnn2.InsertData(command2);
        // }


    }
}
