class Program
{
    static void Main()
    {
        // Create an Employee object and assign it to an IQuittable reference
        IQuittable quittableEmployee = new Employee("Sample", "Student");

        // Call Quit() method using polymorphism
        quittableEmployee.Quit();  // Output: Sample Student has quit the job.

        // Prevent the console from closing immediately
        Console.ReadLine();
    }
}