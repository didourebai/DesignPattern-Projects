using System;
using AbstractFactoryPattern.AbstractEmployees;
using AbstractFactoryPattern.ConcreteFactories;



namespace AbstractFactoryPattern
{
    /// <summary>
    /// Create an instance of separate families of related or dependent objects without specifying their concrete classes.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
