using ADODemoConsoleApp.Models;
using ADODemoConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoConsoleApp
{
    public class ADODemo
    {
        private string _connectionString;
        private EmployeeRepository _EmployeeRepository;

        public ADODemo(string connectionString)
        {
            _connectionString = connectionString;
            _EmployeeRepository = new EmployeeRepository(connectionString);
            
        }

        public void RunSelectAllFromEmployees()
        {
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
                        Console.WriteLine($"{sqlDataReader[0]}, {sqlDataReader[1]}, {sqlDataReader[2]}, {sqlDataReader[3]}");// 0 1 2 to kolejne kolumny   tablica kolumn jednego rekordu
                    }


                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
        public void RunSelectDefinedColumnSet(string column1, string column2)
        {
            var queryString = $"select  {column1} , {column2} from employees";//bedziemy podstawiac w miejsce column

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);
               
                try//robimy w try catch po to ze jakby cos nie dzialalo
                {
                    connection.Open();//otwieramy polaczenie
                    var sqlDataReader = sqlCommand.ExecuteReader();//sqlCommand wykonuje zapytanie execute reader do odczytywania

                    while (sqlDataReader.Read())//odczytujemy odczytane dane rekord po rekordzie
                    {


                        Console.WriteLine($"{sqlDataReader[0]}, {sqlDataReader[1]}");// 0 1 2 to kolejne kolumny   tablica kolumn jednego rekordu
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }


        public void InsertEmployeeDemo()
        {
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = "Andrzej",
                LastName = "Pandrzej",
                Email = "aaa@djsj.pl",
                DepartmentId= Guid.Parse("03B5AD90-05E8-4AA3-BD83-7FB581642928")//zamiana string na guid
            };

            _EmployeeRepository.InsertEmployeeToDb(employee);

        }

        public void InsertManyEmployeesDemo()//wrzucanie losowych wartosci do bazy danych z przypisaniem do jednego departamentu
        {
            var employeeList = new List<Employee>();
            var random = new Random();

            string[] names = { "Michał", "Andrzej", "Marcin", "Monika" };//tworzymy tablice imion do losowania
            string[] lastNames = { "Kowalski", "Nowak", "Miau", "Hau" };


            for (int i = 0; i < 100; i++)
            {
                employeeList.Add(new Employee//tworzymy losową liste
                {
                    Id = Guid.NewGuid(),
                    FirstName = names[random.NextInt64(0, 4)],
                    LastName = lastNames[random.NextInt64(0, 4)],
                    Email = names[random.NextInt64(0, 3)] + names[random.NextInt64(0, 3)] + names[random.NextInt64(0, 3)] + random.NextInt64().ToString() + "@gmail.com",
                    DepartmentId = Guid.Parse("03B5AD90-05E8-4AA3-BD83-7FB581642928")
                });
                Console.WriteLine("Employee created...");
            }

            foreach (var employee in employeeList)//tu dodajemy utworzona liste do bazy danych 
            {
                _EmployeeRepository.InsertEmployeeToDb(employee);
                Console.WriteLine("Employee inserted...");
            }
        }
    }
}




// var numberOfRowsAffected = sqlCommand.ExecuteNonQuery();//wykonaj twoje zapytanie //non query w nazwie bo zrobione w c# a nie w czystym sql   do wykonywania modyfikacji
