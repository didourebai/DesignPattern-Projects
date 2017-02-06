using AbstractFactoryPattern.AbstractEmployees;
using AbstractFactoryPattern.Employees;

namespace AbstractFactoryPattern.ConcreteFactories
{

    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractEmployeeA CreateEmployeeA()
        {
            return new EmployeeA2();
        }
        public override AbstractEmployeeB CreateEmployeeB()
        {
            return new EmployeeB2();
        }
    }

}