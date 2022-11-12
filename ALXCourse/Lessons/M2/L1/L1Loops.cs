using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<string> names = new List<string>();
            names.Add("Adrian");
            names.Add("Mateusz");
            names.Add("Monika");
            names.Add("Magda");
            names.Add("Andrzej");

            foreach(string name in names)
            {
                //name.ToLower();//Zmiana wszystkich liter na małe litery
                Console.WriteLine(name.ToLower() + " kursant.");
                Console.WriteLine(name);
            }
        }

        public static void RunFor()
        {
            int[] numbers = new int[12] { 1, 2, 4, 5, 6, 7, 3, 4, 5, 66, 5, 4 };
            for(int i =0;i<numbers.Length;i++) //tu wyswietlamy wszystko
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)//Wyświetlamy 5 elementów
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = numbers.Length-1; i >=0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
        public static void RunWhile()
        {
            ////////////WHILE//////
            char c = 'q';
            while(c!='n')
            {
                Console.WriteLine("still in the loop!");
                Console.Write("Write a character: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nOutside the loop");

            /* string numberFromKeyboard = "0";
             while(Int32.Parse(numberFromKeyboard)<100000)
             {
                 Console.WriteLine("still in the loop!");
                 Console.Write("Write a number: ");
                 numberFromKeyboard = Console.ReadLine();
                 Console.WriteLine("\n");
             }

             Console.WriteLine("\nOutside the loop");*/
        }
            ///////DO WHILE////

        public static void RunDoWhile()
        {
            string numberFromKeyboard;
            do
            {
                Console.WriteLine("still in the loop!");
                Console.Write("Write a number: ");
                numberFromKeyboard = Console.ReadLine();
                Console.WriteLine("\n");
             } while (Int32.Parse(numberFromKeyboard) < 100000);

                Console.WriteLine("\nOutside the loop");
        }
            


    }
}
