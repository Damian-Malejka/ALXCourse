namespace ALXCourse.Assigments.M2.L2
{
    public class BookStorageService
    {
        List<Book> ThrillerList = new List<Book>();
        List<Book> TravelogueList = new List<Book>();
        List<Book> FantasyList = new List<Book>();
        List<Book> SfList = new List<Book>();
        List<Book> MurderMysteryList = new List<Book>();
        List<Book> UnList = new List<Book>();

        public Book AddBook()
        {
            Console.Write("\nPodaj id: ");
            int id  = Int32.Parse(Console.ReadLine());
            Console.Write("\nPodaj tytul: ");
            string title = Console.ReadLine();
            Console.Write("\nPodaj  autora: ");
            string author = Console.ReadLine();
            Console.Write("\nPodaj kategorie: ");
            string genre = Console.ReadLine();
            Console.Write("\nPodaj opis" +": ");
            string description = Console.ReadLine();

            return (new Book(id, title, author, genre, description));
        }

        public void ClasifyBook(Book bookToClasify)
        {
            switch(bookToClasify.Genre.ToLower())
            {
                case "thriller":
                    ThrillerList.Add(bookToClasify);
                    break;
                case "travel":
                    TravelogueList.Add(bookToClasify);
                    break;
                case "fantasy":
                    FantasyList.Add(bookToClasify);
                    break;
                case "scifi":
                    SfList.Add(bookToClasify);
                    break;
                case "murder":
                    MurderMysteryList.Add(bookToClasify);
                    break;
                default:
                    UnList.Add(bookToClasify);
                    break;
            }
        }
        public void ShowAllLists()
        {
            Console.WriteLine("Thrillers:");
            ShowList(ThrillerList);
            Console.WriteLine("Travel:");
            ShowList(TravelogueList);
            Console.WriteLine("Fantasy:");
            ShowList(FantasyList);
            Console.WriteLine("Sci-Fi:");
            ShowList(SfList);
            Console.WriteLine("Murder:");
            ShowList(MurderMysteryList);
            Console.WriteLine("UnLists Book:");
            ShowList(UnList);
        }
        public static void ShowList(List<Book> list)
        {
            Console.WriteLine($"Number of elements: {list.Count()}");//Count metoda obiektu list liczaca liste elementów, ale jest ten Własciwość Count która się sama aktualizuje
            foreach (Book item in list)
            {
                Console.WriteLine();
                item.PresentBooks();
            }
            Console.WriteLine();
        }
        //listy ktore beda odpowiadam polki w zaleznosci od kategorii ksiazki sci fi
        ////conajmniej 5 polek
        ///jest mozliwosc stworzenia ksiazki z console readline wywolanie w book storage service    
        ///classify book wywolana w book storage service
        ///przedstaw grupe
        ///czy program ma dzialac dalej czy konczyc dzialanie
    }
}
