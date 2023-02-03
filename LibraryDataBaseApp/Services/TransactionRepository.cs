using LibraryDataBaseApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataBaseApp.Services
{
    public class TransactionRepository
    {
        private string _connectionString;

        public TransactionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool InsertTransactionToDb(Transaction transaction, Book book, Client client)
        {
            if(CheckTransactions(book))
            {
                var queryString = "insert into transactions (id_book,id_client) " +
                "values(@idBook, @idClient)";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@idBook", book.IdBook);
                    command.Parameters.AddWithValue("@idClient", client.IdClient);

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
            else
            {
                return false;
            }
        }

        public bool CheckTransactions(Book book)
        {
            var queryString = "select count(*) from transactions where id_book = @idBook";
            bool toReturn = false;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                sqlCommand.Parameters.AddWithValue("@idBook", book.IdBook);

                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        if (Int32.Parse(sqlDataReader[0].ToString()) == 0)
                        {
                            toReturn = true;
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

        public List<Transaction> GetAllTransactionsId()
        {
            var transactions = new List<Transaction>();
            var queryString = "select * from transactions";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var transaction = new Transaction
                        {
                            IdTransaction = Int32.Parse(sqlDataReader[0].ToString()),
                            IdBook = Int32.Parse(sqlDataReader[1].ToString()),
                            IdClient = Int32.Parse(sqlDataReader[2].ToString())
                        };
                        transactions.Add(transaction);
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
            return transactions;
        }

        public bool RemoveTransactionsFromDb(Transaction transaction)
        {
            var queryString = "delete from transactions where id_transaction=@idTransaction";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@idTransaction", transaction.IdTransaction);

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
    }
}
