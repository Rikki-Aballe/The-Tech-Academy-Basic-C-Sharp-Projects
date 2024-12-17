<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 2af4e0c6c25aa6c8e733a30a2d82f897e3ed98f5
