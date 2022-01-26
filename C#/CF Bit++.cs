using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> statements = new List<string>();
        for (int i = 0; i < n; i++)
        {
            statements.Add(Console.ReadLine());
        }
        int x = 0;
        string plus = "++";
        foreach (string statement in statements)
        {
            if (statement.Contains(plus) == true)
            {
                x++;
            }
            else
            {
                x--;
            }
        }
        Console.WriteLine(x);
    }
}