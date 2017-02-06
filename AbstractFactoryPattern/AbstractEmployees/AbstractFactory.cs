namespace AbstractFactoryPattern.AbstractEmployees
{

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractEmployeeA CreateEmployeeA();
        public abstract AbstractEmployeeB CreateEmployeeB();
    }
}