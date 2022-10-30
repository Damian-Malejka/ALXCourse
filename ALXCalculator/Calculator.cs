namespace ALXCalculator
{
    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Running calculator");
            Console.Write("X number: ");
            var x = Double.Parse(Console.ReadLine()); //zczytujemy z klawiatury tutaj potraktowało to jako tekst i dlatego parsujemy na int32
            Console.Write("Y number: ");
            var y = Double.Parse(Console.ReadLine()); //zczytujemy z klawiatury tutaj potraktowało to jako tekst i dlatego parsujemy na int32
            Console.WriteLine($"{x} + {y} = {Add(x,y)}");
            Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
            Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
            Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
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
