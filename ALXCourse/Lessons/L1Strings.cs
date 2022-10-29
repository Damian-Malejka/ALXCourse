using System.Xml.Linq;

namespace ALXCourse.Lessons
{
    public class L1Strings
    {
        public static void Test()
        {
            string name = "Mateusz";
            Console.WriteLine(name);
            name = "Ala"; //poprzednia zmienna name jest niszczona i jest tworzona od nowa z nowa wartoscia to jest właśnie niemutowalność stringa
            Console.WriteLine(name);
            name = name + " ma kota"; //poprzednia zmienna name jest niszczona i jest tworzona od nowa z nowa wartoscia
            Console.WriteLine(name);

            ExpandString(name, "hello");
            Console.WriteLine(name);
            
            ExpandString(name, "world");
            Console.WriteLine(name);
           
            ExpandString(name, "something");
            Console.WriteLine(name);
        }

        public static void ExpandString(string word,string extension)
        {
            word =word + extension;
        }

        public static void ConcatenationTest()
        {
            string word1 = "Ala ma";
            string word2 = "koty dwa";
            string concat1 = word1 + word2;//konkatenacja za pomocą + jak w js
            Console.WriteLine(concat1);
            string concat2 = word1 + " " + word2; //tu ze spacja
            Console.WriteLine(concat2);
            string concat3 = $"{word1} {word2} i dobrze się ma"; //mozna tez tak to jest interpolacja 
            Console.WriteLine(concat3);
        }

    }
}
