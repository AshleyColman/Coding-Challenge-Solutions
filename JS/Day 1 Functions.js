
/*
 * Create the function factorial here
 */
function factorial(n)
{
    var sum = 1;
    for(let i = n; i > 1; i--)
    {
        sum *= i;
    }
    
    return sum;
}
