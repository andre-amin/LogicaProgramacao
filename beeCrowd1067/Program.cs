using System.Globalization;

int N;

N = int.Parse(Console.ReadLine());

for (int i = 0; i <= N; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}