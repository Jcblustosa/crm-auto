using System;
using System.Data;
using CRM_Auto.Util;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO;

namespace CRM_Auto.Models
{
    public class ClienteModel
    {
        public int Id_cliente { get; set; }
        public string Cnpj_cpf { get; set; }
        public string Nome_cliente { get; set; }
        public char Cnpj_ou_cpf { get; set; }
        public string Apelido { get; set; }
        public string Data_nascimento { get; set; }
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

        // para cadastro de veículo
        public int IdVeiculo { get; set; }
        [Display(Name = "Modelo")]
        public int IdModelo { get; set; }
        public string Placa { get; set; }
        public string Motorizacao { get; set; }
        public string AnoFabricacao{ get; set; }
        public string AnoModelo { get; set; }
        public string Renavan { get; set; }
        public Cor Cor { get; set; }

        public int IdMarca { get; set; }
        public string MarcaNome { get; set; }


        public ClienteModel(int Id_cliente, string Cnpj_cpf, string Nome_cliente, char Cnpj_ou_cpf, string Apelido,
                            string Data_nascimento, DateTime Data_cadastro,string Email_nf, string Cep,
                            string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, string Estado,
                            string Telefone, string Celular)
        {
            this.Id_cliente = Id_cliente;
            this.Cnpj_cpf = Cnpj_cpf;
            this.Nome_cliente = Nome_cliente;
            this.Cnpj_ou_cpf = Cnpj_ou_cpf;
            this.Apelido = Apelido;
            this.Data_nascimento = Data_nascimento;
            this.Data_cadastro = Data_cadastro;
            this.Email_nf = Email_nf;
            this.Cep = Cep;
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.Telefone = Telefone;
            this.Celular = Celular;
        }

        public ClienteModel(string Cnpj_cpf)
        {
            this.Cnpj_cpf = Cnpj_cpf;
        }

        public ClienteModel(int IdMarca, string MarcaNome)
        {
            this.IdMarca = IdMarca;
            this.MarcaNome = MarcaNome;
        }

        public ClienteModel()
        {

        }

        

        // private List<ClienteModel> ExecuteQuery(string command)
        // {
        //     List<ClienteModel> marcas = new List<ClienteModel>();

        //     CNN cnn = new CNN();
        //     DataTable dt = cnn.GetData(command);

        //     foreach (DataRow dr in dt.Rows)
        //     {
        //         ClienteModel marca = new ClienteModel();
        //         marca.IdMarca = int.Parse(dr["ID_MARCA"].ToString());
        //         marca.MarcaNome = dr["NOME_MARCA"].ToString();
        //         marcas.Add(marca);
        //     }

        //     return marcas;
        // }

        // public List<ClienteModel> Marcas()
        // {
        //     return this.ExecuteQuery("SELECT * FROM MARCA_CARRO;");
        // }

        public void CadNovoVeiculoCliente()
        {
            string command = "INSERT INTO VEICULO " +
                                "(ID_MODELO, PLACA_VEICULO, MOTORIZACAO, ANO_FABRICACAO, ANO_MODELO, RENAVAN, COR) " +
                                $"VALUES({IdModelo}, '{Placa}', '{Motorizacao}', '{AnoFabricacao}', '{AnoModelo}', '{Renavan}', '{(Cor)Cor}');";

            CNN dal = new CNN();
            dal.UpdateData(command);
        }   

        public void CadastroCliente()
        {
            //Id_usuario_cad = 1;

            Data_cadastro = DateTime.Now;

            string command = $"INSERT INTO [dbo].[CLIENTE] " +
                                     $"([CNPJ_CPF] " +
                                     $",[NOME_CLIENTE] " +
                                     $",[CNPJ_OU_CPF] " +
                                     $",[APELIDO] " +
                                     $",[DATA_NASCIMENTO] " +
                                     $",[DATA_CADASTRO] " +
                                     //$",[ID_USUARIO_CAD] " +
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
                                    $"'{Cnpj_cpf}', " +
                                    $"'{Nome_cliente}', " +
                                    $"'{Cnpj_ou_cpf}', " +
                                    $"'{Apelido}', " +
                                    $"'{Data_nascimento}', " +
                                    $"'{Data_cadastro}', " +
                                    //$"'{Id_usuario_cad}', " +
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

            CNN cnn = new CNN();
            cnn.InsertData(command);
        }

        public void SalvaRegistroCliente()
        {
            string command = $"SELECT ID_CLIENTE FROM CLIENTE WHERE CNPJ_CPJ = '{Cnpj_cpf}';";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);
            
