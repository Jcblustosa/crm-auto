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

        // para cadastro de veículo
        public int IdVeiculo { get; set; }
        // [Display(Name = "Modelo")]
        public int IdModelo { get; set; }
        public string NomeModelo { get; set; }
        public string Placa { get; set; }
        public string Motorizacao { get; set; }
        public string AnoFabricacao{ get; set; }
        public string AnoModelo { get; set; }
        public string Renavan { get; set; }
        public Cor Cor { get; set; }
        public string NomeCor {get; set;}
        public int Quilometragem { get; set;}

        public int IdMarca { get; set; }
        public string MarcaNome { get; set; }


        public ClienteModel(int Id_cliente, string Cnpj_cpf, string Nome_cliente, char Cnpj_ou_cpf, string Apelido,
                            DateTime Data_nascimento, DateTime Data_cadastro, string Email_nf, string Cep,
                            string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, string Estado,
                            string Telefone, string Celular, int IdVeiculo, string Placa, string Motorizacao, string AnoModelo,
                            string Renavan, string NomeCor, int Quilometragem, int IdModelo, string NomeModelo)
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
            this.IdVeiculo = IdVeiculo;
            this.Placa = Placa;
            this.Motorizacao = Motorizacao;
            this.AnoModelo = AnoModelo;
            this.Renavan = Renavan;
            this.NomeCor = NomeCor;
            this.Quilometragem = Quilometragem;
            this.IdModelo = IdModelo;
            this.NomeModelo = NomeModelo;
            NomeModelo=nomeModelo;
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

        private List<ClienteModel> ExecuteQuery(string command)
        {
            List<ClienteModel> veiculos = new List<ClienteModel>();

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(command);

            foreach (DataRow dr in dt.Rows)
            {
                ClienteModel veiculo = new ClienteModel();
                veiculo.IdVeiculo = int.Parse(dr["ID_VEICULO"].ToString());
                veiculo.Placa = dr["PLACA_VEICULO"].ToString();
                veiculo.Motorizacao = dr["MOTORIZACAO"].ToString();
                veiculo.AnoModelo = dr["ANO_MODELO"].ToString();
                veiculo.Renavan = dr["RENAVAN"].ToString();
                veiculo.NomeCor = dr["COR"].ToString();
                veiculo.Quilometragem = int.Parse(dr["QUILOMETRAGEM"].ToString());
                veiculos.Add(veiculo);
            }

            return veiculos;
        }

        public List<ClienteModel> Veiculos(int clienteID)
        {
            return this.ExecuteQuery("SELECT ID_VEICULO, PLACA_VEICULO, MOTORIZACAO, ANO_FABRICACAO, ANO_MODELO, RENAVAN, COR, QUILOMETRAGEM " +
	                                    "FROM VEICULO V INNER JOIN CLIENTE_VEICULO C ON V.ID_VEICULO = C.ID_VEICULO " +
                                        $"WHERE ID_CLIENTE = '{clienteID}';");
        }

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
            string command = "";

            CNN cnn = new CNN();

            if (Id_cliente > 0)
            {
                command = "UPDATE CLIENTE " +
                                $"SET " +
                                    //$"CNPJ_CPF = '{Cnpj_cpf}'" +
                                    $",NOME_CLIENTE = '{Nome_cliente}'" +
                                    //$",CNPJ_OU_CPF = '{Cnpj_ou_cpf}'" +
                                    $",APELIDO = '{Apelido}'" +
                                    $",DATA_NASCIMENTO = '{Data_nascimento}'" +
                                    $",DATA_CADASTRO = '{Data_cadastro}'" +
                                    // $",ID_USUARIO_CAD = " + TempData["IdUsuario"].Value + 
                                    $",EMAIL_NF = '{Email_nf}'" +
                                    $",CEP = '{Cep}'" +
                                    $",LOGRADOURO = '{Logradouro}'" +
                                    $",NUMERO = '{Numero}'" +
                                    $",COMPLEMENTO = '{Complemento}'" +
                                    $",BAIRRO = '{Bairro}'" +
                                    $",CIDADE = '{Cidade}'" +
                                    $",TELEFONE = '{Telefone}'" +
                                    $",CELULAR = '{Celular}'" +
                                    $",ESTADO = '{Estado}'" +
                                $"WHERE ID_CLIENTE = '{Id_cliente}';";

                cnn.UpdateData(command);

                command = $"SELECT C.ID_CLIENTE, CV.ID_VEICULO " +
                                "FROM CLIENTE C INNER JOIN CLIENTE_VEICULO CV ON C.ID_CLIENTE = CV.ID_CLIENTE " +
                                $"WHERE CNPJ_CPF = '{Cnpj_cpf}';";
                
                DataTable dt = cnn.GetData(command);

                if (dt.Rows.Count > 0)
                {
                    Id_cliente = int.Parse(dt.Rows[0]["ID_CLIENTE"].ToString());
                    command = "UPDATE VEICULO " +
                                $"SET PLACA_VEICULO = '{Placa}', " +
                                      $"MOTORIZACAO = '{Motorizacao}', " +
                                      $"ANO_MODELO = '{AnoModelo}',  " +
                                      $"RENAVAN = '{Renavan}',  " +
                                      $"COR = '{NomeCor}',  " +
                                      $"QUILOMETRAGEM = '{Quilometragem}' " +
                                  $"WHERE ID_VEICULO = '{IdVeiculo}'; ";

                    cnn.UpdateData(command);
                }

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

                command = "INSERT INTO VEICULO " +
                                "(ID_MODELO, PLACA_VEICULO, MOTORIZACAO, ANO_MODELO, RENAVAN, COR, QUILOMETRAGEM) " +
                              "VALUES " +
                                $"('{IdModelo}', '{Placa}', '{Motorizacao}', '{AnoModelo}', '{Renavan}', '{Cor}', '{Quilometragem}');";

                cnn.UpdateData(command);

                cnn.desconectar();
            }
        }

        public List<ClienteModel> ListarClientes()
        {
            List<ClienteModel> clientes = new List<ClienteModel>();

            string comando = "SELECT C.ID_CLIENTE, CNPJ_CPF, NOME_CLIENTE, CNPJ_OU_CPF, APELIDO, DATA_NASCIMENTO, " +
                                    "C.DATA_CADASTRO, EMAIL_NF, CEP, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, " +
                                    "CIDADE, ESTADO, TELEFONE, CELULAR, M.ID_MODELO, NOME_MODELO, PLACA_VEICULO, MOTORIZACAO, " +
                                    "ANO_MODELO, RENAVAN, COR, QUILOMETRAGEM, IFNULL(V.ID_VEICULO, 0) AS VEICULO " +
                                "FROM CLIENTE C LEFT JOIN CLIENTE_VEICULO CV ON C.ID_CLIENTE = CV.ID_CLIENTE " +
                                    "LEFT JOIN VEICULO V ON CV.ID_VEICULO = V.ID_VEICULO " +
                                    "LEFT JOIN MODELO_CARRO M ON V.ID_MODELO = M.ID_MODELO;";

            CNN cnn = new CNN();
            DataTable dt = cnn.GetData(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClienteModel cliente = new ClienteModel();

                cliente.Id_cliente = int.Parse(dt.Rows[i]["ID_CLIENTE"].ToString());
                cliente.Cnpj_cpf = dt.Rows[i]["CNPJ_CPF"].ToString();
                cliente.Nome_cliente = dt.Rows[i]["NOME_CLIENTE"].ToString();
                cliente.Cnpj_ou_cpf = char.Parse(dt.Rows[i]["CNPJ_OU_CPF"].ToString());
                cliente.Apelido = dt.Rows[i]["APELIDO"].ToString();
                cliente.Data_nascimento = DateTime.Parse(dt.Rows[i]["DATA_NASCIMENTO"].ToString());
                cliente.Data_cadastro = DateTime.Parse(dt.Rows[i]["DATA_CADASTRO"].ToString());
                cliente.Email_nf = dt.Rows[i]["EMAIL_NF"].ToString();
                cliente.Cep = dt.Rows[i]["CEP"].ToString();
                cliente.Logradouro = dt.Rows[i]["LOGRADOURO"].ToString();
                cliente.Numero = dt.Rows[i]["NUMERO"].ToString();
                cliente.Complemento = dt.Rows[i]["COMPLEMENTO"].ToString();
                cliente.Bairro = dt.Rows[i]["BAIRRO"].ToString();
                cliente.Cidade = dt.Rows[i]["CIDADE"].ToString();
                cliente.Estado = dt.Rows[i]["ESTADO"].ToString();
                cliente.Telefone = dt.Rows[i]["TELEFONE"].ToString();
                cliente.Celular = dt.Rows[i]["CELULAR"].ToString();
                if (int.Parse(dt.Rows[i]["VEICULO"].ToString()) != 0){
                    cliente.IdVeiculo = int.Parse(dt.Rows[i]["VEICULO"].ToString());
                    cliente.IdModelo = int.Parse(dt.Rows[i]["ID_MODELO"].ToString());
                    cliente.NomeModelo = dt.Rows[i]["NOME_MODELO"].ToString();
                    cliente.Placa = dt.Rows[i]["PLACA_VEICULO"].ToString();
                    cliente.Motorizacao = dt.Rows[i]["MOTORIZACAO"].ToString();
                    cliente.AnoModelo = dt.Rows[i]["ANO_MODELO"].ToString();
                    cliente.Renavan = dt.Rows[i]["RENAVAN"].ToString();
                    cliente.NomeCor = dt.Rows[i]["COR"].ToString();
                    cliente.Quilometragem = int.Parse(dt.Rows[i]["QUILOMETRAGEM"].ToString());
                }
                else
                {
                    cliente.IdVeiculo = 0;
                    cliente.IdModelo = 0;
                    cliente.NomeModelo = "";
                    cliente.Placa = "";
                    cliente.Motorizacao = "";
                    cliente.AnoModelo = "";
                    cliente.Renavan = "";
                    cliente.NomeCor = "";
                    cliente.Quilometragem = 0;
                }
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