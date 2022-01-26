using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int n, k;
        string[] input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        k = int.Parse(input[1]);

        int lastDigit = 0;
        for (int i = 0; i < k; i++)
        {
            lastDigit = (n % 10);
            if (lastDigit == 0)
            {
                n = (n / 10);
            }
            else
            {
                n--;
            }
        }
        Console.WriteLine(n);
    }
}