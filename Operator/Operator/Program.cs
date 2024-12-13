using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John", "Doe");
            Employee emp2 = new Employee(102, "Jane", "Smith");

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            // Compare employees using the overloaded operators
            Console.WriteLine(emp1 == emp2 ? "Same employee" : "Different employees");
            Console.WriteLine(emp1 != emp2 ? "Different employees" : "Same employee");

            Console.ReadLine();
        }
    }
}