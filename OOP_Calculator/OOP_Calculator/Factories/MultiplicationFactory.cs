using OOP_Calculator.Operations;

namespace OOP_Calculator.Factories
{
    class MultiplicationFactory : OperationFactory
    {
        public override IOperation CreateOperation()
        {
            return new Multiplication();
        }
    }
}
