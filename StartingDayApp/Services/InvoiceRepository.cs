using StartingDayApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartingDayApp.Services
{
    public class InvoiceRepository
    {
        private string _connectionString;

        public InvoiceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool InsertInvoiceToDb(Invoice invoice)
        {
            var queryString = "insert into invoices (series_number,client_company_name,client_nip, user_first_name, user_last_name, amount) " +
                "values(@seriesNumber, @clientCompanyName, @clientNIP, @userFirstName, @userLastName, @amount)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@seriesNumber", invoice.SeriesNumber);
                command.Parameters.AddWithValue("@clientCompanyName", invoice.ClientCompanyName);
                command.Parameters.AddWithValue("@clientNIP", invoice.ClientNIP);
                command.Parameters.AddWithValue("@userFirstName", invoice.UserFirstName);
                command.Parameters.AddWithValue("@userLastName", invoice.UserLastName);
                command.Parameters.AddWithValue("@amount", invoice.Amount);


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

        public List<Invoice> GetAllInvoices()
        {
            var invoices = new List<Invoice>();
            var queryString = "select * from invoices";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var invoice = new Invoice
                        {
                            Id = Int32.Parse(sqlDataReader[0].ToString()),
                            SeriesNumber = Int32.Parse(sqlDataReader[1].ToString()),
                            ClientCompanyName = sqlDataReader[2].ToString(),
                            ClientNIP = sqlDataReader[3].ToString(),
                            UserFirstName = sqlDataReader[4].ToString(),
                            UserLastName = sqlDataReader[5].ToString(),
                            Amount = Int32.Parse(sqlDataReader[6].ToString()),

                        };
                        invoices.Add(invoice);
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
            return invoices;
        }
        
    }
}
