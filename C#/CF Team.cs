using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputArr = new string[3];
        int problems = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            inputArr = Console.ReadLine().Split(' ');
            for (int j = 0; j < 3; j++)
            {
                if (inputArr[j] == "1")
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                problems++;
            }
        }
        Console.WriteLine(problems);
    }
}