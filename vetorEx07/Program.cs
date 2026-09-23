using System.Globalization;

int N;


N = int.Parse(Console.ReadLine());

string[] nome = new string[N];
double[] nota1 = new double[N];
double[] nota2 = new double[N];

for (int i = 0; i < N; i++)
{
    string[] S = Console.ReadLine().Split(' ');
    nome[i] = S[0];
    nota1[i] = double.Parse(S[1], CultureInfo.InvariantCulture);
    nota2[i] = double.Parse(S[2], CultureInfo.InvariantCulture);
}

Console.WriteLine("Alunos aprovados:");

for (int i = 0; i < N; i++)
{
    double media = (nota1[i] + nota2[i]) / 2;

    if (media >= 6.0)
    {

        Console.WriteLine(nome[i]);
    }
}