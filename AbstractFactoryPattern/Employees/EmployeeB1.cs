using System;
using AbstractFactoryPattern.AbstractEmployees;

namespace AbstractFactoryPattern.Employees
{

    /// <summary>
    /// The 'EmployeeB1' class
    /// </summary>
    class EmployeeB1 : AbstractEmployeeB
    {
        public override void Interact(AbstractEmployeeA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

}