

class Student : Person
{
    private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string _firstName, string _lastName, int _id, int[] _scores)
    : base(_firstName, _lastName, _id)
    {
        testScores = _scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate()
    {
        double average = testScores.Average();

        if (average >= 90 && average <= 100)
        {
            return 'O';
        }
        else if (average >= 80 && average < 90)
        {
            return 'E';
        }
        else if (average >= 70 && average < 80)
        {
            return 'A';
        }
        else if (average >= 55 && average < 70)
        {
            return 'P';
        }
        else if (average >= 40 && average < 55)
        {
            return 'D';
        }
        else
        {
            return 'T';
        }
    }
}

