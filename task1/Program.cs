using System; // this is what allows interaction with the system, so elements like the console

class Program // created a class Program
{
    private int data;
    private static int count = 0; // shared counter

    public Program() // constructor
    {
        Console.WriteLine("\nConstructor Called");
        count++; // counter, inc when constructing
        Console.WriteLine($"Active Objects: {count}");
    }

    ~Program() // destructor
    {
        Console.WriteLine("\nObject Destroyed");
        Console.WriteLine($"Object data was {data}");
        count--; // dec count when destroying
        Console.WriteLine($"Active Objects: {count}");
    }

    public void set_data(int x)
    {
        data = x;
    }

    public void show_data()
    {
        Console.WriteLine("Data: " + data);
    }

    static void TriggerGC()
    {
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, blocking: true);
        GC.WaitForPendingFinalizers();
    }

    static void Main(string[] args)
    {
        Program? p = null; // declaring it as nullable
        for (int i = 1; i < 4; i++)
        {
            p = new Program();
            p.set_data(i * 10);
            p.show_data();
        }
        p = null; // if this isn't done, p will still be reachable, so the third object won't be destroyed, it still is reachable though, because of it being the last local variable
        TriggerGC();
        // GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, blocking: true); // force garbage collection
        // GC.WaitForPendingFinalizers();
        Console.WriteLine("Garbage collection completed.");
        Console.WriteLine($"Number of objects left = {count}");
    }
}
