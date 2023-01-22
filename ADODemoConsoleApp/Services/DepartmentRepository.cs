using ADODemoConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoConsoleApp.Services
{
    public class DepartmentRepository
    {
        private string _connectionString; //_ podłoga oznacza prywatne property
        
        public DepartmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertDepartmentToDB(Department department)
        {
            var queryString = "insert into department(id,department_name) values(@id,@name)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", department.DepartmentId.ToString());
                command.Parameters.AddWithValue("@name", department.DepartmentName);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        /*
        public List<DepartmentRepository> GetAllDepartments()
        {

        }

        public Department GetByID(Guid id)
        {

        }*/

    }
}
