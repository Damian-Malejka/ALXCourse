using LibraryDataBaseApp.Models;
using System.Data.SqlClient;

namespace LibraryDataBaseApp.Services
{
    public class BookRepository
    {
        private string _connectionString;

        public BookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool InsertBookToDb(Book book)
        {
            var queryString = "insert into books (title,first_name_author,last_name_author) " +
                "values(@title, @firstNameAuthor, @lastNameAuthor)";
        
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@title", book.Title);
                command.Parameters.AddWithValue("@firstNameAuthor", book.FirstNameAuthor);
                command.Parameters.AddWithValue("@lastNameAuthor", book.LastNameAuthor);

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

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            var queryString = "select * from books";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection); 
                try
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        var book = new Book
                        {
                            IdBook = Int32.Parse(sqlDataReader[0].ToString()),
                            Title = sqlDataReader[1].ToString(),
                            FirstNameAuthor = sqlDataReader[2].ToString(),
                            LastNameAuthor = sqlDataReader[3].ToString(),

                        };
                        books.Add(book);
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
            return books;
        }
        public bool CheckBooks(Book book)
        {
            var queryString = "select count(*) from books where id_book = @idBook";
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
                        if (Int32.Parse(sqlDataReader[0].ToString()) != 0)
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
    }
}
