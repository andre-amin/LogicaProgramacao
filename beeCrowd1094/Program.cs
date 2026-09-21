using System.Globalization;

int N, pos;
double num = 0.0;
pos = 0;

N = int.Parse(Console.ReadLine());

double[] A = new double[N];
string[] S = new string[N];

S = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    
    A[i] = double.Parse(S[i], CultureInfo.InvariantCulture);

    if (A[i] > num)
    {
        num = A[i];
        pos = i;
    }
}
Console.WriteLine(num.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine(pos.ToString());