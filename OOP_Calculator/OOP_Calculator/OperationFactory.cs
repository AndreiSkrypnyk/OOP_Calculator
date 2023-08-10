using Microsoft.VisualBasic;
using OOP_Calculator.Operations;

namespace OOP_Calculator
{
    class OperationFactory
    {
        public static IOperation OperatorChoice(string operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case "+":
                    return new Addition();
                case "-":
                    return new Subtraction();
                case "*":
                    return new Multiplication();
                case "/":
                    return new Division();
                default:
                    throw new ArgumentException("Invalid operator!");
            }
        }
    }
}
