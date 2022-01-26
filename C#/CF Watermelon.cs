using System;

public class Program
{
    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num > 2 && (num % 2) == 0
        ? "YES" : "NO");
    }
}