            if (dt.Rows.Count > 0)
            {
                command = "UPDATE CLIENTE " +
                                $"SET " +
                                    $"CNPJ_CPF = '{Cnpj_cpf}'" +
                                    $"NOME_CLIENTE = '{Nome_cliente}'" +
                                    $"CNPJ_OU_CPF = '{Cnpj_ou_cpf}'" +
                                    $"APELIDO = '{Apelido}'" +
                                    $"DATA_NASCIMENTO = '{Data_nascimento}'" +
                                    $"DATA_CADASTRO = '{Data_cadastro}'" +
                                    // $"ID_USUARIO_CAD = '{Id_usuario_cad}'" +
                                    $"EMAIL_NF = '{Email_nf}'" +
                                    $"CEP = '{Cep}'" +
                                    $"LOGRADOURO = '{Logradouro}'" +
                                    $"NUMERO = '{Numero}'" +
                                    $"COMPLEMENTO = '{Complemento}'" +
                                    $"BAIRRO = '{Bairro}'" +
                                    $"CIDADE = '{Cidade}'" +
                                    $"TELEFONE = '{Telefone}'" +
                                    $"CELULAR = '{Celular}'" +
                                    $"ESTADO = '{Estado}'" +
                                $"WHERE ID_CLIENTE = '{int.Parse(dt.Rows[0]["ID_CLIENTE"].ToString())}>;";

                cnn.UpdateData(command);
                cnn.desconectar();
            }
            else
            {
                Data_cadastro = DateTime.Now;
                command = $"INSERT INTO [dbo].[CLIENTE] " +
                                    $"([CNPJ_CPF] " +
                                    $",[NOME_CLIENTE] " +
                                    $",[CNPJ_OU_CPF] " +
                                    $",[APELIDO] " +
                                    $",[DATA_NASCIMENTO] " +
                                    $",[DATA_CADASTRO] " +
                                    //$",[ID_USUARIO_CAD] " +
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
                                    $"'{Cnpj_cpf}', " +
                                    $"'{Nome_cliente}', " +
                                    $"'{Cnpj_ou_cpf}', " +
                                    $"'{Apelido}', " +
                                    $"'{Data_nascimento}', " +
                                    $"'{Data_cadastro}', " +
                                    //$"'{Id_usuario_cad}', " +
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

                cnn.UpdateData(command);
                cnn.desconectar();
            }
        }

        public List<ClienteModel> ListarClientes()
        {
            List<ClienteModel> clientes = new List<ClienteModel>();

            string comando = $"SELECT ID_CLIENTE " +
                                    $",CNPJ_CPF " +
                                    $",NOME_CLIENTE " +
                                    $",CNPJ_OU_CPF " +
                                    $",APELIDO " +
                                    $",DATA_NASCIMENTO " +
                                    $",DATA_CADASTRO " +
                                    $",EMAIL_NF " +
                                    $",CEP " +
                                    $",LOGRADOURO " +
                                    $",NUMERO " +
                                    $",COMPLEMENTO " +
                                    $",BAIRRO " +
                                    $",CIDADE " +
                                    $",ESTADO " +
                                    $",TELEFONE " +
                                    $",CELULAR " +
                                $"FROM CLIENTE;";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClienteModel cliente = new ClienteModel(
                    int.Parse(dt.Rows[i]["ID_CLIENTE"].ToString()),
                    dt.Rows[i]["CNPJ_CPF"].ToString(),
                    dt.Rows[i]["NOME_CLIENTE"].ToString(),
                    char.Parse(dt.Rows[i]["CNPJ_OU_CPF"].ToString()),
                    dt.Rows[i]["APELIDO"].ToString(),
                    dt.Rows[i]["DATA_NASCIMENTO"].ToString(),
                    DateTime.Parse(dt.Rows[i]["DATA_CADASTRO"].ToString()),
                    dt.Rows[i]["EMAIL_NF"].ToString(),
                    dt.Rows[i]["CEP"].ToString(),
                    dt.Rows[i]["LOGRADOURO"].ToString(),
                    dt.Rows[i]["NUMERO"].ToString(),
                    dt.Rows[i]["COMPLEMENTO"].ToString(),
                    dt.Rows[i]["BAIRRO"].ToString(),
                    dt.Rows[i]["CIDADE"].ToString(),
                    dt.Rows[i]["ESTADO"].ToString(),
                    dt.Rows[i]["TELEFONE"].ToString(),
                    dt.Rows[i]["CELULAR"].ToString());
                
                clientes.Add(cliente);
            }
            return clientes;
        }

        public List<ClienteModel> ListarMarcaVeiculo()
        {
            string command = "SELECT ID_MARCA, NOME_MARCA FROM MARCA_CARRO;";

            List<ClienteModel> marcas = new List<ClienteModel>();

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            // foreach (DataRow dr in dt.Rows)
            // {
            //     ClienteModel marca = new ClienteModel();
            //     marca.IdMarca = int.Parse(dr["ID_MARCA"].ToString());
            //     marca.MarcaNome = dr["NOME_MARCA"].ToString();
            //     marcas.Add(marca);
            // }

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ClienteModel marca = new ClienteModel();
                marca.IdMarca = int.Parse(dt.Rows[i]["ID_MARCA"].ToString());
                marca.MarcaNome = dt.Rows[i]["NOME_MARCA"].ToString();
                marcas.Add(marca);
            }

            return marcas;
        }

        public void ExcluirRegistroCliente(ClienteModel cliente)
        {
            string comando = $"SELECT ID_SERVICO FROM ORDEM SERVICO WHERE ID_CLIENTE = SELECT ID_CLIENTE FROM CLIENTE WHERE CNPJ_CPF = '{cliente.Cnpj_cpf}";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(comando);

            if (dt.Rows.Count == 0)
            {
                comando = $"DELETE CLIENTE_VEICULO WHERE ID_CLIENTE = '{cliente.Id_cliente}';";
                cnn.UpdateData(comando);
                
                comando = $"DELETE CLIENTE WHERE CNPJ_CPF = '{cliente.Cnpj_cpf}';";
                cnn.UpdateData(comando);
            }
            else
            {
                comando = $"UPDATE CLIENTE SET EXCLUIDO = 1 WHERE CNPJ_CPF = '{cliente.Cnpj_cpf}';";
                cnn.UpdateData(comando);
            }
            cnn.desconectar();
        }
    }
}
