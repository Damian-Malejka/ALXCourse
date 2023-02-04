using HttpClientShowcase.Models;
using Newtonsoft.Json;

namespace HttpClientShowcase
{
    public class SerializationDemo
    { //serializujemy po to zeby strzelac do serwera jsonami w formie tekstu i w druga strone bedziemy odbierac od serwera  i konwertowac na obiektu (deserializowac)
        public BookJsonSamplesHolder RunSerialization() //zwraca klase po to zeby 3 stringi miec
        {
            var book = new Book
            {
                Id = 1,
                Title = "Sourcerer",
                Author = "Terry Prachett",
                Genre = "Fantasy"
            };

            var bookJson = JsonConvert.SerializeObject(book);//konwertujemy objekt na string ktory jest Jsonem, string bo przez siec przesylamy tekstem
            Console.WriteLine(bookJson);

            var bookBox = new BookBox
            {
                Id = 120,
                Book = book

            };



            var bookBoxJson = JsonConvert.SerializeObject(bookBox);//konwertujemy obiekt ktory ma w sobie obiekt na string ktory jest Jsonem, string bo przez siec przesylamy tekstem
            Console.WriteLine(bookBoxJson);

            var book2 = new Book
            {
                Id = 2,
                Title = "The Godfather",
                Author = "Mario Puzo",
                Genre = "Drama"
            };
            var shelf = new List<Book>();
            shelf.Add(book);
            shelf.Add(book2);
            var bookShelf = new BookShelf
            {
                Id=3,
                Books = shelf
            };

            var bookShelfJson=JsonConvert.SerializeObject(bookShelf);//konwertujemy liste obiektow na string ktory jest Jsonem, string bo przez siec przesylamy tekstem
            Console.WriteLine(bookShelfJson);

            return new BookJsonSamplesHolder
            {
                BookJson=bookJson,
                BookBoxJson=bookBoxJson,
                BookShelfJson=bookShelfJson
            };
        }

        public void RunDeserialization(BookJsonSamplesHolder jsonStrings)
        {//zamieniamy ze stringa na obiekty 
            var book=JsonConvert.DeserializeObject<Book>(jsonStrings.BookJson);//<Book> pokazuje w co ma deserializowac deserializuj w obiekt Book
            var booxBox=JsonConvert.DeserializeObject<BookBox>(jsonStrings.BookBoxJson);//to co miedzy diamentami <> decyduje tez o to co bedzie sie podstawialo w var
            var bookShelf = JsonConvert.DeserializeObject<BookShelf>(jsonStrings.BookShelfJson);

           // var book1 = JsonConvert.DeserializeObject<Book>(jsonStrings.BookShelfJson);      to bledne wygeneruje obiekt gdzie beda tylko nulle bo nie bedzie wiedzialo jak przekonwertowac, trzeba sie by przed tym zabezpieczyc  
        }
    }
}
