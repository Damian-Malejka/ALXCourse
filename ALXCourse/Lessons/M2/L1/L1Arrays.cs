using ALXCourse.Lessons.M1.L1.Classes;

namespace ALXCourse.Lessons.M2.L1
{
    public class L1Arrays
    {
        public static void Run()
        {
            int[] intArray = { 1, 2, 3, 4, 5 }; //intArray to nazwa zmiennej z wpisanymi wartosciami
            int[] intArray2 = new int[5]; //deklaracja pustej tablicy elementowej, będą 0 jako wartości domyśle do inta

            int[] intArray3 = new int[3] { 1, 2, 3 };// mozna tez tak zadeklarowac tablice z wpisaniem wartosci
            Console.WriteLine("Pierwsza tablica:");
            ShowArray(intArray);

            Console.WriteLine("\nDruga tablica:");
            intArray2[2] = 2;//wpisujemy wartość do trzeciej pozycji 
            ShowArray(intArray2);

            Console.WriteLine("\nTrzecia tablica:");
            ShowArray(intArray3);

            
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog();
        }

        public static void Run1()
        {
            string[] shoppingArray = new string[6];
            shoppingArray[0] = "milk";//tablica jest statyczna wiec cały czas liczba elementów wynosi 6 my tylko wpisujemy do pustych
            ShowArray(shoppingArray);
            shoppingArray[1] = "butter";
            ShowArray(shoppingArray);
            shoppingArray[5] = "apple juice";
            ShowArray(shoppingArray);
        }
        public static void Run2()
        {
            int[,] intMatrix = new int[3, 2];//deklaracja tablicy dwuwymiarowej pustej
            int[,] intMatrix1 = { { 1, 2 }, { 3, 4 } }; //definicja tablicy dwuwymiarowej z wpisanymi wartościami
            int[,] intMatrix2 = { { 1, 2 ,3}, { 3, 4 ,7},{ 1, 1, 1 },{2,3,5 } }; //definicja tablicy dwuwymiarowej z wpisanymi wartościami

            Show2DArray(intMatrix2);
        }
        public static void ShowArray(string[] array)
        {
            Console.WriteLine($"Number of elements: {array.Length}");
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        public static void Show2DArray(int[,] matrix)//Wyświetlanie tablicy dwuwymiarowej
        {
            for(int iterator = 0; iterator < matrix.GetLength(0);iterator++) //Length tutaj zwróciło by 4, (0) oznacza 1 wymiar
            {
                for (int iterator1 = 0; iterator1 < matrix.GetLength(1); iterator1++)//GetLength pdczytuje wymiary tablcy (1) oznacza drugi wymiar
                {
                    var number = matrix[iterator, iterator1];
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
                
            
        }
    }
}
