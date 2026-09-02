int N = int.Parse(Console.ReadLine());

for(int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());
    
    if (X % 2 == 0 && X < 0)
    {
        Console.WriteLine("EVEN NEGATIVE");
    }
    else if (X % 2 != 0 && X < 0)
    {
        Console.WriteLine("ODD NEGATIVE");
    }
    else if (X % 2 == 0 && X > 0)
    {
        Console.WriteLine("EVEN POSITIVE");
    }
    else if (X % 2 != 0 && X > 0)
    {
        Console.WriteLine("ODD POSITIVE");
    }
    else if (X == 0)
    {
        Console.WriteLine("NULL");
    }
}