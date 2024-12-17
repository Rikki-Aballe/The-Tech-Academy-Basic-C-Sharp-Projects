using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee : Person
{
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override void SayName()
    {
        // Display the employee's full name.
        Console.WriteLine($"{FirstName} {LastName}");
    }
}
