using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Auto.Util
{
    
    public class DAL
    {
        private string ConnectionString = @"Data Source=DESKTOP-K0VSIA3;Initial Catalog=CRM_AUTO;Trusted_Connection=True;";

        //private string ConnectionString = @"Data Source=LAPTOP-K07OAJOR\SQLEXPRESS02;Initial Catalog=CRM_AUTO;Trusted_Connection=True;";

        private SqlConnection SqlConnection;

        //Construtor
        public DAL()
        {
            SqlConnection = new SqlConnection(ConnectionString);

            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
        }

        //Comando Insert
        public void InsertData(string command)
        {
            SqlCommand SqlCommand = new SqlCommand(command, SqlConnection);

            try
            {
                //Executar o comando
                SqlCommand.ExecuteNonQuery();

                //Desconectar
                Desconectar();
            }

            //Mostra mensagem de erro - Variável mensagem
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        //Comando Select
        public DataTable GetData(string command)
        {
            SqlDataAdapter dataAdapter;
            DataTable table;

            try
            {
                dataAdapter = new SqlDataAdapter(command, SqlConnection);
                table = new DataTable();

                dataAdapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    //Console.WriteLine("IOException source: {0}", ex.Source);
                throw;
            }
            finally
            {
                dataAdapter = null;
                table = null;
            }

            return table;
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
