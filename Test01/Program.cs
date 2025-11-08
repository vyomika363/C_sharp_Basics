using System; // makes the system namespace available
int a = 3;
int b = a++; // b=3 and then a=4
Console.WriteLine($"a is {+a++}, b is {-++b}"); // unary operators with pre and post increments
// a remains 4 is printed and then incremented to 5, b is decremented, negated and then printed
int c = 3;
int d = ++c; // c becomes 4 and d becomes 4 too
Console.WriteLine($"c is {-c--}, d is {~d}"); // c is negated, printed and then decremented
// d is passed through bitwise not, turns to -5
