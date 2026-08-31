int dentro, fora;

int N = int.Parse(Console.ReadLine());

dentro = 0;
fora = 0;

for(int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());
    if (X >= 10 && X <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}
Console.WriteLine(dentro + " in");
Console.WriteLine(fora + " out");