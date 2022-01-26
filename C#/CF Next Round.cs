using System;

public class Program
{
    public static void Main()
    {
        int n, k;
        string[] inputArr = new string[2];
        inputArr = Console.ReadLine().Split();
        n = int.Parse(inputArr[0]);
        k = int.Parse(inputArr[1]);

        int[] scoreArr = new int[n];
        Array.Resize(ref inputArr, n);
        inputArr = Console.ReadLine().Split();
        for (int i = 0; i < scoreArr.Length; i++)
        {
            scoreArr[i] = int.Parse(inputArr[i]);
        }

        int pass = 0;
        for (int i = 0; i < scoreArr.Length; i++)
        {
            if (scoreArr[i] >= scoreArr[k - 1] && scoreArr[i] > 0)
            {
                pass++;
            }
        }
        Console.WriteLine(pass);
    }
}