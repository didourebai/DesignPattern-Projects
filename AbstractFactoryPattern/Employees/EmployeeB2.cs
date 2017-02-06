using System;
using AbstractFactoryPattern.AbstractEmployees;

namespace AbstractFactoryPattern.Employees
{
    /// <summary>
    /// The 'EmployeeB2' class
    /// </summary>
    class EmployeeB2 : AbstractEmployeeB
    {
        public override void Interact(AbstractEmployeeA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}