using System.Security.Cryptography.X509Certificates;

namespace ALXCourse.Lessons.Classes
{
    public class Spider
    {
        public string Color;
        public string Species;//gatunek
        public bool IsVenomous; //czy jest jadowity?
        public string Sex;

        /*public Spider() //domyślny konstruktor który się tworzy gdy my nie dodamy zadnego konstruktora
        {

        }*/

        ///OVERLOAD POLEGA na tym ze ma taka sama nazwe, zwraca to samo ale ma rozne argumenty/
        public Spider(string color, string species, bool isVenomous, string sex)
        {
            Color=color;
            Species = species;
            IsVenomous = isVenomous;
            Sex = sex;
        }

        public Spider(string  color, string species)
        {
            Color = color;
            Species = species;
            IsVenomous = true;
            Sex = "male";
        }

        /*public Spider(string color, string sex)  drugiego konstruktora z dwoma argumentami string nie moze byc bo wczesniej juz były ale np string i bool moze być
        {
            Color = color;
            Species = "taran";
            IsVenomous = true;
            Sex = sex;
        }*/

        public Spider(string color, bool isVenomous)  //to moze byc bo jeden argument jest string a drugi bool a we wczesniejszym były dwa stringi
        {
            Color = color;
            IsVenomous = isVenomous;
        }
        
        public Spider() //można zastosować kilka konstruktorów jak by nie było pustego to by się nie dało bez argumentów utworzyć obiektu
        {
            
        }

        public void Present()
        {
            Console.WriteLine($"Here is a new spider");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Is Venomous?: {IsVenomous}");
            Console.WriteLine($"Sex: {Sex}");
        }
    }
}
