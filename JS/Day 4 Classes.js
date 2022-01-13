/*
 * Implement a Polygon class with the following properties:
 * 1. A constructor that takes an array of integer side lengths.
 * 2. A 'perimeter' method that returns the sum of the Polygon's side lengths.
 */
class Polygon
{
    constructor(lengths)
    {
        this.lengthArr = lengths;
    }
    
    perimeter() { 
        let perimeter = 0;
        for (let i=0; i < this.lengthArr.length; i++)
        {
            perimeter += this.lengthArr[i]; 
        }
        return perimeter;
    }
}
