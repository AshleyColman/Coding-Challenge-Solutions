


// Declare second integer, double, and String variables.
int i2 = 0;
double d2 = 0;
string s2 = string.Empty;
// Read and save an integer, double, and String to your variables.
i2 = Convert.ToInt32(Console.ReadLine());
d2 = Convert.ToDouble(Console.ReadLine());
s2 = Console.ReadLine();
// Print the sum of both integer variables on a new line.
i = i + i2;
Console.WriteLine(i);
// Print the sum of the double variables on a new line.
d = d + d2;
Console.WriteLine(d.ToString("F1"));
// Concatenate and print the String variables on a new line
// The 's' variable above should be printed first.
s = s + s2;
Console.WriteLine(s);

