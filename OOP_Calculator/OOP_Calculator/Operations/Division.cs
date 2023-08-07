namespace OOP_Calculator.Operations
{
    class Division : IOperation
    {
        public double Operation(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                Console.WriteLine("\nDivision by zero is impossible!");
                return 0;
            }
            else if (double.IsInfinity(firstValue / secondValue))
            {
                Console.WriteLine("Arithmetic Overflow: The result exceeds the representable range!");
                return 0;
            }

            return firstValue / secondValue;
        }
    }
}
