using System;

class MathOperations
{
    public void PerformOperation(int num1, int num2)
    {
        Console.WriteLine(num2);  // Display the second number
        Console.WriteLine(num1 + 5);  // Add 5 to the first number and display it
    }
}

class Program
{
    static void Main()
    {
        var mathOps = new MathOperations();
        mathOps.PerformOperation(10, 20);  // Call with numbers
        mathOps.PerformOperation(num1: 15, num2: 25);  // Call with named parameters
        Console.ReadLine();
    }
}
