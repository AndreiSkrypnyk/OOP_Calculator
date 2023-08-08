using Microsoft.VisualBasic;
using OOP_Calculator.Operations;

namespace OOP_Calculator
{
    class OperationFactory
    {
        public static IOperation OperatorChoice(string operatorSymbol)
        {
            IOperation operation;

            switch (operatorSymbol)
            {
                case "+":
                    operation = new Addition();
                    break;
                case "-":
                    operation = new Subtraction();
                    break;
                case "*":
                    operation = new Multiplication();
                    break;
                case "/":
                    operation = new Division();
                    break;
                default:
                    throw new ArgumentException("Invalid operator!");
            }

            return operation;
        }
    }
}

/*
           //return operatorSymbol switch
           //{
           //    "+" => new Addition().Operation(first, second),
           //    "-" => new Subtraction().Operation(first, second),
           //    "*" => new Multiplication().Operation(first, second),
           //    "/" => new Division().Operation(first, second),
           //    _ => throw new ArgumentException("Invalid operator!"),
           //};
           */