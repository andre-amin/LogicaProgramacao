using System.Globalization;

int min, max;

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());



if (X > Y)
{
    max = X;
    min = Y;
}
else
{
    min = X;
    max = Y;
}

int soma = 0;
for (int i = min +1; i < max; i++)
{
    if (i % 2 != 0)
    {
        soma += i;

    }
}
Console.WriteLine(soma);