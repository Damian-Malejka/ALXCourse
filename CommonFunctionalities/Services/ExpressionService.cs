using CommonFunctionalities.Services.Interfaces;
using System.Text;


namespace CommonFunctionalities.Services
{
    public class ExpressionService : IExpressionService
    {
        public string ProcessExpression(string expression)
        {
            if(!expression.EndsWith("="))
            {
                expression += "=";
            }

            return CreateNumberSubstring(expression);
        }

        private string CreateNumberSubstring(string expression)
        {
            List<double> numbers = new List<double>();
            List<char> operations = new List<char>();
            //expression = expression.Replace(',','.');//zamieniamy przecinki na kropki;
            var expressionArray = expression.ToCharArray();//konwersja stringa na tablicze charow
            var numberBuilder = new StringBuilder();
            


            for(var i=0;i<expressionArray.Length;i++)
            {
                if (Char.IsDigit(expressionArray[i]) || expressionArray[i]==',')//is digit czy liczba
                {
                    numberBuilder.Append(expressionArray[i]);//tutaj jezeli cos jest cyfra to dodajemy to do number buildera
                }
                else
                {
                    var number = Double.Parse(numberBuilder.ToString());
                    numberBuilder.Clear();
                    numbers.Add(number);
                    operations.Add(expressionArray[i]);
                }
            }

            var result = PerformOperations(numbers, operations).ToString();
            return result;
        }
        private double PerformOperations(List<double>numbers, List<char>operations)
        {
            var result = numbers[0];
            for(int i=1;i<numbers.Count;i++)
            {
                result = PerformOperation(operations[i - 1], result, numbers[i]);
            }
            return result;
        }

        private double PerformOperation(char operationCharacter, double x, double y)
        {
            switch (operationCharacter)
            {
                case '+':
                    return x + y;
                    break;
                case '-':
                    return x - y;
                break;
                case '*':
                    return x * y;
                break;
                case '/':
                    return x / y;
                break;
                default:
                    return x;
                    break;
            }
        }
    }
}
