using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2.Classes
{
    public class Computer
    {
        private string _brand; // to jest pole a nie properta i dlatego przed jest podłoga get set do pol to mozna wprowadzic logike a do propert bez logice na wartosci a np tylko ConsoleWriteLine dodac itp.
        public string Brand
        {//jak bedziemy wpisywac cos do pola to bedziemy to robic poprzez metode Brand i bedzie to przechpodziło przez te metode i wchodziło do pola
            get //get do pobierania z pola
            {
                Console.WriteLine("Getting computer brand");
                return _brand; 
            }
            set//do ustawiania wartosci pola z jakimis warunkami logiaka itp a nie od razu.
            {
                Console.WriteLine("Setting computer brand");
                _brand = value;
            }
        }

        public string Name { get; set; }
        //double? wtedy wartosc domyslna nie jest 0 a staje sie null w nullowalnym double domyslna jest null w nienullowalnym byloby to 0
        private double? _processorFrequency;//znak zapytania da mozliwosc wpisania null wartosc pusta nullowalna bez ? nie mozna by wpisac null   
        public double? ProcessorFrequency
        {
            get
            {
                Console.WriteLine("Getting processor clock frequency [Ghz]...");
                return _processorFrequency;
            }
            set
            {
                if(value>0 && value < 4)
                {
                    Console.WriteLine($"Setting computer's processor clock frequency as {value} [Ghz]");
                    _processorFrequency = value;
                }
                else
                {
                    Console.WriteLine("Invalid processor frequency value!");
                }
            }
        }
        public int NumberOfCores { get; set; }

        public string Model;
        public int StorageSpace { get; }//to mozna tylko zgetować, do zmiennej mozna wpisywać wartości tylko w konstruktorze
        public readonly string GraphicalCardModel;

    }
}
