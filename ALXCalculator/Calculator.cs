using System.Security.Cryptography.X509Certificates;

namespace ALXCalculator
{
    public class Calculator
    {
        List<char> ValidChars;
        char[] ValidOperatorArray = { '+', '-', '*', '/' };
        public Calculator()
        {
            ValidChars = new List<char>();
            ValidChars.Add('+');
            ValidChars.Add('-');
            ValidChars.Add('/');
            ValidChars.Add('*');
        }
        public void Run()
        {
            Console.WriteLine("Running calculator");
            Console.WriteLine();
            Console.WriteLine("OPERATIONS: ");
            Console.WriteLine("+        addition");
            Console.WriteLine("-        substraction");
            Console.WriteLine("*        multiplication");
            Console.WriteLine("/        division");
            Console.WriteLine("diffrent END PROGRAM");
            Console.WriteLine();
            Console.Write("Choose operation: ");

            var operationCharacterInfo = Console.ReadKey().KeyChar;//trzeba pozniej dodac KeyChar bo nas interesuje zczytany znak w sensie zeby odczytać właściwość
            //while((operationCharacterInfo == '+') || (operationCharacterInfo == '-') || (operationCharacterInfo == '/') || (operationCharacterInfo == '*'))
            //while(ValidOperationUsingList(operationCharacterInfo))//tutaj wykorzystujemy liste czy operacje znajduja sie w liscie
            while(ValidOperationUsingArray(operationCharacterInfo))//a tu wykorzystujemy tablice
            {
                Console.WriteLine();
                Console.Write("X number: ");
                var x = Double.Parse(Console.ReadLine()); //zczytujemy z klawiatury tutaj potraktowało to jako tekst i dlatego parsujemy na int32
                Console.Write("Y number: ");
                var y = Double.Parse(Console.ReadLine()); //zczytujemy z klawiatury tutaj potraktowało to jako tekst i dlatego parsujemy na int32

                PerformOperation(operationCharacterInfo, x, y);//.KeyChar było tu ale przeniosłem do miejsca gdzie jest zczytywane //KeyChar daje nam znak właściwość bo ReadKey zwraca wiecej
                
                Console.Write("Choose operation: ");
                operationCharacterInfo = Console.ReadKey().KeyChar;//trzeba pozniej dodac KeyChar bo nas interesuje zczytany znak w sensie zeby odczytać właściwość
            }
        }
        private bool ValidOperationUsingList(char operationCharacter)
        {
            return ValidChars.Contains(operationCharacter); //ta funkcja sprawdza czy ten znak znajduje sie w liscie 
        }
        private bool ValidOperationUsingArray(char operationCharacter)
        {
            return ValidOperatorArray.Contains(operationCharacter); //ta funkcja sprawdza czy ten znak znajduje sie w liscie 
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
