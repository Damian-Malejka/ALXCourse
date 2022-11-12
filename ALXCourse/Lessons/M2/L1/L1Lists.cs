using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L1
{
    public class L1Lists
    {
        public static void Run()
        {
            List<string> shoppingList = new List<string>();

            Console.WriteLine("Dodawanie elementow listy: ");
            shoppingList.Add("milk");
            ShowList(shoppingList);//z kazdym wyswietleniem lista bedzie wieksza o jeden bo dodajemy po jednym produkcie
            shoppingList.Add("butter");
            ShowList(shoppingList);
            shoppingList.Add("papaya");
            ShowList(shoppingList);
            shoppingList.Add("bread");
            ShowList(shoppingList);
            shoppingList.Add("tomato sauce");
            ShowList(shoppingList);
            shoppingList.Add("apple juice");
            ShowList(shoppingList);

            /* Console.WriteLine("\n\nUsuwanie elementow listy: ");
             shoppingList.Remove("apple juice"); //z kazdym kolejnum wyswietleniem usuwamy jeden element lista sie zmniejsza, kolejnosc usuwania nie ma znaczenia
             ShowList(shoppingList);
             shoppingList.Remove("butter");
             ShowList(shoppingList);
             shoppingList.Remove("milk");
             ShowList(shoppingList);
             shoppingList.Remove("bread");
             ShowList(shoppingList);
             shoppingList.Remove("tomato sauce");
             ShowList(shoppingList);*/
            
            /*
            Console.WriteLine(shoppingList[2]);//wyswietlamy 3 element;
            Console.WriteLine();
            shoppingList[3] = "tea";//zamieniamy 4 element jako herbate
            ShowList(shoppingList);
            shoppingList[12] = "coffe";//to zwróci błąd bo mozemy modyfikowac istniejący element listy ale mamy 6 elementow a probujemy modyfikowac 12 a listy są kolejkowane czyli jedno za drugim modyfikujemy.
            ShowList(shoppingList);
            */
        }
        public static void ShowList(List<string> list)
        {
            Console.WriteLine($"Number of elements: {list.Count()}");//Count metoda obiektu list liczaca liste elementów, ale jest ten Własciwość Count która się sama aktualizuje
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
