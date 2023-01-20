using CommonFunctionalities.Services;
using CommonFunctionalities.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class Calculator
    {
        private IExpressionService Service;
        public Calculator()
        {
            Service = new ExpressionService();
        }
        public void Run()
        {
            Console.WriteLine("Enter an expression: ");
            var expression = Console.ReadLine();
            expression = RefactorExpression(expression);//do usuwania spacji
            var result = Service.ProcessExpression(expression);//obsługa serwisu
            Console.WriteLine(result);
        }
        private string RefactorExpression(string expression)
        {
            expression = expression.Trim();//ucinamy przed i za stringiem spacje
            expression = expression.Replace(" ", String.Empty);//tutaj wstawiamy nic w miejsce spacji w środku
            return expression;

        }
    }
}
