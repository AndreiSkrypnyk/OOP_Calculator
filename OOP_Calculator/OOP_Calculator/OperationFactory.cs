using OOP_Calculator.Operations;

namespace OOP_Calculator
{
    class OperationFactory
    {
        public double OperatorChoice(string operatorSymbol, double first, double second)
        {
            switch (operatorSymbol)
            {
                case "+":
                    return new Addition().Operation(first, second);
                case "-":
                    return new Subtraction().Operation(first, second);
                case "*":
                    return new Multiplication().Operation(first, second);
                case "/":
                    return new Division().Operation(first, second);
                default:
                    throw new ArgumentException("Invalid operator!");
            }
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