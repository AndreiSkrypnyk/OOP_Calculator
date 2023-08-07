using OOP_Calculator.Factories;

namespace OOP_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter operator ( +, -, *, / ): ");
            string operatorSymbol = Console.ReadLine();

            OperationFactory factory;

            if (operatorSymbol == "+")
            {
                factory = new AdditionFactory();
            }
            else if (operatorSymbol == "-")
            {
                factory = new SubtractionFactory();
            }
            else if (operatorSymbol == "*")
            {
                factory = new MultiplicationFactory();
            }
            else if (operatorSymbol == "/")
            {
                factory = new DivisionFactory();
            }
            else
            {
                Console.WriteLine("\nInvalid operator!");
                return;
            }

            IOperation operation = factory.CreateOperation();

            try
            {
                Console.Write("\nEnter the first value: ");
                double first = double.Parse(Console.ReadLine());

                Console.Write("Enter the second value: ");
                double second = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nResult: {operation.Operation(first, second)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid value format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nValue is too large or too small!");
            }
            catch (Exception)
            {
                Console.WriteLine("\nUnknown error!");
            }
        }
    }
}