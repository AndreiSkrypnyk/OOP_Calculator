using OOP_Calculator.Operations;

namespace OOP_Calculator.Factories
{
    class AdditionFactory : OperationFactory
    {
        public override IOperation CreateOperation()
        {
            return new Addition();
        }
    }
}
