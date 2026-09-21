using System.Globalization;

int N;
double media, total;
total = 0.0;

N = int.Parse(Console.ReadLine());

double[] A = new double[N];

string[] S = Console.ReadLine().Split(' ');

for(int i = 0; i < N; i++)
{
    A[i] = double.Parse(S[i], CultureInfo.InvariantCulture);
    total += A[i];
}

media = total / N;
Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

foreach(double i in A)
{
    if (i < media)
    {
        Console.WriteLine(i.ToString("F1", CultureInfo.InvariantCulture));
    }
}

