using ALXCourse.Lessons.M2.L2.Classes;
using System.Runtime.CompilerServices;

namespace ALXCourse.Lessons.M2.L2
{
    public class L2GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer();// zamiast var można napisać Computer
            computer.Brand = "Dell";
            computer.ProcessorFrequency = 3.2;
            computer.NumberOfCores = 3;
            computer.Name = "My PC";
            PresentComputer(computer);

            Console.WriteLine("\n");
            var computer1 = new Computer();// zamiast var można napisać Computer
            computer1.Brand = "Dell";
            computer1.ProcessorFrequency = 10;//wyswietli błąd bo nie poza ranga przypisze domyslna wartosc
            computer1.NumberOfCores = 4;
            computer1.Name = "My PC";
            PresentComputer(computer1);
        }
        private static void PresentComputer(Computer computer)
        {
            Console.WriteLine($"\tName: {computer.Name}");
            Console.WriteLine($"\tProcessor frequency: {computer.ProcessorFrequency}");
            Console.WriteLine($"\tNumber of cores: {computer.NumberOfCores}");
            Console.WriteLine($"\tBrand: {computer.Brand}");
        }
    }
}
