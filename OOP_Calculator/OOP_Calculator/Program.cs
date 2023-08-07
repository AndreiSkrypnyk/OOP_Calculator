using System.Runtime.ExceptionServices;

namespace OOP_Calculator
{
    interface IOperation
    {
        double Operation();
    }

    class Addition : IOperation
    {
        public double Operation()
        {
            double first, second;

            try
            {
                Console.Write("Enter the first value: ");
                first = double.Parse(Console.ReadLine());

                Console.Write("Enter the second value: ");
                second = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid value format!");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nValue is too large or too small!");
                return 0;
            }

            double result = first + second;

            if (double.IsInfinity(result))
            {
                Console.WriteLine("Arithmetic Overflow: The result exceeds the representable range!");
            }
            else
            {
                Console.WriteLine($"\nResult: {result}");
            }

            return result;
        }
    }

    class Subtraction : IOperation
    {
        public double Operation()
        {
            double first, second;

            try
            {
                Console.Write("Enter the first value: ");
                first = double.Parse(Console.ReadLine());

                Console.Write("Enter the second value: ");
                second = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid value format!");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nValue is too large or too small!");
                return 0;
            }

            double result = first - second;

            if (double.IsInfinity(result))
            {
                Console.WriteLine("\nArithmetic Overflow: The result exceeds the representable range!");
            }
            else
            {
                Console.WriteLine($"\nResult: {result}");
            }

            return result;
        }
    }

    class Multiplication : IOperation
    {
        public double Operation()
        {
            double first, second;

            try
            {
                Console.Write("Enter the first value: ");
                first = double.Parse(Console.ReadLine());

                Console.Write("Enter the second value: ");
                second = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid value format!");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nValue is too large or too small!");
                return 0;
            }

            double result = first * second;

            if (double.IsInfinity(result))
            {
                Console.WriteLine("\nArithmetic Overflow: The result exceeds the representable range!");
            }
            else
            {
                Console.WriteLine($"\nResult: {result}");
            }

            return result;
        }
    }

    class Division : IOperation
    {
        public double Operation()
        {
            double first, second;

            try
            {
                Console.Write("Enter the first value: ");
                first = double.Parse(Console.ReadLine());

                Console.Write("Enter the second value: ");
                second = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid value format!");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nValue is too large or too small!");
                return 0;
            }

            double result = first / second;

            if (second == 0)
            {
                Console.WriteLine("\nDivision by zero is impossible!");
                return 0;
            }

            if (double.IsInfinity(result))
            {
                Console.WriteLine("\nArithmetic Overflow: The result exceeds the representable range!");
            }
            else
            {
                Console.WriteLine($"\nResult: {result}");
            }

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Addition addition = new Addition();

            addition.Operation();

            Subtraction subtraction = new Subtraction();

            subtraction.Operation();

            Multiplication multiplication = new Multiplication();

            multiplication.Operation();

            Division division = new Division();

            division.Operation();
        }
    }
}