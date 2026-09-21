using System.Globalization;

int N, pares;
double soma, media;
soma = 0.0;
pares = 0;
N = int.Parse(Console.ReadLine());

double[] A = new double[N];

string[] S = Console.ReadLine().Split(' ');

for(int i = 0; i < N; i++)
{
    A[i] = double.Parse(S[i], CultureInfo.InvariantCulture);
}

foreach(double x in A)
{
    if(x % 2 == 0)
    {
        soma += x;
        pares++;
    }
}
media = soma / pares;
Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));