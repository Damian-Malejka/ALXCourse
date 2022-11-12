using ALXCourse.Assigments.M1.Classes;

namespace ALXCourse.Assigments.M1
{
    public class AssigmentsDemo
    {
        public static void Run()
        {
            var desktopComputer = new Computer();

            desktopComputer.Producent = "Lenovo";
            desktopComputer.Model = "t550";
            desktopComputer.isMobile = true;

            desktopComputer.Present();
            Console.WriteLine(desktopComputer.Error());

            Console.Write("\n \n");
            Console.WriteLine("Cat:");
            var furiousCat = new Cat("Mruczek");
            furiousCat.Age = 4;
            furiousCat.isFurious = true;
            furiousCat.Present();
            furiousCat.PleaseEat();
            Console.WriteLine(furiousCat.TestEat("notmeat"));

            var notFuriousCat = new Cat("Kicia", 2, false);
            Console.WriteLine("\nSecond cat:");
            notFuriousCat.Present();
            notFuriousCat.PleaseEat();
            Console.WriteLine(notFuriousCat.TestEat("meat"));

        }
    }
}
