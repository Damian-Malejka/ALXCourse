namespace ALXCourse.Assigments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            var bookStorageService = new BookStorageService();
            char question;
            do
            {
                var book = bookStorageService.AddBook();
                bookStorageService.ClasifyBook(book);
                Console.Write("\nCzy dodac kolejna nowa ksiazke y OR Y(tak)");
                 question = Console.ReadKey().KeyChar;
            } while (question.ToString().ToLower() == "y");//tolower dziala dla stringow dlatego najpierw musimy zrobic konwersje do stringa

            Console.WriteLine("\n\nListy:\n");
            bookStorageService.ShowAllLists();
        }
    }
}
