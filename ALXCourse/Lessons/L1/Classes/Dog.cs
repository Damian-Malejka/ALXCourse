using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.L1.Classes
{
    public class Dog
    {
        public string Name; //wlasciwosc
        public int Age; //wlasciwosc
        public string Race; //rasa //wlasciwosc
        public bool GoodBoi;

        public void Jump() //metoda skacz
        {
            Console.WriteLine("Boing ! Boing!");//skacz skacz
        }

        public void Bark() //metoda szczekanie //tu jest metoda niestatyczna

        {
            Console.WriteLine("Woof! Woof!");//hał hał
        }

        public static void Eat()//statyczna metoda
        {
            Console.WriteLine("yum yum...");

            return; //to nie jest błąd bo tutaj nic nie zwracamy
        }

        public int GetOlderAge() //starszy wiek zwraca nie pobiera argumentów
        {
            return Age + 1;
        }

        public void GrowOlder(int numberOfYears) //postarzanie psa o okreslony wiek nic nie zwraca ale pobiera int
        {
            Age = Age + numberOfYears;
        }

        public int Add(int x,int y) // nie da się bezposrednio zwrócić dwóch intów, można zwrócic listę bądź jakas tablice, albo stworzyc jakas klase o dwoch wlasciwosciach
        {
            return x + y;
        }

        ///to poniżej to klasa do zwracania dwóch wartości z funkcji bedziemy zwracac urodzone suki i psy
        public DogOffspringStats Breed()  //tutaj zwracamy obiekt DogOffspringStats i nic nie przyjmujemy // urodzenia
        {
            DogOffspringStats stats = new DogOffspringStats();//stworzyliśmy obiekt stats klasy DogOffspringStats 
            stats.NumberOfMalePups = 3;//wpisujemy property tego obiektu
            stats.NumberOfFemalePups = 4;
            return stats; //zwracamy utworzony obiekt
        }

        public void Present()
        {
            Console.WriteLine("Attention here is dog" + Name);
            Console.WriteLine("Race" + Race);
            Console.WriteLine("Age" + Age);
            Console.WriteLine("Is he a good boi?" + GoodBoi);
        }

    }
}

