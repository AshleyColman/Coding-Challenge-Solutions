

/**
*    Name: PrintArray
*    Print each element of the generic array on a new line. Do not return anything.
*    @param A generic array
**/
// Write your code here
public static void PrintArray<T>(T[] _array)
{
    for (int i = 0; i < _array.Length; i++)
    {
        Console.WriteLine(_array[i]);
    }
}
