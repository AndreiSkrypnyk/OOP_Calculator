using OOP_Calculator.Operations;

namespace OOP_Calculator.Factories
{
    class SubtractionFactory : OperationFactory
    {
        public override IOperation CreateOperation()
        {
            return new Subtraction();
        }
    }
}
