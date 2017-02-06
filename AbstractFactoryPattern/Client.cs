using AbstractFactoryPattern.AbstractEmployees;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// The 'Client' class. Interaction environment for the products.
    /// </summary>
    class Client
    {
        private AbstractEmployeeA _abstractEmployeeA;
        private AbstractEmployeeB _abstractEmployeeB;

        // Constructor
        public Client(AbstractFactory factory)
        {
            _abstractEmployeeB = factory.CreateEmployeeB();
            _abstractEmployeeA = factory.CreateEmployeeA();
        }

        public void Run()
        {
            _abstractEmployeeB.Interact(_abstractEmployeeA);
        }
    }
}