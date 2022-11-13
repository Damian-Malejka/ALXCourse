using ALXCalculator;
using ALXCalculator.Interfaces;

Console.WriteLine("-- ALX CALCULATOR --");
ICalculator calculator = new Calculator(); //tworzymy obiekt bo run to nie jest metoda statyczna
calculator.Run();
Console.WriteLine("\n--------------------");

