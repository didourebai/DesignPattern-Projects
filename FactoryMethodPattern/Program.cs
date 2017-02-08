using System;
using FactoryMethodPattern.Classes;
using FactoryMethodPattern.ConcreteClasses;

namespace FactoryMethodPattern
{
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        { 
            // An array of creators
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create employees
            foreach (Creator creator in creators)
            {
                Employee employee = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  employee.GetType().Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
