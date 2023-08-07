using OOP_Calculator.Operations;

namespace OOP_Calculator.Factories
{
    class DivisionFactory : OperationFactory
    {
        public override IOperation CreateOperation()
        {
            return new Division();
        }
    }
}
