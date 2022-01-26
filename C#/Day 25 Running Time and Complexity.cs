using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int number in numbers)
        {
            if (CheckPrime(number) == true)
            {
                Console.WriteLine("Prime");
                continue;
            }
            Console.WriteLine("Not prime");
        }
    }

    public static bool CheckPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        double squareRoot = Math.Sqrt(number);
        for (int i = 2; i <= squareRoot; i++)
        {
            if ((number % i) == 0)
            {
                return false;
            }
        }
        return true;
    }
}
