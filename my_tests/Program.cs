using System;
class Program
{
    int age;
    Program() => age=age==0?age+1:age-1;
    static void Main()
    {
        int k = "010%".Replace('0', '%').Length;
        Console.WriteLine("1");
        Console.WriteLine(1);
        Console.WriteLine('1');
        Console.WriteLine('[');
        Console.WriteLine(']');
        Console.WriteLine('1' + 0);
        Console.WriteLine('[' + 0);
        Console.WriteLine(']' + 0);
        Console.WriteLine('[' + 1 + ']');
        Console.WriteLine('[' + '1' + ']');
        Console.WriteLine("[" + 1 + "]");
        Console.WriteLine("[" + "1" + "]");
    }
}