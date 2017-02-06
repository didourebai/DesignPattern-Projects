using AbstractFactoryPattern.AbstractEmployees;
using AbstractFactoryPattern.Employees;

namespace AbstractFactoryPattern.ConcreteFactories
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractEmployeeA CreateEmployeeA()
        {
            return new EmployeeA1();
        }
        public override AbstractEmployeeB CreateEmployeeB()
        {
            return new EmployeeB1();
        }
    }
}