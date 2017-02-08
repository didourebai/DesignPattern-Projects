using FactoryMethodPattern.Classes;

namespace FactoryMethodPattern.ConcreteClasses
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class ConcreteCreatorA : Creator
    {
        public override Employee FactoryMethod()
        {
            return new ConcreteEmployeeA();
        }
    }

}