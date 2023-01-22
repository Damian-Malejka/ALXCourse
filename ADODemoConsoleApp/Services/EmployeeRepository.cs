using ADODemoConsoleApp.Models;
using System.Data.SqlClient;

namespace ADODemoConsoleApp.Services
{
    public class EmployeeRepository
    {
        private string _connectionString;
        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertEmployeeToDb(Employee employee)
        {
            var queryString = "insert into employees (id,first_name,last_name,email,department_id) " +
                "values(@id, @firstName, @lastName, @email, @departmentId)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", employee.Id.ToString());
                command.Parameters.AddWithValue("@firstName", employee.FirstName);
                command.Parameters.AddWithValue("@lastName", employee.LastName);
                command.Parameters.AddWithValue("@email", employee.Email);
                command.Parameters.AddWithValue("@departmentId", employee.DepartmentId.ToString());

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();//wykonujemy zapytanie insertowania
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    Console.Write(ex.StackTrace);
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();
            var queryString = "select * from employees";

            using (SqlConnection connection = new SqlConnection(_connectionString))//using służy do definiowania zasięgu istnienia obiektów, poza usingami obiekt nie istnieje, bo zostaje niszczony
            {//polaczenie chcemy usunac po zakonczeniu operacji z baza dlatego wrzucamy to w usingi mozna jeszcze dodać close
                var sqlCommand = new SqlCommand(queryString, connection); //SqlCommand wykonuje zapytania SqlCommand(zapytanie,obiekt_polaczenia)

                try//robimy w try catch po to ze jakby cos nie dzialalo
                {
                    connection.Open();//otwieramy polaczenie
                    var sqlDataReader = sqlCommand.ExecuteReader();//sqlCommand wykonuje zapytanie execute reader do odczytywania

                    while (sqlDataReader.Read())//odczytujemy odczytane dane rekord po rekordzie
                    {
                        var employee = new Employee
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            FirstName = sqlDataReader[1].ToString(),
                            LastName = sqlDataReader[2].ToString(),
                            Email= sqlDataReader[3].ToString(),
                            DepartmentId = Guid.Parse(sqlDataReader[4].ToString())
                        };
                        employees.Add(employee);
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
            return employees;
        }

        public Employee GetById(Guid Id)
        {
            var queryString = "select * from employees where employees.id=@id";
            var employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(_connectionString))//using służy do definiowania zasięgu istnienia obiektów, poza usingami obiekt nie istnieje, bo zostaje niszczony
            {//polaczenie chcemy usunac po zakonczeniu operacji z baza dlatego wrzucamy to w usingi mozna jeszcze dodać close
                var sqlCommand = new SqlCommand(queryString, connection); //SqlCommand wykonuje zapytania SqlCommand(zapytanie,obiekt_polaczenia)
                sqlCommand.Parameters.AddWithValue("@id", Id.ToString());

                try//robimy w try catch po to ze jakby cos nie dzialalo
                {
                    connection.Open();//otwieramy polaczenie
                    var sqlDataReader = sqlCommand.ExecuteReader();//sqlCommand wykonuje zapytanie execute reader do odczytywania

                    while (sqlDataReader.Read())//odczytujemy odczytane dane rekord po rekordzie
                    {
                        var employee = new Employee
                        {
                            Id = Guid.Parse(sqlDataReader[0].ToString()),
                            FirstName = sqlDataReader[1].ToString(),
                            LastName = sqlDataReader[2].ToString(),
                            Email = sqlDataReader[3].ToString(),
                            DepartmentId = Guid.Parse(sqlDataReader[4].ToString())
                        };
                        employees.Add(employee);
                    }
                    sqlDataReader.Close();
                    return employees.FirstOrDefault();//zwracanie pierwszego elementu z listy

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    throw;
                }
                finally
                {
                    connection.Close();
                }

            }


        }

    }
}
