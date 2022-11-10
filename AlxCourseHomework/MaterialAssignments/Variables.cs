using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class Variables
    {
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum Month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }
        public static void Exercise1()
        {
            string imie="Stanisław";
            string nazwisko="Wąs";
            double wzrost=190.25;
            string plec="male";
            long pesel=98110223334;

            Console.WriteLine($"Imie: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"wzrost: {wzrost}");
            Console.WriteLine($"plec: {plec}");
            Console.WriteLine($"Numer PESEL: {pesel}");
        }

        public static void Exercise2()
        {
            string imie = "Stanisław";
            string nazwisko = "Wąs";
            double wzrost = 190.25;
            string plec = "male";
            long pesel = 98110223334;

            Console.WriteLine($"Imie: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine("wzrost: "+ (int)wzrost);
            Console.WriteLine($"plec: {plec}");
            Console.WriteLine($"Numer PESEL: {pesel}");
        }

        public static void Exercise3()
        {
            Console.WriteLine("Dzisiaj jest: " + (Days)3);
            Console.WriteLine("Miesiąc: " + (Month)10);
            Console.WriteLine("Rok: 2022");
        }


    }
}
