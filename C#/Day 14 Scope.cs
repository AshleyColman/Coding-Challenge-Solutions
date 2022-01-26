

// Add your code here
public Difference(int[] _elements)
{
    elements = _elements;
}

public void computeDifference()
{
    // Compare all numbers against eachother
    // Track the max difference
    // If max difference is found update 

    maximumDifference = 0;
    int absDifference = 0;
    for (int i = 0; i < elements.Length; i++)
    {
        for (int j = (i + 1); j < elements.Length; j++)
        {
            absDifference = Math.Abs(elements[i] - elements[j]);
            if (absDifference > maximumDifference)
            {
                maximumDifference = absDifference;
            }
        }
    }
}
