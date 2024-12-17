using System;
using System.Collections.Generic;


    internal class Program
    {
        static void Main()
        {

        List<string> intlist = new List<string>();
        intlist.Add("Hello");
        intlist.Add("10");
        intlist.Remove("10");

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5,2,10,200,5000};

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //numArray2[5] = 650;

        //Console.WriteLine(numArray1[3]);

        Console.WriteLine(intlist[0]);
        Console.Read();
        }
    }

