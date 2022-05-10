using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Auto.DAL
{
    
    public class DAL
    {
        SqlConnection SqlConnection = new SqlConnection();

        //Construtor
        public void Conexao()
        {
            SqlConnection.ConnectionString = @"Data Source=LAPTOP-K07OAJOR\SQLEXPRESS02;Initial Catalog=CRM_TESTE;Trusted_Connection=True;";
        }

        //Método Conectar
        public SqlConnection Conectar()
        {
            if (SqlConnection.State != System.Data.ConnectionState.Open)
            {
                SqlConnection.Open();
            }
            return SqlConnection;
        }

        //Método Insert
        public void InsertData(string command)
        {
            SqlCommand SqlCommand = new SqlCommand();

            SqlCommand.CommandText = command;

            try
            {
                //Conectar com o banco - Classe conexão
                SqlCommand.Connection = Conectar();

                //Executar o comando
                SqlCommand.ExecuteReader();

                //Desconectar
                Desconectar();
            }

            //Mostra mensagem de erro - Variável mensagem
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método Desconectar
        public void Desconectar()
        {
            if (SqlConnection.State != System.Data.ConnectionState.Closed)
            {
                SqlConnection.Close();
            }
        }
    }
}
