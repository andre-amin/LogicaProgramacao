int N, maior, numAtual;

N = int.Parse(Console.ReadLine());

int[,] A = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] S = Console.ReadLine().Split(' ');

    for (int j = 0; j < N; j++)
    {
        A[i, j] = int.Parse(S[j]);

    }

}

for (int i = 0; i < N; i++)
{
    maior = A[i, 0];
    for (int j = 0; j < N; j++)
    {
        numAtual = A[i, j];

        if (numAtual > maior)
        {
            maior = numAtual;
        }
    }

    Console.WriteLine(maior);
}