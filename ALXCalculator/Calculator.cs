namespace ALXCalculator
{
    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Running calculator");
            Console.WriteLine();
            Console.WriteLine("OPERATIONS: ");
            Console.WriteLine("+       addition");
            Console.WriteLine("-       substraction");
            Console.WriteLine("*       multiplication");
            Console.WriteLine("/       division");
            Console.WriteLine();
            Console.Write("Choose operation: ");
            var operationCharacterInfo = Console.ReadKey();//trzeba pozniej dodac KeyChar bo nas interesuje zczytany znak w sensie zeby odczytać właściwość
            Console.WriteLine();
            Console.Write("X number: ");
            var x = Double.Parse(Console.ReadLine()); //zczytujemy z klawiatury tutaj potraktowało to jako tekst i dlatego parsujemy na int32
            Console.Write("Y number: ");
            var y = Double.Parse(Console.ReadLine()); //zczytujemy z klawiatury tutaj potraktowało to jako tekst i dlatego parsujemy na int32
            
            PerformOperation(operationCharacterInfo.KeyChar, x, y); //KeyChar daje nam znak właściwość bo ReadKey zwraca wiecej
        }

        private void PerformOperation(char operationCharacter, double x, double y)
        {
            switch(operationCharacter)
            {
                case '+':
                    Console.WriteLine($"{x} + {y} = {Add(x, y)}");
                    break;
                case '-':
                    Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation...");
                    break;


            }

        }

        private double Add(double x,double y)//operacje te wykonywane w obrębie klasy kalkulator i z tego poziomu moga byc wywolywane
        {
            return x + y;
        }

        private double Substract(double x, double y)//operacje te wykonywane w obrębie klasy kalkulator i z tego poziomu moga byc wywolywane
        {
            return x - y;
        }

        private double Multiply(double x, double y)//operacje te wykonywane w obrębie klasy kalkulator i z tego poziomu moga byc wywolywane
        {
            return x * y;
        }

        private double Divide(double x, double y)//operacje te wykonywane w obrębie klasy kalkulator i z tego poziomu moga byc wywolywane
        {
            return x / y;
        }
    }
}
