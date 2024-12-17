using System;

    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divide by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        finally
        {
            Console.ReadLine();
        }
        
        }
    }
