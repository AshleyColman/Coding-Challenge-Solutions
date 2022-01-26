using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int k, n, w;
        string[] input = Console.ReadLine().Split();
        k = int.Parse(input[0]);
        n = int.Parse(input[1]);
        w = int.Parse(input[2]);

        int total = 0;
        for (int i = 0; i < w; i++)
        {
            total += (k * (i + 1));
        }
        Console.WriteLine(n >= total ? 0 : (total - n));
    }
}