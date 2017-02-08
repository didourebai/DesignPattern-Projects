using FactoryMethodPattern.Classes;

namespace FactoryMethodPattern.ConcreteClasses
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class ConcreteCreatorB : Creator
    {
        public override Employee FactoryMethod()
        {
            return new ConcreteEmployeeB();
        }
    }
}