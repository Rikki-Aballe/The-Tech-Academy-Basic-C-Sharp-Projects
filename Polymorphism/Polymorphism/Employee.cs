using System;

public class Employee : IQuittable
{
    // Properties for the Employee class
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize Employee's first and last name.
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Implementing the Quit() method from IQuittable interface
    public void Quit()
    {
        // Display a message when the employee quits
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}