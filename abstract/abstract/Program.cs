class Program
{
    static void Main()
    {
        // Create an Employee object.
        Employee employee = new Employee("Sample", "Student");

        // Call the SayName() method on the Employee object.
        employee.SayName();

        // Prevent console from closing immediately.
        Console.ReadLine();
    }
}