using System.Globalization;

//Declaração de variáveis
int N, L, C;
double soma;
soma = 0;

//input de parâmetro para matriz e sua respectiva declaração
N = int.Parse(Console.ReadLine());

double[,] A = new double[N, N];

//Alocação dos dados na matriz
for (int i = 0; i < N; i++)
{
    string[] S = Console.ReadLine().Split(' ');

    for (int j = 0; j < N; j++)
    {
        A[i, j] = double.Parse(S[j], CultureInfo.InvariantCulture);
    }
}

//Declaração de qual linha L e coluna C será lida
L = int.Parse(Console.ReadLine());
C = int.Parse(Console.ReadLine());

//Soma de todos os elementos positivos da matriz
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (A[i, j] > 0)
        {
            soma += A[i, j];
        }
    }
}

Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

//Separação da linha escolhida para leitura
Console.Write("LINHA ESCOLHIDA: ");

for (int i = 0; i < N; i++)
{

    Console.Write(A[L, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

//Separação da coluna escolhida para leitura
Console.Write("COLUNA ESCOLHIDA: ");

for (int i = 0; i < N; i++)
{
    Console.Write(A[i, C].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

//Print da diagonal principal da matriz
Console.Write("DIAGONAL PRINCIPAL: ");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (i == j)
        {
            Console.Write(A[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
    }
}
Console.WriteLine();

//Alteração de todos os elementos negativos da matriz (elevando-os ao quadrado)
Console.WriteLine("MATRIZ ALTERADA:");

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (A[i, j] < 0)
        {
            A[i, j] = Math.Pow(A[i, j], 2.0);

        }
    }

}

//Print da nova matriz
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(A[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();
}