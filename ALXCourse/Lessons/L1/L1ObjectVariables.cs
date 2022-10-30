using ALXCourse.Lessons.L1.Classes;

namespace ALXCourse.Lessons.L1
{
    public class L1ObjectVariables
    {
        public static void Run() //ta metoda jest statyczna więc mozna wywołac ją bezpośrednio na klasie i dlatego podswietla się na zielono np Console też  statyczna nie zwraca wartości
        {
            Console.WriteLine("Variables");

            Dog dog = new Dog(); //stworzyliśmy obiekt o nazwie dog na podstawie wcześniej utworzonej klasy Dog
            dog.Jump(); //uruchomienie metody skacz dla psa 
            dog.Bark(); //uruchomienie metody szczekaj dla psa 
            dog.Name = "Burek"; //nadajemy imie psu
            dog.Race = "Golden Retriever"; //wpisujemy właściwość rasa dla naszego psa
            dog.Age = 2; //wpisujemy wiek 2 lata dla Burka

            Console.WriteLine("Attention here is dog" + dog.Name); //wyświetlanie właściwości nazwa
            Console.WriteLine("Race" + dog.Race); //wyświetlanie właściwości rasa
            Console.WriteLine("Age" + dog.Age); //wyświetlanie właściwości wiek

            Dog.Eat(); // do elementu statycznego odwołujemy się za pomoca nazwy klasy
                       //czyli nie można napisać dog.Eat() w odwołaniu do obiektu   w niestatycznych się właśnie tak robi
                       /////////////////////KAZDY PLIK CS jest klasa/////////////////////
            /// jeżeli klasa jest statyczna to moze zawierac tylko statyczne metody
            /// a niestatyczna klasa moze zawierac i statyczne i niestatyczne/////////////

        }

        public static void Run2() //ta metoda jest statyczna więc mozna wywołac ją bezpośrednio na klasie i dlatego podswietla się na zielono np Console też  statyczna nie zwraca wartości
        {
            Dog westieDog = new Dog(); //tutaj obiekty są lokalne czyli tylko na czas uruchomienia danej metody test2
            westieDog.Race = "WHWT";
            westieDog.Age = 4;
            westieDog.Name = "Skiper";
            westieDog.GoodBoi = true;
            westieDog.Present();
            westieDog.Jump();
            westieDog.Bark();
            Console.WriteLine(westieDog.Add(5, 4));// w dodawaniu było tylko return nie było wyświetlania

            Console.WriteLine(westieDog.Breed()); ///////tutaj jest problem bo wyswietla odnosnik do obiektu stats

            DogOffspringStats stats = westieDog.Breed();
            Console.WriteLine("number of male pups: " + stats.NumberOfMalePups);
            Console.WriteLine("number of female pups: " + stats.NumberOfFemalePups);

            //Lub po mojemu teżtak jest dobrze: 
            Console.WriteLine("number of male pups: " + westieDog.Breed().NumberOfMalePups);
            Console.WriteLine("number of female pups: " + westieDog.Breed().NumberOfFemalePups);
        }

        public void WriteSomething() //tworzymy metode niestatyczna wiec zeby sie do niej odwołać to trzeba najpierw utworzyc obiekt i odwoływać się do obiektu
        {
            Console.WriteLine("Something.....");
        }

    }
}
