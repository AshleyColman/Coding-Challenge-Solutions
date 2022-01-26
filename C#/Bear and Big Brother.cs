using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a, b;
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);

        int years = 0;
        while (a <= b)
        {
            a *= 3;
            b *= 2;
            years++;
        }
        Console.WriteLine(years);
    }
}