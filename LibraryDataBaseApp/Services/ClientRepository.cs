using LibraryDataBaseApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataBaseApp.Services
{
    public class ClientRepository
    {
        private string _connectionString;

        public ClientRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool InsertClientToDb(Client client)
        {
            var queryString = "insert into clients (first_name,last_name) " +
                "values(@firstName, @lastName)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@firstName", client.FirstName);
                command.Parameters.AddWithValue("@lastName", client.LastName);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    Console.Write(ex.StackTrace);
                    return false;
                }
            }
        }

        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();
            var queryString = "select * from clients";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var client = new Client
                        {
                            IdClient = Int32.Parse(sqlDataReader[0].ToString()),
                            FirstName = sqlDataReader[1].ToString(),
                            LastName = sqlDataReader[2].ToString(),

                        };
                        clients.Add(client);
                    }
                    sqlDataReader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                connection.Close();
            }
            return clients;
        }

        public bool CheckClients(Client client)
        {
            var queryString = "select count(*) from clients where id_client = @idClient";
            bool toReturn=false;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                sqlCommand.Parameters.AddWithValue("@idClient", client.IdClient);

                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        if(Int32.Parse(sqlDataReader[0].ToString())!=0)
                        {
                            toReturn=true;
                        }
                    }
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                connection.Close();
            }
            return toReturn;
        }
    }
}
