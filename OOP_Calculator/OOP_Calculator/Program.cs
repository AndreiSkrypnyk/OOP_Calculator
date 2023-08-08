namespace OOP_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                try
                {
                    Console.Write("Enter the first value: ");
                    double first = double.Parse(Console.ReadLine());

                    Console.Write("\nEnter operator ( +, -, *, / ): ");
                    string operatorSymbol = Console.ReadLine();

                    Console.Write("\nEnter the second value: ");
                    double second = double.Parse(Console.ReadLine());

                    OperationFactory operation = new();

                    Console.WriteLine($"\nResult: {operation.OperatorChoice(operatorSymbol, first, second)}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid value format!");
                    Console.WriteLine("\nPress enter to repeat: ");
                    Console.ReadLine();
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nValue is too large or too small!");
                    Console.WriteLine("\nPress enter to repeat: ");
                    Console.ReadLine();
                    continue;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nInvalid operator!");
                    Console.WriteLine("\nPress enter to repeat: ");
                    Console.ReadLine();
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nUnknown error!");
                    Console.WriteLine("\nPress enter to repeat: ");
                    Console.ReadLine();
                    continue;
                }
                
                Console.WriteLine("\nPress enter to repeat: ");
                Console.ReadLine();
            }
        }
    }
}