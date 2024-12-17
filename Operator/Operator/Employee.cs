<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize Employee
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overload "==" and "!=" operators
        public static bool operator ==(Employee emp1, Employee emp2) => emp1?.Id == emp2?.Id;
        public static bool operator !=(Employee emp1, Employee emp2) => !(emp1 == emp2);

        public override string ToString() => $"{FirstName} {LastName} (ID: {Id})";
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize Employee
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overload "==" and "!=" operators
        public static bool operator ==(Employee emp1, Employee emp2) => emp1?.Id == emp2?.Id;
        public static bool operator !=(Employee emp1, Employee emp2) => !(emp1 == emp2);

        public override string ToString() => $"{FirstName} {LastName} (ID: {Id})";
    }
}
>>>>>>> 2af4e0c6c25aa6c8e733a30a2d82f897e3ed98f5
