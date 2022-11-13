namespace ALXCourse.Assigments.M2.L2
{
    public class Book
    {
        //5 propert metoda, prezentujaca
        public int Id;
        public string Title;
        public string Author;
        public string Genre;
        public string Description;
        

        public Book(int id, string title, string author, string genre, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Description = description;
        }

        public void PresentBooks()
        {
            Console.WriteLine($"\tThe Book number: {Id}");
            Console.WriteLine($"\tTitle: {Title}");
            Console.WriteLine($"\tAuthor: {Author}");
            Console.WriteLine($"\tGenre: {Genre}");
            Console.WriteLine($"\tShort Description: {Description}");
        }

    }
}