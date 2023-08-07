namespace OOP_Calculator.Operations
{
    class Addition : IOperation
    {
        public double Operation(double firstValue, double secondValue)
        {
            if (double.IsInfinity(firstValue + secondValue))
            {
                Console.WriteLine("Arithmetic Overflow: The result exceeds the representable range!");
                return 0;
            }

            return firstValue + secondValue;
        }
    }
}
